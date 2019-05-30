using System.Collections.Generic;
using System.Text;

namespace P08_Military_Elite
{

    internal class LeutenantGeneral : Soldier, ILeutenantGeneral
    {
        public LeutenantGeneral(int soldierId, string soldierFN, string soldierLN)
            : base(soldierId, soldierFN, soldierLN)
        {
            this.Privates = new List<ISoldier>();
        }

        public double Salary { get; set; }
        public ICollection<ISoldier> Privates { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine(string.Format(" Salary: {0:0.00}", this.Salary));
            sb.AppendLine("Privates:");
            foreach (var item in this.Privates)
            {
                sb.Append("  ");
                sb.Append(item.ToString());
            }
            return sb.ToString();
        }
    }
}
