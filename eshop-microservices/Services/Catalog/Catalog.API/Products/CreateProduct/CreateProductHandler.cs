using MediatR;

namespace Catalog.API.Products.CreateProduct;

public record CreateProductCommand(
    string Name,
    string Description,
    decimal Price,
    string PictureUri,
    List<string> Category)
    : IRequest<CreateProductResponse>;

public record CreateProductResponse(Guid Id);

internal class CreateProductCommandHandler: IRequestHandler<CreateProductCommand, CreateProductResponse>
{
    public Task<CreateProductResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        // Business logic to create a product.
        throw new NotImplementedException();
    }
}