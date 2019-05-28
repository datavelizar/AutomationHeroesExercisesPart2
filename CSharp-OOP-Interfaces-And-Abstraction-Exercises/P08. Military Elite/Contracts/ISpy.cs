namespace P08._Military_Elite.Contracts
{
    internal interface ISpy : IPrivate, ISoldier
    {
        string CodeNumber { get; set; }
    }
}
