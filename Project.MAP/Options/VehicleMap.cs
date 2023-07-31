using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class VehicleMap : BaseMap<Vehicle>
    {
        public VehicleMap()
        {
            //ToTable("Markalar");
            //Property(x => x.BrandName).HasColumnName("Marka Adi");
            //Property(x => x.Description).HasColumnName("Aciklama");
            //Property(x => x.ModelYear).HasColumnName("Model Yili");
        }
    }
}
