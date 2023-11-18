using AgenstvoNedvizimosty.Context.Contracts.Models;

namespace AgenstvoNedvizimosty.Context.Contracts
{
    public interface ITimeTableContext
    {
        /// <summary>
        ///  Индентификация
        /// </summary>
        ICollection<BaseAuditEntity> BaseAuditEntitys { get; }
        /// <summary>
        /// Путевки
        /// </summary>
        ICollection<Putevka> Putevkas { get; }
        /// <summary>
        /// куда летят
        /// </summary>
        ICollection<PutTargetItem> PutTargetItems { get; }  
        /// <summary>
        /// место назначения
        /// </summary>
        ICollection<Target> Targets { get; }
        /// <summary>
        /// турист данные
        /// </summary>
        ICollection<Turist> Turists { get; }
        /// <summary>
        /// данные операторов
        /// </summary>
        ICollection<TurOper> turOpers { get; }
    }
}
