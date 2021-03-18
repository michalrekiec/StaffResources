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
    public partial class Main : Form
    {
        private FileHelper<List<Employee>> _fileHelper = new FileHelper<List<Employee>>(Program.FilePath);

        private FileHelper<List<Employee>> _temporaryFile = new FileHelper<List<Employee>>(Program.TemporaryPath);

        public Main()
        {
            InitializeComponent();

            RefreshData();
            SetColumnsHeader();
        }

        private void RefreshData()
        {
            var employees = _fileHelper.DeserializeFromFile();
            dgvStaff.DataSource = employees;
        }

        private void SetColumnsHeader()
        {
            dgvStaff.Columns[0].HeaderText = "Numer";
            dgvStaff.Columns[1].HeaderText = "Imię";
            dgvStaff.Columns[2].HeaderText = "Nazwisko";
            dgvStaff.Columns[3].HeaderText = "Dział";
            dgvStaff.Columns[4].HeaderText = "Data przyjęcia";
            dgvStaff.Columns[5].HeaderText = "Data zwolnienia";
            dgvStaff.Columns[6].HeaderText = "Zarobki";
            dgvStaff.Columns[7].HeaderText = "Zatrudniony";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addEditEmployee = new AddEditEmployee();
            addEditEmployee.EmployeeAdded += AddEditEmployee_EmployeeAdded;
            addEditEmployee.ShowDialog();
            addEditEmployee.EmployeeAdded -= AddEditEmployee_EmployeeAdded;
        }

        private void AddEditEmployee_EmployeeAdded()
        {
            RefreshData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznacz pracownika");
                return;
            }

            var addEditEmployee = new AddEditEmployee(Convert.ToInt32(dgvStaff.SelectedRows[0].Cells[0].Value));

            addEditEmployee.EmployeeAdded += AddEditEmployee_EmployeeAdded;
            addEditEmployee.ShowDialog();
            addEditEmployee.EmployeeAdded -= AddEditEmployee_EmployeeAdded;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var employeeDataFilter = new EmployeeDataFilter();
            employeeDataFilter.FilterAdded += EmployeeDataFilter_FilterAdded;
            employeeDataFilter.ShowDialog(); 
            employeeDataFilter.FilterAdded -= EmployeeDataFilter_FilterAdded;
        }

        private void EmployeeDataFilter_FilterAdded()
        {
            var employees = _temporaryFile.DeserializeFromFile();
            dgvStaff.DataSource = employees;
            btnClear.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznacz pracownika, którego chcesz zwolnić");
                return;
            }

            var dismissalForm = new DismissalForm(Convert.ToInt32(dgvStaff.SelectedRows[0].Cells[0].Value));
            dismissalForm.DismissEmployee += DismissalForm_DismissEmployee;
            dismissalForm.ShowDialog(); 
            dismissalForm.DismissEmployee -= DismissalForm_DismissEmployee;
        }

        private void DismissalForm_DismissEmployee()
        {
            RefreshData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            RefreshData();
            btnClear.Visible = false;
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentData = _fileHelper.DeserializeFromFile();
            var filteredData = _fileHelper.DeserializeFromFile();

            if (btnClear.Visible == false)
            {
                currentData = _fileHelper.DeserializeFromFile();
            }
            else
            {
                currentData = _temporaryFile.DeserializeFromFile();
            }

            switch (cbCategory.SelectedIndex)
            {
                case 0:
                    {
                        dgvStaff.DataSource = currentData.OrderBy(x => x.Id).ToList();                        
                    }
                    break;
                case 1:
                    {
                        dgvStaff.DataSource = currentData.OrderByDescending(x => x.Id).ToList();
                    }
                    break;
                case 2:
                    {
                        dgvStaff.DataSource = currentData.OrderBy(x => x.Salary).ToList();
                    }
                    break;
                case 3:
                    {
                        dgvStaff.DataSource = currentData.OrderByDescending(x => x.Salary).ToList();
                    }
                    break;
                case 4:
                    {
                        dgvStaff.DataSource = currentData.OrderBy(x => x.Department).ToList();
                    }
                    break;
                case 5:
                    {
                        dgvStaff.DataSource = currentData.OrderByDescending(x => x.Department).ToList();
                    }
                    break;
                case 6:
                    {
                        dgvStaff.DataSource = currentData.OrderBy(x => x.LastName).ToList();
                    }
                    break;
                case 7:
                    {
                        dgvStaff.DataSource = currentData.OrderBy(x => x.EmploymentDate).ToList();
                    }
                    break;
            }
        }
    }
}
