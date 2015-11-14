using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TCubDash.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ProductModel 
    {
        public string Category { get; set; }

        public int PackSize { get; set; }

        public int QtyPerUnit { get; set; }

        public int QtyInstock { get; set; }

        public double UnitPrice { get; set; }

        public string CurrencyTypeName { get; set; }  //System Entity stores Currency Id

        public string MfgPartNo { get; set;  }  //SKU

        public string VendorPartNo { get; set; } //unique number from supplier

        public string VendorName { get; set; } //System Entity stores Vendor Id


        public string ImageName { get; set; } //DB type TEXT

        public string ProductDescription { get; set; } //DB type TEXT

        public string ProductSheet { get; set; }
        
        public string WebSite { get; set; }
        


    }
}