using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffResources
{
    public partial class EmployeeDataFilter : Form
    {
        private FileHelper<List<Employee>> _fileHelper = new FileHelper<List<Employee>>(Program.FilePath);

        private FileHelper<List<Employee>> _temporaryFile = new FileHelper<List<Employee>>(Program.TemporaryPath);

        public delegate void Del2();
        public event Del2 FilterAdded;

        public EmployeeDataFilter()
        {
            InitializeComponent();

            SetDefaultSalaryValues();
        }

        private void OnFilterAdded()
        {
            FilterAdded?.Invoke();
        }

        private void SetDefaultSalaryValues()
        {
            var employees = _fileHelper.DeserializeFromFile();
            var employeeWithHighestSalary = employees.OrderByDescending(x => x.Salary).FirstOrDefault();
            var employeeWithLowestSalary = employees.OrderBy(x => x.Salary).FirstOrDefault();

            tbLowerLimit.Text = employeeWithLowestSalary.Salary.ToString();
            tbUpperLimit.Text = employeeWithHighestSalary.Salary.ToString();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            decimal resultMin;
            decimal resultMax;

            var filteredList = _fileHelper.DeserializeFromFile();

            if (!cbManagement.Checked)
                filteredList.RemoveAll(x => x.Department == "Zarząd");

            if (!cbHR.Checked)
                filteredList.RemoveAll(x => x.Department == "Kadry");

            if (!cbAccountancy.Checked)
                filteredList.RemoveAll(x => x.Department == "Księgowość");

            if (!cbIT.Checked)
                filteredList.RemoveAll(x => x.Department == "IT");

            if (rbEmployed.Checked)
                filteredList.RemoveAll(x => x.IsActive == false);

            if (rbNotEmployed.Checked)
                filteredList.RemoveAll(x => x.IsActive == true);

            if ((decimal.TryParse(tbLowerLimit.Text, out resultMin) == false) || (decimal.TryParse(tbUpperLimit.Text, out resultMax) == false))
            {
                lbError.ForeColor = Color.Red;
                lbError.Text = "Proszę wprowadzić poprawne wartości liczbowe";
            }
            else
            {
                lbError.Text = "";

                filteredList.RemoveAll(x => x.Salary < Convert.ToDecimal(tbLowerLimit.Text));
                filteredList.RemoveAll(x => x.Salary > Convert.ToDecimal(tbUpperLimit.Text));

                _temporaryFile.SerializeToFile(filteredList);

                OnFilterAdded();
                Close();
            }
        }
    }
}
