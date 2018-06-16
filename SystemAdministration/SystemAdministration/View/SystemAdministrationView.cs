namespace SystemAdministration.View
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Windows.Forms;
    using Constant;
    using Controller;
    using Model;
    using System.Linq;
    using SystemAdministration.Service;

    /// <inheritdoc>
    /// IView
    /// </inheritdoc>
    /// <summary>
    /// Система администрирования
    /// </summary>
    public partial class SystemAdministrationView : Form, ISystemAdministrationView
    {
        /// <inheritdoc />
        /// <summary>
        /// Выбранная роль
        /// </summary>
        public RoleDb Role { get; private set; }

        /// <inheritdoc />
        /// <summary>
        /// Выбранный пользователь
        /// </summary>
        public UserDb User { get; private set; }

        /// <inheritdoc />
        /// <summary>
        /// Имя выбранного элементы
        /// </summary>
        public string ItemNameSelected { get; private set; }

        /// <inheritdoc />
        /// <summary>
        /// Новое имя элемента
        /// </summary>
        public string ItemName { get; private set; }

        /// <inheritdoc />
        /// <summary>
        /// Это сортировка по роли
        /// </summary>
        public bool IsSortByRole { get; private set; }

        /// <inheritdoc />
        /// <summary>
        /// Это удаление
        /// </summary>
        public bool IsRemove { get; private set; }

        /// <summary>
        /// Членство в роли
        /// </summary>
        private SystemAdministrationController RoleMembersService { get; }

        /// <summary>
        /// Колинки таблицы объекты классов
        /// </summary>
        private Dictionary<int, string> ColumnsTableObjectClasses { get; set; }

        /// <summary>
        /// Ячейка пуста
        /// </summary>
        private bool CellIsNull { get; set; }
        
        /// <summary>
        /// Объект класса
        /// </summary>
        public ObjectClass ObjectClass { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="connection">
        /// соединение с бд
        /// </param>
        public SystemAdministrationView(SqlConnection connection)
        {
            InitializeComponent();
            this.RoleMembersService = new SystemAdministrationController(connection, this);
            this.ImportData();
            this.EventsOfElements();
        }

        /// <summary>
        /// События элементов
        /// </summary>
        private void EventsOfElements()
        {
            this.listRoles.SelectedValueChanged += SelectChange;
            this.buttonAdd.Click += AddRole;
            this.buttonDelete.Click += DeleteRole;
            this.buttonRename.Click += RenameRole;
            this.buttonSave.Click += SaveScript;
            this.FormClosing += CloseProgram;
            this.treeFile.AfterSelect += SelectNode;
            this.comboBoxRolesAndUsers.SelectedIndexChanged += SelectRoleAndUsers;
            this.buttonInRole.Click += AddMemberInRole;
            this.buttonAllInRole.Click += AddAllItemsInSelectItem;
            this.buttonOfRole.Click += RemoveItemOfSelectItem;
            this.buttonAllOfRole.Click += RemoveAllItemsOfSelectItem;
            this.buttonSaveRoleMembers.Click += SaveScript;
            this.radioButtonByUsers.CheckedChanged += SortBy;
            this.radioButtonByRoles.CheckedChanged += SortBy;
            this.dataTableClasses.CellEndEdit += EditCell;
            this.buttonSaveTableObjectClasses.Click += SaveScript;
            this.dataTableClasses.DataError += DataError;
            this.comboBoxClasses.SelectedIndexChanged += SelectedClass;
            this.buttonAddClassRatio.Click += AddClassRatio;
            this.buttonAddClassesRatio.Click += AddClassesRatio;
            this.buttonDeleteClassRatio.Click += DeleteClassRatio;
            this.buttonDeleteClassesRatio.Click += ButtonDeleteClassesRatio;
            this.radioButtonParent.CheckedChanged += SortByRatioClasses;
            this.radioButtonDescendant.CheckedChanged += SortByRatioClasses;
        }

        private void SortByRatioClasses(object sender, EventArgs e)
        {
            if (this.radioButtonParent.Checked)
            {
                this.comboBoxClasses.Location = new System.Drawing.Point(180, 60);
            }
            else
            {
                this.comboBoxClasses.Location = new System.Drawing.Point(180, 80);
            }
            this.UpdateRatioClasses(this.radioButtonParent.Checked);
        }

        /// <summary>
        /// Удалить все классы из отнешения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void ButtonDeleteClassesRatio(object sender, EventArgs eventArgs)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Удалить класс из отношения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void DeleteClassRatio(object sender, EventArgs eventArgs)
        {
            var selectedClass = (string)this.listBoxRatioClassesHaveItem.SelectedItem;
            this.DeleteOrAddRowInTableRatioClasses(selectedClass, true);
        }

        private void DeleteOrAddRowInTableRatioClasses(string selectedClass, bool isDelete)
        {
            var selectedClassInComboBox = (KeyValuePair<string, string>)this.comboBoxClasses.SelectedItem;
            var idClassInListBox = this.Classes.Where(x => x.Value == selectedClass).Select(x => x.Key).FirstOrDefault();
            if (isDelete)
            {
                RatioClassesController.DeleteRowInTableRatioClasses(selectedClassInComboBox.Key, idClassInListBox, this.radioButtonParent.Checked);
            }
            else
            {

                RatioClassesController.InsertIntoTableRatioClasses(selectedClassInComboBox.Key, idClassInListBox, this.radioButtonParent.Checked);
            }
            this.UpdateRatioClasses(this.radioButtonParent.Checked);
        }

        /// <summary>
        /// Добавить все классы в отношения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void AddClassesRatio(object sender, EventArgs eventArgs)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Перенести один класс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void AddClassRatio(object sender, EventArgs eventArgs)
        {
            var selectedClass = (string)this.listBoxRatioClassesDontHaveItem.SelectedItem;
            this.DeleteOrAddRowInTableRatioClasses(selectedClass, false);
            EditExtraFieldsClass();
        }

        /// <summary>
        /// Обрабтка ошибок данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            this.dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[e.ColumnIndex]].Value = null;
        }

        /// <summary>
        /// Сортировать по
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortBy(object sender, EventArgs e)
        {
            if (this.radioButtonByUsers.Checked)
            {
                this.comboBoxRolesAndUsers.Location = new System.Drawing.Point(160, 80);
                this.labelLeft.Text = Constants.Text.Member.MemberDontHaveRoles;
                this.labelRight.Text = Constants.Text.Member.MemberHaveRoles;
                this.BindingRolesAndUsers(this.RoleMembersService.Users);
                this.RoleMembersService.ImportItems();
            }
            else if (this.radioButtonByRoles.Checked)
            {
                this.comboBoxRolesAndUsers.Location = new System.Drawing.Point(160, 60);
                this.labelLeft.Text = Constants.Text.Role.RoleDontHaveMembers;
                this.labelRight.Text = Constants.Text.Role.RoleHaveMembers;
                this.BindingRolesAndUsers(this.RoleMembersService.Roles);
                this.RoleMembersService.ImportItems();
            }
        }

        /// <summary>
        /// Удалить все элементы из выбранного элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveAllItemsOfSelectItem(object sender, EventArgs e)
        {
            var items = listBoxHaveRole.Items;
            foreach (var item in items)
            {
                this.ItemName = (string) item;
                this.IsRemove = true;
                this.RoleMembersService.AddOrRemoveMember();
            }

            this.RefreshItems();
        }


        /// <summary>
        /// Добавить все члены 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAllItemsInSelectItem(object sender, EventArgs e)
        {
            var items = listBoxDontHaveRole.Items;
            foreach (var item in items)
            {
                this.ItemName = (string) item;
                this.IsRemove = false;
                this.RoleMembersService.AddOrRemoveMember();
            }

            this.RefreshItems();
        }

        /// <summary>
        /// Удалить эемент из выбранного элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItemOfSelectItem(object sender, EventArgs e)
        {
            this.ItemName = (string) listBoxHaveRole.SelectedItem;
            this.IsRemove = true;
            this.RoleMembersService.AddOrRemoveMember();
            this.RefreshItems();
        }

        /// <summary>
        /// Добавить члена в роль
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddMemberInRole(object sender, EventArgs e)
        {
            this.ItemName = (string) listBoxDontHaveRole.SelectedItem;
            this.IsRemove = false;
            this.RoleMembersService.AddOrRemoveMember();
            this.RefreshItems();
        }

        /// <summary>
        /// Сортировка по роли или пользователям
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectRoleAndUsers(object sender, EventArgs e)
        {
            this.IsSortByRole = this.radioButtonByRoles.Checked;
            if (IsSortByRole)
            {
                this.Role = (RoleDb) comboBoxRolesAndUsers.SelectedItem;
                this.ItemNameSelected = this.Role.Name;
                this.RoleMembersService.FilterImportRoles();
                this.BindingItems();
            }
            else
            {
                this.User = (UserDb) comboBoxRolesAndUsers.SelectedItem;
                this.ItemNameSelected = this.User.Name;
                this.RoleMembersService.FilterImportUsers();
                this.BindingItems();
            }
        }

        /// <summary>
        /// Выбрать панель
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectNode(object sender, EventArgs e)
        {
            if (this.treeFile.SelectedNode.Name == "RoleDB")
            {
                SaveScript(this.panelRoles);
            }
            else if (this.treeFile.SelectedNode.Name == "RolesAndUsers")
            {
                SaveScript(this.panelUsersInRoles);
            }
            else if (this.treeFile.SelectedNode.Name == "ObjectClasses")
            {
                SaveScript(this.panelObjectClasses);
                this.ImportTableObjectClasses();
            }
            else if (this.treeFile.SelectedNode.Name == "RatioClasses")
            {
                SaveScript(this.panelRatioClasses);
                this.ImportClasses();
            }
        }

        /// <summary>
        /// Закрыть прогу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CloseProgram(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Сохранить в скрипт
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void SaveScript(object sender, EventArgs e)
        {
            LoggingService.Save();
            MessageBox.Show(@"Скрипт успешно сохранён", @"Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Переименовать роль
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RenameRole(object sender, EventArgs e)
        {
            var selectRole = (RoleDb) listRoles.SelectedItem;
            this.ItemNameSelected = selectRole.Name;
            this.ItemName = textBoxRole.Text;
            this.RoleMembersService.RenameRole();
            textBoxRole.Text = string.Empty;
            this.ImportData();
        }

        /// <summary>
        /// Удалить роль
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteRole(object sender, EventArgs e)
        {
            var dialogresult = MessageBox.Show(@"Удалить роль?", @"Удаление роли", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogresult == DialogResult.Yes)
            {
                this.ItemNameSelected = textBoxRole.Text;
                this.RoleMembersService.DeleteRole();
                textBoxRole.Text = string.Empty;
                this.ImportData();
            }
        }

        /// <summary>
        /// Добавить роль
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRole(object sender, EventArgs e)
        {
            this.ItemNameSelected = textBoxRole.Text;
            this.RoleMembersService.AddRole();
            this.textBoxRole.Text = string.Empty;
            this.ImportData();
        }

        /// <summary>
        /// Выбрать элемент
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void SelectChange(object sender, EventArgs eventArgs)
        {
            var selectRole = (RoleDb) listRoles.SelectedItem;
            textBoxRole.Text = selectRole.Name;
        }
    }
}