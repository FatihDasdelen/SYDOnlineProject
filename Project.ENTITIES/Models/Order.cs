using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Order : BaseEntity
    {
        
        
        public string ShippedAddress { get; set; }
        public decimal TotalPrice { get; set; }
        public string UserName { get; set; }
        
        [EmailAddress(ErrorMessage = "Lütfen E-mail formatında giriniz")]
        public string Email { get; set; }
        public int AppUserID { get; set; }
        public int? ShipperID { get; set; }


        //Relational Propeties

        public virtual AppUser AppUser { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual Shipper Shipper { get; set; }
    }
}
