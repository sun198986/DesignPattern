using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StrategyPattern
{
    public abstract class SortStrategy
    {
        public abstract List<PersonInfo> Sort(List<PersonInfo> list);
    }

    public class NameSort:SortStrategy
    {

        public override List<PersonInfo> Sort(List<PersonInfo> list)
        {
            Console.WriteLine("NameSorted list");
            return list.OrderBy(p=>int.Parse(Regex.Match(p.Name, @"\d+").Value)).ToList();
        }
    }

   public class AgeSort:SortStrategy
   {
       public override List<PersonInfo> Sort(List<PersonInfo> list)
       {
           list.Sort((PersonInfo x,PersonInfo y)=>-x.Age.CompareTo(y.Age));
           Console.WriteLine("AgeSorted list");
            return list;
       }
   }

   public class EmailSort:SortStrategy
   {
       public override List<PersonInfo> Sort(List<PersonInfo> list)
       {
           Console.WriteLine("EmailSorted list");
           return list.OrderBy(p => p.Email).ToList();
        }
   }
}