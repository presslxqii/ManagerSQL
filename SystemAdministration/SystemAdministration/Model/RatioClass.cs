namespace SystemAdministration.Model
{
    /// <summary>
    /// Отношение класса
    /// </summary>
    public class RatioClass
    {
        /// <summary>
        /// ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Id класса родителя
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// Id класса потомка
        /// </summary>
        public string DescendantId { get; set; }

        /// <summary>
        /// Потомок обязателен
        /// </summary>
        public string DescendantRequired { get; set; }

        /// <summary>
        /// Потомок единствееный
        /// </summary>
        public string DescendantOnly { get; set; }

        /// <summary>
        /// Потомок на ТП
        /// </summary>
        public string DescendantOnTp { get; set; }

        /// <summary>
        /// ТП потомка на ТП родителя
        /// </summary>
        public string TpDescendantOnTpParent { get; set; }

        /// <summary>
        /// Показывать узел класса потомка
        /// </summary>
        public string ShowClassesNodeDescendant { get; set; }

        /// <summary>
        /// Показывать узел класса ТП потомка
        /// </summary>
        public string ShowClassesNodeTpDescendant { get; set; }

        /// <summary>
        /// Папка
        /// </summary>
        public string Folder { get; set; }
    }
}
