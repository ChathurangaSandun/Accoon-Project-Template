using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace $safeprojectname$.UserCases.Customer.CreateCustomer
{
    public class CreateCustomerCommand : IRequest<CustomerCreated>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

