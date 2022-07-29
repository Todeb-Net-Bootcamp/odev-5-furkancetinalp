using Bussines.Configuration.Response;
using DTO.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    //Interface definition of 'Account' for business layer
    public interface IAccountService
    {
        public IEnumerable<GetAccountrequest> GetAll();
        public GetAccountrequest GetByAccountId(int accountId);
        public CommandResponse Insert(CreateAccountRequest request);
        public CommandResponse Update(int id,UpdateAccountRequest request);
        public CommandResponse Delete(int accountId);
    }
}
