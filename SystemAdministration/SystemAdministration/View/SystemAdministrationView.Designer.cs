namespace SystemAdministration.View
{
    partial class SystemAdministrationView
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
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Роли базы данных");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Пользователи и роли");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Роли", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Безопасность", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Классы объектов");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Отношение классов");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Конфигупация", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.treeFile = new System.Windows.Forms.TreeView();
            this.listRoles = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRename = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelRoles = new System.Windows.Forms.Panel();
            this.panelUsersInRoles = new System.Windows.Forms.Panel();
            this.listBoxDontHaveRole = new System.Windows.Forms.ListBox();
            this.listBoxHaveRole = new System.Windows.Forms.ListBox();
            this.buttonAllOfRole = new System.Windows.Forms.Button();
            this.buttonOfRole = new System.Windows.Forms.Button();
            this.buttonAllInRole = new System.Windows.Forms.Button();
            this.buttonInRole = new System.Windows.Forms.Button();
            this.labelRight = new System.Windows.Forms.Label();
            this.labelLeft = new System.Windows.Forms.Label();
            this.comboBoxRolesAndUsers = new System.Windows.Forms.ComboBox();
            this.radioButtonByUsers = new System.Windows.Forms.RadioButton();
            this.radioButtonByRoles = new System.Windows.Forms.RadioButton();
            this.buttonSaveRoleMembers = new System.Windows.Forms.Button();
            this.panelObjectClasses = new System.Windows.Forms.Panel();
            this.buttonSaveTableObjectClasses = new System.Windows.Forms.Button();
            this.dataTableClasses = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductionFunds = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnMetaClass = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnTitleClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTitleNameRoot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNameClassInPlural = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNameInPluralGenitive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnScheme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEditable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnIdStandartsDefault = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnTitleView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNonStandartTriggers = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnNameRule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSpecialSchemeView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExtraMetadata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdTempateReport = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnTimestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRatioClasses = new System.Windows.Forms.Panel();
            this.listBoxRatioClassesDontHaveItem = new System.Windows.Forms.ListBox();
            this.listBoxRatioClassesHaveItem = new System.Windows.Forms.ListBox();
            this.buttonDeleteClassesRatio = new System.Windows.Forms.Button();
            this.buttonDeleteClassRatio = new System.Windows.Forms.Button();
            this.buttonAddClassesRatio = new System.Windows.Forms.Button();
            this.buttonAddClassRatio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxClasses = new System.Windows.Forms.ComboBox();
            this.radioButtonDescendant = new System.Windows.Forms.RadioButton();
            this.radioButtonParent = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelRoles.SuspendLayout();
            this.panelUsersInRoles.SuspendLayout();
            this.panelObjectClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableClasses)).BeginInit();
            this.panelRatioClasses.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Файл";
            // 
            // treeFile
            // 
            this.treeFile.Location = new System.Drawing.Point(12, 29);
            this.treeFile.Name = "treeFile";
            treeNode8.Name = "RoleDB";
            treeNode8.Text = "Роли базы данных";
            treeNode9.Name = "RolesAndUsers";
            treeNode9.Text = "Пользователи и роли";
            treeNode10.Name = "Node1";
            treeNode10.Text = "Роли";
            treeNode11.Name = "Node0";
            treeNode11.Text = "Безопасность";
            treeNode12.Name = "ObjectClasses";
            treeNode12.Text = "Классы объектов";
            treeNode13.Name = "RatioClasses";
            treeNode13.Text = "Отношение классов";
            treeNode14.Name = "Node5";
            treeNode14.Text = "Конфигупация";
            this.treeFile.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode14});
            this.treeFile.Size = new System.Drawing.Size(267, 225);
            this.treeFile.TabIndex = 1;
            // 
            // listRoles
            // 
            this.listRoles.FormattingEnabled = true;
            this.listRoles.Location = new System.Drawing.Point(54, 57);
            this.listRoles.Name = "listRoles";
            this.listRoles.Size = new System.Drawing.Size(455, 186);
            this.listRoles.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(272, 258);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonRename
            // 
            this.buttonRename.Location = new System.Drawing.Point(353, 258);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(75, 23);
            this.buttonRename.TabIndex = 4;
            this.buttonRename.Text = "Rename";
            this.buttonRename.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(434, 258);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // textBoxRole
            // 
            this.textBoxRole.Location = new System.Drawing.Point(54, 261);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(212, 20);
            this.textBoxRole.TabIndex = 6;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(54, 13);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(124, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save as script";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // panelRoles
            // 
            this.panelRoles.Controls.Add(this.buttonAdd);
            this.panelRoles.Controls.Add(this.buttonSave);
            this.panelRoles.Controls.Add(this.buttonDelete);
            this.panelRoles.Controls.Add(this.textBoxRole);
            this.panelRoles.Controls.Add(this.buttonRename);
            this.panelRoles.Controls.Add(this.listRoles);
            this.panelRoles.Location = new System.Drawing.Point(288, 17);
            this.panelRoles.Name = "panelRoles";
            this.panelRoles.Size = new System.Drawing.Size(529, 301);
            this.panelRoles.TabIndex = 9;
            // 
            // panelUsersInRoles
            // 
            this.panelUsersInRoles.Controls.Add(this.listBoxDontHaveRole);
            this.panelUsersInRoles.Controls.Add(this.listBoxHaveRole);
            this.panelUsersInRoles.Controls.Add(this.buttonAllOfRole);
            this.panelUsersInRoles.Controls.Add(this.buttonOfRole);
            this.panelUsersInRoles.Controls.Add(this.buttonAllInRole);
            this.panelUsersInRoles.Controls.Add(this.buttonInRole);
            this.panelUsersInRoles.Controls.Add(this.labelRight);
            this.panelUsersInRoles.Controls.Add(this.labelLeft);
            this.panelUsersInRoles.Controls.Add(this.comboBoxRolesAndUsers);
            this.panelUsersInRoles.Controls.Add(this.radioButtonByUsers);
            this.panelUsersInRoles.Controls.Add(this.radioButtonByRoles);
            this.panelUsersInRoles.Controls.Add(this.buttonSaveRoleMembers);
            this.panelUsersInRoles.Location = new System.Drawing.Point(282, 23);
            this.panelUsersInRoles.Name = "panelUsersInRoles";
            this.panelUsersInRoles.Size = new System.Drawing.Size(529, 301);
            this.panelUsersInRoles.TabIndex = 10;
            // 
            // listBoxDontHaveRole
            // 
            this.listBoxDontHaveRole.FormattingEnabled = true;
            this.listBoxDontHaveRole.Location = new System.Drawing.Point(24, 148);
            this.listBoxDontHaveRole.Name = "listBoxDontHaveRole";
            this.listBoxDontHaveRole.Size = new System.Drawing.Size(202, 147);
            this.listBoxDontHaveRole.TabIndex = 22;
            // 
            // listBoxHaveRole
            // 
            this.listBoxHaveRole.FormattingEnabled = true;
            this.listBoxHaveRole.Location = new System.Drawing.Point(291, 148);
            this.listBoxHaveRole.Name = "listBoxHaveRole";
            this.listBoxHaveRole.Size = new System.Drawing.Size(218, 147);
            this.listBoxHaveRole.TabIndex = 21;
            // 
            // buttonAllOfRole
            // 
            this.buttonAllOfRole.Location = new System.Drawing.Point(232, 249);
            this.buttonAllOfRole.Name = "buttonAllOfRole";
            this.buttonAllOfRole.Size = new System.Drawing.Size(52, 23);
            this.buttonAllOfRole.TabIndex = 19;
            this.buttonAllOfRole.Text = "<<";
            this.buttonAllOfRole.UseVisualStyleBackColor = true;
            // 
            // buttonOfRole
            // 
            this.buttonOfRole.Location = new System.Drawing.Point(232, 220);
            this.buttonOfRole.Name = "buttonOfRole";
            this.buttonOfRole.Size = new System.Drawing.Size(52, 23);
            this.buttonOfRole.TabIndex = 18;
            this.buttonOfRole.Text = "<";
            this.buttonOfRole.UseVisualStyleBackColor = true;
            // 
            // buttonAllInRole
            // 
            this.buttonAllInRole.Location = new System.Drawing.Point(232, 191);
            this.buttonAllInRole.Name = "buttonAllInRole";
            this.buttonAllInRole.Size = new System.Drawing.Size(52, 23);
            this.buttonAllInRole.TabIndex = 17;
            this.buttonAllInRole.Text = ">>";
            this.buttonAllInRole.UseVisualStyleBackColor = true;
            // 
            // buttonInRole
            // 
            this.buttonInRole.Location = new System.Drawing.Point(232, 162);
            this.buttonInRole.Name = "buttonInRole";
            this.buttonInRole.Size = new System.Drawing.Size(51, 23);
            this.buttonInRole.TabIndex = 16;
            this.buttonInRole.Text = ">";
            this.buttonInRole.UseVisualStyleBackColor = true;
            // 
            // labelRight
            // 
            this.labelRight.AutoSize = true;
            this.labelRight.Location = new System.Drawing.Point(269, 123);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(205, 13);
            this.labelRight.TabIndex = 15;
            this.labelRight.Text = "Пользователи, имеющие данную роль:";
            // 
            // labelLeft
            // 
            this.labelLeft.AutoSize = true;
            this.labelLeft.Location = new System.Drawing.Point(21, 123);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(220, 13);
            this.labelLeft.TabIndex = 14;
            this.labelLeft.Text = "Пользователи, не имеющие данную роль:";
            // 
            // comboBoxRolesAndUsers
            // 
            this.comboBoxRolesAndUsers.FormattingEnabled = true;
            this.comboBoxRolesAndUsers.Location = new System.Drawing.Point(160, 60);
            this.comboBoxRolesAndUsers.Name = "comboBoxRolesAndUsers";
            this.comboBoxRolesAndUsers.Size = new System.Drawing.Size(189, 21);
            this.comboBoxRolesAndUsers.TabIndex = 13;
            // 
            // radioButtonByUsers
            // 
            this.radioButtonByUsers.AutoSize = true;
            this.radioButtonByUsers.Location = new System.Drawing.Point(24, 84);
            this.radioButtonByUsers.Name = "radioButtonByUsers";
            this.radioButtonByUsers.Size = new System.Drawing.Size(118, 17);
            this.radioButtonByUsers.TabIndex = 11;
            this.radioButtonByUsers.Text = "По пользователю:";
            this.radioButtonByUsers.UseVisualStyleBackColor = true;
            // 
            // radioButtonByRoles
            // 
            this.radioButtonByRoles.AutoSize = true;
            this.radioButtonByRoles.Checked = true;
            this.radioButtonByRoles.Location = new System.Drawing.Point(24, 60);
            this.radioButtonByRoles.Name = "radioButtonByRoles";
            this.radioButtonByRoles.Size = new System.Drawing.Size(77, 17);
            this.radioButtonByRoles.TabIndex = 10;
            this.radioButtonByRoles.TabStop = true;
            this.radioButtonByRoles.Text = "По ролям:";
            this.radioButtonByRoles.UseVisualStyleBackColor = true;
            // 
            // buttonSaveRoleMembers
            // 
            this.buttonSaveRoleMembers.Location = new System.Drawing.Point(54, 13);
            this.buttonSaveRoleMembers.Name = "buttonSaveRoleMembers";
            this.buttonSaveRoleMembers.Size = new System.Drawing.Size(124, 23);
            this.buttonSaveRoleMembers.TabIndex = 8;
            this.buttonSaveRoleMembers.Text = "Flush as script";
            this.buttonSaveRoleMembers.UseVisualStyleBackColor = true;
            // 
            // panelObjectClasses
            // 
            this.panelObjectClasses.Controls.Add(this.buttonSaveTableObjectClasses);
            this.panelObjectClasses.Controls.Add(this.dataTableClasses);
            this.panelObjectClasses.Location = new System.Drawing.Point(288, 29);
            this.panelObjectClasses.Name = "panelObjectClasses";
            this.panelObjectClasses.Size = new System.Drawing.Size(529, 301);
            this.panelObjectClasses.TabIndex = 8;
            // 
            // buttonSaveTableObjectClasses
            // 
            this.buttonSaveTableObjectClasses.Location = new System.Drawing.Point(33, 13);
            this.buttonSaveTableObjectClasses.Name = "buttonSaveTableObjectClasses";
            this.buttonSaveTableObjectClasses.Size = new System.Drawing.Size(124, 23);
            this.buttonSaveTableObjectClasses.TabIndex = 8;
            this.buttonSaveTableObjectClasses.Text = "Save as script";
            this.buttonSaveTableObjectClasses.UseVisualStyleBackColor = true;
            // 
            // dataTableClasses
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataTableClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTableClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnProductionFunds,
            this.ColumnMetaClass,
            this.ColumnTitleClass,
            this.ColumnTitleNameRoot,
            this.ColumnNameClassInPlural,
            this.ColumnNameInPluralGenitive,
            this.ColumnScheme,
            this.ColumnTable,
            this.ColumnImage,
            this.ColumnEditable,
            this.ColumnIdStandartsDefault,
            this.ColumnTitleView,
            this.ColumnNonStandartTriggers,
            this.ColumnNameRule,
            this.ColumnSpecialSchemeView,
            this.ColumnExtraMetadata,
            this.ColumnIdTempateReport,
            this.ColumnTimestamp});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableClasses.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataTableClasses.Location = new System.Drawing.Point(17, 42);
            this.dataTableClasses.Name = "dataTableClasses";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableClasses.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataTableClasses.Size = new System.Drawing.Size(492, 253);
            this.dataTableClasses.TabIndex = 0;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            // 
            // ColumnProductionFunds
            // 
            this.ColumnProductionFunds.HeaderText = "Производственные фонды";
            this.ColumnProductionFunds.Name = "ColumnProductionFunds";
            this.ColumnProductionFunds.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnProductionFunds.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnMetaClass
            // 
            this.ColumnMetaClass.HeaderText = "Метакласс";
            this.ColumnMetaClass.Name = "ColumnMetaClass";
            // 
            // ColumnTitleClass
            // 
            this.ColumnTitleClass.HeaderText = "Название класса";
            this.ColumnTitleClass.Name = "ColumnTitleClass";
            // 
            // ColumnTitleNameRoot
            // 
            this.ColumnTitleNameRoot.HeaderText = "Название класса в родительном падеже";
            this.ColumnTitleNameRoot.Name = "ColumnTitleNameRoot";
            // 
            // ColumnNameClassInPlural
            // 
            this.ColumnNameClassInPlural.HeaderText = "Название класса во множественном числе";
            this.ColumnNameClassInPlural.Name = "ColumnNameClassInPlural";
            // 
            // ColumnNameInPluralGenitive
            // 
            this.ColumnNameInPluralGenitive.HeaderText = "Название класса во множественном числе родительном падеже";
            this.ColumnNameInPluralGenitive.Name = "ColumnNameInPluralGenitive";
            // 
            // ColumnScheme
            // 
            this.ColumnScheme.HeaderText = "Схема";
            this.ColumnScheme.Name = "ColumnScheme";
            // 
            // ColumnTable
            // 
            this.ColumnTable.HeaderText = "Таблица";
            this.ColumnTable.Name = "ColumnTable";
            // 
            // ColumnImage
            // 
            this.ColumnImage.HeaderText = "Значок";
            this.ColumnImage.Name = "ColumnImage";
            this.ColumnImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnEditable
            // 
            this.ColumnEditable.HeaderText = "Редактируемый";
            this.ColumnEditable.Name = "ColumnEditable";
            this.ColumnEditable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnEditable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnIdStandartsDefault
            // 
            this.ColumnIdStandartsDefault.HeaderText = "ID_Норматива по умолчанию";
            this.ColumnIdStandartsDefault.Name = "ColumnIdStandartsDefault";
            this.ColumnIdStandartsDefault.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnIdStandartsDefault.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnTitleView
            // 
            this.ColumnTitleView.HeaderText = "Название View";
            this.ColumnTitleView.Name = "ColumnTitleView";
            // 
            // ColumnNonStandartTriggers
            // 
            this.ColumnNonStandartTriggers.HeaderText = "Нестандартные триггеры";
            this.ColumnNonStandartTriggers.Name = "ColumnNonStandartTriggers";
            this.ColumnNonStandartTriggers.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnNonStandartTriggers.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnNameRule
            // 
            this.ColumnNameRule.HeaderText = "Правило наименования";
            this.ColumnNameRule.Name = "ColumnNameRule";
            // 
            // ColumnSpecialSchemeView
            // 
            this.ColumnSpecialSchemeView.HeaderText = "Специальная схема отображения";
            this.ColumnSpecialSchemeView.Name = "ColumnSpecialSchemeView";
            // 
            // ColumnExtraMetadata
            // 
            this.ColumnExtraMetadata.HeaderText = "Дополнительнве метаданные";
            this.ColumnExtraMetadata.Name = "ColumnExtraMetadata";
            // 
            // ColumnIdTempateReport
            // 
            this.ColumnIdTempateReport.HeaderText = "ID_Шаблона отчёта";
            this.ColumnIdTempateReport.Name = "ColumnIdTempateReport";
            this.ColumnIdTempateReport.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnIdTempateReport.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnTimestamp
            // 
            this.ColumnTimestamp.HeaderText = "Метка времени";
            this.ColumnTimestamp.Name = "ColumnTimestamp";
            // 
            // panelRatioClasses
            // 
            this.panelRatioClasses.Controls.Add(this.listBoxRatioClassesDontHaveItem);
            this.panelRatioClasses.Controls.Add(this.listBoxRatioClassesHaveItem);
            this.panelRatioClasses.Controls.Add(this.buttonDeleteClassesRatio);
            this.panelRatioClasses.Controls.Add(this.buttonDeleteClassRatio);
            this.panelRatioClasses.Controls.Add(this.buttonAddClassesRatio);
            this.panelRatioClasses.Controls.Add(this.buttonAddClassRatio);
            this.panelRatioClasses.Controls.Add(this.label2);
            this.panelRatioClasses.Controls.Add(this.label3);
            this.panelRatioClasses.Controls.Add(this.comboBoxClasses);
            this.panelRatioClasses.Controls.Add(this.radioButtonDescendant);
            this.panelRatioClasses.Controls.Add(this.radioButtonParent);
            this.panelRatioClasses.Controls.Add(this.button5);
            this.panelRatioClasses.Location = new System.Drawing.Point(285, 29);
            this.panelRatioClasses.Name = "panelRatioClasses";
            this.panelRatioClasses.Size = new System.Drawing.Size(529, 301);
            this.panelRatioClasses.TabIndex = 11;
            // 
            // listBoxRatioClassesDontHaveItem
            // 
            this.listBoxRatioClassesDontHaveItem.FormattingEnabled = true;
            this.listBoxRatioClassesDontHaveItem.Location = new System.Drawing.Point(24, 148);
            this.listBoxRatioClassesDontHaveItem.Name = "listBoxRatioClassesDontHaveItem";
            this.listBoxRatioClassesDontHaveItem.Size = new System.Drawing.Size(202, 147);
            this.listBoxRatioClassesDontHaveItem.TabIndex = 22;
            // 
            // listBoxRatioClassesHaveItem
            // 
            this.listBoxRatioClassesHaveItem.FormattingEnabled = true;
            this.listBoxRatioClassesHaveItem.Location = new System.Drawing.Point(291, 148);
            this.listBoxRatioClassesHaveItem.Name = "listBoxRatioClassesHaveItem";
            this.listBoxRatioClassesHaveItem.Size = new System.Drawing.Size(218, 147);
            this.listBoxRatioClassesHaveItem.TabIndex = 21;
            // 
            // buttonDeleteClassesRatio
            // 
            this.buttonDeleteClassesRatio.Location = new System.Drawing.Point(232, 249);
            this.buttonDeleteClassesRatio.Name = "buttonDeleteClassesRatio";
            this.buttonDeleteClassesRatio.Size = new System.Drawing.Size(52, 23);
            this.buttonDeleteClassesRatio.TabIndex = 19;
            this.buttonDeleteClassesRatio.Text = "<<";
            this.buttonDeleteClassesRatio.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteClassRatio
            // 
            this.buttonDeleteClassRatio.Location = new System.Drawing.Point(232, 220);
            this.buttonDeleteClassRatio.Name = "buttonDeleteClassRatio";
            this.buttonDeleteClassRatio.Size = new System.Drawing.Size(52, 23);
            this.buttonDeleteClassRatio.TabIndex = 18;
            this.buttonDeleteClassRatio.Text = "<";
            this.buttonDeleteClassRatio.UseVisualStyleBackColor = true;
            // 
            // buttonAddClassesRatio
            // 
            this.buttonAddClassesRatio.Location = new System.Drawing.Point(232, 191);
            this.buttonAddClassesRatio.Name = "buttonAddClassesRatio";
            this.buttonAddClassesRatio.Size = new System.Drawing.Size(52, 23);
            this.buttonAddClassesRatio.TabIndex = 17;
            this.buttonAddClassesRatio.Text = ">>";
            this.buttonAddClassesRatio.UseVisualStyleBackColor = true;
            // 
            // buttonAddClassRatio
            // 
            this.buttonAddClassRatio.Location = new System.Drawing.Point(232, 162);
            this.buttonAddClassRatio.Name = "buttonAddClassRatio";
            this.buttonAddClassRatio.Size = new System.Drawing.Size(51, 23);
            this.buttonAddClassRatio.TabIndex = 16;
            this.buttonAddClassRatio.Text = ">";
            this.buttonAddClassRatio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Потомки, имеющие данного родителя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Потомоки, не имеющие данного родителя:";
            // 
            // comboBoxClasses
            // 
            this.comboBoxClasses.FormattingEnabled = true;
            this.comboBoxClasses.Location = new System.Drawing.Point(180, 60);
            this.comboBoxClasses.Name = "comboBoxClasses";
            this.comboBoxClasses.Size = new System.Drawing.Size(189, 21);
            this.comboBoxClasses.TabIndex = 13;
            // 
            // radioButtonDescendant
            // 
            this.radioButtonDescendant.AutoSize = true;
            this.radioButtonDescendant.Location = new System.Drawing.Point(24, 84);
            this.radioButtonDescendant.Name = "radioButtonDescendant";
            this.radioButtonDescendant.Size = new System.Drawing.Size(126, 17);
            this.radioButtonDescendant.TabIndex = 11;
            this.radioButtonDescendant.Text = "По классу потомка:";
            this.radioButtonDescendant.UseVisualStyleBackColor = true;
            // 
            // radioButtonParent
            // 
            this.radioButtonParent.AutoSize = true;
            this.radioButtonParent.Checked = true;
            this.radioButtonParent.Location = new System.Drawing.Point(24, 60);
            this.radioButtonParent.Name = "radioButtonParent";
            this.radioButtonParent.Size = new System.Drawing.Size(130, 17);
            this.radioButtonParent.TabIndex = 10;
            this.radioButtonParent.TabStop = true;
            this.radioButtonParent.Text = "По классу родителя:";
            this.radioButtonParent.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(54, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Flush as script";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(282, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 334);
            this.panel1.TabIndex = 12;
            // 
            // SystemAdministrationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 356);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelUsersInRoles);
            this.Controls.Add(this.panelRoles);
            this.Controls.Add(this.treeFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelRatioClasses);
            this.Controls.Add(this.panelObjectClasses);
            this.Name = "SystemAdministrationView";
            this.Text = "Administration System";
            this.panelRoles.ResumeLayout(false);
            this.panelRoles.PerformLayout();
            this.panelUsersInRoles.ResumeLayout(false);
            this.panelUsersInRoles.PerformLayout();
            this.panelObjectClasses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableClasses)).EndInit();
            this.panelRatioClasses.ResumeLayout(false);
            this.panelRatioClasses.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeFile;
        private System.Windows.Forms.ListBox listRoles;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRename;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panelRoles;
        private System.Windows.Forms.Panel panelUsersInRoles;
        private System.Windows.Forms.ListBox listBoxDontHaveRole;
        private System.Windows.Forms.ListBox listBoxHaveRole;
        private System.Windows.Forms.Button buttonAllOfRole;
        private System.Windows.Forms.Button buttonOfRole;
        private System.Windows.Forms.Button buttonAllInRole;
        private System.Windows.Forms.Button buttonInRole;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.ComboBox comboBoxRolesAndUsers;
        private System.Windows.Forms.RadioButton radioButtonByUsers;
        private System.Windows.Forms.RadioButton radioButtonByRoles;
        private System.Windows.Forms.Button buttonSaveRoleMembers;
        private System.Windows.Forms.Panel panelObjectClasses;
        private System.Windows.Forms.DataGridView dataTableClasses;
        private System.Windows.Forms.Button buttonSaveTableObjectClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnProductionFunds;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnMetaClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitleClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitleNameRoot;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNameClassInPlural;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNameInPluralGenitive;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnScheme;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImage;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnEditable;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnIdStandartsDefault;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitleView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnNonStandartTriggers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNameRule;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSpecialSchemeView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExtraMetadata;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnIdTempateReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTimestamp;
        private System.Windows.Forms.Panel panelRatioClasses;
        private System.Windows.Forms.ListBox listBoxRatioClassesDontHaveItem;
        private System.Windows.Forms.ListBox listBoxRatioClassesHaveItem;
        private System.Windows.Forms.Button buttonDeleteClassesRatio;
        private System.Windows.Forms.Button buttonDeleteClassRatio;
        private System.Windows.Forms.Button buttonAddClassesRatio;
        private System.Windows.Forms.Button buttonAddClassRatio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxClasses;
        private System.Windows.Forms.RadioButton radioButtonDescendant;
        private System.Windows.Forms.RadioButton radioButtonParent;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
    }
}

