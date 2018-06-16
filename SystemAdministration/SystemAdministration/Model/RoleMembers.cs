namespace SystemAdministration.Model
{
    /// <summary>
    /// Члены роли
    /// </summary>
    public class RoleMembers
    {
        /// <summary>
        /// Ид роли
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// Ид пользователя
        /// </summary>
        public int UserId { get; set; }
    }
}
