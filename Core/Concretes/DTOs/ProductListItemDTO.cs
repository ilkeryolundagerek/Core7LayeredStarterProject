using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concretes.DTOs
{
    public class ProductListItemDTO
    {
        /// <summary>
        /// Primary key for Product records.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Name of the product.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Unique product identification number.
        /// </summary>
        public string ProductNumber { get; set; } = null!;

        /// <summary>
        /// Product color.
        /// </summary>
        public string? Color { get; set; }

        /// <summary>
        /// Selling price.
        /// </summary>
        public decimal ListPrice { get; set; }

        /// <summary>
        /// Product size.
        /// </summary>
        public string? Size { get; set; }

        /// <summary>
        /// Unit of measure for Size column.
        /// </summary>
        public string? SizeUnitMeasure { get; set; }


        /// <summary>
        /// Product weight.
        /// </summary>
        public decimal? Weight { get; set; }

        /// <summary>
        /// Unit of measure for Weight column.
        /// </summary>
        public string? WeightUnitMeasure { get; set; }

        /// <summary>
        /// W = Womens, M = Mens, U = Universal
        /// </summary>
        public string? Style { get; set; }

        /// <summary>
        /// Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID. 
        /// </summary>
        public string? ProductSubcategory { get; set; }

        /// <summary>
        /// Product category identification number. Foreign key to ProductCategory.ProductCategoryID.
        /// </summary>
        public string? ProductCategory { get; set; }

        /// <summary>
        /// Product is a member of this product model. Foreign key to ProductModel.ProductModelID.
        /// </summary>
        public string? ProductModel { get; set; }
    }

    public class ProductDetailDTO
    {
        /// <summary>
        /// Primary key for Product records.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Name of the product.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Unique product identification number.
        /// </summary>
        public string ProductNumber { get; set; } = null!;

        /// <summary>
        /// Product color.
        /// </summary>
        public string? Color { get; set; }

        /// <summary>
        /// Selling price.
        /// </summary>
        public decimal ListPrice { get; set; }

        /// <summary>
        /// Product size.
        /// </summary>
        public string? Size { get; set; }

        /// <summary>
        /// Unit of measure for Size column.
        /// </summary>
        public string? SizeUnitMeasure { get; set; }


        /// <summary>
        /// Product weight.
        /// </summary>
        public decimal? Weight { get; set; }

        /// <summary>
        /// Unit of measure for Weight column.
        /// </summary>
        public string? WeightUnitMeasure { get; set; }

        /// <summary>
        /// W = Womens, M = Mens, U = Universal
        /// </summary>
        public string? Style { get; set; }

        /// <summary>
        /// Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID. 
        /// </summary>
        public string? ProductSubcategory { get; set; }

        /// <summary>
        /// Product category identification number. Foreign key to ProductCategory.ProductCategoryID.
        /// </summary>
        public string? ProductCategory { get; set; }

        /// <summary>
        /// Product is a member of this product model. Foreign key to ProductModel.ProductModelID.
        /// </summary>
        public string? ProductModel { get; set; }
    }
}
