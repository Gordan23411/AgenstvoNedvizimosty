using TimeTable207.Context.Contracts;
using TimeTable207.Context.Contracts.Models;

namespace TimeTable207.Context
{
    public class TimeTableContext : ITimeTableContext
    {

        private ICollection<Putevka> putevkas;
        private ICollection<PutTargetItem> putTargetItems;
        private ICollection<Target> targets;
        private ICollection<Turist> turists;
        private ICollection<TurOper> turOpers;

        public TimeTableContext()
        {
            putevkas = new HashSet<Putevka>();
            putTargetItems = new HashSet<PutTargetItem>();
            targets = new HashSet<Target>();
            turists = new HashSet<Turist>();
            turOpers = new HashSet<TurOper>();

            
        }

        ICollection<Putevka> ITimeTableContext.Putevkas => putevkas;

        ICollection<PutTargetItem> ITimeTableContext.PutTargetItems => putTargetItems;

        ICollection<Target> ITimeTableContext.Targets => targets;

        ICollection<Turist> ITimeTableContext.Turists => turists;

        ICollection<TurOper> ITimeTableContext.TurOpers => turOpers;
    }
}