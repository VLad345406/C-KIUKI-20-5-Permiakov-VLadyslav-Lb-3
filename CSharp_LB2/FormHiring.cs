using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CSharp_LB3
{
    public partial class Form1
    {
        TextBox hiringTextBoxIndividualNumber, hiringTextBoxName, hiringTextBoxSurname,
            hiringTextBoxPatronymic, hiringTextBoxSalary, hiringTextBoxNumberBerths;
        Form formHiring;
        
        int hiringIndex, hiringCountEmployees;
        string hiringMode;
        //ініціалізація форми найму працівників
        public void initializeFormHiring(int index, int count, string mode)
        {
            hiringIndex = index;
            hiringCountEmployees = count;
            hiringMode = mode;

            formHiring = new Form()
            {
                Width = 425,
                Height = 275,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false,
                FormBorderStyle = FormBorderStyle.FixedSingle,
                Text = "Найм працівників"
            };
            formHiring.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //підписи полів вводу
            Label hiringLabelIndividualNumber = new Label()
            {
                Location = new Point(20, 20),
                Width = 90,
                Text = "Індив. номер"
            };
            formHiring.Controls.Add(hiringLabelIndividualNumber);
            Label hiringLabelSurname = new Label()
            {
                Location = new Point(20, 50),
                Width = 90,
                Text = "Прізвище"
            };
            formHiring.Controls.Add(hiringLabelSurname);
            Label hiringLabelName = new Label()
            {
                Location = new Point(20, 80),
                Width = 90,
                Text = "Ім'я"
            };
            formHiring.Controls.Add(hiringLabelName);
            Label hiringLabelPatronymic = new Label()
            {
                Location = new Point(20, 110),
                Width = 90,
                Text = "По-батькові"
            };
            formHiring.Controls.Add(hiringLabelPatronymic);
            Label hiringLabelSalary = new Label()
            {
                Location = new Point(20, 140),
                Width = 90,
                Text = "Зп"
            };
            formHiring.Controls.Add(hiringLabelSalary);
            Label hiringLabelNumberBerths = new Label()
            {
                Location = new Point(20, 170),
                Width = 90,
                Text = "Причал"
            };
            formHiring.Controls.Add(hiringLabelNumberBerths);

            //опис полів вводу
            hiringTextBoxIndividualNumber = new TextBox()
            {
                Location = new Point(110, 20),
                Width = 250
            };
            formHiring.Controls.Add(hiringTextBoxIndividualNumber);
            hiringTextBoxName = new TextBox()
            {
                Location = new Point(110, 50),
                Width = 250
            };
            formHiring.Controls.Add(hiringTextBoxName);
            hiringTextBoxSurname = new TextBox()
            {
                Location = new Point(110, 80),
                Width = 250
            };
            formHiring.Controls.Add(hiringTextBoxSurname);
            hiringTextBoxPatronymic = new TextBox()
            {
                Location = new Point(110, 110),
                Width = 250
            };
            formHiring.Controls.Add(hiringTextBoxPatronymic);
            hiringTextBoxSalary = new TextBox()
            {
                Location = new Point(110, 140),
                Width = 250
            };
            formHiring.Controls.Add(hiringTextBoxSalary);
            hiringTextBoxNumberBerths = new TextBox()
            {
                Location = new Point(110, 170),
                Width = 250
            };
            formHiring.Controls.Add(hiringTextBoxNumberBerths);

            //кнопки керування
            Button buttonDone = new Button()
            {
                Location = new Point(172, 200),
                Width = 80,
                Height = 25,
                Text = "Done"
            };
            buttonDone.Click += new System.EventHandler(buttonDoneHiringOnClick);
            formHiring.Controls.Add(buttonDone);
            Button hiringButtonCancel = new Button()
            {
                Location = new Point(262, 200),
                Width = 80,
                Height = 25,
                Text = "Cancel"
            };
            hiringButtonCancel.Click += new System.EventHandler(buttonHiringCancelOnClick);
            formHiring.Controls.Add(hiringButtonCancel);

            formHiring.ShowDialog();
        }

        private void buttonDoneHiringOnClick(object sender, EventArgs eventArgs)
        {
            int resultParseSalary, resultParseNumberBerths;
            Int32.TryParse(hiringTextBoxSalary.Text, out resultParseSalary);
            Int32.TryParse(hiringTextBoxNumberBerths.Text, out resultParseNumberBerths);
            if (hiringTextBoxIndividualNumber.Text == "")
                MessageBox.Show("Введіть податковий номер!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (hiringTextBoxIndividualNumber.Text.Length != 12)
                MessageBox.Show("Неправильна довжина податкового номера!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (checkAccountNumber(hiringTextBoxIndividualNumber.Text))
                MessageBox.Show("Податковий номер не може мати букви!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (checkAccountNumberRepeat(hiringTextBoxIndividualNumber.Text))
                MessageBox.Show("Такий податковий номер вже існує!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (hiringTextBoxSurname.Text == "")
                MessageBox.Show("Введіть прізвище!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (hiringTextBoxName.Text == "")
                MessageBox.Show("Введіть Ім'я!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (hiringTextBoxPatronymic.Text == "")
                MessageBox.Show("Введіть по-батькові!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (hiringTextBoxSalary.Text == "")
                MessageBox.Show("Введіть заробітню плату!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (resultParseSalary <= 0)
                MessageBox.Show("Неправильно вказана зарплата!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (hiringTextBoxNumberBerths.Text == "")
                MessageBox.Show("Введіть номер причалу!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (resultParseNumberBerths <= 0 || arr.ElementAt(hiringIndex).CountBerths < resultParseNumberBerths)
                MessageBox.Show("Неправильно вказаний номер причалу!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Worker newWorker = new Worker();
                newWorker.individualNumber = hiringTextBoxIndividualNumber.Text;
                newWorker.surname = hiringTextBoxSurname.Text;
                newWorker.name = hiringTextBoxName.Text;
                newWorker.patronymic = hiringTextBoxPatronymic.Text;
                newWorker.salary = resultParseSalary;
                newWorker.workerNumberBerths = resultParseNumberBerths;

                Dictionary<string, Worker> hiringDictionaryWorkers = arr.ElementAt(hiringIndex).GetSetWorkers;
                hiringDictionaryWorkers.Add(hiringTextBoxIndividualNumber.Text, newWorker);
                arr.ElementAt(hiringIndex).GetSetWorkers = hiringDictionaryWorkers;
                hiringCountEmployees--;
                if (hiringCountEmployees > 0)
                {
                    hiringTextBoxIndividualNumber.Text = "";
                    hiringTextBoxName.Text = "";
                    hiringTextBoxSurname.Text = "";
                    hiringTextBoxPatronymic.Text = "";
                    hiringTextBoxSalary.Text = "";
                    hiringTextBoxNumberBerths.Text = "";
                }
                else
                    formHiring.Close();
            }
        }
        private void buttonHiringCancelOnClick(object sender, EventArgs eventArgs)
        {
            if (hiringMode == "New")
                MessageBox.Show("Ви ще не додали всіх співробітників!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                formHiring.Close();
        }
    }
}