using Core.Abstracts.IRepositories;
using Core.Abstracts.IUnitOfWorks;
using Data.Contexts;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.UnitOfWorks
{
    public class UnitOfWorkProduction : IUnitOfWorkProduction
    {
        private Aw14Context context;
        public IProductRepository ProductRepository { get; }
        public UnitOfWorkProduction(Aw14Context context, IProductRepository productRepository)
        {
            this.context = context;
            ProductRepository = productRepository;
        }

        public async Task CommitAsync()
        {
            try
            {
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                Dispose();
            }
            
        }

        public void Dispose()
        {
            context.Dispose();
            GC.SuppressFinalize(this);
        }

        //private IProductRepository? productRepository;
        ////public IProductRepository ProductRepository => productRepository = productRepository == null ? new ProductRepository(context) : productRepository;
        //public IProductRepository ProductRepository => productRepository ??= new ProductRepository(context);
    }
}
