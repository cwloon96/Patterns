namespace PatternsExamples.Behavioural.Command
{
    public interface ILight
    {
        void On();
        void Off();
    }

    public class Light : ILight
    {
        public bool LightOn { get; set; }

        public void Off()
        {
            LightOn = false;
        }

        public void On()
        {
            LightOn = true;
        }
    }
}