using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    //Methods is described for Account class via interface
    public interface IAccountRepository
    {
        public IEnumerable<Account> GetAll();
        public Account Get(int id);
        public void Update(Account account);
        public void Delete(Account account);
        public void Insert(Account account);    

    }
}
