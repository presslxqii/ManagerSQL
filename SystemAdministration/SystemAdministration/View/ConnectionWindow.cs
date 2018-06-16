namespace SystemAdministration.View
{
    using System;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    /// <inheritdoc />
    /// <summary>
    /// Окно соединения
    /// </summary>
    public partial class ConnectionWindow : Form
    {
        private const string ErrorTextMessage = "Error connection";

        private const string SuccessfulTextMessage = "Successful connection";

        /// <summary>
        /// Окно соединения
        /// </summary>
        public ConnectionWindow()
        {
            InitializeComponent();
            this.EventsElements();
        }

        /// <summary>
        /// Подписка на события
        /// </summary>
        private void EventsElements()
        {
            buttonConnectionTest.Click += ConnectionTest;
            buttonOk.Click += Connection;
            buttonExit.Click += Exit;
            this.Enter += Connection;
        }
        
        /// <summary>
        /// Выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Соединение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Connection(object sender, EventArgs e)
        {
            var connection = this.GetConnection();
            var systemAdministration = new SystemAdministrationView(connection);
            systemAdministration.Show();
            this.Hide();
        }

        /// <summary>
        /// Проверка соединения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConnectionTest(object sender, EventArgs e)
        {
            try
            {
                using (var connection = this.GetConnection())
                {
                    connection.Open();
                    ShowMessage(SuccessfulTextMessage, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                ShowMessage(ErrorTextMessage, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Показать сообщение
        /// </summary>
        /// <param name="text">
        /// Текст сообщения
        /// </param>
        /// <param name="icon">
        /// Тип сообщения
        /// </param>
        private static void ShowMessage(string text, MessageBoxIcon icon)
        {
            MessageBox.Show(text, @"Connection Info", MessageBoxButtons.OK, icon);
        }

        /// <summary>
        /// Получить соединение
        /// </summary>
        /// <returns>
        /// соединение
        /// </returns>
        private  SqlConnection GetConnection()
        {
            var initialCatalog = textBoxInitialCatalog.Text;
            var server = textBoxServer.Text;
            var connectionString = $"Integrated Security=true; Initial Catalog={initialCatalog}; Server={server}";
            var connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
