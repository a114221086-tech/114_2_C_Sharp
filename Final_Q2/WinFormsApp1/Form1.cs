using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Activated += Form1_Activated;
        }

        private void Form1_Activated(object? sender, EventArgs e)
        {
            RefreshEmployeeList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using var f = new AddEmployeeForm();
            f.ShowDialog(this);
            RefreshEmployeeList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using var f = new DeleteEmployeeForm();
            f.ShowDialog(this);
            RefreshEmployeeList();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            using var f = new UpdateEmployeeForm();
            f.ShowDialog(this);
            RefreshEmployeeList();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            using var f = new SearchEmployeeForm();
            f.ShowDialog(this);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshEmployeeList()
        {
            listBoxEmployees.Items.Clear();
            foreach (var emp in EmployeeStore.Employees.OrderBy(x => x.IdNumber))
            {
                listBoxEmployees.Items.Add(emp);
            }
        }

        private void listBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
