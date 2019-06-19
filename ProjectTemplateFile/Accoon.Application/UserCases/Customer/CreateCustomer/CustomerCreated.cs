﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace $safeprojectname$.UserCases.Customer.CreateCustomer
{
    public class CustomerCreated: INotification
    {
        public Guid CustomerId { get; set; }
    }
}
