using System.Threading;

namespace Builder
{
    public interface IGudgetBuilder
    {
        void CreateMonitor();
        void CreatePowerSupply();
        void CreateKeyboard();
        Gudget GetDevice();
    }

    public class NotebookBuilder : IGudgetBuilder
    {
        private readonly Gudget _gudget;
        public NotebookBuilder()
        {
            _gudget = new Gudget();
        }
        public void CreateMonitor()
        {
            _gudget.Monitor = "LCD monitor";
        }

        public void CreatePowerSupply()
        {
            _gudget.Power = "Battery";
        }

        public void CreateKeyboard()
        {
            _gudget.Keyboard = "Hardware keys";
        }

        public Gudget GetDevice()
        {
            return _gudget;
        }
    }

    public class PhoneBuilder : IGudgetBuilder
    {
        private readonly Gudget _gudget;
        public PhoneBuilder()
        {
            _gudget = new Gudget();
        }
        public void CreateMonitor()
        {
            _gudget.Monitor = "IPS monitor";
        }

        public void CreatePowerSupply()
        {
            _gudget.Power = "Li-On battery";
        }

        public void CreateKeyboard()
        {
            _gudget.Keyboard = "TouchScreen";
        }

        public Gudget GetDevice()
        {
            return _gudget;
        }
    }
}