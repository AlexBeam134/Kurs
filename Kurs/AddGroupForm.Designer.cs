namespace Kurs
{
    partial class AddGroupForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGroupForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.departamentComboBox = new System.Windows.Forms.ComboBox();
            this.departamentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursDataSet = new Kurs.kursDataSet();
            this.nameGroupTextBox = new System.Windows.Forms.TextBox();
            this.departamentsTableAdapter = new Kurs.kursDataSetTableAdapters.departamentsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addGroupButton);
            this.panel1.Controls.Add(this.departamentComboBox);
            this.panel1.Controls.Add(this.nameGroupTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 198);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Кафедра";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название группы";
            // 
            // addGroupButton
            // 
            this.addGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addGroupButton.Location = new System.Drawing.Point(79, 144);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(75, 23);
            this.addGroupButton.TabIndex = 2;
            this.addGroupButton.Text = "Добавить";
            this.addGroupButton.UseVisualStyleBackColor = true;
            // 
            // departamentComboBox
            // 
            this.departamentComboBox.DataSource = this.departamentsBindingSource;
            this.departamentComboBox.DisplayMember = "name_depatament";
            this.departamentComboBox.FormattingEnabled = true;
            this.departamentComboBox.Location = new System.Drawing.Point(12, 105);
            this.departamentComboBox.Name = "departamentComboBox";
            this.departamentComboBox.Size = new System.Drawing.Size(207, 21);
            this.departamentComboBox.TabIndex = 1;
            this.departamentComboBox.ValueMember = "id_departament";
            // 
            // departamentsBindingSource
            // 
            this.departamentsBindingSource.DataMember = "departaments";
            this.departamentsBindingSource.DataSource = this.kursDataSetBindingSource;
            // 
            // kursDataSetBindingSource
            // 
            this.kursDataSetBindingSource.DataSource = this.kursDataSet;
            this.kursDataSetBindingSource.Position = 0;
            // 
            // kursDataSet
            // 
            this.kursDataSet.DataSetName = "kursDataSet";
            this.kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameGroupTextBox
            // 
            this.nameGroupTextBox.Location = new System.Drawing.Point(12, 48);
            this.nameGroupTextBox.Name = "nameGroupTextBox";
            this.nameGroupTextBox.Size = new System.Drawing.Size(207, 20);
            this.nameGroupTextBox.TabIndex = 0;
            // 
            // departamentsTableAdapter
            // 
            this.departamentsTableAdapter.ClearBeforeFill = true;
            // 
            // AddGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 198);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(247, 237);
            this.MinimumSize = new System.Drawing.Size(227, 237);
            this.Name = "AddGroupForm";
            this.Text = "Добавить группу";
            this.Load += new System.EventHandler(this.AddGroupForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addGroupButton;
        private System.Windows.Forms.ComboBox departamentComboBox;
        private System.Windows.Forms.TextBox nameGroupTextBox;
        private System.Windows.Forms.BindingSource kursDataSetBindingSource;
        private kursDataSet kursDataSet;
        private System.Windows.Forms.BindingSource departamentsBindingSource;
        private kursDataSetTableAdapters.departamentsTableAdapter departamentsTableAdapter;
    }
}