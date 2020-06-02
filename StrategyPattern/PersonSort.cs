using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    public class PersonSort
    {
        private List<PersonInfo>  _list = new List<PersonInfo>();

        private SortStrategy _sortStrategy;

        public void  SetPersonSortList(SortStrategy sortStrategy)
        {
            this._sortStrategy = sortStrategy;
        }


        public void Sort()
        {
            _sortStrategy.Sort(_list);
        }

        public void Add(PersonInfo personInfo)
        {
            _list.Add(personInfo);
        }

        public void Display()
        {
            foreach (var personInfo in _list)
            {
                Console.WriteLine($"姓名:{personInfo.Name},年龄:{personInfo.Age}:邮箱:{personInfo.Email},电话:{personInfo.Phone}");
            }
        }
    }
}