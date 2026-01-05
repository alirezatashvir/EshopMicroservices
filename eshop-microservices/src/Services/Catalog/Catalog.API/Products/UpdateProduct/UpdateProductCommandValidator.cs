namespace Catalog.API.Products.UpdateProduct
{
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Product Id cannot be empty");
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name cannot be empty")
                .Length(2, 150).WithMessage("Name must be between 2 and 150 characters");
            RuleFor(x => x.Category).NotEmpty().WithMessage("Category cannot be empty");
            RuleFor(x => x.ImageFile).NotEmpty().WithMessage("ImageFile cannot be empty");
            RuleFor(x => x.Price).GreaterThan(0).WithMessage("Price should be greater than zero");
        }
    }
}
