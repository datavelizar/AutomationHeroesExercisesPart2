using System.Text;

namespace P08_Military_Elite
{
    class Repair
    {
        public string PartName { get; set; }

        public int HoursWorked { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("Part Name: {0} Hours Worked: {1}", this.PartName, this.HoursWorked));
            return sb.ToString();
        }
    }
}
