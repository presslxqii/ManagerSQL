namespace SystemAdministration.Service
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Runtime.Remoting.Metadata.W3cXsd2001;
    using SystemAdministration.Constant;
    using SystemAdministration.Model;

    /// <summary>
    /// Сервис объектов классов
    /// </summary>
    public static class ObjectClassesService
    {
        /// <summary>
        /// Обновить строку в таблице Объекьтов классов
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nameColumn"></param>
        /// <param name="valueCell"></param>
        public static void UpdateTableObjectClasses(string id, string nameColumn, string valueCell)
        {
            var request = $"UPDATE [config].[Классы объектов] SET [{nameColumn}] = \'{valueCell}\' WHERE ID = \'{id}\'";
            SqlCommandsSevice.CommandsSql(request);
            LoggingService.Event(request);
        }

        /// <summary>
        /// Добавить новую строку в таблице Объекьтов классов
        /// </summary>
        /// <param name="viewObjectClass"></param>
        public static void InsertIntoTableObjectClass(ObjectClass viewObjectClass)
        {
            var idTempateReport = viewObjectClass.IdTempateReport == string.Empty ? $"CONVERT(uniqueidentifier,\'{viewObjectClass.IdTempateReport}\')" : "NULL";
            var idStandartsDefault = viewObjectClass.IdStandartsDefault == string.Empty ? $"\'CONVERT(uniqueidentifier, {viewObjectClass.IdStandartsDefault}\')" : "NULL";
            var valuesCells = $"CONVERT(uniqueidentifier,\'{viewObjectClass.Id}\'), \'{viewObjectClass.ProductionFunds}\', \'{viewObjectClass.MetaClass}\', \'{viewObjectClass.TitleClass}\', \'{viewObjectClass.TitleNameRoot}\', \'{viewObjectClass.NameClassInPlural}\', \'{viewObjectClass.NameInPluralGenitive}\'," +
                              $"\'{viewObjectClass.Scheme}\', \'{viewObjectClass.Table}\', \'{viewObjectClass.Image}\', \'{viewObjectClass.Editable}\', {idStandartsDefault}, \'{viewObjectClass.TitleView}\', \'{viewObjectClass.NonStandartTriggers}\', \'{viewObjectClass.NameRule}\'," +
                              $"\'{viewObjectClass.SpecialSchemeView}\',  \'{viewObjectClass.ExtraMetadata}\', {idTempateReport}, \'{viewObjectClass.Timestamp}\'";
            var request = $"INSERT INTO {Constants.DataBase.Requests.TableObjectClasses} ({Constants.DataBase.Requests.ColumnsObjectClasses}) VALUES ({valuesCells})";
            SqlCommandsSevice.CommandsSql(request);
            LoggingService.Event(request);
        }
        
        /// <summary>
        /// Импорт таблицы Объекты классов
        /// </summary>
        /// <returns>
        /// Объекты классов
        /// </returns>
        public static List<ObjectClass> ImportTableObjectClasses()
        {
            SqlCommandsSevice.Connection.Open();
            var objectClasseses = new List<ObjectClass>();
            var request = $"SELECT * FROM {Constants.DataBase.Requests.TableObjectClasses}";
            var command = new SqlCommand(request, SqlCommandsSevice.Connection);
            var values = command.ExecuteReader();
            while (values.Read())
            {
                objectClasseses.Add(new ObjectClass
                {
                    Id = values[0].ToString(),
                    ProductionFunds = (bool)values[1],
                    MetaClass = values[2].ToString(),
                    TitleClass = values[3].ToString(),
                    TitleNameRoot = values[4].ToString(),
                    NameClassInPlural = values[5].ToString(),
                    NameInPluralGenitive = values[6].ToString(),
                    Scheme = values[7].ToString(),
                    Table = values[8].ToString(),
                    Image = values[9] == DBNull.Value ? string.Empty : $"0x{new SoapHexBinary((byte[])values[9])}",
                    Editable = (bool)values[10],
                    IdStandartsDefault = values[11].ToString(),
                    TitleView = values[12].ToString(),
                    NonStandartTriggers = (bool)values[13],
                    NameRule = values[14].ToString(),
                    SpecialSchemeView = values[15].ToString(),
                    ExtraMetadata = values[16].ToString(),
                    IdTempateReport = values[17].ToString(),
                    Timestamp = values[18].ToString()
                });
            }
            SqlCommandsSevice.Connection.Close();
            return objectClasseses;
        }
        
        /// <summary>
        /// Колонки в таблице Объекты классов
        /// </summary>
        /// <returns>
        /// Объекты классов
        /// </returns>
        public static Dictionary<int, string> ColumnsTableObjectClasses()
        {
            return new Dictionary<int, string>
            {
                [0] = "ColumnID",
                [1] = "ColumnProductionFunds",
                [2] = "ColumnMetaClass",
                [3] = "ColumnTitleClass",
                [4] = "ColumnTitleNameRoot",
                [5] = "ColumnNameClassInPlural",
                [6] = "ColumnNameInPluralGenitive",
                [7] = "ColumnScheme",
                [8] = "ColumnTable",
                [9] = "ColumnImage",
                [10] = "ColumnEditable",
                [11] = "ColumnIdStandartsDefault",
                [12] = "ColumnTitleView",
                [13] = "ColumnNonStandartTriggers",
                [14] = "ColumnNameRule",
                [15] = "ColumnSpecialSchemeView",
                [16] = "ColumnExtraMetadata",
                [17] = "ColumnIdTempateReport",
                [18] = "ColumnTimestamp"
            };
        }
    }
}
