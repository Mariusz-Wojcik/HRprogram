using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void btFire_Click(object sender, EventArgs e)
        {

        }

        private void btDelate_Click(object sender, EventArgs e)
        {

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

    }
}
