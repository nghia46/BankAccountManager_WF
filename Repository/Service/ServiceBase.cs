using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Service
{
    public class ServiceBase<T> where T : class
    {
        BankAccountTypeContext _context;
        DbSet<T> _dbSet;
        public ServiceBase()
        {
            _context = new BankAccountTypeContext();
            _dbSet = _context.Set<T>();
        }
        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        public bool Delete(T entity) { 
            try
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        public void Update(T entity)
        {
            var tracker = _context.Attach(entity);
            tracker.State = EntityState.Modified;
            _context.SaveChanges();
        }
        public List<T> SearchByKeyword(Func<T, bool> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }
    }
}
