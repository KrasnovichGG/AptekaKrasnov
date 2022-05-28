using AptekaKrasnov;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApteka
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAptekaFarmacevt()
        {
            Farmacevt farmacevt1 = new Farmacevt("Александр", "Краснов", "Григорьевич", 1975, 20);
            Farmacevt farmacevt2 = new Farmacevt("Станислав", "Семёнов", "Борисович", 1968, 15);
            Farmacevt farmacevt3 = new Farmacevt("Влад", "Надеждин", "Денисович", 1984, 10);
            Farmacevt farmacevt4 = new Farmacevt("Алексундер", "Моисеев", "Александрович", 1992, 6);

            List<Farmacevt> farmacevts = new List<Farmacevt>() { farmacevt1};
           
            Farmacevt farmacevt = new Farmacevt();
            farmacevt.farmacevts.Add(farmacevt1);
            farmacevt.farmacevts.Add(farmacevt2);
            farmacevt.farmacevts.Add(farmacevt3);
            farmacevt.farmacevts.Add(farmacevt4);
      
            
            CollectionAssert.AreEqual(farmacevts.Where(x=>x.Age == 1975).ToList(), farmacevt.AgePrint(1975));
        }
        [TestMethod]
        public void TestNameLec()
        {
            Lekarstva lekarstva10 = new Lekarstva("Нурофен", "Рекитт", 370, 50, "Большая Красная 2а", true);
            Lekarstva lekarstva20 = new Lekarstva("Пенталгин", "Фармстандарт", 1523, 27, "Большая Синяя 2а", true);
            Lekarstva lekarstva30 = new Lekarstva("Лазолван", ", Дельфарм", 760, 40, "Большая Оранжевая 2а", false);
            Lekarstva lekarstva40 = new Lekarstva("Корвалол Реневал", "Обновление", 540, 30, "Большая Зелёная 2а", true);

            List<Lekarstva> lekarstvas = new List<Lekarstva>() { lekarstva10 };

            Lekarstva lekarstva = new Lekarstva();
            lekarstva.lekarstvas.Add(lekarstva10);
            lekarstva.lekarstvas.Add(lekarstva20);
            lekarstva.lekarstvas.Add(lekarstva30);
            lekarstva.lekarstvas.Add(lekarstva40);
            

            CollectionAssert.AreEqual(lekarstvas.Where(x => x.Name == "Нурофен").ToList(), lekarstva.GetLekName("Нурофен"));

        }
        [TestMethod]
        public void TestNameProizvod()
        {
            Lekarstva lekarstva10 = new Lekarstva("Нурофен", "Рекитт", 370, 50, "Большая Красная 2а", true);
            Lekarstva lekarstva20 = new Lekarstva("Пенталгин", "Фармстандарт", 1523, 27, "Большая Синяя 2а", true);
            Lekarstva lekarstva30 = new Lekarstva("Лазолван", ", Дельфарм", 760, 40, "Большая Оранжевая 2а", false);
            Lekarstva lekarstva40 = new Lekarstva("Корвалол Реневал", "Обновление", 540, 30, "Большая Зелёная 2а", true);

            List<Lekarstva> lekarstvas = new List<Lekarstva>() { lekarstva10 };

            Lekarstva lekarstva = new Lekarstva();
            lekarstva.lekarstvas.Add(lekarstva10);
            lekarstva.lekarstvas.Add(lekarstva20);
            lekarstva.lekarstvas.Add(lekarstva30);
            lekarstva.lekarstvas.Add(lekarstva40);

            CollectionAssert.AreEqual(lekarstvas.Where(x => x.Proizvoditel == "Рекитт").ToList(), lekarstva.GetProivodName("Рекитт"));

        }
        [TestMethod]
        public void TestGetMaxPrice()
        {
            List<Lekarstva> lekarstvas = new List<Lekarstva>();
            lekarstvas.Add(new Lekarstva("Нурофен", "Рекитт", 370, 50, "Большая Красная 2а", true));
            lekarstvas.Add(new Lekarstva("Пенталгин", "Фармстандарт", 1523, 27, "Большая Синяя 2а", true));
            lekarstvas.Add(new Lekarstva("Лазолван", ", Дельфарм", 760, 40, "Большая Оранжевая 2а", false));
            lekarstvas.Add(new Lekarstva("Корвалол Реневал", "Обновление", 540, 30, "Большая Зелёная 2а", true));
            lekarstvas.Add(new Lekarstva("Амбробене сироп", "Меркле", 814, 10, "Большая Жёлтая 2а", false));
            Lekarstva farmacevt = new Lekarstva();
            Assert.AreNotEqual(lekarstvas.MaxBy(x=>x.Price), farmacevt.GetPrice(1523));
        }


        [TestMethod]
        public void SortUpPriceTest()
        {
            List<Lekarstva> lekarstvas = new List<Lekarstva>();
            lekarstvas.Add(new Lekarstva("Нурофен", "Рекитт", 370, 50, "Большая Красная 2а", true));
            lekarstvas.Add(new Lekarstva("Корвалол Реневал", "Обновление", 540, 30, "Большая Зелёная 2а", true));
            lekarstvas.Add(new Lekarstva("Лазолван", ", Дельфарм", 760, 40, "Большая Оранжевая 2а", false));
            lekarstvas.Add(new Lekarstva("Амбробене сироп", "Меркле", 814, 10, "Большая Жёлтая 2а", false));
            lekarstvas.Add(new Lekarstva("Пенталгин", "Фармстандарт", 1523, 27, "Большая Синяя 2а", true));
            Lekarstva farmacevt = new Lekarstva();
            CollectionAssert.IsNotSubsetOf(lekarstvas, farmacevt.SortUpPrice());
        }

        [TestMethod]
        public void SortDownPriceTest()
        {
            List<Lekarstva> lekarstvas = new List<Lekarstva>();
            lekarstvas.Add(new Lekarstva("Пенталгин", "Фармстандарт", 1523, 27, "Большая Синяя 2а", true));
            lekarstvas.Add(new Lekarstva("Амбробене сироп", "Меркле", 814, 10, "Большая Жёлтая 2а", false));
            lekarstvas.Add(new Lekarstva("Лазолван", ", Дельфарм", 760, 40, "Большая Оранжевая 2а", false));
            lekarstvas.Add(new Lekarstva("Корвалол Реневал", "Обновление", 540, 30, "Большая Зелёная 2а", true));
            lekarstvas.Add(new Lekarstva("Нурофен", "Рекитт", 370, 50, "Большая Красная 2а", true));
            Lekarstva farmacevt = new Lekarstva();
            CollectionAssert.IsNotSubsetOf(lekarstvas, farmacevt.SortDownPrice());
        }
    }
}