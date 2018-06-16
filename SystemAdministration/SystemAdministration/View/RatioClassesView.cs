using SystemAdministration.Controller;

namespace SystemAdministration.View
{
    using System;
    using System.Windows.Forms;
    using Model;

    public partial class RatioClassesView : Form, IRatioClassesView
    {
        public RatioClass FieldsValue { get; }

        private RatioClassesController RatioClasses { get; }

        public RatioClassesView(RatioClass fieldsValue)
        {
            RatioClasses = new RatioClassesController(this);
            FieldsValue = fieldsValue;
            InitializeComponent();
            MappingFields();
            EventsItems();
        }

        private void EventsItems()
        {
            this.buttonApply.Click += ApplyExtraFields;
            this.buttonCancel.Click += Cancel;
            this.dataTableExtraFieldsClass.DataError += DataError;
        }

        private void DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            this.dataTableExtraFieldsClass.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplyExtraFields(object sender, EventArgs e)
        {
            FieldsValue.DescendantRequired= (string)this.dataTableExtraFieldsClass.Rows[0].Cells[0].Value;
            FieldsValue.DescendantOnly= (string)this.dataTableExtraFieldsClass.Rows[0].Cells[1].Value;
            FieldsValue.DescendantOnTp= (string)this.dataTableExtraFieldsClass.Rows[0].Cells[2].Value;
            FieldsValue.TpDescendantOnTpParent= (string)this.dataTableExtraFieldsClass.Rows[0].Cells[3].Value;
            FieldsValue.ShowClassesNodeDescendant= (string)this.dataTableExtraFieldsClass.Rows[0].Cells[4].Value;
            FieldsValue.ShowClassesNodeTpDescendant = (string)this.dataTableExtraFieldsClass.Rows[0].Cells[5].Value;
            FieldsValue.Folder = (string)this.dataTableExtraFieldsClass.Rows[0].Cells[6].Value;
            RatioClasses.ApplyValueFieldsInTableRatioClasses();
            this.Close();
        }

        private void MappingFields()
        {
            this.dataTableExtraFieldsClass.Rows[0].Cells[0].Value = FieldsValue.DescendantRequired;
            this.dataTableExtraFieldsClass.Rows[0].Cells[1].Value = FieldsValue.DescendantOnly;
            this.dataTableExtraFieldsClass.Rows[0].Cells[2].Value = FieldsValue.DescendantOnTp;
            this.dataTableExtraFieldsClass.Rows[0].Cells[3].Value = FieldsValue.TpDescendantOnTpParent;
            this.dataTableExtraFieldsClass.Rows[0].Cells[4].Value = FieldsValue.ShowClassesNodeDescendant;
            this.dataTableExtraFieldsClass.Rows[0].Cells[5].Value = FieldsValue.ShowClassesNodeTpDescendant;
            this.dataTableExtraFieldsClass.Rows[0].Cells[6].Value = FieldsValue.Folder;
        }
    }
}
