
using AgenstvoNedvizimosty.Context.Contracts;
using AgenstvoNedvizimosty.Context.Contracts.Models;

namespace AgenstvoNedvizimosty.Context
{
    public class AgenstvoNedvizimostyContext : IAgenstvoNedvizimostyContext
    {

        private ICollection<Putevka> putevkas;
        private ICollection<PutTargetItem> putTargetItems;
        private ICollection<Target> targets;
        private ICollection<Turist> turists;
        private ICollection<TurOper> turOpers;

        public AgenstvoNedvizimostyContext()
        {
            putevkas = new HashSet<Putevka>();
            putTargetItems = new HashSet<PutTargetItem>();
            targets = new HashSet<Target>();
            turists = new HashSet<Turist>();
            turOpers = new HashSet<TurOper>();

            
        }

        public ICollection<Putevka> Putevkas => putevkas ;

        public ICollection<PutTargetItem> PutTargetItems => putTargetItems;

        public ICollection<Target> Targets => targets;

        public ICollection<Turist> Turists => turists;

        ICollection<TurOper> IAgenstvoNedvizimostyContext.turOpers => turOpers;
    }
}