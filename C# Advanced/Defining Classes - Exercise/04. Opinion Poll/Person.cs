using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClases
{
    class Person
    {
        private string name;
        private int age;

        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            this.Name = "No name";

            this.Age = 1;
        }
        public Person(int number)
        {
            this.Name = "No name";
            this.Age = number;
        }
        public Person(string name , int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
    class Family
    {
        private string member;
        public string Member { get; set; }

        Dictionary<string,int> MembersList = new Dictionary<string, int>();

        public Dictionary<string,int> AddMember(string member , int age)
        {

            MembersList.Add(member,age);
            return MembersList;
        }
        public string GetOldestMember()
        {
            int maxV = MembersList.Values.Max();
            var maxK = MembersList.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            return string.Join(" ", maxK,maxV);
        }
        public SortedDictionary<string,int> GetElder()
        {
            SortedDictionary<string,int> elder = new SortedDictionary<string, int>();
            foreach (var item in MembersList.Where(v=>v.Value>30))
            {
                elder.Add(item.Key, item.Value);

            }
            return elder;
        }
    }
    class DateModifier
    {
        public double GetDateDifference (string startDate,string endDate)
        {
            var dates = new DateTime();

            return (DateTime.Parse(startDate) - DateTime.Parse(endDate)).TotalDays;
        }

    }

}
