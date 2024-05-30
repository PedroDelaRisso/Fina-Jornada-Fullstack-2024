﻿using Fina.Api.Common.Api;
using Fina.Core.Handlers;
using Fina.Core.Requests.Categories;
using Microsoft.AspNetCore.Mvc;

namespace Fina.Api.Endpoints.Categories;

public class UpdateCategoryEndpoint : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app)
    {
        app.MapPut("/{id}", HandleAsync)
            .WithName("Categories: Update")
            .WithSummary("Atualiza uma categoria")
            .WithDescription("Atualiza uma categoria")
            .WithOrder(2)
            .Produces(204);
    }
    
    private static async Task<IResult> HandleAsync([FromServices] ICategoryHandler handler, [FromBody] UpdateCategoryRequest request)
    {
        var response = await handler.UpdateAsync(request);
        return response.IsSuccess
            ? TypedResults.NoContent()
            : TypedResults.BadRequest(response);
    }
}