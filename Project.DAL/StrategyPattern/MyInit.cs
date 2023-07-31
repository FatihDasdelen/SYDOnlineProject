using Bogus.DataSets;
using Project.COMMON.Tools;
using Project.DAL.Context;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using Name = Bogus.DataSets.Name;
using Vehicle = Project.ENTITIES.Models.Vehicle;
using Model = Project.ENTITIES.Models.Model;
using System.Security.Cryptography;

namespace Project.DAL.StrategyPattern
{
    public class MyInit : CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        {

            #region Admin 
            AppUser au = new AppUser();
            au.UserName = "fatih";
            au.Password = DantexCrypt.Crypt("fd123");
            au.Email = "fatihdasdelen@hotmial.com";
            au.Role = ENTITIES.Enums.UserRole.Admin;
            au.Active = true;
            context.AppUsers.Add(au);
            context.SaveChanges();



            #endregion



            #region NormalUser
            for (int i = 0; i < 10; i++)
            {
                AppUser ap = new AppUser();
                ap.UserName = new Internet("tr").UserName();
                ap.Password = new Internet("tr").Password();
                ap.Email = new Internet("tr").Email();
                context.AppUsers.Add(ap);
            }
            context.SaveChanges();

            for (int i = 2; i < 12; i++)
            {
                AppUserProfile aup = new AppUserProfile();
                aup.ID = i;
                aup.FirstName = new Name("tr").FirstName();
                aup.LastName = new Name("tr").LastName();

            }
            context.SaveChanges();

            #endregion







            //Marka ve Model Bilgileri
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                Vehicle v = new Vehicle();
                v.BrandName = new Commerce("tr").Categories(1)[0];
                v.Description = new Lorem("tr").Sentence(5);

                for (int j = 0; j < 5; j++)
                {
                    Model m = new Model();
                    m.ModelName = new Name("tr").FirstName();
                    m.ModelYear = rnd.Next(2005, 2022);
                    m.Pack = new Commerce("tr").Categories(1)[0];
                    v.Models.Add(m);



                }


                context.Vehicle.Add(v);
                context.SaveChanges();
            }

            for (int i = 0; i < 10; i++)
            {
                Category c = new Category();
                c.CategoryName = new Commerce("tr").Categories(1)[0];
                c.Description = new Lorem("tr").Sentence(10);

                for (int j = 0; j < 100; j++)
                {
                    Product p = new Product();
                    p.ProductName = new Commerce("tr").ProductName();
                    p.PartCode = new Commerce("tr").Ean13();
                    p.UnitPrice = Convert.ToDecimal(new Commerce("tr").Price());
                    p.UnitsInStock = 100;
                    p.ImagePath = new Images().Nightlife();
                    c.Products.Add(p);


                }

                context.Categories.Add(c);
                context.SaveChanges();
            }









        }
    }
}
