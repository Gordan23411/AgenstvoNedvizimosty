namespace TimeTable207.Context.Contracts.Models
{
    /// <summary>
    /// Инфа о путевке
    /// </summary>
    public class Target : BaseAuditEntity
    {
        /// <summary>
        /// название путевки
        /// </summary>
        public decimal namePut { get; set; }
        /// <summary>
        /// куда люди полетят 
        /// </summary>
        public string KudaAdress { get; set; }
        /// <summary>
        /// цена за 1-го человека
        /// </summary>
        public decimal PriseHuman { get; set; } 
    }
}
