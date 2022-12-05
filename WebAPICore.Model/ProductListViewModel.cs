using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPICore.Model
{
	public class ProductListViewModel
	{
		public int ID { get; set; }
		public string ModelNo { get; set; }
		public string Make { get; set; }
		public string StockDesc { get; set; }
		public string Colour { get; set; }
		public decimal SellingPrice { get; set; }
		public int ManufactureGuarantee { get; set; }
		public string SupplierCode { get; set; }
	}

	public class ProductDetailsViewModel : ProductListViewModel
	{
		public string Category { get; set; }
		public string SubCategory { get; set; }
		public string PartNo { get; set; }
		public string EANCode { get; set; }
		public decimal CostPrice { get; set; }
		public decimal RetailPrice { get; set; }
		public decimal TradePrice { get; set; }
		public int ItemType { get; set; }
		public int? Taxcode { get; set; }
		public bool AllowDiscount { get; set; }
		public int ExtnQty { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? DateLastModified { get; set; }
		public bool Discontinued { get; set; }
		public DateTime? DateDiscontinued { get; set; }
	}
}
