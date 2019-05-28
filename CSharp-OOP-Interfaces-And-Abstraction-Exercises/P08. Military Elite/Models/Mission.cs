namespace P08._Military_Elite.Models
{
    internal class Mission
    {
        public Mission()
            : this("Private")
        {
        }

        public Mission(string codeName, StateType state = StateType.InProgress)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get; set; }

        public StateType State { get; private set; }

        public void CompleteMission()
        {
            this.State = StateType.Finished;
        }
    }
}
