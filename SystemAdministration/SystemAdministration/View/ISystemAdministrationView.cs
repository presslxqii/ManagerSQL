namespace SystemAdministration.View
{
    using Model;

    /// <summary>
    /// Представление
    /// </summary>
    public interface ISystemAdministrationView
    {
        /// <summary>
        /// Выбранная роль
        /// </summary>
        RoleDb Role { get; }

        /// <summary>
        /// Выбранный пользователь
        /// </summary>
        UserDb User { get; }

        /// <summary>
        /// Имя выбранного элементы
        /// </summary>
        string ItemNameSelected { get; }

        /// <summary>
        /// Новое имя элемента
        /// </summary>
        string ItemName { get; }

        /// <summary>
        /// Это сортировка по роли
        /// </summary>
        bool IsSortByRole { get; }

        /// <summary>
        /// Это удаление
        /// </summary>
        bool IsRemove { get; }

        /// <summary>
        /// Объекты классов
        /// </summary>
        ObjectClass ObjectClass { get; set; }
    }
}
