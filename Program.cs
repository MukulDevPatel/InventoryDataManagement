namespace InventoryDataManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Inventory Data Management");
            string path = @"D:\BridgeLabz Second batch\DEMO-\InventoryDataManagement\InventoryData.json";
            ReadTheData readTheData = new ReadTheData();
            InventoryDetails data = readTheData.Read(path);
            Console.WriteLine("Type Of Rices ");
            Console.WriteLine("=================================================");
            for (int i = 0; i < data.typeOfRice.Count; i++)
            {
                Console.WriteLine(data.typeOfRice[i].Name);
                Console.WriteLine(data.typeOfRice[i].Weight);
                Console.WriteLine(data.typeOfRice[i].Price);
                int invebtoryprice = data.typeOfRice[i].Weight * data.typeOfRice[i].Price;

                Console.WriteLine("The price of {0} for {1}kg is {2}Rs. ", data.typeOfRice[i].Name, data.typeOfRice[i].Weight, invebtoryprice);
                Console.WriteLine("-------------------------------------------------");
            }
            Console.WriteLine("#####################################################");
            Console.WriteLine("Type Of Wheats ");
            Console.WriteLine("=================================================");
            for (int i = 0; i < data.typeOfWheats.Count; i++)
            {
                Console.WriteLine(data.typeOfWheats[i].Name);
                Console.WriteLine(data.typeOfWheats[i].Weight);
                Console.WriteLine(data.typeOfWheats[i].Price);
                int invebtoryprice = data.typeOfWheats[i].Weight * data.typeOfWheats[i].Price;

                Console.WriteLine("The price of {0} for {1}kg is {2}Rs. ", data.typeOfWheats[i].Name, data.typeOfWheats[i].Weight, invebtoryprice);
                Console.WriteLine("-------------------------------------------------");
            }
            Console.WriteLine("#####################################################");
            Console.WriteLine("Type Of Pulses ");
            Console.WriteLine("=================================================");
            for (int i = 0; i < data.typeOfPulses.Count; i++)
            {
                Console.WriteLine(data.typeOfPulses[i].Name);
                Console.WriteLine(data.typeOfPulses[i].Weight);
                Console.WriteLine(data.typeOfPulses[i].Price);
                int invebtoryprice = data.typeOfPulses[i].Weight * data.typeOfPulses[i].Price;
                Console.WriteLine("The price of {0} for {1}kg is {2}Rs. ", data.typeOfPulses[i].Name, data.typeOfPulses[i].Weight, invebtoryprice);
                Console.WriteLine("-------------------------------------------------");
            }
        }
    }
}
