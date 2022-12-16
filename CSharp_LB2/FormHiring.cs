using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CSharp_LB3
{
    public partial class Form1
    {
        TextBox hiringTextBox;
        Form formHiring;

        //ініціалізація форми найму/звільнення працівників
        public void initializeFormHiring()
        {
            formHiring = new Form()
            {
                Width = 550,
                Height = 150,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false,
                FormBorderStyle = FormBorderStyle.FixedSingle,
                Text = "Найм працівників"
            };
            formHiring.Show();

            Label addLabelInfo = new Label()
            {
                Location = new Point(20, 20),
                Width = 500,
                Text = "Зараз в цьому порту " + arr.ElementAt(comboBoxPorts.SelectedIndex).CountEmployees + " співробітників." +
                " Для звільнення в полі перед числом допишіть знак -"
            };
            formHiring.Controls.Add(addLabelInfo);
            hiringTextBox = new TextBox()
            {
                Location = new Point(20, 50),
                Width = 250
            };
            formHiring.Controls.Add(hiringTextBox);
            Button buttonDone = new Button()
            {
                Location = new Point(20, 80),
                Width = 80,
                Height = 20,
                Text = "Done"
            };
            buttonDone.Click += new System.EventHandler(buttonDoneHiringOnClick);
            formHiring.Controls.Add(buttonDone);
        }

        private void buttonDoneHiringOnClick(object sender, EventArgs eventArgs)
        {
            int resultAdd = 0;
            Int32.TryParse(hiringTextBox.Text, out resultAdd);

            if (hiringTextBox.Text == "")
                MessageBox.Show("Введіть значення!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (resultAdd == 0)
                MessageBox.Show("Неправильний формат даних!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                arr.ElementAt(comboBoxPorts.SelectedIndex).CountEmployees += resultAdd;
                formHiring.Close();
            }
        }
    }
}
