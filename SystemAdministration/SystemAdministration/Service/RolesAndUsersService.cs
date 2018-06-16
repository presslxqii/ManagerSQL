namespace SystemAdministration.Service
{
    using Constant;
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Windows.Forms;
    using SystemAdministration.Model;

    /// <summary>
    /// Роли и пользователи
    /// </summary>
    public static class RolesAndUsersService
    {
        /// <summary>
        /// биндинг ролей
        /// </summary>
        public static List<RoleMembers> ListRoleMembers { get; private set; }

        /// <summary>
        /// Получить всех пользователей
        /// </summary>
        /// <returns>
        /// Пользователи
        /// </returns>
        public static IEnumerable<UserDb> Users()
        {
            return GetValues<UserDb>("WINDOWS_USER");
        }

        /// <summary>
        /// Получить все роли базы данных
        /// </summary>
        /// <returns>
        /// Роли базы данных
        /// </returns>
        public static IEnumerable<RoleDb> Roles()
        {
            return GetValues<RoleDb>("DATABASE_ROLE");
        }

        /// <summary>
        /// Создать новую роль
        /// </summary>
        public static void AddRole(string roleName)
        {
            try
            {
                var request = $"CREATE ROLE \"{roleName}\" AUTHORIZATION [dbo]";
                SqlCommandsSevice.CommandsSql(request);
                LoggingService.Event(request);
            }
            catch (Exception)
            {
                SqlCommandsSevice.Connection.Close();
                MessageBox.Show(@"Такое имя роли уже существует", @"Connection Info", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        /// <summary>       
        /// Переименовать роль
        /// </summary>
        public static void RenameRole(string roleName, string newRoleName)
        {
            var request = $"ALTER ROLE \"{roleName}\" WITH NAME = \"{newRoleName}\"";
            SqlCommandsSevice.CommandsSql(request);
            LoggingService.Event(request);
        }

        /// <summary>
        /// Получить из таблицы Шаблоны отчётов колонку ID
        /// </summary>
        /// <returns>
        /// Значения колонки ID
        /// </returns>
        public static Dictionary<string, string> TemplateReportsIds()
        {
            SqlCommandsSevice.Connection.Open();
            var templateReportsIds = new Dictionary<string, string>();
            const string request = Constants.DataBase.Requests.TemplateReportsIds;
            var command = new SqlCommand(request, SqlCommandsSevice.Connection);
            var values = command.ExecuteReader();
            while (values.Read())
            {
                templateReportsIds.Add(values[0].ToString(), values[1].ToString());
            }
            SqlCommandsSevice.Connection.Close();
            return templateReportsIds;
        }

        /// <summary>
        /// Удалить роль
        /// </summary>
        public static void DeleteRole(string roleName)
        {
            var request = $"DROP ROLE \"{roleName}\"";
            SqlCommandsSevice.CommandsSql(request);
            LoggingService.Event(request);
        }

        /// <summary>
        /// Членнство в роли
        /// </summary>
        public static void GetRoleMembersIds()
        {
            ListRoleMembers = new List<RoleMembers>();

            SqlCommandsSevice.Connection.Open();
            const string request =
                "SELECT [role_principal_id], [member_principal_id] FROM [sys].[database_role_members]";
            var command = new SqlCommand(request, SqlCommandsSevice.Connection);
            var values = command.ExecuteReader();

            while (values.Read())
            {
                ListRoleMembers.Add(new RoleMembers{ RoleId = (int)values[0], UserId = (int)values[1] });
            }

            SqlCommandsSevice.Connection.Close();
        }

        /// <summary>
        /// Получить из таблицы Нормативы работы колонку ID
        /// </summary>
        /// <returns>
        /// Значнгие колонки ID 
        /// </returns>
        public static Dictionary<string, string> StandartrsWorkIds()
        {
            SqlCommandsSevice.Connection.Open();
            var templateReportsIds = new Dictionary<string, string>();
            const string request = Constants.DataBase.Requests.StandartsWorks;
            var command = new SqlCommand(request, SqlCommandsSevice.Connection);
            var values = command.ExecuteReader();
            while (values.Read())
            {
                templateReportsIds.Add(values[0].ToString(), values[1].ToString());
            }
            SqlCommandsSevice.Connection.Close();
            return templateReportsIds;
        }
        
        /// <summary>
        /// Добавление члена в роль
        /// </summary>
        public static void AddMemberInRole(string role, string member)
        {
            var request = $"ALTER ROLE \"{role}\"  ADD MEMBER \"{member}\"";
            SqlCommandsSevice.CommandsSql(request);
            LoggingService.Event(request);
        }

        /// <summary>
        /// Удаление члена из роли
        /// </summary>
        public static void RemoveMemberOfRole(string role, string member)
        {
            var request = $"ALTER ROLE \"{role}\"  DROP MEMBER \"{member}\"";
            SqlCommandsSevice.CommandsSql(request);
            LoggingService.Event(request);
        }

        /// <summary>
        /// Ограничение на ячейку Метаклассы
        /// </summary>
        /// <returns></returns>
        public static string[] MetaClasses()
        {
            return new[]
            {
                "Класс-сателлит (работы по факту)",
                "Класс-сателлит (работы по плану)",
                "Оборудование",
                "Область производства",
                "Справочник"
            };
        }
        
        /// <summary>
        /// Получить значение
        /// </summary>
        /// <typeparam name="T">
        /// Сущность бд
        /// </typeparam>
        /// <param name="typeDesc">
        /// Тип элемента
        /// </param>
        /// <returns></returns>
        private static IEnumerable<T> GetValues<T>(string typeDesc) where T : IDataPrinciples, new()
        {
            SqlCommandsSevice.Connection.Open();
            var collection = new List<T>();
            var request =
                $"SELECT [name], [principal_id] FROM [sys].[database_principals] WHERE [type_desc] = '{typeDesc}'";
            var command = new SqlCommand(request, SqlCommandsSevice.Connection);
            var values = command.ExecuteReader();

            while (values.Read())
            {
                collection.Add(new T {Name = values[0].ToString(), Id = (int) values[1]});
            }

            SqlCommandsSevice.Connection.Close();
            return collection;
        }
    }
}