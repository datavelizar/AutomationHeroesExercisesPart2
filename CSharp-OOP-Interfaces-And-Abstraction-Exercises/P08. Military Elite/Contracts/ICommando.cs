namespace P08._Military_Elite.Contracts
{
    using P08._Military_Elite.Models;
    using System.Collections.Generic;

    internal interface ICommando
    {
        ICollection<Mission> Missions { get; set; }
    }
}
