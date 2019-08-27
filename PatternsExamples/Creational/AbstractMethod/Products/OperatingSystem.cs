namespace PatternsExamples.Creational.AbstractMethod.Products
{
    public enum OperatingSystemType
    {
        Windows,
        Linux,
        MacOS
    }

    public interface IOperatingSystem
    {
        OperatingSystemType GetOperatingSystem();
    }

    public class Windows : IOperatingSystem
    {
        public OperatingSystemType GetOperatingSystem()
        {
            return OperatingSystemType.Windows;
        }
    }

    public class MacOS : IOperatingSystem
    {
        public OperatingSystemType GetOperatingSystem()
        {
            return OperatingSystemType.MacOS;
        }
    }

    public class Linux : IOperatingSystem
    {
        public OperatingSystemType GetOperatingSystem()
        {
            return OperatingSystemType.Linux;
        }
    }
}