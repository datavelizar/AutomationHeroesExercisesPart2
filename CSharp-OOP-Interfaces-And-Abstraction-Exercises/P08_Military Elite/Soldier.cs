using System.Text;

namespace P08_Military_Elite
{
    abstract class Soldier : ISoldier
    {
        public Soldier(int soldierId, string soldierFN, string soldierLN)
        {
            this.Id = soldierId;
            this.FirstName = soldierFN;
            this.LastName = soldierLN;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append(string.Format("Name: {0} {1} Id: {2}", this.FirstName, this.LastName, this.Id));

            return sb.ToString();
        }
    }
}
