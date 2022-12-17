using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CSharp_LB3
{
    public partial class Form1
    {
        TextBox removeVechicleTextBox;
        Form formRemoveVechicles;
        int removeVechiclesIndexArray;

        //ініціалізація форми звільнення працівників
        public void initializeFormRemoveVechicles(int arrayIndex)
        {
            removeVechiclesIndexArray = arrayIndex;
            formRemoveVechicles = new Form()
            {
                Width = 425,
                Height = 125,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false,
                FormBorderStyle = FormBorderStyle.FixedSingle,
                Text = "Видалення техніки"
            };

            Label removeVechicleLabel = new Label()
            {
                Location = new Point(20, 20),
                Width = 95,
                Text = "Обліковий номер"
            };
            formRemoveVechicles.Controls.Add(removeVechicleLabel);
            removeVechicleTextBox = new TextBox()
            {
                Location = new Point(125, 20),
                Width = 250
            };
            formRemoveVechicles.Controls.Add(removeVechicleTextBox);
            Button buttonDone = new Button()
            {
                Location = new Point(125, 50),
                Width = 80,
                Height = 25,
                Text = "Done"
            };
            buttonDone.Click += new System.EventHandler(buttonDoneRemoveVechiclesOnClick);
            formRemoveVechicles.Controls.Add(buttonDone);

            formRemoveVechicles.ShowDialog();
        }

        private void buttonDoneRemoveVechiclesOnClick(object sender, EventArgs eventArgs)
        {
            int removeVechicleParse;
            Int32.TryParse(removeVechicleTextBox.Text, out removeVechicleParse);
            if (removeVechicleTextBox.Text == "")
                MessageBox.Show("Введіть обліковий номер техніки!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (removeVechicleParse <= 0)
                MessageBox.Show("Неправильний формат облікового номера техніки!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int removeIndex = -1;

                List<Machine> removeVechicles = new List<Machine>();
                for (int i = 0; i < arr.ElementAt(removeVechiclesIndexArray).listMachines.Count(); i++)
                {
                    if (removeVechicleParse == arr.ElementAt(removeVechiclesIndexArray).listMachines[i].uniqueNumber)
                    {
                        removeIndex = i;
                        break;
                    }
                }
                if (removeIndex == -1)
                    MessageBox.Show("Техніки, з таким обліковим номером немає в ціому порту!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    for (int i = 0; i < arr.ElementAt(removeVechiclesIndexArray).listMachines.Count(); i++)
                    {
                        if (i != removeIndex)
                            removeVechicles.Add(arr.ElementAt(removeVechiclesIndexArray).listMachines[i]);
                    }
                    arr.ElementAt(removeVechiclesIndexArray).listMachines = removeVechicles;
                    MessageBox.Show("Успішне видалення!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    arr.ElementAt(removeVechiclesIndexArray).CountVehicles--;
                    formRemoveVechicles.Close();
                }
            }
        }
    }
}
