using System.Net.Cache;
using System.Windows.Forms;

namespace SystemAdministration.Constant
{
    /// <summary>
    /// Константы
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Запрос
        /// </summary>
        public static class DataBase
        {
            /// <summary>
            /// Классы объектов
            /// </summary>
            public static class Requests
            {
                public const string TableObjectClasses = "[config].[Классы объектов]";

                public const string TableRatioClasses = "[config].[Отношения классов]";

                public const string TemplateReportsIds = "SELECT [ID],[Название шаблона] FROM [rep].[Шаблоны отчетов]";

                public const string StandartsWorks = "SELECT [ID],[Название] FROM [tasks].[Нормативы работ]";

                public const string ColumnsObjectClasses = "[ID]" +
                                                           ",[Производственные фонды]" +
                                                           ",[Метакласс]" +
                                                           ",[Название класса]" +
                                                           ",[Название класса в родительном падеже]" +
                                                           ",[Название класса во множественном числе]" +
                                                           ",[Название класса во множественном числе родительном падеже]" +
                                                           ",[Схема]" +
                                                           ",[Таблица]" +
                                                           ",[Значок]" +
                                                           ",[Редактируемый]" +
                                                           ",[ID_Норматива по умолчанию]" +
                                                           ",[Название View]" +
                                                           ",[Нестандартные триггеры]" +
                                                           ",[Правило именования]" +
                                                           ",[Специальная схема отображения]" +
                                                           ",[Дополнительные метаданные]" +
                                                           ",[ID_Шаблона_отчета]" +
                                                           ",[Метка времени]";

                public const string ColumnsRatioClasses = "[ID]" +
                                                          ",[ID_Класса_родителя]" +
                                                          ",[ID_Класса_потомка]";

                public const string RatioClasses = "SELECT * FROM[rubius_dream].[config].[Отношения классов]";

                public const string Classes = "SELECT [ID],[Название класса] FROM [config].[Классы объектов]";
            }
        }

        /// <summary>
        /// Текст
        /// </summary>
        public static class Text
        {
            /// <summary>
            /// Член
            /// </summary>
            public static class Member
            {
                public const string SortBy = "Выберите пользователя:";

                public const string MemberHaveRoles = "Роли, не имеющие данного пользователя:";

                public const string MemberDontHaveRoles = "Роли, имеющие данного пользователя:";
            }

            /// <summary>
            /// Роль
            /// </summary>
            public static class Role
            {
                public const string SortBy = "Выберите роль:";

                public const string RoleHaveMembers = "Пользователи, не имеющие данную роль:";

                public const string RoleDontHaveMembers = "Пользователи, имеющие данную роль:";
            }
        }
    }
}
