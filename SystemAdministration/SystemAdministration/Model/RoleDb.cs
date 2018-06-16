namespace SystemAdministration.Model
{
    /// <inheritdoc />
    /// <summary>
    /// Роли базы данных
    /// </summary>
    public class RoleDb : IDataPrinciples
    {
        /// <inheritdoc />
        /// <summary>
        /// ИД роли
        /// </summary>
        public int Id { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Название роли
        /// </summary>
        public string Name { get; set; }
    }
}
