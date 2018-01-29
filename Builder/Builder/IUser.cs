namespace Builder
{
    public interface IUser
    {
        Gudget Construct();
    }

    public class User : IUser
    {
        private readonly IGudgetBuilder _builder;

        public User(IGudgetBuilder builder)
        {
            _builder = builder;
        }

        public Gudget Construct()
        {
            _builder.CreateMonitor();
            _builder.CreateKeyboard();
            _builder.CreatePowerSupply();
            return _builder.GetDevice();
        }
    }
}