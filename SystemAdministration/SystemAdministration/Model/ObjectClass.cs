namespace SystemAdministration.Model
{
    /// <summary>
    /// Объект класса
    /// </summary>
    public class ObjectClass
    {
        /// <summary>
        /// ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Производственные фонды
        /// </summary>
        public bool ProductionFunds { get; set; }

        /// <summary>
        /// Метакласс
        /// </summary>
        public string MetaClass { get; set; }

        /// <summary>
        /// "Название класса
        /// </summary>
        public string TitleClass { get; set; }

        /// <summary>
        /// Название класса в родительном падеже
        /// </summary>
        public string TitleNameRoot { get; set; }

        /// <summary>
        /// Название класса во множественном числе
        /// </summary>
        public string NameClassInPlural { get; set; }

        /// <summary>
        /// Название класса во множественном числе родительном падеже
        /// </summary>
        public string NameInPluralGenitive { get; set; }

        /// <summary>
        /// Схема
        /// </summary>
        public string Scheme { get; set; }

        /// <summary>
        /// Таблица
        /// </summary>
        public string Table { get; set; }

        /// <summary>
        /// Значок
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Редактируемый
        /// </summary>
        public bool Editable { get; set; }

        /// <summary>
        /// ID_Нормативы по умолчанию
        /// </summary>
        public string IdStandartsDefault { get; set; }

        /// <summary>
        /// Название View
        /// </summary>
        public string TitleView { get; set; }

        /// <summary>
        /// Нестандартные триггеры
        /// </summary>
        public bool NonStandartTriggers { get; set; }

        /// <summary>
        /// Правило наименования
        /// </summary>
        public string NameRule { get; set; }

        /// <summary>
        /// Специальная схема отображения
        /// </summary>
        public string SpecialSchemeView { get; set; }

        /// <summary>
        /// Дополнительнве метаданные
        /// </summary>
        public string ExtraMetadata { get; set; }

        /// <summary>
        /// ID_Шаблона отчёта
        /// </summary>
        public string IdTempateReport { get; set; }

        /// <summary>
        /// Метка времени
        /// </summary>
        public string Timestamp { get; set; }

    }
}
