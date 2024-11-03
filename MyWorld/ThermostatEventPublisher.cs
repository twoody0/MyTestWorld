namespace MyWorld;

public class ThermostatEventPublisher
{
    // Defining the event publisher
    //public Action<float>? OnTemperatureChange { get; set; }

    public class TemperatureArgs : System.EventArgs
    {
        public TemperatureArgs(float newTemperature)
        {
            NewTemperature = newTemperature;
        }

        public float NewTemperature { get; set; }
    }

    public event EventHandler<TemperatureArgs> OnTemperatureChange = delegate { };

    public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e)
        where TEventArgs : EventArgs;

    private float _CurrentTemperature;

    public float CurrentTemperature
    {
        get { return _CurrentTemperature; }
        set
        {
            if (value != CurrentTemperature)
            {
                _CurrentTemperature = value;
                OnTemperatureChange?.Invoke(this, new TemperatureArgs(value));
            }
        }
    }
}