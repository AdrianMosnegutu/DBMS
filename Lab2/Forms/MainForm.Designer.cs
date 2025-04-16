namespace Lab2
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
            this.parentTableGridView = new System.Windows.Forms.DataGridView();
            this.parentTableLabel = new System.Windows.Forms.Label();
            this.buttonsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.childTableLabel = new System.Windows.Forms.Label();
            this.childTableGridView = new System.Windows.Forms.DataGridView();
            this.formTableLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parentTableGridView)).BeginInit();
            this.buttonsTableLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childTableGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // formTableLayout
            // 
            this.formTableLayout.ColumnCount = 2;
            this.formTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formTableLayout.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.formTableLayout.Controls.Add(this.buttonsTableLayout, 0, 1);
            this.formTableLayout.Controls.Add(this.tableLayoutPanel2, 1, 0);
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
            this.tableLayoutPanel1.Controls.Add(this.parentTableGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.parentTableLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(573, 425);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // parentTableGridView
            // 
            this.parentTableGridView.AllowUserToAddRows = false;
            this.parentTableGridView.AllowUserToDeleteRows = false;
            this.parentTableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parentTableGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parentTableGridView.Location = new System.Drawing.Point(3, 23);
            this.parentTableGridView.Name = "parentTableGridView";
            this.parentTableGridView.ReadOnly = true;
            this.parentTableGridView.RowHeadersWidth = 51;
            this.parentTableGridView.RowTemplate.Height = 24;
            this.parentTableGridView.Size = new System.Drawing.Size(567, 399);
            this.parentTableGridView.TabIndex = 1;
            this.parentTableGridView.SelectionChanged += new System.EventHandler(this.ParentTableGridView_SelectChanged);
            // 
            // parentTableLabel
            // 
            this.parentTableLabel.AutoSize = true;
            this.parentTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentTableLabel.Location = new System.Drawing.Point(3, 0);
            this.parentTableLabel.Name = "parentTableLabel";
            this.parentTableLabel.Size = new System.Drawing.Size(104, 20);
            this.parentTableLabel.TabIndex = 0;
            this.parentTableLabel.Text = "Parent Table";
            // 
            // buttonsTableLayout
            // 
            this.buttonsTableLayout.ColumnCount = 1;
            this.formTableLayout.SetColumnSpan(this.buttonsTableLayout, 2);
            this.buttonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTableLayout.Controls.Add(this.deleteButton, 0, 1);
            this.buttonsTableLayout.Controls.Add(this.updateButton, 1, 0);
            this.buttonsTableLayout.Controls.Add(this.addButton, 0, 0);
            this.buttonsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTableLayout.Location = new System.Drawing.Point(8, 439);
            this.buttonsTableLayout.Name = "buttonsTableLayout";
            this.buttonsTableLayout.RowCount = 3;
            this.buttonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTableLayout.Size = new System.Drawing.Size(1153, 210);
            this.buttonsTableLayout.TabIndex = 2;
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(3, 143);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(1147, 64);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(3, 73);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(1147, 64);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(1147, 64);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.childTableLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.childTableGridView, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(587, 8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(574, 425);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // childTableLabel
            // 
            this.childTableLabel.AutoSize = true;
            this.childTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childTableLabel.Location = new System.Drawing.Point(3, 0);
            this.childTableLabel.Name = "childTableLabel";
            this.childTableLabel.Size = new System.Drawing.Size(93, 20);
            this.childTableLabel.TabIndex = 3;
            this.childTableLabel.Text = "Child Table";
            // 
            // childTableGridView
            // 
            this.childTableGridView.AllowUserToAddRows = false;
            this.childTableGridView.AllowUserToDeleteRows = false;
            this.childTableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.childTableGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childTableGridView.Location = new System.Drawing.Point(3, 23);
            this.childTableGridView.Name = "childTableGridView";
            this.childTableGridView.ReadOnly = true;
            this.childTableGridView.RowHeadersWidth = 51;
            this.childTableGridView.RowTemplate.Height = 24;
            this.childTableGridView.Size = new System.Drawing.Size(568, 399);
            this.childTableGridView.TabIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)(this.parentTableGridView)).EndInit();
            this.buttonsTableLayout.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childTableGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel formTableLayout;
        private System.Windows.Forms.TableLayoutPanel buttonsTableLayout;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView parentTableGridView;
        private System.Windows.Forms.Label parentTableLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label childTableLabel;
        private System.Windows.Forms.DataGridView childTableGridView;
    }
}

