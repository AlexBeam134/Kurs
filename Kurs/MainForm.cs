using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kurs
{
    public partial class MainForm : Form
    {
        private Point mouseDownLocation;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1.groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.kursDataSet1.groups);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1.departaments". При необходимости она может быть перемещена или удалена.
            this.departamentsTableAdapter.Fill(this.kursDataSet1.departaments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1.teachers". При необходимости она может быть перемещена или удалена.
            this.teachersTableAdapter1.Fill(this.kursDataSet1.teachers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1.courses". При необходимости она может быть перемещена или удалена.
            this.coursesTableAdapter1.Fill(this.kursDataSet1.courses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1.students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter1.Fill(this.kursDataSet1.students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1.grades". При необходимости она может быть перемещена или удалена.
            this.gradesTableAdapter1.Fill(this.kursDataSet1.grades);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1.grades". При необходимости она может быть перемещена или удалена.
            this.gradesTableAdapter1.Fill(this.kursDataSet1.grades);

        }

        private void paramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.Show();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeacherForm addTeacherForm = new AddTeacherForm();
            addTeacherForm.Show();
        }

        private void departamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDepartamentForm addDepartamentForm = new AddDepartamentForm();
            addDepartamentForm.Show();
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGroupForm addGroupForm = new AddGroupForm();
            addGroupForm.Show();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.Show();
        }

        private void baseCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (coursesdataGridView.Visible == true)
            {
                MessageBox.Show("База предметов уже открыта");
                teacherdataGridView.Select();
            }
            else
            {
                coursesdataGridView.Visible = true;
                teacherdataGridView.Visible = false;
                coursesdataGridView.Select();
            }
        }

        private void baseDepartamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (departamentsdataGridView.Visible == true)
            {
                MessageBox.Show("База факультетов уже открыта");
                departamentsdataGridView.Select();
            }
            else
            {
                departamentsdataGridView.Visible = true;
                groupsdataGridView.Visible = false;
                departamentsdataGridView.Select();
            }
        }

        private void baseGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (groupsdataGridView.Visible == true)
            {
                MessageBox.Show("База групп уже открыта");
                groupsdataGridView.Select();
            }
            else
            {
                groupsdataGridView.Visible = true;
                teacherdataGridView.Visible = false;
                groupsdataGridView.Select();
            }
        }
        private void baseTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (teacherdataGridView.Visible == true)
            {
                MessageBox.Show("База преподавателей уже открыта");
                teacherdataGridView.Select();
            }
            else
            {
                coursesdataGridView.Visible = false;
                teacherdataGridView.Visible = true;
                teacherdataGridView.Select();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text != "" && searchComboBox.Text != "Выберите базу для поиска")
            {
                switch (searchComboBox.SelectedIndex)
                {
                    case 0:
                        string searchValue = SearchTextBox.Text;

                        groupsdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        try
                        {
                            foreach (DataGridViewRow row in groupsdataGridView.Rows)
                            {
                                if (row.Cells[1].Value.ToString().Equals(searchValue))
                                {
                                    MessageBox.Show(row.Cells[2].FormattedValue.ToString());
                                    row.Selected = true;
                                    break;
                                }
                            }
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show("совпадений не найдено");
                        }
                        break;
                    case 1:
                        MessageBox.Show("Дисциплина");
                        break;
                    case 2:
                        MessageBox.Show("Кафедра");
                        break;
                    case 3:
                        MessageBox.Show("Преподаватель");
                        break;
                    case 4:
                        MessageBox.Show("Студент");
                        break;
                    case 5:
                        MessageBox.Show("Успеваемость");
                        break;
                    default:
                        break;
                }
                /*switch (searchComboBox.SelectedIndex)
                {
                    case 0: MessageBox.Show("Группа");
                            break;
                    case 1:
                        MessageBox.Show("Дисциплина");
                        break;
                    case 2:
                        MessageBox.Show("Кафедра");
                        break;
                    case 3:
                        MessageBox.Show("Преподаватель");
                        break;
                    case 4:
                        MessageBox.Show("Студент");
                        break;
                    case 5:
                        MessageBox.Show("Успеваемость");
                        break;
                    default:
                        break;
                }*/
            }
            else
            {
                MessageBox.Show("Вы не указали критерий поиска или не выбрали базу!");
            }
        }

        private void teachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.teachersBindingSource.EndEdit();
            this.teachersTableAdapter1.Update(kursDataSet1);
            this.teachersTableAdapter1.Fill(this.kursDataSet1.teachers);
        }

        private void gradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.gradesBindingSource.EndEdit();
            this.gradesTableAdapter1.Update(kursDataSet1);
            this.gradesTableAdapter1.Fill(this.kursDataSet1.grades);
        }

        private void saveToolStripMenuItem_doubleClick(object sender, EventArgs e)
        {
            //tableBindingSource.EndEdit();
            //tableTableAdapter.Update(database1DataSet);

        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.coursesBindingSource.EndEdit();
            this.coursesTableAdapter1.Update(kursDataSet1);
            this.coursesTableAdapter1.Fill(this.kursDataSet1.courses);
        }

        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.groupsBindingSource.EndEdit();
            this.groupsTableAdapter.Update(kursDataSet1);
            this.groupsTableAdapter.Fill(this.kursDataSet1.groups);
        }

        private void departamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.departamentsBindingSource.EndEdit();
            this.departamentsTableAdapter.Update(kursDataSet1);
            this.departamentsTableAdapter.Fill(this.kursDataSet1.departaments);
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.studentsBindingSource1.EndEdit();
            this.studentsTableAdapter1.Update(kursDataSet1);
            this.studentsTableAdapter1.Fill(this.kursDataSet1.students);
        }

        private void allSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.gradesBindingSource.EndEdit();
            this.gradesTableAdapter1.Update(kursDataSet1);

            this.coursesBindingSource.EndEdit();
            this.coursesTableAdapter1.Update(kursDataSet1);

            this.departamentsBindingSource.EndEdit();
            this.departamentsTableAdapter.Update(kursDataSet1);

            this.groupsBindingSource.EndEdit();
            this.groupsTableAdapter.Update(kursDataSet1);

            this.studentsBindingSource1.EndEdit();
            this.studentsTableAdapter1.Update(kursDataSet1);

            this.teachersBindingSource.EndEdit();
            this.teachersTableAdapter1.Update(kursDataSet1);

            this.groupsTableAdapter.Fill(this.kursDataSet1.groups);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1.departaments". При необходимости она может быть перемещена или удалена.
            this.departamentsTableAdapter.Fill(this.kursDataSet1.departaments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1.teachers". При необходимости она может быть перемещена или удалена.
            this.teachersTableAdapter1.Fill(this.kursDataSet1.teachers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1.courses". При необходимости она может быть перемещена или удалена.
            this.coursesTableAdapter1.Fill(this.kursDataSet1.courses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1.students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter1.Fill(this.kursDataSet1.students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1.grades". При необходимости она может быть перемещена или удалена.
            this.gradesTableAdapter1.Fill(this.kursDataSet1.grades);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Справочную информацию уточняйте у производителя по номеру +7-9869-44-63-53");
        }
    }
}
