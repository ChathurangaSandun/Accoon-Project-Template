using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Accoon.Application.UserCases.Customer.CreateCustomer
{
    public class CustomerCreatedHandler : INotificationHandler<CustomerCreated>
    {
        //private readonly IEventBus eventBus;
        public CustomerCreatedHandler()
        {
            //this.eventBus = eventBus;
        }
        public Task Handle(CustomerCreated response, CancellationToken cancellationToken)
        {
            //var customerCreatedEvent = new CustomerCreatedIntegrationEvent(response.CustomerId);

            //this.eventBus.Publish(customerCreatedEvent);

            return Task.CompletedTask;

        }
    }
}
