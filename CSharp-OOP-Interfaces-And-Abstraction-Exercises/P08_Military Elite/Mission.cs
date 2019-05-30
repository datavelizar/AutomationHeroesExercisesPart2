using System.Text;

namespace P08_Military_Elite
{
    internal class Mission
    {
        public Mission(string codeName, StateType state = StateType.inProgress)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get; set; }
        public StateType State { get; private set; }

        public void CompleteMission()
        {
            this.State = StateType.finished;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Format("Code Name: {0} State: {1}", this.CodeName, this.State));

            return sb.ToString();
        }
    }
}
