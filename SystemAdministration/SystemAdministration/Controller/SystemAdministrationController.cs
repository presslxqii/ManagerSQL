namespace SystemAdministration.Controller
{
    using View;
    using Model;
    using System.Collections.Generic;
    using System.Linq;
    using System.Data.SqlClient;
    using Service;

    /// <summary>
    /// Членство в роли
    /// </summary>
    public class SystemAdministrationController
    {
        /// <summary>
        /// Пользователи
        /// </summary>
        public List<UserDb> Users { get; private set; }

        /// <summary>
        /// Роли
        /// </summary>
        public List<RoleDb> Roles { get; private set; }
        
        /// <summary>
        /// Сервис по работе с ролями и пользователями
        /// </summary>
        //private RolesAndUsersService RolesAndUsersService { get; }
        
        /// <summary>
        /// Элементы в выбранном элменте
        /// </summary>
        public List<string> ItemsInSelectItem { get; private set; }

        /// <summary>
        /// Элементы не входящие в выбранный элемент
        /// </summary>
        public List<string> ItemsOfSelectItem { get; private set; }

        public List<ObjectClass> ListObjectClasses { get; private set; }

        public string[] MetaClasses { get; private set; }

        public Dictionary<string, string> TemplateReportsIds { get; private set; }

        public Dictionary<string, string> StandartsWorksIds { get; private set; }

        public Dictionary<int, string> ColumnsTableObjectClasses { get; set; }

        /// <summary>
        /// Библиотека пользователей роли
        /// </summary>
        private Dictionary<int, string> RoleMembersDictionary { get; set; }

        private ISystemAdministrationView View { get; }

        /// <summary>
        /// Членство в ролях
        /// </summary>
        /// <param name="connection">
        /// Соединение
        /// </param>
        /// <param name="view"></param>
        public SystemAdministrationController(SqlConnection connection, ISystemAdministrationView view)
        {
            new SqlCommandsSevice(connection);
            //RolesAndUsersService = new RolesAndUsersService();
            this.View = view;
            this.ImportData();
        }

        /// <summary>
        /// Вызрузить все данные
        /// </summary>
        public void ImportData()
        {
            this.ListObjectClasses = ObjectClassesService.ImportTableObjectClasses();
            this.Roles = RolesAndUsersService.Roles().ToList();
            this.Users = RolesAndUsersService.Users().ToList();
            this.MetaClasses = RolesAndUsersService.MetaClasses();
            this.TemplateReportsIds = RolesAndUsersService.TemplateReportsIds();
            this.StandartsWorksIds = RolesAndUsersService.StandartrsWorkIds();
            this.ColumnsTableObjectClasses = ObjectClassesService.ColumnsTableObjectClasses();
        }

        /// <summary>
        /// Загрузка членов роли
        /// </summary>
        public void FilterImportUsers()
        {
            this.RefreshItems(this.Roles, this.View.IsSortByRole);
        }

        /// <summary>
        /// Загрузка ролей пользователя
        /// </summary>
        public void FilterImportRoles()
        {
            this.RefreshItems(this.Users, this.View.IsSortByRole);
        }

        /// <summary>
        /// Загрузка элементов
        /// </summary>
        public void ImportItems()
        {
            if (this.View.IsSortByRole)
            {
                this.FilterImportRoles();
            }
            else
            {
                this.FilterImportUsers();
            }
        }

        /// <summary>
        /// Удаление или добавить члены
        /// </summary>
        public void AddOrRemoveMember()
        {
            if (this.View.ItemNameSelected == null)
                return;

            if (this.View.IsRemove)
            {
                this.RemoveItem(this.View.IsSortByRole, this.View.ItemName);
            }
            else
            {
                this.AddItem(this.View.IsSortByRole, this.View.ItemName);
            }
        }

        /// <summary>
        /// Обновить элементы
        /// </summary>
        /// <typeparam name="T">
        /// Сущность бд
        /// </typeparam>
        /// <param name="itemDb">
        /// Элементы бд
        /// </param>
        /// <param name="isSortByRole">
        /// Фильтр по роли
        /// </param>
        private void RefreshItems<T>(IEnumerable<T> itemDb, bool isSortByRole) where T : IDataPrinciples
        {
            RolesAndUsersService.Users();
            RolesAndUsersService.GetRoleMembersIds();
            this.RoleMembersDictionary = new Dictionary<int, string>();
            itemDb.ToList().ForEach(x => RoleMembersDictionary.Add(x.Id, x.Name));
            ItemsInSelectItem = new List<string>();

            foreach (var rolesAndUserse in RolesAndUsersService.ListRoleMembers)
            {
                if (isSortByRole)
                {
                    if (rolesAndUserse.RoleId != this.View.Role.Id) continue;
                    ItemsInSelectItem.Add(this.RoleMembersDictionary[rolesAndUserse.UserId]);
                    this.RoleMembersDictionary.Remove(rolesAndUserse.UserId);
                }
                else
                {
                    if (rolesAndUserse.UserId != this.View.User.Id) continue;
                    ItemsInSelectItem.Add(this.RoleMembersDictionary[rolesAndUserse.RoleId]);
                    this.RoleMembersDictionary.Remove(rolesAndUserse.RoleId);
                }
            }

            ItemsOfSelectItem = this.RoleMembersDictionary.ToList().Select(x => x.Value).ToList();
        }

        /// <summary>
        /// Удалить эленмент
        /// </summary>
        /// <param name="isSortByRole">
        /// Фильтр по роли
        /// </param>
        /// <param name="item">
        /// Имя выбранного элемента
        /// </param>
        private void RemoveItem(bool isSortByRole, string item)
        {
            if (isSortByRole)
            {
                RolesAndUsersService.RemoveMemberOfRole(this.View.ItemNameSelected, item);
            }
            else
            {
                RolesAndUsersService.RemoveMemberOfRole(item, this.View.ItemNameSelected);
            }
        }

        /// <summary>
        /// Добавыить элемент
        /// </summary>
        /// <param name="isSortByRole">
        /// Фильтр по роли
        /// </param>
        /// <param name="item">
        /// Имя выбранного элемента
        /// </param>
        private void AddItem(bool isSortByRole, string item)
        {
            if (isSortByRole)
            {
                RolesAndUsersService.AddMemberInRole(this.View.ItemNameSelected, item);
            }
            else
            {
                RolesAndUsersService.AddMemberInRole(item, this.View.ItemNameSelected);
            }
        }

        /// <summary>
        /// Добавить роль
        /// </summary>
        public void AddRole()
        {
            RolesAndUsersService.AddRole(this.View.ItemNameSelected);
        }

        /// <summary>
        /// Удалить роль
        /// </summary>
        public void DeleteRole()
        {
            RolesAndUsersService.DeleteRole(this.View.ItemNameSelected);
        }

        /// <summary>
        /// Переименовать роль
        /// </summary>
        public void RenameRole()
        {
            RolesAndUsersService.RenameRole(this.View.ItemNameSelected, this.View.ItemName);
        }

        /// <summary>
        /// Обновить строку со значениями
        /// </summary>
        /// <param name="id">
        /// Id строки
        /// </param>
        /// <param name="nameColumn">
        /// Имя колонки
        /// </param>
        /// <param name="valueCell">
        /// Значение ячейки
        /// </param>
        public void UpdateTableObjectClasses(string id, string nameColumn, string valueCell)
        {
            ObjectClassesService.UpdateTableObjectClasses(id, nameColumn, valueCell);
        }

        /// <summary>
        /// Новая стока в таблице объекты классов
        /// </summary>
        public void InsertIntoTableObjectClass()
        {
            ObjectClassesService.InsertIntoTableObjectClass(this.View.ObjectClass);
        }

        /// <summary>
        /// Импорт отношение классов
        /// </summary>
        public void ImportRatioClasses()
        {
            var t = RatioClassesService.ImportClasses();
        }
    }
}
