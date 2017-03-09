using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHook.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        /// <summary>
        /// PayPal invoice_number
        /// </summary>
        public int OrderID { get; set; }

        /// <summary>
        /// User DeviceHash
        /// </summary>
        public string DeviceHash { get; set; }

        public DateTime OrderDate { get; set; }
        
        public decimal OrderTotal { get; set; }

        public string Status { get; set; }
        
    }
}