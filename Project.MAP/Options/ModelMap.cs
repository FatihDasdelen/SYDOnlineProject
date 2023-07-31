using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class ModelMap : BaseMap<Model>
    {
        public ModelMap()
        {
            //ToTable("Araç Modelleri");
            //Property(x => x.ModelYear).HasColumnName("Model Yili");
            //Property(x => x.ModelName).HasColumnName("Model Adi");
            //Property(x => x.Pack).HasColumnName("Araç Paketi");

        }
    }
}
