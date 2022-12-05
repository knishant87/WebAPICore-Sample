using System;
using System.Collections.Generic;
using System.Text;
using WebAPICore.Model;

namespace WebAPICore.Bussiness.Repository
{
	public interface IProductRepository
	{
		public List<ProductListViewModel> GetProducts();
		public ProductDetailsViewModel GetByID(int ID);

		public bool AddProduct(ProductDetailsViewModel req);
		public bool UpdateProduct(ProductDetailsViewModel req);
		public bool DeleteProduct(ProductDetailsViewModel req);
	}
}
