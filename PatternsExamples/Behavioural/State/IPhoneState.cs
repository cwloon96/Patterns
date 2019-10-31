using System;

namespace PatternsExamples.Behavioural.State
{
    public interface IPhoneState
    {
        void Charging();
        void Using();
    }

    public class HasBattery : IPhoneState
    {
        private Phone currentPhone;

        public HasBattery(Phone phone)
        {
            currentPhone = phone;
        }

        public void Charging()
        {
            var newBatteryAmount = currentPhone.remainingBattery + 10;
            if (newBatteryAmount >= 100)
            {
                currentPhone.remainingBattery = 100;
                Console.WriteLine("Phone is fully charged. Please stop charging.");
            }
            else
                currentPhone.remainingBattery = newBatteryAmount;
            currentPhone.UpdatePhoneState(currentPhone.hasBattery);
        }

        public void Using()
        {
            var newBatteryAmount = currentPhone.remainingBattery - 10;
            if (newBatteryAmount <= 0)
            {
                currentPhone.remainingBattery = 0;
                currentPhone.UpdatePhoneState(currentPhone.noBattery);
            }
            else
                currentPhone.remainingBattery = newBatteryAmount;
        }
    }

    public class NoBattery : IPhoneState
    {
        private Phone currentPhone;

        public NoBattery(Phone phone)
        {
            currentPhone = phone;
        }

        public void Charging()
        {
            currentPhone.remainingBattery += 10;
            currentPhone.UpdatePhoneState(currentPhone.hasBattery);
        }

        public void Using()
        {
            Console.WriteLine("No more battery, please charge.");
        }
    }
}