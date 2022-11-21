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
        TextBox addBerthsTextBox;
        Form formAddBerths;

        //ініціалізація форми додавання причалів
        public void initializeFormAddBerths()
        {
            formAddBerths = new Form()
            {
                Width = 300,
                Height = 150,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false,
                FormBorderStyle = FormBorderStyle.FixedSingle,
                Text = "Додати причали"
            };
            formAddBerths.Show();

            Label addLabelInfo = new Label()
            {
                Location = new Point(20, 20),
                Width = 300,
                Text = "Зараз в цьому порту " + arr.ElementAt(comboBoxPorts.SelectedIndex).NumberBerths + " причалів"
            };
            formAddBerths.Controls.Add(addLabelInfo);
            addBerthsTextBox = new TextBox()
            {
                Location = new Point(20, 50),
                Width = 250
            };
            formAddBerths.Controls.Add(addBerthsTextBox);
            Button buttonDone = new Button()
            {
                Location = new Point(20, 80),
                Width = 80,
                Height = 20,
                Text = "Done"
            };
            buttonDone.Click += new System.EventHandler(buttonDoneOnClick);
            formAddBerths.Controls.Add(buttonDone);
        }

        private void buttonDoneOnClick(object sender, EventArgs eventArgs)
        {
            int resultAdd = 0;
            Int32.TryParse(addBerthsTextBox.Text, out resultAdd);

            if (addBerthsTextBox.Text == "")
                MessageBox.Show("Введіть значення!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (resultAdd <= 0)
                MessageBox.Show("Неправильний формат даних!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                arr.ElementAt(comboBoxPorts.SelectedIndex).NumberBerths += resultAdd;
                formAddBerths.Close();
            }
        }
    }
}
