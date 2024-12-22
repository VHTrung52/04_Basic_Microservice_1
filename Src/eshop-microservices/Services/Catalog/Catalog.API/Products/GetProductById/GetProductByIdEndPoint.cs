namespace Catalog.API.Products.GetProductById;

public record GetProductByIdResponse(Product Product);

public class GetProductByIdEndPoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/products/{id}", async (Guid id, ISender sender) =>
        {
            var result = await sender.Send(new GetProductByIdQuery(id));
            var response = result.Adapt<GetProductByIdResponse>();
            return Results.Ok(response);
        }).WithDisplayName(nameof(GetProductByIdEndPoint))
        .Produces<GetProductByIdResponse>(StatusCodes.Status201Created)
        .Produces(StatusCodes.Status400BadRequest)
        .WithSummary("Get Product By Id")
        .WithDescription("Get Product By Id");
}
}