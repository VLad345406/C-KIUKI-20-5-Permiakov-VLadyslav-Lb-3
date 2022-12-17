using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CSharp_LB3
{
    public partial class Form1
    {
        TextBox firingWorkerNumberTextBox;
        Form formFiring;
        int firingIndexArray;

        //ініціалізація форми звільнення працівників
        public void initializeFormFiring(int arrayIndex)
        {
            firingIndexArray = arrayIndex;
            formFiring = new Form()
            {
                Width = 425,
                Height = 125,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false,
                FormBorderStyle = FormBorderStyle.FixedSingle,
                Text = "Звільнення працівників"
            };

            Label firingLabelWorkerNumber = new Label()
            {
                Location = new Point(20, 20),
                Width = 95,
                Text = "Обліковий номер"
            };
            formFiring.Controls.Add(firingLabelWorkerNumber);
            firingWorkerNumberTextBox = new TextBox()
            {
                Location = new Point(125, 20),
                Width = 250
            };
            formFiring.Controls.Add(firingWorkerNumberTextBox);
            Button buttonDone = new Button()
            {
                Location = new Point(125, 50),
                Width = 80,
                Height = 25,
                Text = "Done"
            };
            buttonDone.Click += new System.EventHandler(buttonDoneFiringOnClick);
            formFiring.Controls.Add(buttonDone);

            formFiring.ShowDialog();
        }

        private void buttonDoneFiringOnClick(object sender, EventArgs eventArgs)
        {
            if (firingWorkerNumberTextBox.Text == "")
                MessageBox.Show("Введіть значення!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (firingWorkerNumberTextBox.Text.Length != 12)
                MessageBox.Show("Неправильна довжина податкового номера", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (checkAccountNumber(firingWorkerNumberTextBox.Text))
                MessageBox.Show("Неправильний формат податкового номера", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Dictionary<string, Worker> firingDictionaryWorkers = arr.ElementAt(hiringIndex).GetSetWorkers;
                int firingIndex = -1;
                for (int i = 0; i < firingDictionaryWorkers.Count(); i++)
                {
                    if (firingWorkerNumberTextBox.Text == firingDictionaryWorkers.ElementAt(i).Key)
                    {
                        firingIndex = i;
                        break;
                    }
                }
                if (firingIndex == -1)
                    MessageBox.Show("Такого співробітника в цьому порту немає!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Dictionary<string, Worker> newDictionaryWorkers = new Dictionary<string, Worker>();
                    for (int i = 0; i < firingDictionaryWorkers.Count(); i++)
                    {
                        if (i != firingIndex)
                            newDictionaryWorkers.Add(firingDictionaryWorkers.ElementAt(i).Key, firingDictionaryWorkers.ElementAt(i).Value);
                    }
                    arr.ElementAt(firingIndex).GetSetWorkers = newDictionaryWorkers;
                    arr.ElementAt(firingIndex).CountEmployees--;
                    MessageBox.Show("Успішне звільнення!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formFiring.Close();
                }
            }
        }
    }
}
