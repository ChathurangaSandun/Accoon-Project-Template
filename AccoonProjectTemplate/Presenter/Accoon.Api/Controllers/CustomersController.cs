using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Accoon.Application.UserCases.Customer.CreateCustomer;
using Accoon.Application.UserCases.Customer.GetCustomer;
using Accoon.Application.UserCases.Customer.GetCustomerList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Accoon.Api.Controllers
{    
    public class CustomersController : BaseController
    {
        [Route("")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create([FromBody] CreateCustomerCommand createCustomerCommand)
        {
            var customer = await Mediator.Send(createCustomerCommand);
            return CreatedAtAction(nameof(Get), new { id = customer.CustomerId }, null);
        }

        [Route("{id:guid}")]
        [HttpGet]
        [ProducesResponseType(typeof(CustomerModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CustomerModel>> Get([FromRoute] Guid id)
        {
            var customer = await Mediator.Send(new GetCustomerQuery() { Id = id });
            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        [Route("")]
        [HttpGet]
        [ProducesResponseType(typeof(CustomerListViewModel), StatusCodes.Status200OK)]
        public async Task<ActionResult<CustomerListViewModel>> Get()
        {
            var customerListModel = await Mediator.Send(new GetCustomersListQuery());
            return Ok(customerListModel);
        }
    }
}