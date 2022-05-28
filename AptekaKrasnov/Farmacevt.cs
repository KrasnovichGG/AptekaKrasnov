using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptekaKrasnov
{
    public class Farmacevt
    {
        
        public Farmacevt(string name, string surname, string family, int age, int staj)
        {
            
            Name = name;
            Surname = surname;
            Family = family;
            Age = age;
            Staj = staj;

        }
        public Farmacevt()
        {

        }
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Family { get; set; }
        public int Age { get; set; }
        public int Staj { get; set; }

      public  List<Farmacevt> farmacevts = new List<Farmacevt>();


        public override string ToString()
        {
            return "Имя:" + Name + " " + "Фамилия:" + Surname + " " + "Отчество:" + Family + " " + "Год рождения" + Age + " " + "Стаж работы" + Staj + " ";
        }
        public List<Farmacevt> AgePrint(int age)
        {
          
            var lst = farmacevts.Where(x => x.Age == age).ToList();
            return lst;
        }
    }
}
