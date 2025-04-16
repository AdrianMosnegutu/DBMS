namespace Lab1
{
    partial class MainForm
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
            this.formTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.artistGridView = new System.Windows.Forms.DataGridView();
            this.artistLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.albumLabel = new System.Windows.Forms.Label();
            this.albumGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.releaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.artistIdNumericInput = new System.Windows.Forms.NumericUpDown();
            this.buttonsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.formTableLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artistGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumGridView)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artistIdNumericInput)).BeginInit();
            this.buttonsTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // formTableLayout
            // 
            this.formTableLayout.ColumnCount = 2;
            this.formTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.formTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.formTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.formTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.formTableLayout.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.formTableLayout.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.formTableLayout.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.formTableLayout.Controls.Add(this.buttonsTableLayout, 1, 1);
            this.formTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formTableLayout.Location = new System.Drawing.Point(0, 0);
            this.formTableLayout.Name = "formTableLayout";
            this.formTableLayout.Padding = new System.Windows.Forms.Padding(5);
            this.formTableLayout.RowCount = 2;
            this.formTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.formTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.formTableLayout.Size = new System.Drawing.Size(1169, 657);
            this.formTableLayout.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.artistGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.artistLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(573, 425);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // artistGridView
            // 
            this.artistGridView.AllowUserToAddRows = false;
            this.artistGridView.AllowUserToDeleteRows = false;
            this.artistGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artistGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artistGridView.Location = new System.Drawing.Point(3, 23);
            this.artistGridView.Name = "artistGridView";
            this.artistGridView.ReadOnly = true;
            this.artistGridView.RowHeadersWidth = 51;
            this.artistGridView.RowTemplate.Height = 24;
            this.artistGridView.Size = new System.Drawing.Size(567, 399);
            this.artistGridView.TabIndex = 1;
            this.artistGridView.SelectionChanged += new System.EventHandler(this.ArtistGridView_SelectChange);
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistLabel.Location = new System.Drawing.Point(3, 0);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(104, 20);
            this.artistLabel.TabIndex = 0;
            this.artistLabel.Text = "Artists Table";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.albumLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.albumGridView, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(587, 8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(574, 425);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // albumLabel
            // 
            this.albumLabel.AutoSize = true;
            this.albumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumLabel.Location = new System.Drawing.Point(3, 0);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(111, 20);
            this.albumLabel.TabIndex = 3;
            this.albumLabel.Text = "Albums Table";
            // 
            // albumGridView
            // 
            this.albumGridView.AllowUserToAddRows = false;
            this.albumGridView.AllowUserToDeleteRows = false;
            this.albumGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.albumGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.albumGridView.Location = new System.Drawing.Point(3, 23);
            this.albumGridView.Name = "albumGridView";
            this.albumGridView.ReadOnly = true;
            this.albumGridView.RowHeadersWidth = 51;
            this.albumGridView.RowTemplate.Height = 24;
            this.albumGridView.Size = new System.Drawing.Size(568, 399);
            this.albumGridView.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.titleTextBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.releaseDateTimePicker, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.artistIdNumericInput, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 439);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(573, 210);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 64);
            this.label3.TabIndex = 4;
            this.label3.Text = "Album Artist ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 63);
            this.label2.TabIndex = 2;
            this.label2.Text = "Album Release Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Album Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(215, 13);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(301, 27);
            this.titleTextBox.TabIndex = 1;
            // 
            // releaseDateTimePicker
            // 
            this.releaseDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.releaseDateTimePicker.Location = new System.Drawing.Point(215, 76);
            this.releaseDateTimePicker.Name = "releaseDateTimePicker";
            this.releaseDateTimePicker.Size = new System.Drawing.Size(299, 27);
            this.releaseDateTimePicker.TabIndex = 3;
            // 
            // artistIdNumericInput
            // 
            this.artistIdNumericInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistIdNumericInput.Location = new System.Drawing.Point(215, 139);
            this.artistIdNumericInput.Name = "artistIdNumericInput";
            this.artistIdNumericInput.Size = new System.Drawing.Size(299, 27);
            this.artistIdNumericInput.TabIndex = 5;
            // 
            // buttonsTableLayout
            // 
            this.buttonsTableLayout.ColumnCount = 1;
            this.buttonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTableLayout.Controls.Add(this.deleteButton, 2, 0);
            this.buttonsTableLayout.Controls.Add(this.addButton, 0, 0);
            this.buttonsTableLayout.Controls.Add(this.updateButton, 1, 0);
            this.buttonsTableLayout.Location = new System.Drawing.Point(587, 439);
            this.buttonsTableLayout.Name = "buttonsTableLayout";
            this.buttonsTableLayout.RowCount = 3;
            this.buttonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buttonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buttonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buttonsTableLayout.Size = new System.Drawing.Size(573, 210);
            this.buttonsTableLayout.TabIndex = 2;
            this.buttonsTableLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonsTableLayout_Paint);
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(3, 143);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(567, 64);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(567, 64);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(3, 73);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(567, 64);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 657);
            this.Controls.Add(this.formTableLayout);
            this.Name = "MainForm";
            this.Text = "DBMS - Lab 1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.formTableLayout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artistGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumGridView)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artistIdNumericInput)).EndInit();
            this.buttonsTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel formTableLayout;
        private System.Windows.Forms.TableLayoutPanel buttonsTableLayout;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView artistGridView;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label albumLabel;
        private System.Windows.Forms.DataGridView albumGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.DateTimePicker releaseDateTimePicker;
        private System.Windows.Forms.NumericUpDown artistIdNumericInput;
        private System.Windows.Forms.Button deleteButton;
    }
}

