namespace SystemAdministration.Service
{
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using Constant;
    using Model;

    /// <summary>
    /// Серивис отношение классов
    /// </summary>
    public static class RatioClassesService
    {
        /// <summary>
        /// Импорт таблицы отношение классов
        /// </summary>
        /// <returns>
        /// Отнощение классов
        /// </returns>
        public static List<RatioClass> ImportRatioClasses()
        {
            SqlCommandsSevice.Connection.Open();
            var ratioClasses = new List<RatioClass>();
            const string request = Constants.DataBase.Requests.RatioClasses;
            var command = new SqlCommand(request, SqlCommandsSevice.Connection);
            var values = command.ExecuteReader();
            while (values.Read())
            {
                ratioClasses.Add(new RatioClass
                {
                    Id = values[0].ToString(),
                    ParentId = values[1].ToString(),
                    DescendantId = values[2].ToString(),
                    DescendantRequired = values[3].ToString(),
                    DescendantOnly = values[4].ToString(),
                    DescendantOnTp = values[5].ToString(),
                    TpDescendantOnTpParent = values[6].ToString(),
                    ShowClassesNodeDescendant = values[7].ToString(),
                    ShowClassesNodeTpDescendant = values[8].ToString(),
                    Folder = values[9].ToString()
                });
            }
            SqlCommandsSevice.Connection.Close();
            return ratioClasses;
        }

        /// <summary>
        /// Импорт классов
        /// </summary>
        /// <returns>
        /// Классы
        /// </returns>
        public static Dictionary<string, string> ImportClasses()
        {
            SqlCommandsSevice.Connection.Open();
            var classes = new Dictionary<string, string>();
            const string request = Constants.DataBase.Requests.Classes;
            var command = new SqlCommand(request, SqlCommandsSevice.Connection);
            var values = command.ExecuteReader();
            while (values.Read())
            {
                classes.Add(values[0].ToString(), values[1].ToString());
            }
            SqlCommandsSevice.Connection.Close();
            return classes;
        }

        public static void UpdateTableRatioClasses(RatioClass ratioClass)
        {
            var request = $"UPDATE [config].[Отношения классов] SET [Потомок обязателен] = \'{ratioClass.DescendantRequired}\'," +
                          $"[Потомок единственный] = \'{ratioClass.DescendantOnly}\'," +
                          $"[Потомок на ТП] = \'{ratioClass.DescendantOnTp}\'," +
                          $"[ТП потомка на ТП родителя] = \'{ratioClass.TpDescendantOnTpParent}\'," +
                          $"[Показывать узел класса потомка] = \'{ratioClass.ShowClassesNodeDescendant}\'," +
                          $"[Показывать узел ТП потомка] = \'{ratioClass.ShowClassesNodeTpDescendant}\'," +
                          $"[Папка] = \'{ratioClass.Folder}\'" +
                          $"WHERE ID = \'{ratioClass.Id}\'";
            SqlCommandsSevice.CommandsSql(request);
            LoggingService.Event(request);
        }

        public static void InsertIntoTableRatioClasses(string idClassParent, string idClassDescendent)
        {
            var valuesCells = $"NEWID(), CONVERT(uniqueidentifier,\'{idClassParent}\'), CONVERT(uniqueidentifier,\'{idClassDescendent}\')";
            var request = $"INSERT INTO {Constants.DataBase.Requests.TableRatioClasses} ({Constants.DataBase.Requests.ColumnsRatioClasses}) VALUES ({valuesCells})";
            SqlCommandsSevice.CommandsSql(request);
            LoggingService.Event(request);
        }

        public static void DeleteRowInTableRatioClasses(string idClassParent, string idClassDescendent)
        {
            var request = $"DELETE FROM {Constants.DataBase.Requests.TableRatioClasses} WHERE [ID_Класса_родителя] = '{idClassParent}' AND [ID_Класса_потомка] = '{idClassDescendent}'";
            SqlCommandsSevice.CommandsSql(request);
            LoggingService.Event(request);
        }
    }
}
