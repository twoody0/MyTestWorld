namespace MyWorld;

public class HeaterDelegate
{
    public HeaterDelegate(float temperature)
    {
        Temperature = temperature;
    }

    public float Temperature { get; set; }

    public void OnTemperatureChanged(float newTemperature)
    {
        if (newTemperature < Temperature)
        {
            Console.WriteLine("Heater: On");
        }
        else
        {
            Console.WriteLine("Heater: Off");
        }
    }
}