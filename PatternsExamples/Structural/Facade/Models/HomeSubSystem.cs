namespace PatternsExamples.Structural.Facade.Models
{
    public class HomeSubSystem : IHomeSubSystem
    {
        public bool IsSwitchOn;

        public void SwitchOff()
        {
            IsSwitchOn = false;
        }

        public void SwitchOn()
        {
            IsSwitchOn = true;
        }
    }

    public class Light : HomeSubSystem
    {
    }

    public class MusicSystem : HomeSubSystem
    {
    }

    public class TV : HomeSubSystem
    {
    }

    public class Security : HomeSubSystem
    {
    }
}