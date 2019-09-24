namespace PatternsExamples.Behavioural.ChainOfResponsibility
{
    public abstract class Executor
    {
        public const int AddData = 1;
        public const int UpdateData = 2;
        public const int DeleteData = 3;
        public const int DropDatabase = 4;

        protected Executor NextExecutor = null;

        public void SetNextExecutor(Executor executor) => NextExecutor = executor;

        public abstract string HandleRequest(string data, int action);
    }

    public class JuniorDeveloper : Executor
    {
        public override string HandleRequest(string data, int action)
        {
            if (action <= AddData)
                return $"{data} is added by {this.GetType().Name}";
            else if (NextExecutor != null)
                return NextExecutor.HandleRequest(data, action);

            return "No Action Performed";
        }
    }

    public class SeniorDeveloper : Executor
    {
        public override string HandleRequest(string data, int action)
        {
            if (action <= UpdateData)
                return $"{data} is updated by {this.GetType().Name}";
            else if (NextExecutor != null)
                return NextExecutor.HandleRequest(data, action);

            return "No Action Performed";
        }
    }

    public class TeamLead : Executor
    {
        public override string HandleRequest(string data, int action)
        {
            if (action <= DeleteData)
                return $"{data} is deleted by {this.GetType().Name}";
            else if (NextExecutor != null)
                return NextExecutor.HandleRequest(data, action);

            return "No Action Performed";
        }
    }
}