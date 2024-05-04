using System.Text;
using lab5_serialization;

namespace Lab5
{
  public partial class Program
  {
    static void Main()
    {
      Console.OutputEncoding = UTF8Encoding.UTF8;    
      bool get_out_out = false, get_out = false;
      while (!get_out_out) {
        Console.Write("\nChoose struct { Order, Train }: ");
        Console.WriteLine("[0] Exit");
        Console.WriteLine("[1] Order");
        Console.WriteLine("[2] Train");
        int objectType = int.Parse(Console.ReadLine()), choice;
        
        switch (objectType) {
          case 1:
            get_out = false;
            while (!get_out)
            {
              Console.WriteLine("[0] Exit");
              Console.WriteLine("[1] Write data to TXT file");
              Console.WriteLine("[2] Serialize data to JSON file");
              Console.WriteLine("[3] Serialize data to XML file");
              if (File.Exists("Orders.txt"))
                Console.WriteLine("[4] Read data data TXT file");
              if (File.Exists("Orders.json"))
                Console.WriteLine("[5] Deserialize data from JSON file");
              if (File.Exists("Orders.xml"))
                Console.WriteLine("[6] Deserialize data from XML file");
              
              Console.Write("\nChoose an option: ");
              choice = int.Parse(Console.ReadLine());

              switch (choice)
              {
                case 1:
                  WriteIntoTxt(EnterObjects<Order>(), "Orders.txt");
                  break;
                case 2:
                  SerializeIntoJson(EnterObjects<Order>(), "Orders.json");
                  break;
                case 3:
                  SerializeIntoXml(EnterObjects<Order>(), "Orders.xml");
                  break;
                case 4:
                  ReadFromTxt<Order>("Orders.txt");
                  break;
                case 5:
                  DeserializeFromJson<Order>("Orders.json");
                  break;
                case 6:
                  DeserializeFromXml<Order>("Orders.xml");
                  break;
                case 0:
                  get_out = true;
                  break;
                default:
                  Console.WriteLine("?");
                  break;
              }
            }
          break;
          case 2:
            get_out = false;
            while (!get_out)
            {
              Console.WriteLine("[0] Exit");
              Console.WriteLine("[1] Write data to TXT file");
              Console.WriteLine("[2] Serialize data to JSON file");
              Console.WriteLine("[3] Serialize data to XML file");
              if (File.Exists("Trains.txt"))
                Console.WriteLine("[4] Read data data TXT file");
              if (File.Exists("Trains.json"))
                Console.WriteLine("[5] Deserialize data from JSON file");
              if (File.Exists("Trains.xml"))
                Console.WriteLine("[6] Deserialize data from XML file");
                
              Console.Write("\nChoose an option: ");
              choice = int.Parse(Console.ReadLine());
              switch (choice)
              {
                case 1:
                  WriteIntoTxt(EnterObjects<Train>(), "Trains.txt");
                  break;
                case 2:
                  SerializeIntoJson(EnterObjects<Train>(), "Trains.json");
                  break;
                case 3:
                  SerializeIntoXml(EnterObjects<Train>(), "Trains.xml");
                  break;
                case 4:
                  ReadFromTxt<Train>("Trains.txt");
                  break;
                case 5:
                  DeserializeFromJson<Train>("Trains.json");
                  break;
                case 6:
                  DeserializeFromXml<Train>("Trains.xml");
                  break;
                case 0:
                  get_out = true;
                  break;
                default:
                  Console.WriteLine("?");
                  break;
              }
            }
          break;
          case 0:
            get_out_out = true;
            break;
        }
      }
    
    }
  }
}
