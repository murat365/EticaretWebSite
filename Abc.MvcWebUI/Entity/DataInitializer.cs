using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var  kategoriler = new List<Category>()
            {
                new Category(){Name="Kamera",Description="Kamera Ürünleri"},
                new Category(){Name="Bilgisayar",Description="Bilgisayar  ürünleri"},
                new Category(){Name="Elektronik",Description="Elektronik Ürünleri"},
                new Category(){Name="Telefon",Description="Telefon Ürünleri"},
                new Category(){Name="Beyaz Eşya",Description="Beyaz Eşya Ürünleri"},
            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();


            var urunler = new List<Product>()
            {
                new Product(){Name="Canon eos profesyonel camera",Description="rastgele içerik sjdhbvhjsdbhsdbghsdh",Price=345,Stock=320, IsApproved=true, CategoryId = 1, IsHome=true},
                new Product(){Name="Canon eos profesyonel camera2",Description="rastgele içerik sjdhbvhjsdbhsdbghsdh",Price=346,Stock=320, IsApproved=false, CategoryId = 1},
                new Product(){Name="Canon eos profesyonel camera3",Description="rastgele içerik sjdhbvhjsdbhsdbghsdh",Price=344,Stock=320, IsApproved=true, CategoryId = 1},
                new Product(){Name="Canon eos profesyonel camera4",Description="rastgele içerik sjdhbvhjsdbhsdbghsdh",Price=347,Stock=320, IsApproved=true, CategoryId = 1},

                new Product(){Name="Canon eos profesyonel camera5",Description="rastgele içerik sjdhbvhjsdbhsdbghsdh",Price=347,Stock=320, IsApproved=true, CategoryId = 2, IsHome=true},
                new Product(){Name="Canon eos profesyonel camera6",Description="rastgele içerik sjdhbvhjsdbhsdbghsdh",Price=34577,Stock=320, IsApproved=false, CategoryId = 2},
                new Product(){Name="Canon eos profesyonel camera7",Description="rastgele içerik sjdhbvhjsdbhsdbghsdh",Price=345,Stock=320, IsApproved=true, CategoryId = 2},
                new Product(){Name="Canon eos profesyonel camera8",Description="rastgele içerik sjdhbvhjsdbhsdbghsdh",Price=345,Stock=320, IsApproved=true, CategoryId = 2, IsHome = true},

                new Product(){Name="Canon eos profesyonel camera9",Description="rastgele içerik sjdhbvhjsdbhsdbghsdh",Price=345,Stock=320, IsApproved=true, CategoryId = 3, IsHome=true},
                new Product(){Name="Canon eos profesyonel camera10",Description="rastgele içerik sjdhbvhjsdbhsdbghsdh",Price=345,Stock=320, IsApproved=false, CategoryId = 3},
                new Product(){Name="Canon eos profesyonel camera11",Description="rastgele içerik sjdhbvhjsdbhsdbghsdh",Price=345,Stock=320, IsApproved=true, CategoryId = 3},
                new Product(){Name="Canon eos profesyonel camera12",Description="rastgele içerik sjdhbvhjsdbhsdbghsdh",Price=345,Stock=320, IsApproved=false, CategoryId = 3},

                new Product(){Name="Canon eos profesyonel camera13",Description="rastgele içerik sjdhbvhjsdbhsdbghsdh",Price=345,Stock=320, IsApproved=false, CategoryId = 4},
                new Product(){Name="Canon eos profesyonel camera14",Description="rastgele içerik sjdhbvhjsdbhsdbghsdh",Price=345,Stock=320, IsApproved=true, CategoryId = 4},
                new Product(){Name="Canon eos profesyonel camera15",Description="rastgele içerik sjdhbvhjsdbhsdbghsdh",Price=345,Stock=320, IsApproved=false, CategoryId = 4, IsHome=true},
                new Product(){Name="Canon eos profesyonel camera16",Description="rastgele içerik sjdhbvhjsdbhsdbghsdh",Price=345,Stock=320, IsApproved=true, CategoryId = 4}
            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}