namespace SystemAdministration.View
{
    partial class RatioClassesView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataTableExtraFieldsClass = new System.Windows.Forms.DataGridView();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.ColumnDescendantRequired = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnDescendantOnly = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnDescendantTp = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnTpDescendantTp = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnShowNode = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnShowNodeTp = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnFolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableExtraFieldsClass)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTableExtraFieldsClass
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableExtraFieldsClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTableExtraFieldsClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDescendantRequired,
            this.ColumnDescendantOnly,
            this.ColumnDescendantTp,
            this.ColumnTpDescendantTp,
            this.ColumnShowNode,
            this.ColumnShowNodeTp,
            this.ColumnFolder});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableExtraFieldsClass.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataTableExtraFieldsClass.Location = new System.Drawing.Point(36, 12);
            this.dataTableExtraFieldsClass.Name = "dataTableExtraFieldsClass";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableExtraFieldsClass.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataTableExtraFieldsClass.Size = new System.Drawing.Size(522, 64);
            this.dataTableExtraFieldsClass.TabIndex = 0;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(392, 92);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 1;
            this.buttonApply.Text = "Применить";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(483, 92);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // ColumnDescendantRequired
            // 
            this.ColumnDescendantRequired.HeaderText = "Потомок обязателен";
            this.ColumnDescendantRequired.Name = "ColumnDescendantRequired";
            this.ColumnDescendantRequired.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDescendantRequired.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnDescendantRequired.Width = 120;
            // 
            // ColumnDescendantOnly
            // 
            this.ColumnDescendantOnly.HeaderText = "Потомок единственный";
            this.ColumnDescendantOnly.Name = "ColumnDescendantOnly";
            this.ColumnDescendantOnly.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDescendantOnly.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnDescendantOnly.Width = 150;
            // 
            // ColumnDescendantTp
            // 
            this.ColumnDescendantTp.HeaderText = "Потомок на ТП";
            this.ColumnDescendantTp.Name = "ColumnDescendantTp";
            this.ColumnDescendantTp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDescendantTp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnDescendantTp.Width = 130;
            // 
            // ColumnTpDescendantTp
            // 
            this.ColumnTpDescendantTp.HeaderText = "ТП потомка на ТП родителя";
            this.ColumnTpDescendantTp.Name = "ColumnTpDescendantTp";
            this.ColumnTpDescendantTp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnTpDescendantTp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnTpDescendantTp.Width = 150;
            // 
            // ColumnShowNode
            // 
            this.ColumnShowNode.HeaderText = "Показывать узел класса потомка";
            this.ColumnShowNode.Name = "ColumnShowNode";
            this.ColumnShowNode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnShowNode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnShowNode.Width = 150;
            // 
            // ColumnShowNodeTp
            // 
            this.ColumnShowNodeTp.HeaderText = "Показывать узел ТП потомка";
            this.ColumnShowNodeTp.Name = "ColumnShowNodeTp";
            this.ColumnShowNodeTp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnShowNodeTp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnShowNodeTp.Width = 150;
            // 
            // ColumnFolder
            // 
            this.ColumnFolder.HeaderText = "Папка";
            this.ColumnFolder.Name = "ColumnFolder";
            this.ColumnFolder.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnFolder.Width = 150;
            // 
            // RatioClassesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 130);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.dataTableExtraFieldsClass);
            this.Name = "RatioClassesView";
            this.Text = "WindowExtraFeildsClass";
            ((System.ComponentModel.ISupportInitialize)(this.dataTableExtraFieldsClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTableExtraFieldsClass;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnDescendantRequired;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnDescendantOnly;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnDescendantTp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnTpDescendantTp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnShowNode;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnShowNodeTp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFolder;
    }
}