
namespace Basket.API.Basket.StoreBasket
{
    public class StoreBasketCommandValidator : AbstractValidator<StoreBasketCommand>
    {
        public StoreBasketCommandValidator()
        {
            RuleFor(x => x.Cart).NotNull().WithMessage("Cart can't be null");
            RuleFor(x => x.Cart.UserName).Empty().WithMessage("UserName is required");
        }
    }
}
