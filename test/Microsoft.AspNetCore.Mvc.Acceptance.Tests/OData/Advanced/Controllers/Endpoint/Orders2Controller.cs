﻿namespace Microsoft.AspNetCore.OData.Advanced.Controllers.Endpoint
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.OData.Models;
    using Microsoft.AspNetCore.OData.Query;
    using Microsoft.AspNetCore.OData.Routing.Controllers;

    [ApiVersion( "2.0" )]
    [ControllerName( "Orders" )]
    public class Orders2Controller : ODataController
    {
        public IActionResult Get( ODataQueryOptions<Order> options, ApiVersion apiVersion ) =>
            Ok( new[] { new Order() { Id = 1, Customer = $"Customer v{apiVersion}" } } );

        public IActionResult Get( int key, ODataQueryOptions<Order> options, ApiVersion apiVersion ) =>
            Ok( new Order() { Id = key, Customer = $"Customer v{apiVersion}" } );
    }
}