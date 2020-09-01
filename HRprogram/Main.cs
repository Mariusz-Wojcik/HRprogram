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
        }

        private void RefreshDiary()
        {
            var employees = _fileHelper.DeserializeFromFile();         
            dgvMain.DataSource = employees;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var addEditEmployee = new AddEditEmployee();
            addEditEmployee.ShowDialog();
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

        }
    }
}
