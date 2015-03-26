namespace MobilePhoneDevice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Gsm
    {
        private static readonly Gsm iPhone4S = new Gsm("Apple", "IPhone 4s", "Pesho", 800,
                                               new Battery(BatteryType.LiIon, 1400),
                                               new Display(1800, 4.4));
        private string model;
        private string manufacturer;
        private string owner;
        private Battery battery;
        private Display display;
        private bool ownerIsSet;
        private bool batteryIsSet;
        private bool displayIsSet;
        private int price;
        private List<Call> callHistory;

        public Gsm(string gsmManufacturer, string gsmModel)
        {
            this.Manufacturer = gsmManufacturer;
            this.Model = gsmModel;
            this.CallHistory = new List<Call>();
            this.ownerIsSet = false;
            this.batteryIsSet = false;
            this.displayIsSet = false;
        }

        public Gsm(string gsmManufacturer, string gsmModel, string gsmOwner, int gsmPrice, Battery gsmBattery, Display gsmDisplay)
            : this(gsmManufacturer, gsmModel)
        {
            this.Owner = gsmOwner;
            this.Price = gsmPrice;
            this.Battery = gsmBattery;
            this.Display = gsmDisplay;
            this.displayIsSet = true;
            this.batteryIsSet = true;
            this.ownerIsSet = true;
        }

        public static Gsm IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid name Manufacturer!");
                }

                this.manufacturer = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid model name!");
                }

                this.model = value;
            }
        }

        public string Owner
        {
            get
            {
                if (String.IsNullOrWhiteSpace(this.owner))
                {
                    throw new ArgumentException("No information");
                }

                return this.owner;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid name!");
                }

                this.owner = value;
            }
        }

        public int Price 
        {
            get
            {
                if (price <= 0)
                {
                    throw new ArgumentOutOfRangeException("This value can not be negative!"); 
                }

                return this.price;
            }
            private set
            {
                this.price = value;
            }
        }

        public Battery Battery
        {
            get
            {
                if (this.battery.Equals(null))
                {
                    throw new ArgumentException("No information");
                }

                return this.battery;
            }
            private set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                if (this.display.Equals(null))
                {
                    throw new ArgumentException("No information");
                }

                return this.display;
            }
            private set
            {
                this.display = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return new List<Call>(this.callHistory);
            }
            private set
            {
                this.callHistory = value;
            }
        }

        public void AddCallHistory(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void DeleteCallHistory(Call call)
        {
            this.CallHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public decimal CalculateTotalPrice(List<Call> CallHistory, decimal pricePerMinute)
        {
            decimal result = 0;
            decimal totalDuration = CallHistory.Select(x => x.Duration).Sum();
            result = (totalDuration / 60.0M) * pricePerMinute;
            return result;
        }

        public override string ToString()
        {
            return String.Format("Manufacturer {0,10}\nModel {1,17}\nOwner {2,17}\nPrice {3,17} lv\n\n{4}\n\n{5}",
                this.Manufacturer, this.Model, 
                this.ownerIsSet ? this.Owner : String.Empty, 
                this.Price,
                this.batteryIsSet ? String.Format("{0}", this.Battery.ToString()) : String.Empty,
                this.displayIsSet ? String.Format("{0}", this.Display.ToString()) : String.Empty);
        }
    }
}
