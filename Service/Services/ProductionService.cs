using Core.Abstracts.IServices;
using Core.Abstracts.IUnitOfWorks;
using Core.Concretes.DTOs;
using Core.Concretes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductionService : IProductionService
    {
        private IUnitOfWorkProduction unitOfWorkProduction;

        public ProductionService(IUnitOfWorkProduction unitOfWorkProduction)
        {
            this.unitOfWorkProduction = unitOfWorkProduction;
        }

        public async Task<ProductDetailDTO> GetProductAsync(int productId)
        {
            var product = await unitOfWorkProduction.ProductRepository.FindOneAsync(productId);
            if (product != null)
            {
                return new ProductDetailDTO
                {
                    ProductId = product.ProductId,
                    Color = product.Color,
                    Name = product.Name,
                    ListPrice = product.ListPrice,
                    ProductNumber = product.ProductNumber,
                    Size = product.Size,
                    Weight = product.Weight,
                    Style = product.Style,
                    SizeUnitMeasure = product.SizeUnitMeasureCodeNavigation?.Name,
                    WeightUnitMeasure = product.WeightUnitMeasureCodeNavigation?.Name,
                    ProductModel = product.ProductModel?.Name,
                    ProductSubcategory = product.ProductSubcategory?.Name,
                    ProductCategory = product.ProductSubcategory?.ProductCategory.Name,
                };

            }
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductListItemDTO>> GetProductsAsync(Expression<Func<ProductDetailDTO, bool>>? expression = null)
        {
            var includes = new Expression<Func<Product, object>>[]
            {
                x=>x.SizeUnitMeasureCodeNavigation,
                x=>x.WeightUnitMeasureCodeNavigation,
                x=>x.ProductModel,
                x=>x.ProductSubcategory
            };
            var values = await unitOfWorkProduction.ProductRepository.FindManyAsync(includes: includes);
            return from product in values
                   select new ProductListItemDTO
                   {
                       ProductId = product.ProductId,
                       Color = product.Color,
                       Name = product.Name,
                       ListPrice = product.ListPrice,
                       ProductNumber = product.ProductNumber,
                       Size = product.Size,
                       Weight = product.Weight,
                       Style = product.Style,
                       SizeUnitMeasure = product.SizeUnitMeasureCodeNavigation?.Name,
                       WeightUnitMeasure = product.WeightUnitMeasureCodeNavigation?.Name,
                       ProductModel = product.ProductModel?.Name,
                       ProductSubcategory = product.ProductSubcategory?.Name,
                       ProductCategory = product.ProductSubcategory?.ProductCategory.Name,
                   };
        }
    }
}
