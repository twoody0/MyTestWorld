namespace MyWorld;

public class ThermostatEventPublisher
{
    // Defining the event publisher
    public Action<float>? OnTemperatureChange { get; set; }

    private float _CurrentTemperature;

    public float CurrentTemperature
    {
        get { return _CurrentTemperature; }
        set
        {
            if (value != CurrentTemperature)
            {
                _CurrentTemperature = value;
                OnTemperatureChange?.Invoke(value);
            }
        }
    }
}