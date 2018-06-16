namespace SystemAdministration.Service
{
    using System;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    /// <summary>
    /// Сервис комманд sql
    /// </summary>
    public class SqlCommandsSevice
    {
        /// <summary>
        /// Соединение
        /// </summary>
        public static SqlConnection Connection { get; set; }

        public SqlCommandsSevice(SqlConnection connection)
        {
            Connection = connection;
        }

        /// <summary>
        /// Обращение к бд
        /// </summary>
        /// <param name="request">
        /// Запрос
        /// </param>
        public static void CommandsSql(string request)
        {
            try
            {
                Connection.Open();
                var command = new SqlCommand(request, Connection);
                command.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception e)
            {
                Connection.Close();
                MessageBox.Show(e.Message, @"Command information", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
