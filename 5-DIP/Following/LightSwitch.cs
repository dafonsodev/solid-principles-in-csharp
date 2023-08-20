using _5_DIP.Following.Interfaces;

namespace _5_DIP.Following
{
    public class LightSwitch
    {
        private readonly ISwitchable _switchable;

        public LightSwitch(ISwitchable switchable)
        {
            _switchable = switchable;
        }

        public void TurnOnLight()
        {
            _switchable.TurnOn();
        }

        public void TurnOffLight()
        {
            _switchable.TurnOff();
        }
    }
}
