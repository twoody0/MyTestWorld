namespace MyWorld;

public class ThermostatEventPublisher
{
    // Defining the event publisher
    public Action<float>? OnTemperatureChange { get; set; }

    public float CurrentTemperature { get; set; }
}