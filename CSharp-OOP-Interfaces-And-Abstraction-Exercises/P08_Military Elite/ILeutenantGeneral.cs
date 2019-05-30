using System.Collections.Generic;

namespace P08_Military_Elite
{
    internal interface ILeutenantGeneral : IPrivate, ISoldier
    {
        ICollection<ISoldier> Privates { get; set; }
    }
}
