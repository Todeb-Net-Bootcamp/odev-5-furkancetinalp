using DAL.Abstract;
using DAL.DbContexts;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    //Methods in the related interface specification
    public class AccountRepository : IAccountRepository
    {
        private readonly PaymentAppDbContext _context;
        public AccountRepository(PaymentAppDbContext context)
        {
            _context = context;
        }

        public void Delete(Account account)
        {
            _context.Accounts.Remove(account);
            _context.SaveChanges();
        }

        public Account Get(int id)
        {
           return  _context.Accounts.SingleOrDefault(x=>x.CustomerId == id);
        }

        public IEnumerable<Account> GetAll()
        {
            return _context.Accounts.ToList();
        }

        public void Insert(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();

        }

        public void Update(Account account)
        {
            _context.Accounts.Update(account);
            _context.SaveChanges();
        }
    }
}
