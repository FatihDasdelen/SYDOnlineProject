using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class AppUser : BaseEntity
    {
        public AppUser()
        {
            Role = UserRole.Member;
            ActivationCode = Guid.NewGuid();
            UserName = UserName;
        }
        
        [Required(ErrorMessage ="{0} Girilmesi zorunludur")]
        [Display(Name = "Kullanıcı İsmi")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "{0} Girilmesi zorunludur")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }
        public Guid ActivationCode { get; set; }
        public bool Active { get; set; }
        [Required(ErrorMessage = "{0} Girilmesi zorunludur")]
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage ="Lütfen E-mail formatında giriniz")]
        public string Email { get; set; }
        public UserRole Role { get; set; }


        //Relational Properties
        public virtual AppUserProfile Profile { get; set; }
        public virtual List<Order> Orders { get; set; }


    }
}
