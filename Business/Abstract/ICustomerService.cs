using Bussines.Configuration.Response;
using DTO.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    //Interface definition of 'Customer' for business layer
    public interface ICustomerService
    {
        public IEnumerable<GetCustomerRequest> GetAll();
        public GetCustomerRequest GetByIdentity(string identityNumber);
        public CommandResponse Insert(CreateCustomerRequest request);
        public CommandResponse Update(string identityNumber, UpdateCustomerRequest request);
        public CommandResponse Delete(string identityNumber);

    }
}
