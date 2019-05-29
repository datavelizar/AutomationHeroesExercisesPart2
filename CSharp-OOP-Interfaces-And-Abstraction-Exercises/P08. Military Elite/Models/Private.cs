namespace P08._Military_Elite.Models
{
    using P08._Military_Elite.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Private : IPrivate
    {
        public double Salary { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public override string ToString()
        {
            //Name: < firstName > < lastName > Id: < id > Salary: < salary >
            var sb = new StringBuilder();

            sb.Append(string.Format($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary}"));
            return sb.ToString();
        }
    }
}
