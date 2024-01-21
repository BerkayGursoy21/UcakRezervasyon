using System;

namespace Berkay.mains
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public string Id { get; set; }
        public string TelNo { get; set; }
        public int Sex { get; set; }
        public string Date { get; set; }

        public Customer(string tName, string tSurname, string tAge, string tId, string ttelNo, int tSex, string tDate)
        {
            Name = tName;
            Surname = tSurname;
            Age = tAge;
            Id = tId;
            TelNo = ttelNo;
            Sex = tSex;
            Date = tDate;
        }
    }
}
