﻿using WebShopDemo.Core.Models;

namespace WebShopDemo.Core.Contracts
{
    /// <summary>
    /// Manipulates product data
    /// </summary>
    public interface IProductService
    {
        /// <summary>
        /// Gets all products
        /// </summary>
        /// <returns>Lict of products</returns>
        Task<IEnumerable<ProductDto>> GetAll();


        /// <summary>
        /// Adds new product
        /// </summary>
        /// <param name="productDto">Product model</param>
        /// <returns></returns>

        Task Add(ProductDto productDto);

        Task Delete(Guid id);
    }
}
