﻿namespace Microsoft.AspNetCore.OData.Conventions.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.OData.Models;
    using Microsoft.AspNetCore.OData.Routing.Controllers;

    public class CustomersController : ODataController
    {
        public IActionResult Get() => Ok();

        public IActionResult Get( int key ) => Ok();

        public IActionResult Post( [FromBody] Customer customer )
        {
            customer.Id = 42;
            return Created( customer );
        }

        public IActionResult Put( int key, [FromBody] Customer customer ) => NoContent();

        public IActionResult Delete( int key ) => NoContent();
    }
}