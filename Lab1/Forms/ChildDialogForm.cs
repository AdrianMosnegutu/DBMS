using System;
using System.Linq;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;
using Lab1.Services;

namespace Lab1.Forms
{
    public partial class ChildDialogForm : Form
    {
        private readonly string _dialogTitle;
        private readonly string _successMessage;
        private readonly List<string> _fieldNames;
        private readonly Action<List<string>> _buttonAction;
        private readonly List<string> _defaultValues;

        public ChildDialogForm(string dialogTitle, string successMessage, Action<List<string>> buttonAction, List<string> defaultValues = null)
        {
            InitializeComponent();
            this.Text = dialogTitle;

            _dialogTitle = dialogTitle;
            _successMessage = successMessage;
            _fieldNames = AppService.ColumnNames;
            _buttonAction = buttonAction;
            _defaultValues = defaultValues;

            AddDynamicControls();
            AdjustFormSize();
        }

        private IEnumerable<TextBox> GetAllTextBoxes(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                    yield return textBox;

                foreach (var child in GetAllTextBoxes(control))
                    yield return child;
            }
        }

        private void ExecuteButtonAction(object sender, EventArgs e)
        {
            List<string> textBoxValues = GetAllTextBoxes(this)
                .Select(tb => tb.Text)
                .ToList();

            try
            {
                _buttonAction(textBoxValues);
                MessageBox.Show(_successMessage);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while inserting: {ex.Message}");
            }
        }

        private void AddDynamicControls()
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            TableLayoutPanel layoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                ColumnCount = 2,
                RowCount = _fieldNames.Count + 1,
                Padding = new Padding(10),
                GrowStyle = TableLayoutPanelGrowStyle.AddRows
            };

            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            int rowIndex = 0;
            for (int index = 0; index < _fieldNames.Count; ++index)
            {
                string field = _fieldNames[index];
                string defaultValue = _defaultValues?[index] ?? "";

                if (field == AppService.ForeignKey)
                    continue;

                Label label = new Label
                {
                    Text = textInfo.ToTitleCase(field.Replace("_", " ")),
                    AutoSize = true,
                    Anchor = AnchorStyles.Right,
                    Margin = new Padding(5)
                };

                TextBox textBox = new TextBox
                {
                    Anchor = AnchorStyles.Left | AnchorStyles.Right,
                    Margin = new Padding(5),
                    MinimumSize = new Size(150, 20),
                    Text = defaultValue
                };

                layoutPanel.Controls.Add(label, 0, rowIndex);
                layoutPanel.Controls.Add(textBox, 1, rowIndex);
                rowIndex++;
            }

            Button button = new Button
            {
                Text = _dialogTitle.Split(',')[0],
                Anchor = AnchorStyles.None,
                AutoSize = true,
                Margin = new Padding(10)
            };

            button.Click += ExecuteButtonAction;
            layoutPanel.Controls.Add(button, 0, rowIndex);
            layoutPanel.SetColumnSpan(button, 2);

            this.Controls.Add(layoutPanel);
        }

        private void AdjustFormSize()
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}