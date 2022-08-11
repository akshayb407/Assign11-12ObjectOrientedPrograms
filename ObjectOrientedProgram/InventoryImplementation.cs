using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgram
{
    public class InventoryImplementation
    {
        private static string filepath = "H:/Json.json";
        public void Add()
        {
            string jfile = File.ReadAllText(filepath);
            Inventory iv;
            iv = (Inventory)JsonConvert.DeserializeObject<Inventory>(jfile);
            if (iv == null)
            {
                iv = new Inventory();
            }
            int sum = 0;
            if (iv != null)
            {
                sum = iv.Sum;
            }
            Seeds item = new Seeds();
            Console.WriteLine("Enter 1--> for Rice\tEnter 2--> for Pulses\tEnter 3--> for Wheats\t");

            int entered = int.Parse(Console.ReadLine());

            Console.Write("Enter the name of the Product: ");
            item.Brand = Console.ReadLine();
            Console.Write("Enter the Price per Kg: ");
            item.PricePerkg = int.Parse(Console.ReadLine());
            Console.Write("Enter the Weight: ");
            item.Weight = int.Parse(Console.ReadLine());
            item.TotalPrice = item.PricePerkg * item.Weight;
            if (iv != null)
            {
                sum += item.TotalPrice;
            }
            else
            {
                sum = item.TotalPrice;
            }

            ///running a  based on user
            switch (entered)
            {
                case 1:
                    if (iv.Rice == null)
                    {
                        iv.Rice = new List<Seeds>();
                    }

                    iv.Rice.Add(item);
                    break;
                case 2:
                    if (iv.Pulses == null)
                    {
                        iv.Pulses = new List<Seeds>();
                    }

                    iv.Pulses.Add(item);
                    break;
                case 3:
                    if (iv.Wheats == null)
                    {
                        iv.Wheats = new List<Seeds>();
                    }

                    iv.Wheats.Add(item);
                    break;
                default:
                    Console.WriteLine("Invalid Entry try Again...");
                    break;
            }

            iv.Sum = sum;

            using (StreamWriter writer = File.CreateText(filepath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, iv);
                Console.WriteLine("new Product Added to the Inventory");
            }
        }

        public void Delete()
        {
            Console.WriteLine("Are you sure you Want to delete...items from Inventory: ");

            string jfile = File.ReadAllText(filepath);

            Inventory iv = JsonConvert.DeserializeObject<Inventory>(jfile);

            Console.WriteLine("Enter 1--> for Rice\tEnter 2--> for Pulses\tEnter 3--> for Wheats\t");

            int entered = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name of the brand");

            string brand = Console.ReadLine();

            int sum = iv.Sum;

            switch (entered)
            {
                case 1:
                    foreach (Seeds s in iv.Rice)
                    {
                        if (s.Brand.Equals(brand))
                        {
                            sum -= s.TotalPrice;
                            iv.Rice.Remove(s);
                            break;
                        }
                    }

                    break;

                case 2:
                    foreach (Seeds s in iv.Pulses)
                    {
                        if (s.Brand.Equals(brand))
                        {
                            sum -= s.TotalPrice;
                            iv.Pulses.Remove(s);
                            break;
                        }
                    }

                    break;

                case 3:
                    foreach (Seeds s in iv.Wheats)
                    {
                        if (s.Brand.Equals(brand))
                        {
                            sum -= s.TotalPrice;
                            iv.Wheats.Remove(s);
                            break;
                        }
                    }

                    break;
                default:
                    Console.WriteLine("there is no such brand available in Inventory");
                    break;
            }

            iv.Sum = sum;

            using (StreamWriter stream = File.CreateText(filepath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(stream, iv);
            }
        }

        public void DisplayOutput()
        {
            string jfile = File.ReadAllText(filepath);

            if (jfile.Length < 1)
            {
                Console.WriteLine("Inventory is Empty Please add the contents");
                return;
            }

            Inventory iv = JsonConvert.DeserializeObject<Inventory>(jfile);

            Console.WriteLine("Enter 1 to show the total Enventory Cost\n Enter 2 to Display json string");
            int entered = int.Parse(Console.ReadLine());

            switch (entered)
            {
                case 1:
                    Console.WriteLine("the total inventory cost is : " + iv.Sum);
                    break;
                case 2:
                    Console.WriteLine(jfile);
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }
    }
}
