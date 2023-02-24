using System;
using System.IO;
using System.Collections.Generic;


class Item {
  	public string name;       // name of the item
    public int amount;        // amount of such item
    public int branchID;     // ID of the company branch. 
  
    public void Print() {
        Console.WriteLine("{0},{1},{2}", name, amount, branchID); 
    }
};

partial class Program
{
    static void PrintFileContents(string filename) {
        Console.WriteLine("--- Begin printing {0} contents -----------", filename);
        StreamReader sr = File.OpenText(filename);
        if (sr != null)
        {
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }
        }
        else {
            Console.WriteLine("File {0} does not exist!", filename);
        }
        Console.WriteLine("--- End printing {0} contents -----------", filename);
    }
    
    static void WriteFile(string filename, string content) {
        StreamWriter sw = File.CreateText(filename);
        if (sw != null)
        {
            sw.Write(content);
        }
    }        
    
    static void Add(List<Item> inventory, string name, int amount, int branchID) {
        Console.WriteLine("Adding: {0},{1},{2}", name, amount, branchID);
        Item item = new Item();
        item.name = name;
        item.amount = amount;
        item.branchID = branchID;
        inventory.Add(item);
    }
    
    
    static void TestWriteFile() {
        Console.WriteLine("=== Test WriteInventory ===");
        
        // Normal case 
        List<Item> inventory = new List<Item>();
        Add(inventory, "Fuji Apple", 125, 0);
        Add(inventory, "Orange", 200, 0);
        Add(inventory, "HDMI cables", 3, 0);
        Add(inventory, "Logitech Mouse", 3, 1);
        Add(inventory, "Xbox Controller", 2, 2);
        
        Console.WriteLine("Writing to test_write.csv");
        WriteInventory(inventory, "test_write.csv");
        
        Console.WriteLine();
        
        Add(inventory, "WIFI dongle", 1, 0);
        Add(inventory, "Coffee Cups", 25, 1);
        Console.WriteLine("Writing to test_write_2.csv");
        WriteInventory(inventory, "test_write_2.csv");
   
        Console.WriteLine();
        
        
        Add(inventory, "A4 paper", 25000, 0);
        Console.WriteLine("Writing to test_write_3.csv");
        WriteInventory(inventory, "test_write_3.csv");
        
        Console.WriteLine();
        
        PrintFileContents("test_write.csv");
        PrintFileContents("test_write_2.csv");
        PrintFileContents("test_write_3.csv");
        
    }    
    
    
    static void TestReadFile() {
        Console.WriteLine("=== Test ReadInventory ===");
        {
            StreamWriter sw = File.CreateText("test_read.csv");
            sw.WriteLine("Apple,200,2");
            sw.WriteLine("Orange,200,2");
            sw.WriteLine("A4 Paper,5000,1");
            sw.WriteLine("Mouse,20,1");
            sw.WriteLine("Dell Monitor,20,1");
            sw.WriteLine("Logitech Keyboard,20,1");
            sw.Close();
        }
        
        {
            StreamWriter sw = File.CreateText("test_read_2.csv");
            sw.WriteLine("Sushi,200,2");
            sw.WriteLine("Teriyaki Chicken,200,2");
            sw.WriteLine("Rice Bags,100,2");
            sw.WriteLine("Cash Register,20,0");
            sw.WriteLine("NET Scanner,20,0");
            sw.WriteLine("Clock,10,2");
            sw.WriteLine("Clock,10,0");
            sw.Close();
        }
        
        {
           
            PrintFileContents("test_read.csv");
            Console.WriteLine("Reading file into inventory...");
            List<Item> inventory = ReadInventory("test_read.csv");
            foreach(Item e in inventory) {
                e.Print();
            }
            
        } 
        Console.WriteLine();
        
        {
            PrintFileContents("test_read_2.csv");
            Console.WriteLine("Reading file into inventory...");
            List<Item> inventory = ReadInventory("test_read_2.csv");
            foreach(Item e in inventory) {
                e.Print();
            }
        } 
        
        
    }
    
    
    static void Main(string[] args)
    {

        TestWriteFile();

    	TestReadFile();

    }
}

