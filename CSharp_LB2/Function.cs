using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CSharp_LB3
{
    public partial class Form1
    {
        //функція розрахунку витраченого часу на ремонту в порта
        private int calcTime(int numberVechicles, int countEmployees, int serviceTime, List<Dock> listDock)
        {
            int result = 0;

            while (numberVechicles > 5 && countEmployees > 15)
            {
                result += serviceTime * 5;
                numberVechicles -= 5;
                countEmployees -= 15;
            }
            if (numberVechicles != 0 && countEmployees >= 15 && countEmployees > 0)
                result += serviceTime * numberVechicles;
            return result;
        }
        //функція розрахунку прибутку порту
        private int calcProfit(int countVehicles, int maintenanceCost)
        {
            int result = 0;
            result += countVehicles * maintenanceCost;
            return result;
        }

        //фукнція показу інформації на головному єкрані через DataGridView
        public void addInfoToDataGridView(DataGridView dataGridView, int index)
        {
            dataGridView.Rows.Clear();
            dataGridView.Rows.Add("Назва порту", arr.ElementAt(index).Name);
            dataGridView.Rows.Add("Адреса порту", arr.ElementAt(index).Adress);
            dataGridView.Rows.Add("Кількість працівників порту", arr.ElementAt(index).CountEmployees);
            dataGridView.Rows.Add("Кількість одиниць техніки", arr.ElementAt(index).CountVehicles);
            dataGridView.Rows.Add("Вартість однієї одиниці техніки", arr.ElementAt(index).CostVehicles + " $");
            dataGridView.Rows.Add("Вартість обслуговування одного корабля", arr.ElementAt(index).MaintenanceCost + " $");
            dataGridView.Rows.Add("Час обслуговування одного корабля", arr.ElementAt(index).ServiceTime + " год.");
            dataGridView.Rows.Add("Кількість причалів", arr.ElementAt(index).CountBerths);
            dataGridView.Rows.Add("Кількість кораблів, що обслуговуються", arr.ElementAt(index).CountShips);

            dataGridView.Rows.Add();
            dataGridView.Rows.Add("Розраховані дані");

            dataGridView.Rows.Add("Необхідний час для обслуговування", arr.ElementAt(index).SpentServiceTime + " год.");
            dataGridView.Rows.Add("Прибуток порту від обслуговування " + arr.ElementAt(index).CountVehicles + " кораблів",
               arr.ElementAt(index).ServiceProfit + " $");
        }

        //очищення полів вводу
        private void clearForm()
        {
            textBoxName.AddPlaceholder("Назва порту");
            textBoxAdress.AddPlaceholder("Адреса порту");
            textBoxCountEmployees.AddPlaceholder("Кількість працівників порту");
            textBoxNumberVehicles.AddPlaceholder("Кількість одиниць техніки");
            textBoxCostVehicles.AddPlaceholder("Вартість однієї одиниці техніки");
            textBoxMaintenanceCost.AddPlaceholder("Вартість обслуговування одного корабля");
            textBoxServiceTime.AddPlaceholder("Час обслуговування одного корабля");
            textBoxNumberBerths.AddPlaceholder("Кількість причалів (на 1 причал - 5 одиниць техніки та 15 робочих");
            textBoxCountShips.AddPlaceholder("Кількість кораблів, що обслуговуються портом");
        }

        //перевірка на повторюваність портів
        bool checkPortsRepeat(string portNameCheck)
        {
            bool result = false;

            if (arr.Count() != 0)
            {
                for (int i = 0; i < arr.Count(); i++)
                {
                    if (arr.ElementAt(i).Name == portNameCheck)
                    {
                        result = true;
                        break;
                    }
                }
            }

            return result;
        }

        //перевірка на правильність вводу облікового номеру
        bool checkAccountNumber (string accountNumber)
        {
            bool result = false;
            bool checkInFor = false;
            string number = "0123456789";
            for (int i = 0; i < accountNumber.Length; i++)
            {
                for (int j = 0; j < number.Length; j++)
                {
                    if (accountNumber[i] == number[j])
                    {
                        checkInFor = true;
                        break;
                    }
                }
                if (!checkInFor)
                {
                    result = true;
                    break;
                }    
            }
            return result;
        }
    }
}
