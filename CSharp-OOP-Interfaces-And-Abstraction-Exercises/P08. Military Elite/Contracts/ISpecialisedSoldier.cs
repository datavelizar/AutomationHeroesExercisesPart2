namespace P08._Military_Elite.Contracts
{
    using P08._Military_Elite.Models;

    internal interface ISpecialisedSoldier : IPrivate, ISoldier
    {
        CorpsType Corps { get; set; }
    }
}
