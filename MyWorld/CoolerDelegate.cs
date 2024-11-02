using System.Runtime.CompilerServices;

namespace MyWorld;

public class CoolerDelegate
{
    public CoolerDelegate(float temperature)
    {
        Temperature = temperature;
    }

    public float Temperature { get; set; }

    public void OnTemperatureChanged(float newTemperature)
    {
        if (newTemperature > Temperature)
        {
            Console.WriteLine("Cooler: On");
        }
        else
        {
            Console.WriteLine("Cooler: Off");
        }
    }
}