using Microsoft.Extensions.Configuration;
using Repository.Models;
using Repository.Service;
using System.Data;
using System.Diagnostics;

namespace Managerment
{
    public partial class ManagermentForm : Form
    {
        BankAccountService _bankAccountService = new BankAccountService();
        public ManagermentForm()
        {
            List<BankAccount> bankAccounts = _bankAccountService.GetAll();
            InitializeComponent();
            getDataToGrid(bankAccounts);
            txtAccountID.Enabled = false;
            cbTypeID.Items.Add("AT0001");
            cbTypeID.Items.Add("AT0002");
            cbTypeID.Items.Add("AT0003");
            cbTypeID.Items.Add("AT0004");
            cbTypeID.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        internal void getDataToGrid(Object datasource)
        {
            if (Login_From.IsLoginSuccessful)
            {
                dgvListAccount.DataSource = datasource;
            }
            else
            {
                dgvListAccount.DataSource = null;
            }
        }

        internal void searchAccount()
        {
            BankAccount account = new BankAccount();
            string keyWord = txtSearch.Text.ToLower();
            object searchResults = _bankAccountService.SearchByKeyword(account => account.BranchName.ToLower().Contains(keyWord));
            dgvListAccount.DataSource = searchResults;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchAccount();
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchAccount();
            }
        }
        private void dgvListAccount_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvListAccount.Rows[e.RowIndex];
                txtAccountID.Text = selectedRow.Cells["AccountID"].Value.ToString();
                txtAccountName.Text = selectedRow.Cells["AccountName"].Value.ToString();
                txtBranchName.Text = selectedRow.Cells["BranchName"].Value.ToString();
                dtOpenDate.Value = (DateTime)selectedRow.Cells["OpenDate"].Value;
                cbTypeID.Text = selectedRow.Cells["TypeID"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Login_From.IsLoginSuccessful)
            {
                // Get the last account
                BankAccount lastAccount = _bankAccountService.GetAll().OrderByDescending(a => a.AccountId).FirstOrDefault();

                // Extract the numerical portion of the ID and increment it
                int lastAccountId = 0;
                if (lastAccount != null && int.TryParse(lastAccount.AccountId.Substring(4), out lastAccountId))
                {
                    lastAccountId++;
                }
                DateTime selectedDate = dtOpenDate.Value;
                int selectedYear = selectedDate.Year;
                // Check if the lastAccountId is within the allowed range
                if (lastAccountId <= 9999)
                {
                    if (selectedYear >= 2000 && selectedYear <= 2022)
                    {
                        string newAccountId = $"ACCT{lastAccountId.ToString("D4")}";

                        BankAccount account = new BankAccount
                        {
                            AccountId = newAccountId,
                            AccountName = txtAccountName.Text,
                            BranchName = txtBranchName.Text,
                            OpenDate = selectedDate,
                            TypeId = cbTypeID.Text,
                        };
                        _bankAccountService.Add(account);
                        dgvListAccount.DataSource = _bankAccountService.GetAll();
                    }
                    else
                    {
                        MessageBox.Show("Year range is in 2002 to 2022.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Cannot create more accounts. Maximum limit reached.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You need to login as an admin to perform this task", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
