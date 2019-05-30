namespace P08_Military_Elite
{
    internal interface ISpecialisedSoldier : IPrivate, ISoldier
    {
        CorpsType Corps { get; set; }
    }
}
