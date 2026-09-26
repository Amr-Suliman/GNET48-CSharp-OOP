namespace AssignmentOneOOP
{
    internal struct Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public string TrackingCode
        {
            get
            {
                return trackingCode;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine($"Invalid tracking code: {trackingCode}");
                    return;
                }
                trackingCode = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine($"Invalid description: {value}");
                    return;
                }
                description = value;
            }
        }

        public decimal Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Invalid weight: {value}");
                    return;
                }
                weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get
            {
                return deliveryFee;
            }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Invalid delivery fee: {value}");
                    return;
                }
                deliveryFee = value;
            }
        }

        public DeliveryAddress Destination { get; set; }

        public decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5);
            }
        }

        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress();
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if(newFee>0)
            {
                DeliveryFee = newFee;
            }
            else
            {
                Console.WriteLine($"Invalid delivery fee: {newFee}");
            }
        }

        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fee: ${DeliveryFee}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: ${EstimatedCost}");
        }
    }

}
