using AutoMapper;
using DTO.Account;
using DTO.Customer;
using Models.Entities;


namespace Business.Configuration.Mapper
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            //Mappings for 'Account' class
            CreateMap<CreateAccountRequest, Account>();
            CreateMap<UpdateAccountRequest, Account>();
            CreateMap<Account, GetAccountrequest>();

            //Mappings for 'Customer' class
            CreateMap<CreateCustomerRequest, Customer>();
            CreateMap<UpdateCustomerRequest, Customer>();
            CreateMap<Customer,GetCustomerRequest>();


        }
    }
}
