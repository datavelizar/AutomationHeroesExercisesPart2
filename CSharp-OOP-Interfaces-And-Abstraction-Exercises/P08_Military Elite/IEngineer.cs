using System.Collections.Generic;

namespace P08_Military_Elite
{
    internal interface IEngineer : ISpecialisedSoldier, IPrivate, ISoldier
    {
        ICollection<Repair> Repairs { get; set; }
    }
}
