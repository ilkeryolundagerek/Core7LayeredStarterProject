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

        public UnitOfWorkProduction(Aw14Context context)
        {
            this.context = context;
        }

        private IProductRepository? productRepository;
        //public IProductRepository ProductRepository => productRepository = productRepository == null ? new ProductRepository(context) : productRepository;
        public IProductRepository ProductRepository => productRepository ??= new ProductRepository(context);
    }
}
