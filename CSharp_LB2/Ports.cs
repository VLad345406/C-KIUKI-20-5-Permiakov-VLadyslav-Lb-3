using System.Collections;
using System.Collections.Generic;
    
namespace CSharp_LB3
{
    class Ports
    {
        public string Name;
        public string Adress;
        public int CountEmployees;
        public int CountVehicles;
        public int MaintenanceCost;
        public int ServiceTime;
        public int CountBerths;
        public int SpentServiceTime;
        public int ServiceProfit;

        public List<Dock> listDocks;
        public List<Machine> listMachines;

        private Dictionary<string, Worker> Workers;
        private List<Item> Equipment;
        private List<Dock> Docks;
        private int index;

        //конструктор без параметрів (ініціалізуючий)
        public Ports()
        {
            Name = "";
            Adress = "";
            CountEmployees = 0;
            CountVehicles = 0;
            MaintenanceCost = 0;
            ServiceTime = 0;
            CountBerths = 0;
            SpentServiceTime = 0;
            ServiceProfit = 0;
            Workers = new Dictionary<string, Worker>();
            listMachines = new List<Machine>();
        }

        //конструктор копіювання
        public Ports(Ports port)
        {
            Name = port.Name + " (copy)";
            Adress = port.Adress;
            CountEmployees = port.CountEmployees;
            CountVehicles = port.CountVehicles;
            MaintenanceCost = port.MaintenanceCost;
            ServiceTime = port.ServiceTime;
            CountBerths = port.CountBerths;
            SpentServiceTime = port.SpentServiceTime;
            ServiceProfit = port.ServiceProfit;
        }

        //getters & setters
        public int GetCountEmployees
        {
            get { return CountEmployees; }
        }

        public Dock GetSetDockInfo
        {
            get 
            {
                Dock getter = Docks[index];
                return getter;
            }
            set 
            {
                Docks.Add(value);
            }
        }

        public int SetIndex
        {
            set { index = value; }
        }

        public Dictionary<string, Worker> GetSetWorkers
        {
            get { return Workers; }
            set { Workers = value; }
        }
    }

    //реалізація інтерфейсу IEqualityComparer
    class PortsCompareer : IEqualityComparer<Ports>
    {
        public bool Equals(Ports x, Ports y)
        {
            if (x == null && y == null) return true;
            if (x == null) return false;
            if (y == null) return false;
            return object.Equals(x.Name, y.Name);
        }

        public int GetHashCode(Ports obj)
        {
            return obj.Name.GetHashCode();
        }
    }

    class Worker
    {
        public string individualNumber;
        public string surname, name, patronymic;
        public int salary;
        public int workerNumberBerths;
    }

    abstract class Item : Ports
    {
        public int cost;
        public int countWorkers;
    }

    class Machine : Item
    {
        public int uniqueNumber;
        public bool isWorking;

        public int GetMachineCount
        {
            get { return CountVehicles; }
        }
    }

    class Dock : Item
    {
        public string accountNumberDock;
        const int constNumberOfHours = 30;
        public List<int> numbersVehicles;
        public List<string> workersIndividualNumber;
        public int actualNumberOfHours;

        public int GetDockCountBerth
        {
            get { return CountBerths; }
        }
    }
}
