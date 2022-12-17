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
            dataGridView.Rows.Add("Вартість обслуговування одного корабля", arr.ElementAt(index).MaintenanceCost + " $");
            dataGridView.Rows.Add("Час обслуговування одного корабля", arr.ElementAt(index).ServiceTime + " год.");
            dataGridView.Rows.Add("Кількість причалів", arr.ElementAt(index).CountBerths);

            dataGridView.Rows.Add();
            dataGridView.Rows.Add("Розраховані дані");

            dataGridView.Rows.Add("Необхідний час для обслуговування", arr.ElementAt(index).SpentServiceTime + " год.");
            dataGridView.Rows.Add("Прибуток порту від обслуговування " + arr.ElementAt(index).CountVehicles + " кораблів",
               arr.ElementAt(index).ServiceProfit + " $");
        }

        //очищення полів вводу
        private void clearForm()
        {
            textBoxName.Text = "";
            textBoxAdress.Text = "";
            textBoxCountEmployees.Text = "";
            textBoxNumberVehicles.Text = "";
            textBoxMaintenanceCost.Text = "";
            textBoxServiceTime.Text = "";
            textBoxNumberBerths.Text = "";
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
            bool checkInFor;
            string number = "0123456789";
            for (int i = 0; i < accountNumber.Length; i++)
            {
                checkInFor = false;
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

        //перевірка на повторюваність облікового номера
        bool checkAccountNumberRepeat(string accountNumber)
        {
            Dictionary<string, Worker> checkNumber;
            bool result = false;
            bool checkInFor;
            for (int i = 0; i < arr.Count; i++)
            {
                checkNumber = arr.ElementAt(i).GetSetWorkers;
                checkInFor = false;
                for (int j = 0; j < checkNumber.Count(); j++)
                {
                    if (accountNumber == checkNumber.ElementAt(j).Key)
                    {
                        checkInFor = true;
                        break;
                    }
                }
                if (checkInFor)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        //перевірка на повторюваність облікового номера техніки
        bool checkVechiclesRepeat(int vechicleNumber)
        {
            bool result = false;
            bool checkInFor;
            for (int i = 0; i < arr.Count(); i++)
            {
                checkInFor = false;
                for (int j = 0; j < arr.ElementAt(i).listMachines.Count(); j++)
                {
                    if (vechicleNumber == arr.ElementAt(i).listMachines[j].uniqueNumber)
                    {
                        checkInFor = true;
                        break;
                    }
                }
                if (checkInFor)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}
