using System.Collections.Generic;
using System.Text;

namespace P08_Military_Elite
{
    class Engineer : Soldier, IEngineer
    {
        public Engineer(int soldierId, string soldierFN, string soldierLN)
           : base(soldierId, soldierFN, soldierLN)
        {
            this.Repairs = new List<Repair>();
        }

        public double Salary { get; set; }
        public ICollection<Repair> Repairs { get; set; }
        public CorpsType Corps { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine(string.Format(" Salary: {0:0.00}", this.Salary));

            sb.Append("Corps: ");
            sb.AppendLine(this.Corps.ToString());

            sb.AppendLine("Repairs:");
            foreach (var item in this.Repairs)
            {
                sb.Append("  ");
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
