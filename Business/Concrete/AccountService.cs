using AutoMapper;
using Business.Abstract;
using Business.Configuration.Validator.AccountValidator;
using Bussines.Configuration.Extensions;
using Bussines.Configuration.Response;
using DAL.Abstract;
using DTO.Account;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //Expanding and modifying  methods in IAccountService
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _repository;
        private readonly ICustomerRepository _repository2;
        private readonly IMapper _mapper;
        public AccountService(IAccountRepository repository,IMapper mapper, ICustomerRepository repository2)
        {
            _repository = repository;
            _mapper = mapper;
            _repository2 = repository2;
        }
        public CommandResponse Delete(int accountId)
        {
            //If there is no account related to 'accountId', account cannot be deleted
            var check = _repository.Get(accountId);
            if(check is null)
            {
                return new CommandResponse { Message = "No data found!!!", Status = false };
            }
            _repository.Delete(check);
            return new CommandResponse { Message ="Account has been deleted!",Status = true };
        }

        public IEnumerable<GetAccountrequest> GetAll()
        {
            //Getting all accounts
            var data = _repository.GetAll();
            var mapped = data.Select(x=>_mapper.Map<GetAccountrequest>(x)).ToList();
            return mapped;
        }

        //Getting account via accountId
        public GetAccountrequest GetByAccountId(int accountId)
        {
            var check = _repository.Get(accountId);
            
            var mapped = _mapper.Map<GetAccountrequest>(check);
            
            return mapped;
        }

        public CommandResponse Insert(CreateAccountRequest request)
        {
            var validator = new CreateAccountRequestValidator();
            validator.Validate(request).ThrowIfException();
            //If account already exists, it wont be allowed to create another account.
            var check = _repository.Get(request.CustomerId);
            if(check is not null)
            {
                return new CommandResponse { Message = "Account already exists!!!", Status = false };
            }
            //If there is no customer found related to that account, account cannot be created
            var customerList = _repository2.GetAll();
            var  checkIfExistingCustomer = customerList.Where(x=>x.Id==request.CustomerId).FirstOrDefault();
            if(checkIfExistingCustomer is null)
            {
                return new CommandResponse { Message = "Customer does not exist. So, impossible to create an account!!!", Status = false };

            }
            var mapped = _mapper.Map<Account>(request);
            _repository.Insert(mapped);
            return new CommandResponse { Message = "Account created!", Status = true };
        }

        //Update method for Account
        public CommandResponse Update(int id,UpdateAccountRequest request)
        {
            var validator = new UpdateAccountRequestValidator();
            validator.Validate(request).ThrowIfException();
            var check = _repository.Get(id);
            if (check is null)
            {
                return new CommandResponse { Message = "Costumer does NOT exist!!!", Status = false };
            }
            //Checking if customer related to customer id exists.
            //If not, customer does not exist and no permission to update to nonexistent customer
            var customerCheck = _repository2.GetAll();
            var checkifExistingCustomer= customerCheck.FirstOrDefault(x=>x.Id==request.CustomerId);
            if(checkifExistingCustomer is null)
            {
                return new CommandResponse { Message = "Costumer does NOT exist!!!", Status = false };
            }
            //if new accountId already has an account
            if(_repository.Get(request.CustomerId)!=null)
                {
                return new CommandResponse { Message = "The accountId you're trying to get already has an account!!!", Status = false };

            }
            var mapped = _mapper.Map(request,check);
            _repository.Update(mapped);
            return new CommandResponse { Message = "Account updated!", Status = true };

        }
    }
}
