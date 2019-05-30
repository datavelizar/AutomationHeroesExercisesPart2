using System;
using System.Text;

namespace P08_Military_Elite
{
    class Private : Soldier, IPrivate
    {
        private int privateId;
        private string privateFN;
        private string privateLN;

        public Private(int soldierId, string soldierFN, string soldierLN)
            : base(soldierId, soldierFN, soldierLN)
        {
            this.Id = soldierId;
            this.FirstName = soldierFN;
            this.LastName = soldierLN;
        }

        public int Id
        {
            get { return this.privateId; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Id cannot be negative");
                }
                this.privateId = value;
            }
        }
        public string FirstName
        {
            get { return this.privateFN; }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("FirstName cannot be empty");
                }
                this.privateFN = value;
            }
        }
        public string LastName
        {
            get { return this.privateLN; }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("LastName cannot be empty");
                }
                this.privateLN = value;
            }
        }

        public double Salary { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine(string.Format(" Salary: {0:0.00}", this.Salary));
            return sb.ToString();
        }
    }
}
