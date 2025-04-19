namespace Lab1.Forms
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
            formTableLayout = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            artistGridView = new System.Windows.Forms.DataGridView();
            artistLabel = new System.Windows.Forms.Label();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            albumLabel = new System.Windows.Forms.Label();
            albumGridView = new System.Windows.Forms.DataGridView();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            titleTextBox = new System.Windows.Forms.TextBox();
            releaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            artistIdNumericInput = new System.Windows.Forms.NumericUpDown();
            buttonsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            deleteButton = new System.Windows.Forms.Button();
            addButton = new System.Windows.Forms.Button();
            updateButton = new System.Windows.Forms.Button();
            formTableLayout.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)artistGridView).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)albumGridView).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)artistIdNumericInput).BeginInit();
            buttonsTableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // formTableLayout
            // 
            formTableLayout.ColumnCount = 2;
            formTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            formTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            formTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            formTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            formTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            formTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            formTableLayout.Controls.Add(tableLayoutPanel1, 0, 0);
            formTableLayout.Controls.Add(tableLayoutPanel2, 1, 0);
            formTableLayout.Controls.Add(tableLayoutPanel3, 0, 1);
            formTableLayout.Controls.Add(buttonsTableLayout, 1, 1);
            formTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            formTableLayout.Location = new System.Drawing.Point(0, 0);
            formTableLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            formTableLayout.Name = "formTableLayout";
            formTableLayout.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            formTableLayout.RowCount = 2;
            formTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            formTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            formTableLayout.Size = new System.Drawing.Size(1229, 821);
            formTableLayout.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(artistGridView, 0, 1);
            tableLayoutPanel1.Controls.Add(artistLabel, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(8, 10);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(603, 531);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // artistGridView
            // 
            artistGridView.AllowUserToAddRows = false;
            artistGridView.AllowUserToDeleteRows = false;
            artistGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            artistGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            artistGridView.Location = new System.Drawing.Point(3, 24);
            artistGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            artistGridView.Name = "artistGridView";
            artistGridView.ReadOnly = true;
            artistGridView.RowHeadersWidth = 51;
            artistGridView.RowTemplate.Height = 24;
            artistGridView.Size = new System.Drawing.Size(597, 503);
            artistGridView.TabIndex = 1;
            artistGridView.SelectionChanged += ArtistGridView_SelectChange;
            // 
            // artistLabel
            // 
            artistLabel.AutoSize = true;
            artistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            artistLabel.Location = new System.Drawing.Point(3, 0);
            artistLabel.Name = "artistLabel";
            artistLabel.Size = new System.Drawing.Size(104, 20);
            artistLabel.TabIndex = 0;
            artistLabel.Text = "Artists Table";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(albumLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(albumGridView, 0, 1);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(617, 10);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(604, 531);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // albumLabel
            // 
            albumLabel.AutoSize = true;
            albumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            albumLabel.Location = new System.Drawing.Point(3, 0);
            albumLabel.Name = "albumLabel";
            albumLabel.Size = new System.Drawing.Size(111, 20);
            albumLabel.TabIndex = 3;
            albumLabel.Text = "Albums Table";
            // 
            // albumGridView
            // 
            albumGridView.AllowUserToAddRows = false;
            albumGridView.AllowUserToDeleteRows = false;
            albumGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            albumGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            albumGridView.Location = new System.Drawing.Point(3, 24);
            albumGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            albumGridView.Name = "albumGridView";
            albumGridView.ReadOnly = true;
            albumGridView.RowHeadersWidth = 51;
            albumGridView.RowTemplate.Height = 24;
            albumGridView.Size = new System.Drawing.Size(598, 503);
            albumGridView.TabIndex = 4;
            albumGridView.SelectionChanged += AlbumGridView_SelectChange;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(titleTextBox, 1, 0);
            tableLayoutPanel3.Controls.Add(releaseDateTimePicker, 1, 1);
            tableLayoutPanel3.Controls.Add(artistIdNumericInput, 1, 2);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(8, 549);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel3.Size = new System.Drawing.Size(603, 262);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(13, 170);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(135, 80);
            label3.TabIndex = 4;
            label3.Text = "Artist ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(13, 91);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(135, 79);
            label2.TabIndex = 2;
            label2.Text = "Release Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(13, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(135, 79);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // titleTextBox
            // 
            titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            titleTextBox.Location = new System.Drawing.Point(154, 16);
            titleTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new System.Drawing.Size(412, 27);
            titleTextBox.TabIndex = 1;
            // 
            // releaseDateTimePicker
            // 
            releaseDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            releaseDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            releaseDateTimePicker.Location = new System.Drawing.Point(154, 95);
            releaseDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            releaseDateTimePicker.Name = "releaseDateTimePicker";
            releaseDateTimePicker.Size = new System.Drawing.Size(412, 27);
            releaseDateTimePicker.TabIndex = 3;
            // 
            // artistIdNumericInput
            // 
            artistIdNumericInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            artistIdNumericInput.Location = new System.Drawing.Point(154, 174);
            artistIdNumericInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            artistIdNumericInput.Name = "artistIdNumericInput";
            artistIdNumericInput.Size = new System.Drawing.Size(412, 27);
            artistIdNumericInput.TabIndex = 5;
            // 
            // buttonsTableLayout
            // 
            buttonsTableLayout.ColumnCount = 1;
            buttonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            buttonsTableLayout.Controls.Add(deleteButton, 2, 0);
            buttonsTableLayout.Controls.Add(addButton, 0, 0);
            buttonsTableLayout.Controls.Add(updateButton, 1, 0);
            buttonsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonsTableLayout.Location = new System.Drawing.Point(617, 549);
            buttonsTableLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonsTableLayout.Name = "buttonsTableLayout";
            buttonsTableLayout.RowCount = 3;
            buttonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            buttonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            buttonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            buttonsTableLayout.Size = new System.Drawing.Size(604, 262);
            buttonsTableLayout.TabIndex = 2;
            // 
            // deleteButton
            // 
            deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            deleteButton.Location = new System.Drawing.Point(3, 180);
            deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(598, 80);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // addButton
            // 
            addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            addButton.Location = new System.Drawing.Point(3, 4);
            addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(598, 80);
            addButton.TabIndex = 0;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // updateButton
            // 
            updateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            updateButton.Location = new System.Drawing.Point(3, 92);
            updateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            updateButton.Name = "updateButton";
            updateButton.Size = new System.Drawing.Size(598, 80);
            updateButton.TabIndex = 1;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += UpdateButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1229, 821);
            Controls.Add(formTableLayout);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "DBMS - Lab 1";
            Load += MainForm_Load;
            formTableLayout.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)artistGridView).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)albumGridView).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)artistIdNumericInput).EndInit();
            buttonsTableLayout.ResumeLayout(false);
            ResumeLayout(false);

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

