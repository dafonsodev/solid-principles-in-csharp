namespace _5_DIP.Violating
{
    public class LightSwitch
    {
        private readonly ElectricityProvider _electricityProvider;

        public LightSwitch()
        {
            _electricityProvider = new ElectricityProvider();
        }

        public void TurnOnLight()
        {
            _electricityProvider.TurnOn();
        }

        public void TurnOffLight()
        {
            _electricityProvider.TurnOff();
        }
    }
}
