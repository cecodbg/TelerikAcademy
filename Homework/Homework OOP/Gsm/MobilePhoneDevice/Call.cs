namespace MobilePhoneDevice
{
    using System;

    public class Call
    {
        public Call(DateTime dateTime, string phoneNumber, int duration)
        {
            this.DateTime = dateTime;
            this.PhoneNumber = phoneNumber;
            this.Duration = duration;
        }

        public DateTime DateTime { get; private set; }

        public string PhoneNumber { get; private set; }

        public int Duration { get; private set; }

        public override string ToString()
        {
            return String.Format("Date {0,40}\nDialled phone number {1,15}\nDuration {2,20} seconds",
                this.DateTime.ToString("dd.MM.yyyy hh:mm:ss"),
                this.PhoneNumber, this.Duration);
        }
    }
}