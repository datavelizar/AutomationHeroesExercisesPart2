using System.Collections.Generic;

namespace P08_Military_Elite
{
    internal interface ICommando : ISpecialisedSoldier, IPrivate, ISoldier
    {
        ICollection<Mission> Missions { get; set; }
    }
}
