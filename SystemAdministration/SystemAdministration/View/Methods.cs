namespace SystemAdministration.View
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Model;
    using SystemAdministration.Service;


    public partial class SystemAdministrationView
    {
        private static bool isSecondLaunch;

        /// <summary>
        /// Классы
        /// </summary>
        private Dictionary<string, string> Classes { get; set; }

        /// <summary>
        /// Класс
        /// </summary>
        private RatioClass Class { get; set; }

        private List<RatioClass> RatioClasses { get; set; }

        /// <summary>
        /// Мапинг ячеек таблицы классы объкьтов
        /// </summary>
        private void ImportTableObjectClasses()
        {
            var listObjectClasses = this.RoleMembersService.ListObjectClasses;
            this.RoleMembersService.MetaClasses.ToList().ForEach(x => this.ColumnMetaClass.Items.Add(x));
            var columnIdTempateReport = this.RoleMembersService.TemplateReportsIds;
            columnIdTempateReport.ToList().ForEach(x => this.ColumnIdTempateReport.Items.Add(x.Value));
            var standartsWorksIds = this.RoleMembersService.StandartsWorksIds;
            standartsWorksIds.ToList().ForEach(x => this.ColumnIdStandartsDefault.Items.Add(x.Value));

            foreach (var listObjectClass in listObjectClasses)
            {
                var row = this.dataTableClasses.Rows.Add();
                this.dataTableClasses.Rows[row].Cells[ColumnsTableObjectClasses[0]].Value = listObjectClass.Id;
                this.dataTableClasses.Rows[row].Cells[ColumnsTableObjectClasses[1]].Value = listObjectClass.ProductionFunds;
                this.dataTableClasses.Rows[row].Cells[ColumnsTableObjectClasses[2]].Value = listObjectClass.MetaClass;
                this.dataTableClasses.Rows[row].Cells[ColumnsTableObjectClasses[3]].Value = listObjectClass.TitleClass;
                this.dataTableClasses.Rows[row].Cells[ColumnsTableObjectClasses[4]].Value = listObjectClass.TitleNameRoot;
                this.dataTableClasses.Rows[row].Cells[ColumnsTableObjectClasses[5]].Value = listObjectClass.NameClassInPlural;
                this.dataTableClasses.Rows[row].Cells[ColumnsTableObjectClasses[6]].Value = listObjectClass.NameInPluralGenitive;
                this.dataTableClasses.Rows[row].Cells[ColumnsTableObjectClasses[7]].Value = listObjectClass.Scheme;
                this.dataTableClasses.Rows[row].Cells[ColumnsTableObjectClasses[8]].Value = listObjectClass.Table;
                this.dataTableClasses.Rows[row].Cells[ColumnsTableObjectClasses[9]].Value = listObjectClass.Image;
                this.dataTableClasses.Rows[row].Cells[ColumnsTableObjectClasses[10]].Value = listObjectClass.Editable;
                this.dataTableClasses.Rows[row].Cells[ColumnsTableObjectClasses[11]].Value = listObjectClass.IdStandartsDefault == string.Empty ? string.Empty : standartsWorksIds[listObjectClass.IdStandartsDefault];
                this.dataTableClasses.Rows[row].Cells[ColumnsTableObjectClasses[12]].Value = listObjectClass.TitleView;
                this.dataTableClasses.Rows[row].Cells[ColumnsTableObjectClasses[13]].Value = listObjectClass.NonStandartTriggers;
                this.dataTableClasses.Rows[row].Cells[ColumnsTableObjectClasses[14]].Value = listObjectClass.NameRule;
                this.dataTableClasses.Rows[row].Cells[ColumnsTableObjectClasses[15]].Value = listObjectClass.SpecialSchemeView;
                this.dataTableClasses.Rows[row].Cells[ColumnsTableObjectClasses[16]].Value = listObjectClass.ExtraMetadata;
                this.dataTableClasses.Rows[row].Cells[ColumnsTableObjectClasses[17]].Value = listObjectClass.IdTempateReport == string.Empty ? string.Empty : columnIdTempateReport[listObjectClass.IdTempateReport];
                this.dataTableClasses.Rows[row].Cells[ColumnsTableObjectClasses[18]].Value = listObjectClass.Timestamp;
            }
        }

        /// <summary>
        /// Редактировать ячейки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditCell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            this.CellIsNull = false;
            if (this.dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[0]].Value == null)
            {
                this.CheckEmptyCell(this.dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[3]]);
                this.CheckEmptyCell(this.dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[4]]);
                this.CheckEmptyCell(this.dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[7]]);
                this.CheckEmptyCell(this.dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[8]]);
                if (this.CellIsNull)
                {
                    return;
                }

                this.dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[18]].Value = DateTime.Now;
                this.dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[0]].Value = Guid.NewGuid();
                var idTempateReport = this.RoleMembersService.TemplateReportsIds.Where(x => x.Value == (string)dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[17]].Value).Select(x => x.Key).FirstOrDefault();


                this.ObjectClass = new ObjectClass
                {
                    Id = dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[0]].Value.ToString(),
                    ProductionFunds =
                        dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[1]].Value is bool && (bool)dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[1]].Value,
                    MetaClass = (string)dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[2]].Value,
                    TitleClass = (string)dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[3]].Value,
                    TitleNameRoot =
                        (string)dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[4]].Value,
                    NameClassInPlural =
                        (string)dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[5]].Value,
                    NameInPluralGenitive =
                        (string)dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[6]].Value,
                    Scheme = (string)dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[7]].Value,
                    Table = (string)dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[8]].Value,
                    Image = dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[9]].Value as string,
                    Editable = dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[10]].Value is bool && (bool)(bool)dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[10]].Value,
                    IdStandartsDefault =
                        (string)dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[11]].Value,
                    TitleView = (string)dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[12]].Value,
                    NonStandartTriggers =
                        dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[13]].Value is bool && (bool)dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[13]].Value,
                    NameRule = (string)dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[14]].Value,
                    SpecialSchemeView =
                        (string)dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[15]].Value,
                    ExtraMetadata =
                        (string)dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[16]].Value,
                    IdTempateReport = idTempateReport,
                    Timestamp = dataTableClasses.Rows[e.RowIndex].Cells[ColumnsTableObjectClasses[18]].Value as string
                };

                this.RoleMembersService.InsertIntoTableObjectClass();
            }
            else
            {

                var row = this.dataTableClasses.Rows[e.RowIndex];
                var idRowUpdate = row.Cells[0].Value.ToString();
                var valueCellUpdate = (string)row.Cells[e.ColumnIndex].Value;
                var titleColumnUpdate = this.dataTableClasses.Columns[e.ColumnIndex].HeaderText;

                if (e.ColumnIndex == 17)
                {
                    valueCellUpdate = this.RoleMembersService.TemplateReportsIds.Where(x => x.Value == (string)row.Cells[e.ColumnIndex].Value).Select(x => x.Key).FirstOrDefault();
                }
                else if (e.ColumnIndex == 11)
                {
                    valueCellUpdate = this.RoleMembersService.StandartsWorksIds.Where(x => x.Value == (string)row.Cells[e.ColumnIndex].Value).Select(x => x.Key).FirstOrDefault();
                }
                               
                this.RoleMembersService.UpdateTableObjectClasses(idRowUpdate, titleColumnUpdate, valueCellUpdate);
            }
        }
        
        /// <summary>
        /// Провека на пустую ячейку
        /// </summary>
        /// <param name="cell"></param>
        private void CheckEmptyCell(DataGridViewCell cell)
        {
            if (cell.Value == null)
            {
                cell.Style.BackColor = Color.LightCoral;
                CellIsNull = true;
            }
            else
            {
                cell.Style.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Сохранить в скрипт
        /// </summary>
        /// <param name="panel">
        /// Панель
        /// </param>
        private static void SaveScript(Panel panel)
        {
            panel.BringToFront();
            if (!isSecondLaunch)
            {
                isSecondLaunch = true;
                return;
            }
            var dialogresult = MessageBox.Show(@"Cохранить в скрипт?", @"Сохранить", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                LoggingService.Save();
            }
            else
            {
                LoggingService.Flush();
            }
        }

        /// <summary>
        /// Обновить элменты на форме
        /// </summary>
        private void BindingItems()
        {
            this.listBoxDontHaveRole.DataSource = new BindingSource(this.RoleMembersService.ItemsOfSelectItem, null);
            this.listBoxDontHaveRole.DisplayMember = "Name";
            this.listBoxHaveRole.DataSource = new BindingSource(this.RoleMembersService.ItemsInSelectItem, null);
            this.listBoxHaveRole.DisplayMember = "Name";
        }
        
        /// <summary>
        /// Обновить элементы
        /// </summary>
        private void RefreshItems()
        {
            this.RoleMembersService.ImportItems();
            this.BindingItems();
        }

        /// <summary>
        /// Подключение к comboBoxRolesAndUsers
        /// </summary>
        /// <typeparam name="T">
        /// Объект
        /// </typeparam>
        /// <param name="dataSource">
        /// Коллекция
        /// </param>
        private void BindingRolesAndUsers<T>(IReadOnlyCollection<T> dataSource)
        {
            this.comboBoxRolesAndUsers.DataSource = new BindingSource(dataSource, null);
            this.comboBoxRolesAndUsers.DisplayMember = "Name";
        }
        
        /// <summary>
        /// Импорт данных
        /// </summary>
        private void ImportData()
        {
            this.ColumnsTableObjectClasses = this.RoleMembersService.ColumnsTableObjectClasses;
            RoleMembersService.ImportData();
            var bindingRoleSource = new BindingSource { DataSource = RoleMembersService.Roles };
            this.listRoles.DataSource = bindingRoleSource;
            this.listRoles.DisplayMember = "Name";
            this.comboBoxRolesAndUsers.DataSource = bindingRoleSource;
            this.comboBoxRolesAndUsers.DisplayMember = "Name";
        }

        /// <summary>
        /// Импорт классов
        /// </summary>
        private void ImportClasses()
        {
            this.Classes = RatioClassesService.ImportClasses();
            this.comboBoxClasses.DataSource = new BindingSource{ DataSource = this.Classes };
            this.comboBoxClasses.DisplayMember = "Value";
        }

        /// <summary>
        /// Выбрать класс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectedClass(object sender, EventArgs e)
        {
            this.UpdateRatioClasses(this.radioButtonParent.Checked);
        }

        /// <summary>
        /// Редактировать дополнительные поля класса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditExtraFieldsClass()
        {
            var parent = this.ParentClass(this.radioButtonParent.Checked, out var child);
            this.Class = this.RatioClasses.Where(x => x.ParentId == parent & x.DescendantId == child).Select(x => x).FirstOrDefault();
            var windowExtraFields = new RatioClassesView(this.Class);
            windowExtraFields.Show();
        }

        private string ParentClass(bool isSortByParent, out string child)
        {
            string parent;
            var selectedClass = (KeyValuePair<string, string>)this.comboBoxClasses.SelectedItem;
            var selectedClassId = this.Classes.Where(x => x.Value == (string)this.listBoxRatioClassesHaveItem.SelectedItem).Select(x => x.Key).FirstOrDefault();

            if (isSortByParent)
            {
                parent = selectedClass.Key;
                child = selectedClassId;
            }
            else
            {
                parent = selectedClassId;
                child = selectedClass.Value;
            }
            return parent;
        }

        private void UpdateRatioClasses(bool isParent)
        {
            var selectedClass = (KeyValuePair<string, string>)this.comboBoxClasses.SelectedItem;
            this.RatioClasses = RatioClassesService.ImportRatioClasses();
            var descendantsInParent = isParent ? RatioClasses.Where(x => x.ParentId == selectedClass.Key).Select(x => x.DescendantId) :
                RatioClasses.Where(x => x.DescendantId == selectedClass.Key).Select(x => x.ParentId);
            var descendantsOutParent = isParent ? RatioClasses.Where(x => x.ParentId != selectedClass.Key).Select(x => x.DescendantId) :
                RatioClasses.Where(x => x.DescendantId != selectedClass.Key).Select(x => x.ParentId);
            var nameClassesInParent = descendantsInParent.Select(x => this.Classes[x]).ToList();
            var nameClassesOutParent = descendantsOutParent.Select(x => this.Classes[x]).ToList();
            this.listBoxRatioClassesHaveItem.DataSource = new BindingSource { DataSource = nameClassesInParent };
            this.listBoxRatioClassesDontHaveItem.DataSource = new BindingSource { DataSource = nameClassesOutParent };
        }
    }
}