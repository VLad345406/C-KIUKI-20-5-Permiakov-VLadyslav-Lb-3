using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace CSharp_LB3
{
    class Ports
    {
        public string Name;
        public string Adress;
        public int CountEmployees;
        public int CountVehicles;
        public int CostVehicles;
        public int MaintenanceCost;
        public int ServiceTime;
        public int NumberBerths;
        public int SpentServiceTime;
        public int ServiceProfit;

        //конструктор без параметрів (ініціалізуючий)
        public Ports()
        {
            Name = "";
            Adress = "";
            CountEmployees = 0;
            CountVehicles = 0;
            CostVehicles = 0;
            MaintenanceCost = 0;
            ServiceTime = 0;
            NumberBerths = 0;
            SpentServiceTime = 0;
            ServiceProfit = 0;
        }

        //конструктор копіювання
        public Ports(Ports port)
        {
            Name = port.Name + " (copy)";
            Adress = port.Adress;
            CountEmployees = port.CountEmployees;
            CountVehicles = port.CountVehicles;
            CostVehicles = port.CostVehicles;
            MaintenanceCost = port.MaintenanceCost;
            ServiceTime = port.ServiceTime;
            NumberBerths = port.NumberBerths;
            SpentServiceTime = port.SpentServiceTime;
            ServiceProfit = port.ServiceProfit;
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
        string individualNumber;
        string surname, name, patronymic;
        int salary;
        int workerNumberBerths;
    }

    abstract class Item
    {
        int cost;
        int countWorkers;
    }

    class Machine : Item
    {
        int uniqueNumber;
        bool isWorking;
    }

    class Dock : Item
    {
        string accountNumber;
        const int constNumberOfHours = 30;
        List<int> countVehicles;
        List<string> workersIndividualNumber;
        int actualNumberOfHours;
    }
}
