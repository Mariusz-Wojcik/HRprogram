using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRprogram
{
    public partial class AddEditEmployee : Form
    {
        private int _employeeId;
        private FileHelper<List<Employee>> _fileHelper = new FileHelper<List<Employee>>(Program.FilePath);
        public AddEditEmployee()
        {
            InitializeComponent();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            var employees = _fileHelper.DeserializeFromFile();
            if (_employeeId != 0)
                employees.RemoveAll(x => x.Id == _employeeId);
            else
                AssignIdToNewEmployee(employees);

            AddNewUserToList(employees);

            _fileHelper.SerializeToFile(employees);

            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {

        }

        private void AddNewUserToList(List<Employee> employees)
        {
            var employee = new Employee
            {
                Id = _employeeId,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                HireDate = tbHireDate.Text,
                FireDate = tbFireDate.Text,
                Salary = Convert.ToInt32(tbSalary.Text),
                Remarks = rtbRemarks.Text
            };

            employees.Add(employee);
        }
        private void AssignIdToNewEmployee(List<Employee> employees)
        {
            var studentWithHigherId = employees.OrderByDescending(x => x.Id).FirstOrDefault();

            _employeeId = studentWithHigherId == null ?
                1 : studentWithHigherId.Id + 1;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
