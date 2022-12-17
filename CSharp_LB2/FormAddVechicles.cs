using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CSharp_LB3
{
    public partial class Form1
    {
        TextBox addVechiclesCostTextBox, addVechiclesWorkersTextBox, addVechiclesNumberTextBox;
        Form formAddVechicles;
        RadioButton addVechiclesRadioButtonTrue, addVechiclesRadioButtonFalse;

        int addVechiclesIndex;
        int addVechicleCount;
        string addVechicleMode;
        //ініціалізація форми звільнення працівників
        public void initializeFormAddVechicles(int index, int count, string mode)
        {
            addVechiclesIndex = index;
            addVechicleCount = count;
            addVechicleMode = mode;

            formAddVechicles = new Form()
            {
                Width = 405,
                Height = 185,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false,
                FormBorderStyle = FormBorderStyle.FixedSingle,
                Text = "Додавання техніки"
            };
            formAddVechicles.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //опис полів
            Label labelCost = new Label()
            {
                Location = new Point(20, 20),
                Width = 95,
                Text = "Вартість"
            };
            formAddVechicles.Controls.Add(labelCost);
            Label labelWorkers = new Label()
            {
                Location = new Point(20, 50),
                Width = 95,
                Text = "К-сть робітників"
            };
            formAddVechicles.Controls.Add(labelWorkers);
            Label labelVechicleNumber = new Label()
            {
                Location = new Point(20, 80),
                Width = 95,
                Text = "Обліковий номер"
            };
            formAddVechicles.Controls.Add(labelVechicleNumber);
            Label labelIsWorking = new Label()
            {
                Location = new Point(20, 110),
                Width = 95,
                Text = "Справність"
            };
            formAddVechicles.Controls.Add(labelIsWorking);

            //поля вводу інформації
            addVechiclesCostTextBox = new TextBox()
            {
                Location = new Point(125, 20),
                Width = 250
            };
            formAddVechicles.Controls.Add(addVechiclesCostTextBox);
            addVechiclesWorkersTextBox = new TextBox()
            {
                Location = new Point(125, 50),
                Width = 250
            };
            formAddVechicles.Controls.Add(addVechiclesWorkersTextBox);
            addVechiclesNumberTextBox = new TextBox()
            {
                Location = new Point(125, 80),
                Width = 250
            };
            formAddVechicles.Controls.Add(addVechiclesNumberTextBox);
            GroupBox isWorkingGroupBox = new GroupBox()
            {
                Location = new Point(125, 100),
                Width = 110,
                Height = 40
            };
            addVechiclesRadioButtonTrue = new RadioButton()
            {
                Location = new Point(10, 10),
                Text = "Так",
                Width = 50,
                Checked = true
            };
            isWorkingGroupBox.Controls.Add(addVechiclesRadioButtonTrue);
            addVechiclesRadioButtonFalse = new RadioButton()
            {
                Location = new Point(70, 10),
                Width = 35,
                Text = "Ні",
            };
            isWorkingGroupBox.Controls.Add(addVechiclesRadioButtonFalse);
            formAddVechicles.Controls.Add(isWorkingGroupBox);

            //кнопки керування
            Button buttonDone = new Button()
            {
                Location = new Point(125, 145),
                Width = 80,
                Height = 25,
                Text = "Done"
            };
            buttonDone.Click += new System.EventHandler(buttonDoneAddVechiclesOnClick);
            formAddVechicles.Controls.Add(buttonDone);
            Button buttonCancel = new Button()
            {
                Location = new Point(215, 145),
                Width = 80,
                Height = 25,
                Text = "Cancel"
            };
            buttonCancel.Click += new System.EventHandler(buttonCancelAddVechiclesOnClick);
            formAddVechicles.Controls.Add(buttonCancel);

            formAddVechicles.ShowDialog();
        }

        private void buttonDoneAddVechiclesOnClick(object sender, EventArgs eventArgs)
        {
            int costParse, workersParse, numberParse;
            Int32.TryParse(addVechiclesCostTextBox.Text, out costParse);
            Int32.TryParse(addVechiclesWorkersTextBox.Text, out workersParse);
            Int32.TryParse(addVechiclesNumberTextBox.Text, out numberParse);

            if (addVechiclesCostTextBox.Text == "")
                MessageBox.Show("Введіть вартість техніки!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (costParse <= 0)
                MessageBox.Show("Неправильний формат вартості!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (addVechiclesWorkersTextBox.Text == "")
                MessageBox.Show("Введіть кількість робітників, необхідних для обслуговування!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (workersParse <= 0)
                MessageBox.Show("Неправильний формат кількості робітників", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (addVechiclesNumberTextBox.Text == "")
                MessageBox.Show("Введіть обліковий номер!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numberParse <= 0)
                MessageBox.Show("Неправильний формат облікового номера!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (checkVechiclesRepeat(numberParse))
                MessageBox.Show("Такий обліковий номер вже існує!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Machine addMachine = new Machine()
                { 
                    cost = costParse,
                    countWorkers = workersParse,
                    uniqueNumber = numberParse
                };
                if (addVechiclesRadioButtonTrue.Checked)
                    addMachine.isWorking = true;
                else
                    addMachine.isWorking = false;
                arr.ElementAt(addVechiclesIndex).listMachines.Add(addMachine);
                addVechicleCount--;
                if (addVechicleCount > 0)
                {
                    addVechiclesCostTextBox.Text = "";
                    addVechiclesWorkersTextBox.Text = "";
                    addVechiclesNumberTextBox.Text = "";
                    addVechiclesRadioButtonTrue.Checked = true;
                }
                else
                    formAddVechicles.Close();
            }
        }
        private void buttonCancelAddVechiclesOnClick(object sender, EventArgs eventArgs)
        {
            if (addVechicleMode == "New")
                MessageBox.Show("Ви ще не додали інформацію про всю техніку!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                formAddVechicles.Close();
        }
    }
}
