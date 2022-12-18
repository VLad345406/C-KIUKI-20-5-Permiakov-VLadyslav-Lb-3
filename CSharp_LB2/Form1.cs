using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_LB3
{
    public partial class Form1 : Form
    {
        HashSet<Ports> arr;

        public Form1()
        {
            InitializeComponent();
            arr = new HashSet<Ports>(new PortsCompareer());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clearForm();
            if (!Directory.Exists("HarborData"))
                Directory.CreateDirectory("HarborData");
            else
            {
                var directories = Directory.GetDirectories("HarborData");
                for (int i = 0; i < directories.Length; i++)
                {
                    Ports loadPort = new Ports();
                    
                    //читання main.txt
                    StreamReader mainReader = new StreamReader(directories[i] + "\\main.txt");
                    int mainCount = 0;
                    while (!mainReader.EndOfStream)
                    {
                        switch (mainCount)
                        {
                            case 0:
                                loadPort.Name = mainReader.ReadLine();
                                mainCount++;
                                break;
                            case 1:
                                loadPort.Adress = mainReader.ReadLine();
                                mainCount++;
                                break;
                            case 2:
                                int count;
                                Int32.TryParse(mainReader.ReadLine(), out count);
                                loadPort.CountEmployees = count;
                                mainCount++;
                                break;
                            case 3:
                                Int32.TryParse(mainReader.ReadLine(), out count);
                                loadPort.CountVehicles = count;
                                mainCount++;
                                break;
                            case 4:
                                Int32.TryParse(mainReader.ReadLine(), out count);
                                loadPort.MaintenanceCost = count;
                                mainCount++;
                                break;
                            case 5:
                                Int32.TryParse(mainReader.ReadLine(), out count);
                                loadPort.CountBerths = count;
                                mainCount++;
                                break;
                            case 6:
                                Int32.TryParse(mainReader.ReadLine(), out count);
                                loadPort.ServiceTime = count;
                                mainCount++;
                                break;
                            case 7:
                                Int32.TryParse(mainReader.ReadLine(), out count);
                                loadPort.ServiceProfit = count;
                                mainCount++;
                                break;
                        }
                    }
                    mainReader.Close();
                    loadPort.SetIndex = i;

                    //читання Workers.txt
                    Dictionary<string, Worker> loadWorkers = new Dictionary<string, Worker>();
                    StreamReader workersReader = new StreamReader(directories[i] + "\\Workers.txt");
                    int workersCount = 0;
                    Worker workerRead = new Worker();
                    while (!workersReader.EndOfStream)
                    {
                        switch (workersCount)
                        {
                            case 0:
                                workerRead.individualNumber = workersReader.ReadLine();
                                workersCount++;
                                break;
                            case 1:
                                workerRead.surname = workersReader.ReadLine();
                                workersCount++;
                                break;
                            case 2:
                                workerRead.name = workersReader.ReadLine();
                                workersCount++;
                                break;
                            case 3:
                                workerRead.patronymic = workersReader.ReadLine();
                                workersCount++;
                                break;
                            case 4:
                                int count;
                                Int32.TryParse(workersReader.ReadLine(), out count);
                                workerRead.salary = count;
                                workersCount++;
                                break;
                            case 5:
                                Int32.TryParse(workersReader.ReadLine(), out count);
                                workerRead.workerNumberBerths = count;
                                workersCount++;
                                break;
                            case 6:
                                workersCount = 0;
                                workersReader.ReadLine();
                                loadWorkers.Add(workerRead.individualNumber, workerRead);
                                workerRead = new Worker();
                                break;
                        }
                    }
                    workersReader.Close();
                    loadPort.GetSetWorkers = loadWorkers;


                    //читання Machines.txt
                    int machinesCount = 0;
                    List<Machine> loadMachines = new List<Machine>();
                    Machine currentMachine = new Machine();
                    StreamReader machinesReader = new StreamReader(directories[i] + "\\Machines.txt");
                    int machicnesCount = 0;
                    while (!machinesReader.EndOfStream)
                    {
                        switch (machinesCount)
                        {
                            case 0:
                                int count;
                                Int32.TryParse(machinesReader.ReadLine(), out count);
                                currentMachine.cost = count;
                                machinesCount++;
                                break;
                            case 1:
                                Int32.TryParse(machinesReader.ReadLine(), out count);
                                currentMachine.countWorkers = count;
                                machinesCount++;
                                break;
                            case 2:
                                Int32.TryParse(machinesReader.ReadLine(), out count);
                                currentMachine.uniqueNumber = count;
                                machinesCount++;
                                break;
                            case 3:
                                if (machinesReader.ReadLine() == "True")
                                    currentMachine.isWorking = true;
                                else
                                    currentMachine.isWorking = false;
                                machinesCount++;
                                break;
                            case 4:
                                machinesReader.ReadLine();
                                loadMachines.Add(currentMachine);
                                currentMachine = new Machine();
                                machinesCount = 0;
                                break;
                        }
                    }
                    machinesReader.Close();
                    loadPort.listMachines = loadMachines;
                    comboBoxPorts.Items.Add(loadPort.Name);
                    arr.Add(loadPort);
                    loadPort = new Ports();
                }
            }
        }

        private void buttonAddPort_Click(object sender, EventArgs e)
        {
            bool checkRepeat = checkPortsRepeat(textBoxName.Text);

            //конвертація необхідних даних з string в int
            int countEmployees, numberVehicles, maintenanceCost, serviceTime, numberBerths;
            Int32.TryParse(textBoxCountEmployees.Text, out countEmployees);
            Int32.TryParse(textBoxNumberVehicles.Text, out numberVehicles);
            Int32.TryParse(textBoxMaintenanceCost.Text, out maintenanceCost);
            Int32.TryParse(textBoxServiceTime.Text, out serviceTime);
            Int32.TryParse(textBoxNumberBerths.Text, out numberBerths);

            //перевірки на правильність заповнення
            if (textBoxName.Text == "" || textBoxAdress.Text == "" ||
                textBoxCountEmployees.Text == "" || textBoxNumberVehicles.Text == "" ||
                textBoxMaintenanceCost.Text == "" || textBoxServiceTime.Text == "" || 
                textBoxNumberBerths.Text == "")
                MessageBox.Show("Недостатньо даних!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (checkRepeat)
                MessageBox.Show("Такий порт вже існує!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (countEmployees <= 0)
                MessageBox.Show("Неправильно вказана кількість працівників!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numberVehicles <= 0)
                MessageBox.Show("Неправильно вказана кількість техніки!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (maintenanceCost <= 0)
                MessageBox.Show("Неправильно вказана вартість обслуговування техніки!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (serviceTime <= 0)
                MessageBox.Show("Неправильно вказаний час обслуговування!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numberBerths <= 0)
                MessageBox.Show("Неправильно вказана кількість причалів!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numberVehicles / 5 > numberBerths)
                MessageBox.Show("Цей порт не зможе прийняти стільки кораблів!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Ports temp = new Ports();
                temp.Name = textBoxName.Text;
                temp.Adress = textBoxAdress.Text;
                temp.CountEmployees = countEmployees;
                temp.CountVehicles = numberVehicles;
                temp.MaintenanceCost = maintenanceCost;
                temp.ServiceTime = serviceTime;
                temp.CountBerths = numberBerths;
                
                temp.ServiceProfit = calcProfit(numberVehicles, maintenanceCost);
                arr.Add(temp);
                arr.ElementAt(arr.Count() - 1).SetIndex = arr.Count() - 1;

                initializeFormHiring(arr.Count() - 1, countEmployees, "New");

                List<Dock> listDockTemp = new List<Dock>();
                Dock dockTemp = new Dock();

                List<int> arrayNumberVechicles = new List<int>();

                List<string> workersNumber = new List<string>();

                initializeFormAddVechicles(arr.Count() - 1, numberVehicles, "New");

                //генерування податкових номерів співробітників
                Dictionary<string, Worker> currentDockWorkers = arr.ElementAt(arr.Count() - 1).GetSetWorkers;

                for (int i = 1; i <= numberBerths; i++)
                {
                    for (int j = 0; j < currentDockWorkers.Count(); j++)
                    {
                        if (i == currentDockWorkers.ElementAt(j).Value.workerNumberBerths)
                            workersNumber.Add(currentDockWorkers.ElementAt(j).Key);
                    }
                }
                dockTemp.workersIndividualNumber = workersNumber;
                dockTemp.numbersVehicles = arrayNumberVechicles;
                dockTemp.workersIndividualNumber = workersNumber;
                dockTemp.actualNumberOfHours = serviceTime;
                listDockTemp.Add(dockTemp);
                arr.ElementAt(arr.Count() - 1).listDocks = listDockTemp;
                arr.ElementAt(arr.Count() - 1).SpentServiceTime = calcTime(numberVehicles, countEmployees, serviceTime, listDockTemp);
                comboBoxPorts.Items.Add(textBoxName.Text);
                clearForm();
            }
        }

        //функція-обробник зміни індекса в comboBox
        private void comboBoxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButtonShow.Checked)
                addInfoToDataGridView(dataGridView1, comboBoxPorts.SelectedIndex);
            else if (radioButtonHiring.Checked)
                initializeFormHiring(comboBoxPorts.SelectedIndex, 1, "Add");
            else if (radioButtonFiring.Checked)
                initializeFormFiring(comboBoxPorts.SelectedIndex);
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
            else if (radioButtonAddVechicle.Checked)
                initializeFormAddVechicles(comboBoxPorts.SelectedIndex, 1, "Add");
            else if (radioButtonRemoveVechicle.Checked)
                initializeFormRemoveVechicles(comboBoxPorts.SelectedIndex);
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult MSExit = MessageBox.Show("Ви точно бажаєте вийти?", "Message!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (MSExit == DialogResult.Yes)
            {
                for (int i = 0; i < arr.Count(); i++)
                {
                    Directory.CreateDirectory("HarborData\\" + arr.ElementAt(i).Name);
                    //main.txt
                    string mainSave = arr.ElementAt(i).Name + '\n'
                    + arr.ElementAt(i).Adress + '\n'
                    + arr.ElementAt(i).CountEmployees + '\n'
                    + arr.ElementAt(i).CountVehicles + '\n'
                    + arr.ElementAt(i).MaintenanceCost + '\n'
                    + arr.ElementAt(i).CountBerths + '\n'
                    + arr.ElementAt(i).ServiceTime + '\n'
                    + arr.ElementAt(i).ServiceProfit;
                    File.WriteAllText("HarborData\\" + arr.ElementAt(i).Name + "\\main.txt", mainSave);
                    //Workers.txt
                    Dictionary<string, Worker> currentWorkers = arr.ElementAt(i).GetSetWorkers;
                    string workersSave = ""; //currentWorkers.Count().ToString() + "\n\n";
                    for (int j = 0; j < currentWorkers.Count(); j++)
                    {
                        workersSave += currentWorkers.ElementAt(j).Key + "\n"
                        + currentWorkers.ElementAt(j).Value.surname + "\n"
                        + currentWorkers.ElementAt(j).Value.name + "\n"
                        + currentWorkers.ElementAt(j).Value.patronymic + "\n"
                        + currentWorkers.ElementAt(j).Value.salary + "\n"
                        + currentWorkers.ElementAt(j).Value.workerNumberBerths + "\n\n";
                    }
                    File.WriteAllText("HarborData\\" + arr.ElementAt(i).Name + "\\Workers.txt", workersSave);
                    //Machines.txt
                    string machinesSave = ""; //arr.ElementAt(i).listMachines.Count().ToString() + "\n\n";
                    for (int j = 0; j < arr.ElementAt(i).listMachines.Count(); j++)
                    {
                        machinesSave += arr.ElementAt(i).listMachines[j].cost + "\n"
                        + arr.ElementAt(i).listMachines[j].countWorkers + "\n"
                        + arr.ElementAt(i).listMachines[j].uniqueNumber + "\n"
                        + arr.ElementAt(i).listMachines[j].isWorking + "\n\n";
                    }
                    File.WriteAllText("HarborData\\" + arr.ElementAt(i).Name + "\\Machines.txt", machinesSave);
                }
                Application.Exit();
            }
        }
    }
}
