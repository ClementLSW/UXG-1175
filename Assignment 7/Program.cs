using System;


class Program {
    static void PrintPlayerPosition(Player player) {
        Console.WriteLine("{0}: {1}, {2}", player.Name, player.X, player.Y);
    }


    static void Main() {
        Player p1 = new Player("Mario");
        Player p2 = new Player("Luigi");
        InputHandler inputHandler = new InputHandler();

        // Test p1!
        inputHandler.SetPlayer(p1);
        Console.WriteLine("Moving p1 up");
        inputHandler.Do("up");
        PrintPlayerPosition(p1);
        
        Console.WriteLine("Moving p1 down");
        inputHandler.Do("down");
        PrintPlayerPosition(p1);
        

        Console.WriteLine("Moving p1 left");
        inputHandler.Do("left");
        PrintPlayerPosition(p1);

        Console.WriteLine("Moving p1 right");
        inputHandler.Do("right");
        PrintPlayerPosition(p1);

        for (int i = 0; i < 4; ++i ){ 
            Console.WriteLine("Undoing previous p1 action");
            inputHandler.Do("undo");
            PrintPlayerPosition(p1);
        }

        // Test p2
        inputHandler.SetPlayer(p2);
        for (int i = 0; i < 2; ++i) {
            Console.WriteLine("Moving p2 up");
            inputHandler.Do("up");
            PrintPlayerPosition(p2);
        }

        Console.WriteLine("Undoing previous p2 action");
        inputHandler.Do("undo");
        PrintPlayerPosition(p2);

        Console.WriteLine("Undoing previous p2 action");
        inputHandler.Do("undo");
        PrintPlayerPosition(p2);
      
        for (int i = 0; i < 3; ++i) { 
            Console.WriteLine("Moving p2 down");
            inputHandler.Do("down");
            PrintPlayerPosition(p2);

            Console.WriteLine("Moving p2 left");
            inputHandler.Do("left");
            PrintPlayerPosition(p2);
        }

        Console.WriteLine("Undoing previous p2 action");
        inputHandler.Do("undo");
        PrintPlayerPosition(p2);

        for (int i = 0; i < 2; ++i ) { 

            Console.WriteLine("Moving p2 right");
            inputHandler.Do("right");
            PrintPlayerPosition(p2);
           
            Console.WriteLine("Moving p2 right");
            inputHandler.Do("right");
            PrintPlayerPosition(p2);

            Console.WriteLine("Moving p2 left");
            inputHandler.Do("left");
            PrintPlayerPosition(p2);

            Console.WriteLine("Moving p2 up");
            inputHandler.Do("up");
            PrintPlayerPosition(p2);
        }


        for (int i = 0; i < 3; ++i) {
            Console.WriteLine("Undoing previous p2 action");
            inputHandler.Do("undo");
            PrintPlayerPosition(p2);
        }
        

    }
}
