using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptekaKrasnov
{
    public class Lekarstva : IComparable
    {
        public Lekarstva(string name, string proizvoditel, int price, int count, string address, bool activity)
        {
            Name = name;
            Proizvoditel = proizvoditel;
            Price = price;
            Count = count;
            Address = address;
            Activity = activity;
        }

        public Lekarstva()
        {
        }

        public List<Lekarstva> lekarstvas = new List<Lekarstva>();

        public string Name { get; set; }
        public string Proizvoditel { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public string Address { get; set; }
        public bool Activity { get; set; }
        

        public override string ToString()
        {
            return $"Название: {Name} Производитель: {Proizvoditel}  Цена: {Price} Количество: {Count} Адрес:{Address} Активный {Activity}";
        }

        public int CompareTo(object obj)
        {
            var lek = (Lekarstva)obj;
            return (Price.CompareTo(lek.Price));
        }

        public List<Lekarstva>GetLekName(string name) /*По названию товара*/
        {
            return lekarstvas.Where(x => x.Name == name).ToList();
        }
        public List<Lekarstva> GetProivodName(string proizvoditel) /*По названию производителя*/
        {
            return lekarstvas.Where(x => x.Proizvoditel == proizvoditel).ToList();
        }
        public List<Lekarstva> GetPrice(int price) /*Получение самого дорого лекарства*/
        {
            lekarstvas.Add(new Lekarstva("Нурофен", "Рекитт", 370, 50, "Большая Красная 2а", true));
            lekarstvas.Add(new Lekarstva("Пенталгин", "Фармстандарт", 1523, 27, "Большая Синяя 2а", true));
            lekarstvas.Add(new Lekarstva("Лазолван", ", Дельфарм", 760, 40, "Большая Оранжевая 2а", false));
            lekarstvas.Add(new Lekarstva("Корвалол Реневал", "Обновление", 540, 30, "Большая Зелёная 2а", true));
            lekarstvas.Add(new Lekarstva("Амбробене сироп", "Меркле", 814, 10, "Большая Жёлтая 2а", false));

            return lekarstvas.Where(x => x.Price == price).ToList();
        }
        public List<Lekarstva> MaxPrice(int price) /*Сортировка по дорогому леркаству*/
        {
            lekarstvas.Add(new Lekarstva("Нурофен", "Рекитт", 370, 50, "Большая Красная 2а", true));
            lekarstvas.Add(new Lekarstva("Пенталгин", "Фармстандарт", 1523, 27, "Большая Синяя 2а", true));
            lekarstvas.Add(new Lekarstva("Лазолван", ", Дельфарм", 760, 40, "Большая Оранжевая 2а", false));
            lekarstvas.Add(new Lekarstva("Корвалол Реневал", "Обновление", 540, 30, "Большая Зелёная 2а", true));
            lekarstvas.Add(new Lekarstva("Амбробене сироп", "Меркле", 814, 10, "Большая Жёлтая 2а", false));

            return lekarstvas.ToList();
        }
        public List<Lekarstva> MinPrice(int price) /*Сортировка по дешёвому лекарству*/
        {
            lekarstvas.Add(new Lekarstva("Нурофен", "Рекитт", 370, 50, "Большая Красная 2а", true));
            lekarstvas.Add(new Lekarstva("Пенталгин", "Фармстандарт", 1523, 27, "Большая Синяя 2а", true));
            lekarstvas.Add(new Lekarstva("Лазолван", ", Дельфарм", 760, 40, "Большая Оранжевая 2а", false));
            lekarstvas.Add(new Lekarstva("Корвалол Реневал", "Обновление", 540, 30, "Большая Зелёная 2а", true));
            lekarstvas.Add(new Lekarstva("Амбробене сироп", "Меркле", 814, 10, "Большая Жёлтая 2а", false));

            return lekarstvas.ToList();
        }
        public List<Lekarstva> GetActivity(bool activity) /*Активный ли?*/
        {
            lekarstvas.Add(new Lekarstva("Нурофен", "Рекитт", 370, 50, "Большая Красная 2а", true));
            lekarstvas.Add(new Lekarstva("Пенталгин", "Фармстандарт", 1523, 27, "Большая Синяя 2а", true));
            lekarstvas.Add(new Lekarstva("Лазолван", ", Дельфарм", 760, 40, "Большая Оранжевая 2а", false));
            lekarstvas.Add(new Lekarstva("Корвалол Реневал", "Обновление", 540, 30, "Большая Зелёная 2а", true));
            lekarstvas.Add(new Lekarstva("Амбробене сироп", "Меркле", 814, 10, "Большая Жёлтая 2а", false));

            return lekarstvas.Where(x => x.Activity == activity).ToList();
        }

        public List<Lekarstva> SortDownPrice()
        {
            lekarstvas.Add(new Lekarstva("Нурофен", "Рекитт", 370, 50, "Большая Красная 2а", true));
            lekarstvas.Add(new Lekarstva("Пенталгин", "Фармстандарт", 1523, 27, "Большая Синяя 2а", true));
            lekarstvas.Add(new Lekarstva("Лазолван", ", Дельфарм", 760, 40, "Большая Оранжевая 2а", false));
            lekarstvas.Add(new Lekarstva("Корвалол Реневал", "Обновление", 540, 30, "Большая Зелёная 2а", true));
            lekarstvas.Add(new Lekarstva("Амбробене сироп", "Меркле", 814, 10, "Большая Жёлтая 2а", false));

            for (int i = lekarstvas.Count - 1; i > 0; i--)
                for (int j = 1; j <= i; j++)
                {
                    object element1 = lekarstvas[(j - 1)];
                    object element2 = lekarstvas[(j)];
                    var comparableElement1 = (IComparable)element1;
                    if (comparableElement1.CompareTo(element2) < 0)
                    {
                        object temporary = lekarstvas[(j)];
                        lekarstvas[j] = (lekarstvas[j - 1]);
                        lekarstvas[j - 1] = (Lekarstva)temporary;
                    }
                }
            return lekarstvas;
        }

        public List<Lekarstva> SortUpPrice()
        {
            lekarstvas.Add(new Lekarstva("Нурофен", "Рекитт", 370, 50, "Большая Красная 2а", true));
            lekarstvas.Add(new Lekarstva("Пенталгин", "Фармстандарт", 1523, 27, "Большая Синяя 2а", true));
            lekarstvas.Add(new Lekarstva("Лазолван", ", Дельфарм", 760, 40, "Большая Оранжевая 2а", false));
            lekarstvas.Add(new Lekarstva("Корвалол Реневал", "Обновление", 540, 30, "Большая Зелёная 2а", true));
            lekarstvas.Add(new Lekarstva("Амбробене сироп", "Меркле", 814, 10, "Большая Жёлтая 2а", false));

            for (int i = lekarstvas.Count - 1; i > 0; i--)
                for (int j = 1; j <= i; j++)
                {
                    object element1 = lekarstvas[(j - 1)];
                    object element2 = lekarstvas[(j)];
                    var comparableElement1 = (IComparable)element1;
                    if (comparableElement1.CompareTo(element2) > 0)
                    {
                        object temporary = lekarstvas[(j)];
                        lekarstvas[j] = (lekarstvas[j - 1]);
                        lekarstvas[j - 1] = (Lekarstva)temporary;
                    }
                }
            return lekarstvas;
        }
    }
}
