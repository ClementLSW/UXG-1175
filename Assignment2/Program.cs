using System;

class Program
{
    static void PrintBuilders(IStringBuilder[] builders) {
        for(int i = 0; i < builders.Length; ++i) {
            Console.WriteLine("builder #{0}: {1}", i, builders[i].String);
        }
    }

    // Entry point of the program!
    static void Main(string[] args)
    {
        IStringBuilder[] builders = new IStringBuilder[3];
        builders[0] = new NormalStringBuilder();
        builders[1] = new SmolStringBuilder();
        builders[2] = new BeegStringBuilder();

        // Test if append actually works
        foreach(IStringBuilder b in builders) {
            b.Append("Hello World. ");
        }
        PrintBuilders(builders); 
        
        foreach(IStringBuilder b in builders) {
            b.Append("The weather is clear today!");
        }
        PrintBuilders(builders); 
        
        // Test clear
        foreach(IStringBuilder b in builders) {
            b.Clear();
        }

        foreach(IStringBuilder b in builders) {
            b.Append("Goodbye World");
        }
        PrintBuilders(builders); 


    }
}

