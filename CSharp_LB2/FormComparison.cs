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
        ComboBox comboBoxPort1, comboBoxPort2;
        Label labelPort1NumberBerths, labelPort2NumberBerths, labelComparison;

        //ініціалізація форми порівняння
        public void initializeFormComparison()
        {
            Form formComparison = new Form()
            {
                Width = 600,
                Height = 150,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false,
                FormBorderStyle = FormBorderStyle.FixedSingle,
                Text = "Порівняння портів за кількістю причалів, що можуть функціонувати"
            };
            formComparison.Show();

            comboBoxPort1 = new ComboBox()
            {
                Location = new Point(30, 20),
                Width = 250
            };
            formComparison.Controls.Add(comboBoxPort1);
            //присвоєння обробника зміни індекса comboBoxoPort1
            comboBoxPort1.SelectedIndexChanged += new System.EventHandler(this.comboBoxPort1_SelectedIndexChanged);
            labelPort1NumberBerths = new Label()
            {
                Location = new Point(30, 50),
                Width = 250,
                Text = "Кількість причалів в цьому порту: Null"
            };
            formComparison.Controls.Add(labelPort1NumberBerths);

            comboBoxPort2 = new ComboBox()
            {
                Location = new Point(310, 20),
                Width = 250
            };
            formComparison.Controls.Add(comboBoxPort2);
            //присвоєння обробника зміни індекса comboBoxoPort2
            comboBoxPort2.SelectedIndexChanged += new System.EventHandler(this.comboBoxPort2_SelectedIndexChanged);
            labelPort2NumberBerths = new Label()
            {
                Location = new Point(310, 50),
                Width = 250,
                Text = "Кількість причалів в цьому порту: Null"
            };
            formComparison.Controls.Add(labelPort2NumberBerths);

            labelComparison = new Label()
            {
                Location = new Point(290, 50),
                Width = 50
            };
            formComparison.Controls.Add(labelComparison);

            for (int i = 0; i < arr.Count(); i++)
            {
                comboBoxPort1.Items.Add(arr.ElementAt(i).Name);
                comboBoxPort2.Items.Add(arr.ElementAt(i).Name);
            }
            
        }

        private void comboBoxPort1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelPort1NumberBerths.Text = "Кількість причалів в цьому порту: " + arr.ElementAt(comboBoxPort1.SelectedIndex).CountBerths;
        }
        private void comboBoxPort2_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelPort2NumberBerths.Text = "Кількість причалів в цьому порту: " + arr.ElementAt(comboBoxPort2.SelectedIndex).CountBerths;
            if (comboBoxPort1.SelectedIndex == -1)
                MessageBox.Show("Оберіть порт з першого списку!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (arr.ElementAt(comboBoxPort1.SelectedIndex).CountBerths > arr.ElementAt(comboBoxPort2.SelectedIndex).CountBerths)
                    labelComparison.Text = ">";
                else if (arr.ElementAt(comboBoxPort1.SelectedIndex).CountBerths < arr.ElementAt(comboBoxPort2.SelectedIndex).CountBerths)
                    labelComparison.Text = "<";
                else
                    labelComparison.Text = "=";
            }
        }
    }
}
