using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebAPICore.Model;

namespace WebAPICore.Bussiness.Repository
{
	public class ProductRepository : IProductRepository
	{
		public List<ProductDetailsViewModel> productList = new List<ProductDetailsViewModel>()
		{
			new ProductDetailsViewModel()
			{
				ID = 1,
				ModelNo = "1001795",
				AllowDiscount = true,
				Category = "BeoSound",
				Colour = "Red",
				CostPrice = 234,
				CreatedBy = "Basudev",
				DateDiscontinued = null,
				DateLastModified = DateTime.Now,
				Discontinued = false,
				EANCode = "E1001795",
				ExtnQty = 1,
				ItemType = 0,
				Make = "BANG & OLUFSEN",
				ManufactureGuarantee = 1,
				PartNo = "07112022",
				RetailPrice = 456,
				SellingPrice = 567,
				StockDesc = "BeoCom 1401 GB  Terracotta",
				SubCategory = "",
				SupplierCode = "BANGOLUF",
				Taxcode = 1,
				TradePrice = 45
			},
			new ProductDetailsViewModel()
			{
				ID = 2,
				ModelNo = "8780062",
				AllowDiscount = true,
				Category = "BeoSound",
				Colour = "Red",
				CostPrice = 234,
				CreatedBy = "Basudev",
				DateDiscontinued = null,
				DateLastModified = DateTime.Now,
				Discontinued = false,
				EANCode = "E8780062",
				ExtnQty = 1,
				ItemType = 0,
				Make = "BANG & OLUFSEN",
				ManufactureGuarantee = 1,
				PartNo = "07112022",
				RetailPrice = 456,
				SellingPrice = 567,
				StockDesc = "BeoCom 1401 GB  Terracotta",
				SubCategory = "",
				SupplierCode = "BANGOLUF",
				Taxcode = 1,
				TradePrice = 45
			}
		};

		public bool AddProduct(ProductDetailsViewModel req)
		{
			productList.Add(req);
			return true;
		}

		public bool DeleteProduct(ProductDetailsViewModel req)
		{
			var product = productList.FirstOrDefault(q => q.ID == req.ID);
			if (product != null)
			{
				productList.Remove(product);
				return true;
			}
			return false;
		}

		public ProductDetailsViewModel GetByID(int ID)
		{
			return  productList.FirstOrDefault(q => q.ID == ID);
		}

		public List<ProductListViewModel> GetProducts()
		{
			return productList.Select(s => new ProductListViewModel()
			{
				ID = s.ID,
				Colour = s.Colour,
				Make = s.Make,
				ManufactureGuarantee = s.ManufactureGuarantee,
				ModelNo = s.ModelNo,
				SellingPrice = s.SellingPrice,
				StockDesc = s.StockDesc,
				SupplierCode = s.SupplierCode
			}).ToList();
		}

		public bool UpdateProduct(ProductDetailsViewModel req)
		{
			var product = productList.FirstOrDefault(q => q.ID == req.ID);
			if (product != null)
			{
				product = req;
				return true;
			}
			return false;
		}
	}

}
