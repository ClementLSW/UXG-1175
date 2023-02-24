using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


partial class Program 
{
    static void WriteInventory(List<Item> inventory, string filename) 
    {
        StreamWriter sw;
        sw = File.CreateText(filename);


        foreach (Item item in inventory)
        {
            string str = item.name + "," + item.amount.ToString() + "," + item.branchID.ToString() + "\n";
            sw.Write(str);
        }

       sw.Close();
    }
    
    
    static List<Item> ReadInventory(string filename) {
        StreamReader sr;
        sr = File.OpenText(filename);

        List<Item> itemList = new List<Item>();

        while (true)
        {
            string input = sr.ReadLine();
            if (input == null)
            {
                break;
            }
            else
            {
                string[] tokens = input.Split(",", 3);
                Item item = new Item();
                item.name = tokens[0];
                item.amount = int.Parse(tokens[1]);
                item.branchID = int.Parse(tokens[2]);

                itemList.Add(item);
            }
        }

        sr.Close();

        return itemList;
    }
    
}

