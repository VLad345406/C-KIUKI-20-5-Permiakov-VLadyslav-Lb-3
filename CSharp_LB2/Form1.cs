using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CSharp_LB3
{
    public partial class Form1 : Form
    {
        HashSet<Ports> arr;
        private Dictionary<string, Worker> dictionaryWorkers;
        private List<Item> equipment;
        private List<Dock> Docks;

        public Form1()
        {
            InitializeComponent();
            arr = new HashSet<Ports>(new PortsCompareer());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clearForm();
        }

        private void buttonAddPort_Click(object sender, EventArgs e)
        {
            bool checkRepeat = checkPortsRepeat(textBoxName.Text);

            //конвертація необхідних даних з string в int
            int countEmployees, numberVehicles, costVehicles, maintenanceCost, serviceTime, numberBerths, countShips;
            Int32.TryParse(textBoxCountEmployees.Text, out countEmployees);
            Int32.TryParse(textBoxNumberVehicles.Text, out numberVehicles);
            Int32.TryParse(textBoxCostVehicles.Text, out costVehicles);
            Int32.TryParse(textBoxMaintenanceCost.Text, out maintenanceCost);
            Int32.TryParse(textBoxServiceTime.Text, out serviceTime);
            Int32.TryParse(textBoxNumberBerths.Text, out numberBerths);
            Int32.TryParse(textBoxCountShips.Text, out countShips);

            //перевірки на правильність заповнення
            if (textBoxName.Text == "" || textBoxName.Text == "Назва порту" ||
                textBoxAdress.Text == "" || textBoxAdress.Text == "Адреса порту" ||
                textBoxCountEmployees.Text == "" || textBoxCountEmployees.Text == "Кількість працівників порту" ||
                textBoxNumberVehicles.Text == "" || textBoxNumberVehicles.Text == "Кількість одиниць техніки" ||
                textBoxCostVehicles.Text == "" || textBoxCostVehicles.Text == "Вартість однієї одиниці техніки" ||
                textBoxMaintenanceCost.Text == "" || textBoxMaintenanceCost.Text == "Вартість обслуговування одного корабля" ||
                textBoxServiceTime.Text == "" || textBoxServiceTime.Text == "Час обслуговування одного корабля" ||
                textBoxNumberBerths.Text == "" || textBoxNumberBerths.Text == "Кількість причалів (на 1 причал - 5 одиниць техніки та 15 робочих" ||
                textBoxCountShips.Text == "" || textBoxCountShips.Text == "Кількість кораблів, що обслуговуються портом"
                )
                MessageBox.Show("Недостатньо даних!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (checkRepeat)
                MessageBox.Show("Такий порт вже існує!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (countEmployees <= 0)
                MessageBox.Show("Неправильно вказана кількість працівників!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numberVehicles <= 0)
                MessageBox.Show("Неправильно вказана кількість техніки!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (costVehicles <= 0)
                MessageBox.Show("Неправильно вказана вартість техніки!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (maintenanceCost <= 0)
                MessageBox.Show("Неправильно вказана вартість обслуговування техніки!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (serviceTime <= 0)
                MessageBox.Show("Неправильно вказаний час обслуговування!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numberBerths <= 0)
                MessageBox.Show("Неправильно вказана кількість причалів!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (countShips <= 0)
                MessageBox.Show("Неправильно вказана кількість кораблів, що обслуговується!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numberVehicles / 5 > numberBerths)
                MessageBox.Show("Цей порт не зможе прийняти стільки кораблів!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Ports temp = new Ports();
                temp.Name = textBoxName.Text;
                temp.Adress = textBoxAdress.Text;
                temp.CountEmployees = countEmployees;
                temp.CountVehicles = numberVehicles;
                temp.CostVehicles = costVehicles;
                temp.MaintenanceCost = maintenanceCost;
                temp.ServiceTime = serviceTime;
                temp.CountBerths = numberBerths;
                temp.CountShips = countShips;
                temp.SpentServiceTime = calcTime(numberVehicles, countEmployees, serviceTime);
                temp.ServiceProfit = calcProfit(numberVehicles, maintenanceCost);
                arr.Add(temp);
                comboBoxPorts.Items.Add(textBoxName.Text);
                clearForm();
            }
        }

        //функція-обробник зміни індекса в comboBox
        private void comboBoxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButtonShow.Checked)
                addInfoToDataGridView(dataGridView1, comboBoxPorts.SelectedIndex);
            else if (radioButtonHiringFiring.Checked)
                initializeFormHiringFiring();
            else if (radioButtonCopy.Checked)
            {
                if (arr.Count == 0)
                    MessageBox.Show("Копіювання неможливе без даних", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (checkPortsRepeat(arr.ElementAt(comboBoxPorts.SelectedIndex).Name + " (copy)"))
                        MessageBox.Show("Копія цього порту вже існує!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        arr.Add(new Ports(arr.ElementAt(comboBoxPorts.SelectedIndex)));
                        comboBoxPorts.Items.Add(arr.ElementAt(arr.Count() - 1).Name);
                        MessageBox.Show("Успішне копіювання!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
                MessageBox.Show("Оберіть режим роботи!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonComparison_Click(object sender, EventArgs e)
        {
            if (arr.Count() >= 2)
                initializeFormComparison();
            else
                MessageBox.Show("Не можна запустити порівняння, доки записаних портів менше 2х!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
