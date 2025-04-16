using System;
using System.Globalization;
using System.Windows.Forms;
using Lab2.Services;

namespace Lab2
{
    public partial class MainForm : Form
    {
        private readonly AppService _service = new AppService();

        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            parentTableLabel.Text = $"{textInfo.ToTitleCase(AppService.ParentTableName)}s Table";
            childTableLabel.Text = $"{textInfo.ToTitleCase(AppService.ChildTableName)}s Table";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _service.LoadParentRecords(parentTableGridView);
        }

        private void ParentTableGridView_SelectChanged(object sender, EventArgs e)
        {
            if (parentTableGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = parentTableGridView.SelectedRows[0];
                int parentId = int.Parse(selectedRow.Cells[AppService.ForeignKey].Value.ToString());
                _service.LoadChildRecords(parentId, childTableGridView);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (parentTableGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = parentTableGridView.SelectedRows[0];
                int parentId = int.Parse(selectedRow.Cells[AppService.ForeignKey].Value.ToString());
                _service.OpenAddChildRecordDialogForm(parentId, childTableGridView);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (parentTableGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedParentRow = parentTableGridView.SelectedRows[0];
                int parentId = int.Parse(selectedParentRow.Cells[AppService.ForeignKey].Value.ToString());

                if (childTableGridView.SelectedRows.Count == 1)
                {
                    DataGridViewRow selectedChildRow = childTableGridView.SelectedRows[0];
                    int childId = int.Parse(selectedChildRow.Cells[AppService.PrimaryKey].Value.ToString());
                    _service.OpenUpdateChildRecordDialogForm(parentId, childId, childTableGridView);
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (parentTableGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedParentRow = parentTableGridView.SelectedRows[0];
                int parentId = int.Parse(selectedParentRow.Cells[AppService.ForeignKey].Value.ToString());

                if (childTableGridView.SelectedRows.Count == 1)
                {
                    DataGridViewRow selectedChildRow = childTableGridView.SelectedRows[0];
                    int childId = int.Parse(selectedChildRow.Cells[AppService.PrimaryKey].Value.ToString());
                    _service.DeleteChildRecord(parentId, childId, childTableGridView);
                }
            }
        }
    }
}
