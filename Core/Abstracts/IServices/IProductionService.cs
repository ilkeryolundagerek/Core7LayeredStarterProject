using Core.Concretes.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstracts.IServices
{
    public interface IProductionService
    {
        Task<IEnumerable<ProductListItemDTO>> GetProductsAsync(Expression<Func<ProductDetailDTO, bool>>? expression = null);

        Task<ProductDetailDTO> GetProductAsync(int productId);
    }
}
