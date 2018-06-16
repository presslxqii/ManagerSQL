namespace SystemAdministration.Model
{
    /// <summary>
    /// Принципы базы данных
    /// </summary>
    public interface IDataPrinciples
    {
        /// <summary>
        /// ИД
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        string Name { get; set; }
    }
}
