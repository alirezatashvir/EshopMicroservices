
namespace Basket.API.Basket.GetBasket
{
    // public record GetBasketRequest(string UserName);

    public record GetBasketResponse(ShoppingCart Cart);
    public class GetBasketEndpoints : ICarterModule
    {
        public async void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/basket/{userName}", async (string userName, ISender sender) =>
            {
                var result = sender.Send(new GetBasketQuery(userName));
                var response = result.Adapt<GetBasketResponse>();

            })
        }
    }
}
