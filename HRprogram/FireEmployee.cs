using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRprogram
{
    class FireEmployee
    {
        private int _employeeId;
        private Employee _employee;
        private FileHelper<List<Employee>> _fileHelper = new FileHelper<List<Employee>>(Program.FilePath);
        
        public FireEmployee (int id =0)
        {
         
            _employeeId = id;
            GetEmployeeData();
            var employees = _fileHelper.DeserializeFromFile();
            if (_employeeId != 0)
                employees.RemoveAll(x => x.Id == _employeeId);
            UpdateFireDate(employees);
            _fileHelper.SerializeToFile(employees);
        }

        private void GetEmployeeData()
        {
            if (_employeeId != 0)
            {
                var employee = _fileHelper.DeserializeFromFile();
                _employee = employee.FirstOrDefault(x => x.Id == _employeeId);
                MessageBox.Show($"{_employee.FirstName}");
                if (_employee == null)

                    throw new Exception("Brak pracownika o podanym Id");

            }
        }

        private void UpdateFireDate(List<Employee> employees)
        {
            var fireDate = Interaction.InputBox("Wprowadź datę zwolnienia");
            var employee = new Employee
            {
                Id = _employeeId,
                FirstName = _employee.FirstName,
                LastName = _employee.LastName,
                HireDate = _employee.HireDate,
                FireDate = fireDate,
                Salary = Convert.ToInt32(_employee.Salary),
                Remarks = _employee.Remarks
            };
            employees.Add(employee);
        }
    }
}
