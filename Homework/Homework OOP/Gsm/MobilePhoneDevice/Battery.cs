namespace MobilePhoneDevice
{
    using System;

    public class Battery
    {
        private int batteryCapacity;
        private double hoursIdle;
        private double hoursTalk;
        private bool idleIsSet;
        private bool talkIsSet;

        public Battery(BatteryType batteryType, int batteryCapacity)
        {
            this.Type = batteryType;
            this.Capacity = batteryCapacity;
            this.idleIsSet = false;
            this.talkIsSet = false;
        }

        public Battery(BatteryType batteryType, int batteryCapacity, double batteryHoursIdle, double batteryHoursTalk)
            : this(batteryType, batteryCapacity)
        {
            this.HoursIdle = batteryHoursIdle;
            this.HoursTalk = batteryHoursTalk;
            this.idleIsSet = true;
            this.talkIsSet = true;
        }

        public BatteryType Type { get; private set; }

        public int Capacity 
        {
            get
            {
                if (batteryCapacity <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid value!");
                }

                return this.batteryCapacity;
            }
            private set
            {
                 this.batteryCapacity = value;
            }
                }

        public double HoursIdle 
        {
            get
            {
                if (!idleIsSet)
                {
                    throw new ArgumentNullException("No information");
                }

                return this.hoursIdle;
            }
            private set
            {
                this.hoursIdle = value;
            }
        }

        public double HoursTalk 
        {
           get
            {
                if (!talkIsSet)
                {
                    throw new ArgumentNullException("No information");
                }

                return this.hoursTalk;
            }
            private set
            {
                this.hoursTalk = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Battery:\nBattery type {0,10}\nBattery capacity {1,6} mAh\nTalk time {2,13} h\nStand-by {3,14} h",
                this.Type, this.Capacity,       
                this.talkIsSet ? String.Format("{0}", this.HoursTalk) : String.Empty,
                this.idleIsSet ? String.Format("{0}", this.HoursIdle) : String.Empty);  
        }
    }
}