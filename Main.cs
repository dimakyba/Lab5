using System.Text;

namespace Lab5
{
  public partial class Program
  {
    static void Main()
    {
      Console.OutputEncoding = Encoding.Unicode;
      Console.InputEncoding = Encoding.Unicode;

      bool get_out_out = false, get_out, txt, json, xml;
      while (!get_out_out) {
        Console.WriteLine("[0] Exit");
        Console.WriteLine("[1] Order");
        Console.WriteLine("[2] Train");
        Console.Write("\nChoose an option: ");
        
        int objectType = int.Parse(Console.ReadLine()), choice;
        switch (objectType) {
          case 1:
            get_out = false;
            while (!get_out)
            {
              txt = File.Exists("Orders.txt");
              json = File.Exists("Orders.json");
              xml = File.Exists("Orders.xml");
              Console.WriteLine("[0] Exit");
              Console.WriteLine("[1] Write data to TXT file");
              Console.WriteLine("[2] Serialize data to JSON file");
              Console.WriteLine("[3] Serialize data to XML file");
              if (txt)
                Console.WriteLine("[4] Read data data TXT file");
              if (json)
                Console.WriteLine("[5] Deserialize data from JSON file");
              if (xml)
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
                  if (txt)
                    ReadFromTxt<Order>("Orders.txt");
                  else
                    Console.WriteLine("Generate a .txt file first");
                  break;
                case 5:
                  if (json)
                    DeserializeFromJson<Order>("Orders.json");
                  else
                    Console.WriteLine("Generate a .json file first");
                  break;
                case 6:
                  if (xml)
                    DeserializeFromXml<Order>("Orders.xml");
                  else
                    Console.WriteLine("Generate a .xml file first");
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
              txt = File.Exists("Orders.txt");
              json = File.Exists("Orders.json");
              xml = File.Exists("Orders.xml");
              Console.WriteLine("[0] Exit");
              Console.WriteLine("[1] Write data to TXT file");
              Console.WriteLine("[2] Serialize data to JSON file");
              Console.WriteLine("[3] Serialize data to XML file");
              if (txt)
                Console.WriteLine("[4] Read data data TXT file");
              if (json)
                Console.WriteLine("[5] Deserialize data from JSON file");
              if (xml)
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
                  if (txt)
                    ReadFromTxt<Train>("Trains.txt");
                  else
                    Console.WriteLine("Generate a .txt file first");
                  break;
                case 5:
                  if (json)
                    DeserializeFromJson<Train>("Trains.json");
                  else
                    Console.WriteLine("Generate a .json file first");
                  break;
                case 6:
                  if (xml)
                    DeserializeFromXml<Train>("Trains.xml");
                  else
                    Console.WriteLine("Generate a .xnl file first");
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
