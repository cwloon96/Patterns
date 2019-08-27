namespace PatternsExamples.Behavioural.Command
{
    public interface ICommand
    {
        void Execute();
        void Unexecute();
    }

    public class LightOnCommand : ICommand
    {
        protected ILight Light;

        public LightOnCommand(ILight light)
        {
            Light = light;
        }

        public void Execute()
        {
            Light.On();
        }

        public void Unexecute()
        {
            Light.Off();
        }
    }

    public class LightOffCommand : ICommand
    {
        protected ILight Light;

        public LightOffCommand(ILight light)
        {
            Light = light;
        }

        public void Execute()
        {
            Light.Off();
        }

        public void Unexecute()
        {
            Light.On();
        }
    }
}