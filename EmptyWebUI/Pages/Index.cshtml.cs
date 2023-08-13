using Core.Abstracts.IServices;
using Core.Concretes.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmptyWebUI.Pages
{
    public class IndexModel : PageModel
    {
        private IProductionService service;

        public IndexModel(IProductionService service)
        {
            this.service = service;
        }

        public IEnumerable<ProductListItemDTO> Products = new HashSet<ProductListItemDTO>();

        public async void OnGetAsync()
        {
            Products = await service.GetProductsAsync();
        }
    }
}
