using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1.teachers". При необходимости она может быть перемещена или удалена.
            this.teachersTableAdapter1.Fill(this.kursDataSet1.teachers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1.courses". При необходимости она может быть перемещена или удалена.
            this.coursesTableAdapter1.Fill(this.kursDataSet1.courses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1.students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter1.Fill(this.kursDataSet1.students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1.grades". При необходимости она может быть перемещена или удалена.
            this.gradesTableAdapter1.Fill(this.kursDataSet1.grades);

        }

        private void paramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void baseTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
