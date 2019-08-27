namespace PatternsExamples.Behavioural.Command
{
    public class Controller
    {
        ICommand On;
        ICommand Off;

        public Controller(ICommand on, ICommand off)
        {
            On = on;
            Off = off;
        }

        public void ClickOn()
        {
            On.Execute();
        }

        public void ClickOff()
        {
            Off.Execute();
        }
    }
}