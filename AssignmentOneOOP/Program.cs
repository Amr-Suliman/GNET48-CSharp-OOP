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

        }
    }
}
