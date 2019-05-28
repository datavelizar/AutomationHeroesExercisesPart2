namespace P08._Military_Elite.Contracts
{
    using System.Collections.Generic;
    
    internal interface ILeutenantGeneral : IPrivate, ISoldier
    {
        ICollection<IPrivate> Privates { get; set; }
    }
}
