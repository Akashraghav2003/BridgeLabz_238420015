using SmartHomeDevices;

class Program
{
    static void Main(string[] args)
    {
        Thermostat thermostat = new Thermostat("TH123", "On", 22.5);
        thermostat.DisplayStatus();
    }
}
