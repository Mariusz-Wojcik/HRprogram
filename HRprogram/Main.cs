using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace HRprogram
{
    public partial class Main : Form
    {
        private FileHelper<List<Employee>> _fileHelper = new FileHelper<List<Employee>>(Program.FilePath);

        public Main()
        {
            InitializeComponent();
            RefreshDiary();
            SetColumnHeader();
        }

        private void RefreshDiary()
        {
            var employees = _fileHelper.DeserializeFromFile();
            dgvMain.DataSource = employees;
        }



        private void btAdd_Click(object sender, EventArgs e)
        {
            var addEditEmployee = new AddEditEmployee();
            addEditEmployee.FormClosing += AddEditEmployee_FormClosing;
            addEditEmployee.ShowDialog();
        }

        private void AddEditEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshDiary();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count == 0)
            {
                MessageBox.Show("Zaznacz pracownika którego dane chcesz edytować");
                return;
            }

            var addEditEmployee = new AddEditEmployee(Convert.ToInt32(dgvMain.SelectedRows[0].Cells[0].Value));
            addEditEmployee.FormClosing += AddEditEmployee_FormClosing;
            addEditEmployee.ShowDialog();
        }

        private void btFire_Click(object sender, EventArgs e)
        {
            
            var fireEmployee = new FireEmployee(Convert.ToInt32(dgvMain.SelectedRows[0].Cells[0].Value));

            RefreshDiary();

        }

        private void btDelate_Click(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count == 0)
            {
                MessageBox.Show("Zaznacz pracownika którego dane chcesz usunąć");
                return;
            }

            var selectedEmployee = dgvMain.SelectedRows[0];
            var confirmDelete =
                MessageBox.Show($"Czy na pewno chcesz usunąć pracownika " +
                $"{(selectedEmployee.Cells[1].Value.ToString() + " " + selectedEmployee.Cells[2].Value.ToString()).Trim()}",
                "Usuwanie pracownika",
                MessageBoxButtons.OKCancel);

            if (confirmDelete == DialogResult.OK)
            {
                DeleteEmployee(Convert.ToInt32(selectedEmployee.Cells[0].Value));
                RefreshDiary();
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            RefreshDiary();
        }

        private void SetColumnHeader()
        {
            dgvMain.Columns[0].HeaderText = "Numer pracownika";
            dgvMain.Columns[1].HeaderText = "Imię";
            dgvMain.Columns[2].HeaderText = "Nazwisko";
            dgvMain.Columns[3].HeaderText = "Data zatrudnienia";
            dgvMain.Columns[4].HeaderText = "Data zwolnienia";
            dgvMain.Columns[5].HeaderText = "Pensja";
            dgvMain.Columns[6].HeaderText = "Uwagi";
        }

        private void DeleteEmployee(int id)
        {
            var employees = _fileHelper.DeserializeFromFile();
            employees.RemoveAll(x => x.Id == id);
            _fileHelper.SerializeToFile(employees);
        }


    }
}
