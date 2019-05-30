using System.Text;

namespace P08_Military_Elite
{
    class Spy : Soldier, ISpy
    {
        public Spy(int soldierId, string soldierFN, string soldierLN)
            : base(soldierId, soldierFN, soldierLN)
        {
        }

        public string CodeNumber { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine(string.Format("Code Number: {0}", this.CodeNumber));
            return sb.ToString();
        }
    }
}
