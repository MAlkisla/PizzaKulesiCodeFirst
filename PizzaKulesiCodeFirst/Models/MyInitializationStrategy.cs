using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKulesiCodeFirst.Models
{
    public class MyInitializationStrategy : CreateDatabaseIfNotExists<PizzaKulesiContext>
    {
        protected override void Seed(PizzaKulesiContext context)
        {
            Musteri musteri1 = new Musteri
            {
                AdSoyad = "Meriç Alkışla",
                Adres = "Keçiören",
            };
            Musteri musteri2 = new Musteri
            {
                AdSoyad = "Azize Fidan",
                Adres = "Gölbaşı",
            };

            Pizza pizza1 = new Pizza {Cesit = "Bol malzemos",};
            Pizza pizza2 = new Pizza {Cesit = "Karışık",};
            Pizza pizza3 = new Pizza {Cesit = "Vejeteryan",};
            Pizza pizza4 = new Pizza {Cesit = "Kavurmalı",};

            EkstraMalzeme ekstraMalzeme1 = new EkstraMalzeme { MalzemeAd = "Mantar",};
            EkstraMalzeme ekstraMalzeme2 = new EkstraMalzeme { MalzemeAd = "Mozzarella",};
            EkstraMalzeme ekstraMalzeme3 = new EkstraMalzeme { MalzemeAd = "Küp Sucuk", };
            EkstraMalzeme ekstraMalzeme4 = new EkstraMalzeme { MalzemeAd = "Biber",};

            Siparis siparis = new Siparis()
            {
                MusteriId = 1,
                PizzaId = 2,
                EkstraMalzemeler = new List<EkstraMalzeme> { ekstraMalzeme1, ekstraMalzeme2},
                TeslimDurumu = true,
            };

            context.Pizzalar.AddRange(new Pizza[] { pizza1, pizza2, pizza3, pizza4 });
            context.EkstraMalzemeler.AddRange(new EkstraMalzeme[] { ekstraMalzeme1, ekstraMalzeme2, ekstraMalzeme3, ekstraMalzeme4 });
            context.Musteriler.AddRange(new Musteri[] { musteri1, musteri2 });
            context.Siparisler.Add(siparis);
        }
    }
}
