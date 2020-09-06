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
        private Employee _employee;
        private FileHelper<List<Employee>> _fileHelper = new FileHelper<List<Employee>>(Program.FilePath);
        public AddEditEmployee(int id = 0)
        {
            InitializeComponent();
            _employeeId = id;
            GetEmployeeData();

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

        
        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GetEmployeeData()
        {
            if (_employeeId != 0)
            {
                Text = "Edytowanie danych pracownika";
                var employee = _fileHelper.DeserializeFromFile();
                _employee = employee.FirstOrDefault(x => x.Id == _employeeId);

                if (_employee == null)

                    throw new Exception("Brak pracownika o podanym Id");

                FillTextBoxes();
            }
        }
        private void FillTextBoxes()
        {
            tbId.Text = _employee.Id.ToString();
            tbFirstName.Text = _employee.FirstName;
            tbLastName.Text = _employee.LastName;
            tbHireDate.Text = _employee.HireDate;
            tbFireDate.Text = _employee.FireDate;
            tbSalary.Text = _employee.Salary.ToString();
            rtbRemarks.Text = _employee.Remarks;
        }
    }
}
