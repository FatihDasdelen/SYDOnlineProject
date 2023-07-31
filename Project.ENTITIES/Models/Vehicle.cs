using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Vehicle : BaseEntity
    {

        public Vehicle()
        {
            Models = new List<Model>();
            
        }
        
        public string BrandName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }



        //Relaitonal Properties
        public virtual List<Model> Models { get; set; }

    }
}
