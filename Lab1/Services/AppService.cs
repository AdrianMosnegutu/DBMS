using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Generic;
using Lab1.Forms;
using Lab1.Repositories;
using System.Data;

namespace Lab1.Services
{
    internal class AppService
    {
        private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

        private static readonly string _parentTableName = ConfigurationManager.AppSettings["ParentTableName"];
        private static readonly string _childTableName = ConfigurationManager.AppSettings["ChildTableName"];

        private static readonly List<string> _columnNames = ConfigurationManager.AppSettings["ChildColumnNames"].Split(',').ToList();

        private static readonly string _primaryKey = ConfigurationManager.AppSettings["ChildPrimaryKey"];
        private static readonly string _foreignKey = ConfigurationManager.AppSettings["ParentPrimaryKey"];
        
        public static string ParentTableName => _parentTableName;
        public static string ChildTableName => _childTableName;

        public static string PrimaryKey => _primaryKey;
        public static string ForeignKey => _foreignKey;

        public static List<string> ColumnNames => _columnNames;

        private readonly AppRepository _repository = new AppRepository(
            _connectionString, 
            ParentTableName, 
            ChildTableName, 
            _primaryKey, 
            ForeignKey, 
            _columnNames
        );

        public void LoadParentRecords(DataGridView dataGridView)
        {
            _repository.ParentRepository.LoadRecords();
            dataGridView.DataSource = _repository.ParentRepository.GetRecords();

            if (dataGridView.Rows.Count > 0)
            {
                dataGridView.Rows[0].Selected = true;
            }
        }

        public void LoadChildRecords(int parentId, DataGridView dataGridView)
        {
            _repository.ChildRepository.LoadRecords(parentId);
            dataGridView.DataSource = _repository.ChildRepository.GetRecords();

            if (dataGridView.Rows.Count > 0)
            {
                dataGridView.Rows[0].Selected = true;
            }
        }

        public void OpenAddChildRecordDialogForm(int parentId, DataGridView dataGridView)
        {
            void addChildRecordAction(List<string> values)
            {
                values.Add(parentId.ToString());
             
                _repository.ChildRepository.InsertRecord(values);
                LoadChildRecords(parentId, dataGridView);
            }

            ChildDialogForm addRecordDialog = new ChildDialogForm(
                $"Add {ChildTableName}",
                $"Successfully added a new {ChildTableName} record!",
                addChildRecordAction
            );

            addRecordDialog.ShowDialog();
        }

        public void OpenUpdateChildRecordDialogForm(int parentId, int childId, DataGridView dataGridView)
        {
            void updateChildRecordAction(List<string> values)
            {
                values.Prepend(childId.ToString());
                values.Add(parentId.ToString());

                _repository.ChildRepository.UpdateRecord(childId, values);
                LoadChildRecords(parentId, dataGridView);
            }

            List<string> defaultValues = _repository.ChildRepository.GetRecord(childId).ItemArray
                .Skip(1)
                .Select(item => item?.ToString() ?? string.Empty)
                .ToList();

            ChildDialogForm updateRecordDialog = new ChildDialogForm(
                $"Update {ChildTableName}",
                $"Successfully updated the {ChildTableName} record with id {childId}!",
                updateChildRecordAction,
                defaultValues
            );

            updateRecordDialog.ShowDialog();
        }

        public void DeleteChildRecord(int parentId, int childId, DataGridView dataGridView)
        {
            _repository.ChildRepository.DeleteRecord(childId);
            LoadChildRecords(parentId, dataGridView);
        }
    }
}
