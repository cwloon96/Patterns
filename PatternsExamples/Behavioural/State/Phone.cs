namespace PatternsExamples.Behavioural.State
{
    public class Phone
    {
        public IPhoneState hasBattery { get; private set; }
        public IPhoneState noBattery { get; private set; }

        public IPhoneState phoneState { get; private set; }

        public int remainingBattery { get; set; } = 50;

        public Phone()
        {
            hasBattery = new HasBattery(this);
            noBattery = new NoBattery(this);

            phoneState = remainingBattery > 0 ? hasBattery : noBattery;
        }

        public void UpdatePhoneState(IPhoneState state)
        {
            phoneState = state;
        }

        public int Charge()
        {
            phoneState.Charging();
            return remainingBattery;
        }

        public int Use()
        {
            phoneState.Using();
            return remainingBattery;
        }
    }
}