namespace P08._Military_Elite.Contracts
{
    using P08._Military_Elite.Models;
    using System.Collections.Generic;

    internal interface IEngineer : ISpecialisedSoldier, IPrivate, ISoldier
    {
        ICollection<Repair> Repairs { get; set; }
    }
}
