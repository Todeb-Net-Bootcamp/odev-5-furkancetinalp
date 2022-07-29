using AutoMapper;
using Business.Abstract;
using Business.Configuration.Validator.CustomerValidator;
using Bussines.Configuration.Extensions;
using Bussines.Configuration.Response;
using DAL.Abstract;
using DTO.Customer;
using FluentValidation;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //Expanding and modifying  methods in ICustomerService
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;
        private readonly IMapper _mapper;
        public CustomerService(ICustomerRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        //If there is no customer related to 'identityNumber', customer cannot be deleted
        public CommandResponse Delete(string identityNumber)
        {
            var check = _repository.GetByIdentity(identityNumber);
            if(check is null)
            {
                return new CommandResponse { Message = "No username found!!", Status = false };
            }
            _repository.Delete(check);
            return new CommandResponse { Message = "Username Deleted!!", Status = true };
        }
        //Print all customer via listing
        public IEnumerable<GetCustomerRequest> GetAll()
        {
            var data = _repository.GetAll();
            var mappedData = data.Select(x=>_mapper.Map<GetCustomerRequest>(x)).ToList();
            return mappedData;
        }

        //Get a customer info by indentityNumber
        public GetCustomerRequest GetByIdentity(string identityNumber)
        {
            var check = _repository.GetByIdentity(identityNumber);
            var mappedData = _mapper.Map<GetCustomerRequest>(check);
            return mappedData;
        }

        //Customer insert method
        public CommandResponse Insert(CreateCustomerRequest request)
        {
            var validator = new CreateCustomerRequestValidator();
            validator.Validate(request).ThrowIfException();

            //If idenditynumber already exists, no permission to create another customer
            var check = _repository.GetByIdentity(request.IdentityNumber);
            if(check is not null)
            {
                return new CommandResponse { Message = "Username already exists!!", Status = false };
            }
            var mappedData = _mapper.Map<Customer>(request);
            _repository.Create(mappedData);
            return new CommandResponse { Message = "Username created!", Status = true };
        }

        //Updating variables of customers IF related customer EXISTS.
        public CommandResponse Update(string identityNumber, UpdateCustomerRequest request)
        {
            var validator = new UpdateCustomerRequestValidator();
            validator.Validate(request).ThrowIfException();
            var check = _repository.GetByIdentity(identityNumber);
            if(check is null)
            {
                return new CommandResponse { Message = "Username does not exist!!", Status = false };
            }
            var mappedData = _mapper.Map(request, check);
            _repository.Update(mappedData);
            return new CommandResponse { Message = "Successfully updated", Status = true };

        }
    }
}
