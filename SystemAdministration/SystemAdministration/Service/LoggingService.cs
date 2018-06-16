namespace SystemAdministration.Service
{
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// Журнал логгов
    /// </summary>
    public static class LoggingService
    {
        private const string FileName = "SqlCommand.txt";

        private static StreamWriter Logging { get; set; }

        /// <summary>
        /// Журнал логгов
        /// </summary>
        static LoggingService()
        {
            Logging = new StreamWriter(FileName);
        }

        /// <summary>
        /// Событие
        /// </summary>
        public static void Event(string command)
        {
            Logging.WriteLine("GO");
            Logging.WriteLine(command);
        }

        /// <summary>
        /// Сбросить буффер
        /// </summary>
        public static void Flush()
        {
            Logging.Close();
            Logging = new StreamWriter(FileName);
        }

        /// <summary>
        /// Сохранить sql
        /// </summary>
        public static void Save()
        {
            var saveFileDialog = new SaveFileDialog {Filter = @"sql files (*.sql)|*.sql|All files (*.*)|*.*" };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream stream;
                if ((stream = saveFileDialog.OpenFile()) != null)
                {
                    Logging.Close();
                    using (var fileStream = new StreamReader(FileName))
                    {
                        var streamWriter =  new StreamWriter(stream);
                        streamWriter.WriteLine(fileStream.ReadToEnd());
                        streamWriter.Close();
                    }
                    Logging = new StreamWriter(FileName);
                    stream.Close();
                }
            }
        }
    }
}
