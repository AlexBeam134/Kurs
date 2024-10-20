namespace Kurs
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьБазуКурсовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базуПредметовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursDataSet1 = new Kurs.kursDataSet();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradesTableAdapter1 = new Kurs.kursDataSetTableAdapters.gradesTableAdapter();
            this.studentsTableAdapter1 = new Kurs.kursDataSetTableAdapters.studentsTableAdapter();
            this.coursesTableAdapter1 = new Kurs.kursDataSetTableAdapters.coursesTableAdapter();
            this.teachersTableAdapter1 = new Kurs.kursDataSetTableAdapters.teachersTableAdapter();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iddradesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 45);
            this.panel1.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(943, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьБазуКурсовToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.ParamToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // открытьБазуКурсовToolStripMenuItem
            // 
            this.открытьБазуКурсовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseTeacherToolStripMenuItem,
            this.базуПредметовToolStripMenuItem});
            this.открытьБазуКурсовToolStripMenuItem.Name = "открытьБазуКурсовToolStripMenuItem";
            this.открытьБазуКурсовToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьБазуКурсовToolStripMenuItem.Text = "Открыть";
            // 
            // baseTeacherToolStripMenuItem
            // 
            this.baseTeacherToolStripMenuItem.Name = "baseTeacherToolStripMenuItem";
            this.baseTeacherToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.baseTeacherToolStripMenuItem.Text = "Базу преподавателей";
            this.baseTeacherToolStripMenuItem.Click += new System.EventHandler(this.baseTeacherToolStripMenuItem_Click);
            // 
            // базуПредметовToolStripMenuItem
            // 
            this.базуПредметовToolStripMenuItem.Name = "базуПредметовToolStripMenuItem";
            this.базуПредметовToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.базуПредметовToolStripMenuItem.Text = "Базу предметов";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // ParamToolStripMenuItem
            // 
            this.ParamToolStripMenuItem.Name = "ParamToolStripMenuItem";
            this.ParamToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ParamToolStripMenuItem.Text = "Параметры";
            this.ParamToolStripMenuItem.Click += new System.EventHandler(this.paramToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.сохранитьToolStripMenuItem.Text = "Сохранить ";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 49);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(943, 334);
            this.panel3.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddradesDataGridViewTextBoxColumn,
            this.studentDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn,
            this.teacherDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gradesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.kursDataSet1;
            // 
            // kursDataSet1
            // 
            this.kursDataSet1.DataSetName = "kursDataSet";
            this.kursDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "courses";
            this.coursesBindingSource.DataSource = this.kursDataSet1;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "teachers";
            this.teachersBindingSource.DataSource = this.kursDataSet1;
            // 
            // gradesBindingSource
            // 
            this.gradesBindingSource.DataMember = "grades";
            this.gradesBindingSource.DataSource = this.kursDataSet1;
            // 
            // gradesTableAdapter1
            // 
            this.gradesTableAdapter1.ClearBeforeFill = true;
            // 
            // studentsTableAdapter1
            // 
            this.studentsTableAdapter1.ClearBeforeFill = true;
            // 
            // coursesTableAdapter1
            // 
            this.coursesTableAdapter1.ClearBeforeFill = true;
            // 
            // teachersTableAdapter1
            // 
            this.teachersTableAdapter1.ClearBeforeFill = true;
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // teacherDataGridViewTextBoxColumn
            // 
            this.teacherDataGridViewTextBoxColumn.DataPropertyName = "teacher";
            this.teacherDataGridViewTextBoxColumn.DataSource = this.teachersBindingSource;
            this.teacherDataGridViewTextBoxColumn.DisplayMember = "FIO";
            this.teacherDataGridViewTextBoxColumn.HeaderText = "Преподаватель";
            this.teacherDataGridViewTextBoxColumn.Name = "teacherDataGridViewTextBoxColumn";
            this.teacherDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teacherDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teacherDataGridViewTextBoxColumn.ValueMember = "id_teacher";
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Балл";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "course";
            this.courseDataGridViewTextBoxColumn.DataSource = this.coursesBindingSource;
            this.courseDataGridViewTextBoxColumn.DisplayMember = "name";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Предмет";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.courseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.courseDataGridViewTextBoxColumn.ValueMember = "id_course";
            // 
            // studentDataGridViewTextBoxColumn
            // 
            this.studentDataGridViewTextBoxColumn.DataPropertyName = "student";
            this.studentDataGridViewTextBoxColumn.DataSource = this.studentsBindingSource;
            this.studentDataGridViewTextBoxColumn.DisplayMember = "FIO";
            this.studentDataGridViewTextBoxColumn.HeaderText = "Студент";
            this.studentDataGridViewTextBoxColumn.Name = "studentDataGridViewTextBoxColumn";
            this.studentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.studentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.studentDataGridViewTextBoxColumn.ValueMember = "id_student";
            // 
            // iddradesDataGridViewTextBoxColumn
            // 
            this.iddradesDataGridViewTextBoxColumn.DataPropertyName = "id_drades";
            this.iddradesDataGridViewTextBoxColumn.FillWeight = 30F;
            this.iddradesDataGridViewTextBoxColumn.HeaderText = "№";
            this.iddradesDataGridViewTextBoxColumn.Name = "iddradesDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 428);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private kursDataSet kursDataSet;
        private kursDataSetTableAdapters.gradesTableAdapter gradesTableAdapter;
        private kursDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private kursDataSetTableAdapters.coursesTableAdapter coursesTableAdapter;
        private kursDataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem открытьБазуКурсовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem базуПредметовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ParamToolStripMenuItem;
        private kursDataSet kursDataSet1;
        private System.Windows.Forms.BindingSource gradesBindingSource;
        private kursDataSetTableAdapters.gradesTableAdapter gradesTableAdapter1;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private kursDataSetTableAdapters.studentsTableAdapter studentsTableAdapter1;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private kursDataSetTableAdapters.coursesTableAdapter coursesTableAdapter1;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private kursDataSetTableAdapters.teachersTableAdapter teachersTableAdapter1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddradesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn studentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teacherDataGridViewTextBoxColumn;
    }
}