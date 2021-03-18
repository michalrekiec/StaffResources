using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace StaffResources
{
    public partial class AddEditEmployee : Form
    {
        private FileHelper<List<Employee>> _fileHelper = new FileHelper<List<Employee>>(Program.FilePath);

        private FileHelper<List<Employee>> _temporaryFile = new FileHelper<List<Employee>>(Program.TemporaryPath);

        public delegate void Del1();
        public event Del1 EmployeeAdded;

        private int _id;
        public AddEditEmployee(int id = 0)
        {
            InitializeComponent();

            _id = id;

            if (id != 0)
            {
                Text = "Edytowanie danych pracownika";

                var employees = _fileHelper.DeserializeFromFile();
                var employee = employees.FirstOrDefault(x => x.Id == id);

                tbId.Text = employee.Id.ToString();
                tbFirstName.Text = employee.FirstName;
                tbLastName.Text = employee.LastName;
                dtpEmploymentDate.Value = employee.EmploymentDate;
                cbDepartment.SelectedItem = employee.Department;
                tbSalary.Text = employee.Salary.ToString();
            }
        }

        private void OnEmployeeAdded()
        {
            EmployeeAdded?.Invoke();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var employees = _fileHelper.DeserializeFromFile();

            if (_id != 0)
            {
                employees.RemoveAll(x => x.Id == _id);
            }
            else
            {
                var employeeWithHighestId = employees.OrderByDescending(x => x.Id).FirstOrDefault();
                _id = employeeWithHighestId == null ? 1 : employeeWithHighestId.Id + 1;
            }

            var employee = new Employee
            {
                Id = _id,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                EmploymentDate = dtpEmploymentDate.Value,
                DismissalDate = null,
                Department = cbDepartment.Text,
                IsActive = true
            };

            decimal result;

            // Check whether Salary property has numeric format or not
            if (decimal.TryParse(tbSalary.Text, out result) == true)
            {
                lbWarning.Text = "";
                employee.Salary = result;
                employees.Add(employee);

                _fileHelper.SerializeToFile(employees);

                OnEmployeeAdded();

                Close();
            }
            else
            {
                lbWarning.ForeColor = Color.Red;
                lbWarning.Text = "Proszę wpisać właściwy format liczbowy.";
            }
        }
    }
}
