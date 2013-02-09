using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manasco_Mailon_Assignment_2.ViewModels
{
    public class CheckoutVM
    {
        public int  tylenol{ get; set; }
        public int ibuprofren { get; set;}
        public int aspirin { get; set; }
        public double subtotal { get; set; }
        public double tax { get; set; }
        public double total { get; set; }
        public bool hasParameter { get; set; }
        public double tyTotal { get; set; }
        public double ibTotal { get; set; }
        public double asTotal { get; set; }

        public void Math()
        {
            tyTotal = tylenol * 1.99;
            ibTotal = ibuprofren * .99;
            asTotal = aspirin * 1.49;
            subtotal = tylenol*1.99 + aspirin*1.49 + ibuprofren*.99;
            tax = subtotal * .08;
            total = subtotal + tax;
            hasParameter = true;
        }


    }
}