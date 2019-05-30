using System.Collections.Generic;
using System.Text;

namespace P08_Military_Elite
{
    class Commando : Soldier, ICommando
    {
        public Commando(int soldierId, string soldierFN, string soldierLN)
           : base(soldierId, soldierFN, soldierLN)
        {
            this.Missions = new List<Mission>();
        }

        public ICollection<Mission> Missions { get; set; }
        public CorpsType Corps { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine(string.Format(" Salary: {0:0.00}", this.Salary));

            sb.Append("Corps: ");
            sb.AppendLine(this.Corps.ToString());

            sb.AppendLine("Missions:");
            foreach (var item in this.Missions)
            {
                sb.Append("  ");
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}
