namespace Managerment
{
    partial class ManagermentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvListAccount = new DataGridView();
            txtSearch = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            txtAccountID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAccountName = new TextBox();
            txtBranchName = new TextBox();
            label6 = new Label();
            dtOpenDate = new DateTimePicker();
            btnAdd = new Button();
            cbTypeID = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvListAccount).BeginInit();
            SuspendLayout();
            // 
            // dgvListAccount
            // 
            dgvListAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListAccount.Location = new Point(50, 70);
            dgvListAccount.Name = "dgvListAccount";
            dgvListAccount.RowHeadersWidth = 51;
            dgvListAccount.RowTemplate.Height = 25;
            dgvListAccount.Size = new Size(700, 150);
            dgvListAccount.TabIndex = 0;
            dgvListAccount.CellContentDoubleClick += dgvListAccount_CellContentDoubleClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(114, 43);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(225, 23);
            txtSearch.TabIndex = 1;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 45);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 2;
            label1.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(345, 43);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtAccountID
            // 
            txtAccountID.Location = new Point(170, 238);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.Size = new Size(184, 23);
            txtAccountID.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(65, 239);
            label2.Name = "label2";
            label2.Size = new Size(77, 19);
            label2.TabIndex = 5;
            label2.Text = "Account ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(65, 350);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 6;
            label3.Text = "Order date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(65, 276);
            label4.Name = "label4";
            label4.Size = new Size(99, 19);
            label4.TabIndex = 7;
            label4.Text = "Account Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(65, 311);
            label5.Name = "label5";
            label5.Size = new Size(91, 19);
            label5.TabIndex = 8;
            label5.Text = "Branch Name";
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(170, 275);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(184, 23);
            txtAccountName.TabIndex = 9;
            // 
            // txtBranchName
            // 
            txtBranchName.Location = new Point(170, 310);
            txtBranchName.Name = "txtBranchName";
            txtBranchName.Size = new Size(184, 23);
            txtBranchName.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(65, 402);
            label6.Name = "label6";
            label6.Size = new Size(55, 19);
            label6.TabIndex = 12;
            label6.Text = "Type ID";
            // 
            // dtOpenDate
            // 
            dtOpenDate.Location = new Point(170, 350);
            dtOpenDate.Margin = new Padding(3, 2, 3, 2);
            dtOpenDate.Name = "dtOpenDate";
            dtOpenDate.Size = new Size(219, 23);
            dtOpenDate.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(523, 239);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbTypeID
            // 
            cbTypeID.FormattingEnabled = true;
            cbTypeID.Location = new Point(170, 401);
            cbTypeID.Name = "cbTypeID";
            cbTypeID.Size = new Size(127, 23);
            cbTypeID.TabIndex = 16;
            // 
            // ManagermentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbTypeID);
            Controls.Add(btnAdd);
            Controls.Add(dtOpenDate);
            Controls.Add(label6);
            Controls.Add(txtBranchName);
            Controls.Add(txtAccountName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtAccountID);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(dgvListAccount);
            Name = "ManagermentForm";
            Text = "TestForm";
            ((System.ComponentModel.ISupportInitialize)dgvListAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListAccount;
        private TextBox txtSearch;
        private Label label1;
        private Button btnSearch;
        private TextBox txtAccountID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAccountName;
        private TextBox txtBranchName;
        private Label label6;
        private DateTimePicker dtOpenDate;
        private Button btnAdd;
        private ComboBox cbTypeID;
    }
}