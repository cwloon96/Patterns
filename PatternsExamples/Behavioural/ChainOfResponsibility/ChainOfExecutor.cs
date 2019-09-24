namespace PatternsExamples.Behavioural.ChainOfResponsibility
{
    public class ChainOfExecutor
    {
        public static Executor GetExecutorChain()
        {
            var junior = new JuniorDeveloper();
            var senior = new SeniorDeveloper();
            var lead = new TeamLead();

            junior.SetNextExecutor(senior);
            senior.SetNextExecutor(lead);

            return junior;
        }
    }
}