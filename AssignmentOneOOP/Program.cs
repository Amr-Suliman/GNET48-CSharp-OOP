namespace AssignmentOneOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Part 1 : Theoretical Questions

            #region Question 1

            // a)
            // DeliveryAddress is a struct, so it is a Value Type.
            // When it is copied, a separate copy of its value is created.
            // Modifying the copy does not affect the original.

            // b)
            // Customer is a class, so it is a Reference Type.
            // When it is copied, both variables refer to the same object.
            // Modifying the object through one variable affects the other variable.

            #endregion

            #region Question 2

            // a)
            // Problems from an encapsulation perspective:
            // 1] No validation.
            // 2] The data can be modified directly from outside.
            // 3] We cannot control read/write access, such as read-only or write-only.

            // b)
            // Private fields hide the data from outside access.
            // Public properties allow controlled access to the data
            // and allow us to add validation when setting values.

            #endregion

            #endregion

            #region Part 2 : Practical Questions
            //Smart Delivery Management System

            #region Practical 1

            //DeliveryAddress address1 = new DeliveryAddress("Zagazig", "El-Galaa", 15);

            //DeliveryAddress address2 = address1;

            //address2.city = "Cairo";

            //Console.WriteLine($"Address 1: {address1.GetFullAddress()}");
            //Console.WriteLine($"Address 2: {address2.GetFullAddress()}");

            #endregion

            #endregion

            #region Practical 2

            //Test Constructor 1
            //Shipment shipment1 = new Shipment("TR001");

            //shipment1.PrintShipment();

            //Console.WriteLine("----------------------------");

            //Test Constructor 2
            //DeliveryAddress address = new DeliveryAddress(
            //    "Zagazig",
            //    "El-Galaa",
            //    15
            //);

            //Shipment shipment2 = new Shipment(
            //    "TR002",
            //    "Laptop",
            //    10,
            //    100,
            //    address
            //);

            //shipment2.PrintShipment();

            //Console.WriteLine("----------------------------");

            //Test UpdateDeliveryFee with valid value
            //shipment2.UpdateDeliveryFee(200);

            //shipment2.PrintShipment();

            //Console.WriteLine("----------------------------");

            //Test UpdateDeliveryFee with invalid value
            //shipment2.UpdateDeliveryFee(-50);

            //shipment2.PrintShipment();

            #endregion

            #region Practical 3

            // Create DeliveryCenter
            DeliveryCenter center = new DeliveryCenter();

            #region Shipment 1

            Console.WriteLine("Enter Shipment 1 Data:");

            Console.Write("Tracking Code: ");
            string trackingCode1 = Console.ReadLine();

            Console.Write("Description: ");
            string description1 = Console.ReadLine();

            Console.Write("Weight: ");
            decimal weight1 = decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal deliveryFee1 = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city1 = Console.ReadLine();

            Console.Write("Street: ");
            string street1 = Console.ReadLine();

            Console.Write("Building Number: ");
            int buildingNumber1 = int.Parse(Console.ReadLine());

            DeliveryAddress address1 = new DeliveryAddress(
                city1,
                street1,
                buildingNumber1
            );

            Shipment shipment1 = new Shipment(
                trackingCode1,
                description1,
                weight1,
                deliveryFee1,
                address1
            );

            center.AddShipment(shipment1);

            #endregion

            #region Shipment 2

            Console.WriteLine("\nEnter Shipment 2 Data:");

            Console.Write("Tracking Code: ");
            string trackingCode2 = Console.ReadLine();

            Console.Write("Description: ");
            string description2 = Console.ReadLine();

            Console.Write("Weight: ");
            decimal weight2 = decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal deliveryFee2 = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city2 = Console.ReadLine();

            Console.Write("Street: ");
            string street2 = Console.ReadLine();

            Console.Write("Building Number: ");
            int buildingNumber2 = int.Parse(Console.ReadLine());

            DeliveryAddress address2 = new DeliveryAddress(
                city2,
                street2,
                buildingNumber2
            );

            Shipment shipment2 = new Shipment(
                trackingCode2,
                description2,
                weight2,
                deliveryFee2,
                address2
            );

            center.AddShipment(shipment2);

            #endregion

            #region Shipment 3

            Console.WriteLine("\nEnter Shipment 3 Data:");

            Console.Write("Tracking Code: ");
            string trackingCode3 = Console.ReadLine();

            Console.Write("Description: ");
            string description3 = Console.ReadLine();

            Console.Write("Weight: ");
            decimal weight3 = decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal deliveryFee3 = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city3 = Console.ReadLine();

            Console.Write("Street: ");
            string street3 = Console.ReadLine();

            Console.Write("Building Number: ");
            int buildingNumber3 = int.Parse(Console.ReadLine());

            DeliveryAddress address3 = new DeliveryAddress(
                city3,
                street3,
                buildingNumber3
            );

            Shipment shipment3 = new Shipment(
                trackingCode3,
                description3,
                weight3,
                deliveryFee3,
                address3
            );

            center.AddShipment(shipment3);

            #endregion

            #region Print Three Shipments

            Console.WriteLine("\n========== Shipments ==========");

            Console.WriteLine("\nShipment 1:");
            center[0].PrintShipment();

            Console.WriteLine("\nShipment 2:");
            center[1].PrintShipment();

            Console.WriteLine("\nShipment 3:");
            center[2].PrintShipment();

            #endregion

            #region Search By Tracking Code

            Console.Write("\nEnter Tracking Code to search: ");
            string searchTrackingCode = Console.ReadLine();

            Shipment foundShipment = center[searchTrackingCode];

            if (string.IsNullOrWhiteSpace(foundShipment.TrackingCode))
            {
                Console.WriteLine("Shipment not found.");
            }
            else
            {
                Console.WriteLine("\n========== Shipment Found ==========");
                foundShipment.PrintShipment();
            }

            #endregion

            #region DeliveryAddress Copy Test

            Console.WriteLine("\n========== DeliveryAddress Copy Test ==========");

            DeliveryAddress originalAddress = new DeliveryAddress(
                "Zagazig",
                "El-Galaa",
                15
            );

            DeliveryAddress copiedAddress = originalAddress;

            copiedAddress.city = "Cairo";

            Console.WriteLine($"Original Address: {originalAddress.GetFullAddress()}");
            Console.WriteLine($"Copied Address: {copiedAddress.GetFullAddress()}");

            #endregion

            #endregion

        }
    }
}
