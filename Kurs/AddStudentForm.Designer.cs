namespace Kurs
{
    partial class AddStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.surnameStudentTextBox = new System.Windows.Forms.TextBox();
            this.nameStudentTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursDataSet = new Kurs.kursDataSet();
            this.date_of_birhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupsTableAdapter = new Kurs.kursDataSetTableAdapters.groupsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.addStudentButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.middleNameTextBox);
            this.panel1.Controls.Add(this.surnameStudentTextBox);
            this.panel1.Controls.Add(this.nameStudentTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupComboBox);
            this.panel1.Controls.Add(this.date_of_birhDateTimePicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(388, 187);
            this.panel1.MinimumSize = new System.Drawing.Size(388, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 187);
            this.panel1.TabIndex = 0;
            // 
            // addStudentButton
            // 
            this.addStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addStudentButton.Location = new System.Drawing.Point(263, 138);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(75, 23);
            this.addStudentButton.TabIndex = 12;
            this.addStudentButton.Text = "Добавить";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Группа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата Рождения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Имя";
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(15, 141);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(195, 20);
            this.middleNameTextBox.TabIndex = 8;
            // 
            // surnameStudentTextBox
            // 
            this.surnameStudentTextBox.Location = new System.Drawing.Point(15, 97);
            this.surnameStudentTextBox.Name = "surnameStudentTextBox";
            this.surnameStudentTextBox.Size = new System.Drawing.Size(195, 20);
            this.surnameStudentTextBox.TabIndex = 7;
            // 
            // nameStudentTextBox
            // 
            this.nameStudentTextBox.Location = new System.Drawing.Point(15, 51);
            this.nameStudentTextBox.Name = "nameStudentTextBox";
            this.nameStudentTextBox.Size = new System.Drawing.Size(195, 20);
            this.nameStudentTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // groupComboBox
            // 
            this.groupComboBox.DataSource = this.groupsBindingSource;
            this.groupComboBox.DisplayMember = "name_groups";
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(238, 97);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(131, 21);
            this.groupComboBox.TabIndex = 2;
            this.groupComboBox.ValueMember = "id_groups";
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "groups";
            this.groupsBindingSource.DataSource = this.kursDataSet;
            // 
            // kursDataSet
            // 
            this.kursDataSet.DataSetName = "kursDataSet";
            this.kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // date_of_birhDateTimePicker
            // 
            this.date_of_birhDateTimePicker.Location = new System.Drawing.Point(238, 51);
            this.date_of_birhDateTimePicker.Name = "date_of_birhDateTimePicker";
            this.date_of_birhDateTimePicker.Size = new System.Drawing.Size(131, 20);
            this.date_of_birhDateTimePicker.TabIndex = 1;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 187);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(404, 226);
            this.MinimumSize = new System.Drawing.Size(404, 226);
            this.Name = "AddStudentForm";
            this.Text = "Добавить студента";
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.DateTimePicker date_of_birhDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox surnameStudentTextBox;
        private System.Windows.Forms.TextBox nameStudentTextBox;
        private System.Windows.Forms.Button addStudentButton;
        private kursDataSet kursDataSet;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private kursDataSetTableAdapters.groupsTableAdapter groupsTableAdapter;
    }
}