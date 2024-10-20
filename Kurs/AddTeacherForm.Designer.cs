namespace Kurs
{
    partial class AddTeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeacherForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.surnameTeacherTextBox = new System.Windows.Forms.TextBox();
            this.middle_nameTeachertextBox = new System.Windows.Forms.TextBox();
            this.addTeacherButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.departamentComboBox = new System.Windows.Forms.ComboBox();
            this.departamentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursDataSet = new Kurs.kursDataSet();
            this.nameTeacherTextBox = new System.Windows.Forms.TextBox();
            this.departamentsTableAdapter = new Kurs.kursDataSetTableAdapters.departamentsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.surnameTeacherTextBox);
            this.panel1.Controls.Add(this.middle_nameTeachertextBox);
            this.panel1.Controls.Add(this.addTeacherButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.departamentComboBox);
            this.panel1.Controls.Add(this.nameTeacherTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 256);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Факультет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фамилия";
            // 
            // surnameTeacherTextBox
            // 
            this.surnameTeacherTextBox.Location = new System.Drawing.Point(21, 85);
            this.surnameTeacherTextBox.Name = "surnameTeacherTextBox";
            this.surnameTeacherTextBox.Size = new System.Drawing.Size(228, 20);
            this.surnameTeacherTextBox.TabIndex = 5;
            // 
            // middle_nameTeachertextBox
            // 
            this.middle_nameTeachertextBox.Location = new System.Drawing.Point(21, 132);
            this.middle_nameTeachertextBox.Name = "middle_nameTeachertextBox";
            this.middle_nameTeachertextBox.Size = new System.Drawing.Size(228, 20);
            this.middle_nameTeachertextBox.TabIndex = 4;
            // 
            // addTeacherButton
            // 
            this.addTeacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addTeacherButton.Location = new System.Drawing.Point(100, 215);
            this.addTeacherButton.Name = "addTeacherButton";
            this.addTeacherButton.Size = new System.Drawing.Size(75, 23);
            this.addTeacherButton.TabIndex = 3;
            this.addTeacherButton.Text = "Добавить";
            this.addTeacherButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // departamentComboBox
            // 
            this.departamentComboBox.DataSource = this.departamentsBindingSource;
            this.departamentComboBox.DisplayMember = "name_depatament";
            this.departamentComboBox.FormattingEnabled = true;
            this.departamentComboBox.Location = new System.Drawing.Point(21, 171);
            this.departamentComboBox.Name = "departamentComboBox";
            this.departamentComboBox.Size = new System.Drawing.Size(228, 21);
            this.departamentComboBox.TabIndex = 1;
            this.departamentComboBox.ValueMember = "id_departament";
            // 
            // departamentsBindingSource
            // 
            this.departamentsBindingSource.DataMember = "departaments";
            this.departamentsBindingSource.DataSource = this.kursDataSet;
            // 
            // kursDataSet
            // 
            this.kursDataSet.DataSetName = "kursDataSet";
            this.kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTeacherTextBox
            // 
            this.nameTeacherTextBox.Location = new System.Drawing.Point(21, 41);
            this.nameTeacherTextBox.Name = "nameTeacherTextBox";
            this.nameTeacherTextBox.Size = new System.Drawing.Size(228, 20);
            this.nameTeacherTextBox.TabIndex = 0;
            // 
            // departamentsTableAdapter
            // 
            this.departamentsTableAdapter.ClearBeforeFill = true;
            // 
            // AddTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 256);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(288, 295);
            this.MinimumSize = new System.Drawing.Size(288, 295);
            this.Name = "AddTeacherForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Добавить преподавателя";
            this.Load += new System.EventHandler(this.AddTeacherForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox surnameTeacherTextBox;
        private System.Windows.Forms.TextBox middle_nameTeachertextBox;
        private System.Windows.Forms.Button addTeacherButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox departamentComboBox;
        private System.Windows.Forms.TextBox nameTeacherTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private kursDataSet kursDataSet;
        private System.Windows.Forms.BindingSource departamentsBindingSource;
        private kursDataSetTableAdapters.departamentsTableAdapter departamentsTableAdapter;
    }
}