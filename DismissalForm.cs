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
    public partial class DismissalForm : Form
    {
        private FileHelper<List<Employee>> _fileHelper = new FileHelper<List<Employee>>(Program.FilePath);

        public delegate void Del3();
        public event Del3 DismissEmployee;

        private int _id;
        public DismissalForm(int id = 0)
        {
            InitializeComponent();

            _id = id;
            AskForDismissal();
        }

        private void OnDismissEmployee()
        {
            DismissEmployee?.Invoke();
        }

        private void AskForDismissal()
        {
            var employees = _fileHelper.DeserializeFromFile();
            var dismissedPerson = employees.FirstOrDefault(x => x.Id == _id);

            lbQuestion.Text = $"Dane pracownika do zwolnienia: \n{dismissedPerson.Id}. {dismissedPerson.FirstName} {dismissedPerson.LastName} - {dismissedPerson.Department}\n" +
                $"Zatrudniony dnia {dismissedPerson.EmploymentDate}\nCzy jesteś pewien?";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDismissEmployee_Click(object sender, EventArgs e)
        {
            var employees = _fileHelper.DeserializeFromFile();
            var dismissedPerson = employees.FirstOrDefault(x => x.Id == _id);

            if (dtpDismissalDate.Value < dismissedPerson.EmploymentDate)
            {
                lbInformation.ForeColor = Color.Red;
                lbInformation.Text = "Data zwolnienia nie może być wcześniejsza niż data zatrudnienia";
            }
            else
            {
                dismissedPerson.DismissalDate = dtpDismissalDate.Value;
                dismissedPerson.IsActive = false;
                _fileHelper.SerializeToFile(employees);

                OnDismissEmployee();
                Close();
            }
        }
    }
}
