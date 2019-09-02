namespace PatternsExamples.Structural.Bridge
{
    public abstract class View
    {
        protected IResource Resource;

        public View(IResource resource)
        {
            Resource = resource;
        }

        public abstract string Show();
    }

    public class LongView : View
    {
        public LongView(IResource resource) : base(resource)
        {
        }

        public override string Show()
        {
            return $"Long View - {Resource.Title()} | {Resource.Snippet()} | {Resource.Url()}";
        }
    }

    public class ShortView : View
    {
        public ShortView(IResource resource) : base(resource)
        {
        }

        public override string Show()
        {
            return $"Short View - {Resource.Title()} | {Resource.Snippet()} | {Resource.Url()}";
        }
    }
} 