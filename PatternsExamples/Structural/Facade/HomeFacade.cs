using PatternsExamples.Structural.Facade.Models;

namespace PatternsExamples.Structural.Facade
{
    public class HomeFacade
    {
        IHomeSubSystem Light;
        IHomeSubSystem MusicSystem;
        IHomeSubSystem TV;
        IHomeSubSystem Security;

        public HomeFacade(IHomeSubSystem light, 
            IHomeSubSystem musicSystem, 
            IHomeSubSystem tv, 
            IHomeSubSystem security)
        {
            Light = light;
            MusicSystem = musicSystem;
            TV = tv;
            Security = security;
        }

        public void LeaveHome()
        {
            Light.SwitchOff();
            MusicSystem.SwitchOff();
            TV.SwitchOff();
            Security.SwitchOff();
        }

        public void ArriveHome()
        {
            Light.SwitchOn();
            MusicSystem.SwitchOn();
            TV.SwitchOn();
            Security.SwitchOn();
        }
    }
}