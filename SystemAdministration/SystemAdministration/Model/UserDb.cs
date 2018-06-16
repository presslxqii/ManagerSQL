namespace SystemAdministration.Model
{
    /// <inheritdoc />
    /// <summary>
    /// Пользователь
    /// </summary>
    public class UserDb : IDataPrinciples
    {
        /// <inheritdoc />
        /// <summary>
        /// ИД пользователя
        /// </summary>
        public int Id { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }
    }
}
