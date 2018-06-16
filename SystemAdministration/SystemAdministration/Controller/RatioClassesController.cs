namespace SystemAdministration.Controller
{
    using View;
    using Service;

    public class RatioClassesController
    {
        private IRatioClassesView RatioClassesView { get; }

        public RatioClassesController(IRatioClassesView view)
        {
            this.RatioClassesView = view;
        }

        public void ApplyValueFieldsInTableRatioClasses()
        {
            RatioClassesService.UpdateTableRatioClasses(this.RatioClassesView.FieldsValue);
        }

        public static void InsertIntoTableRatioClasses(string idClassInComboBox, string idClassInListBox, bool isSortByParent)
        {
            if (isSortByParent)
            {
                RatioClassesService.InsertIntoTableRatioClasses(idClassInComboBox, idClassInListBox);
            }
            else
            {
                RatioClassesService.InsertIntoTableRatioClasses(idClassInListBox, idClassInComboBox);
            }
        }

        public static void DeleteRowInTableRatioClasses(string idClassInComboBox, string idClassInListBox, bool isSortByParent)
        {
            if (isSortByParent)
            {
                RatioClassesService.DeleteRowInTableRatioClasses(idClassInComboBox, idClassInListBox);
            }
            else
            {
                RatioClassesService.DeleteRowInTableRatioClasses(idClassInListBox, idClassInComboBox);
            }
        }
    }
}
