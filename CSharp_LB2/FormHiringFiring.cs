using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_LB3
{
    public partial class Form1
    {
        TextBox hiringFiringTextBox;
        Form formHiringFiring;

        //ініціалізація форми найму/звільнення працівників
        public void initializeFormHiringFiring()
        {
            formHiringFiring = new Form()
            {
                Width = 550,
                Height = 150,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false,
                FormBorderStyle = FormBorderStyle.FixedSingle,
                Text = "Додати причали"
            };
            formHiringFiring.Show();

            Label addLabelInfo = new Label()
            {
                Location = new Point(20, 20),
                Width = 500,
                Text = "Зараз в цьому порту " + arr.ElementAt(comboBoxPorts.SelectedIndex).CountEmployees + " співробітників." +
                " Для звільнення в полі перед числом допишіть знак -"
            };
            formHiringFiring.Controls.Add(addLabelInfo);
            hiringFiringTextBox = new TextBox()
            {
                Location = new Point(20, 50),
                Width = 250
            };
            formHiringFiring.Controls.Add(hiringFiringTextBox);
            Button buttonDone = new Button()
            {
                Location = new Point(20, 80),
                Width = 80,
                Height = 20,
                Text = "Done"
            };
            buttonDone.Click += new System.EventHandler(buttonDoneHiringFiringOnClick);
            formHiringFiring.Controls.Add(buttonDone);
        }

        private void buttonDoneHiringFiringOnClick(object sender, EventArgs eventArgs)
        {
            int resultAdd = 0;
            Int32.TryParse(hiringFiringTextBox.Text, out resultAdd);

            if (hiringFiringTextBox.Text == "")
                MessageBox.Show("Введіть значення!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (resultAdd == 0)
                MessageBox.Show("Неправильний формат даних!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                arr.ElementAt(comboBoxPorts.SelectedIndex).CountEmployees += resultAdd;
                formHiringFiring.Close();
            }
        }
    }
}
