using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTable207.Context.Contracts.Models;

namespace TimeTable207.Context.Contracts
{
     public class ITimeTableContext
    {
        ICollection<Putevka> Putevkas { get;} = Array.Empty<Putevka>();

        ICollection<PutTargetItem> PutTargetItems { get; } = Array.Empty<PutTargetItem>();

        ICollection<Target> targets { get; } = Array.Empty<Target>();

        ICollection<Turist> turists { get; } = Array.Empty<Turist>();

        ICollection<TurOper> turOpers { get; } = Array.Empty<TurOper>();





    }
}
