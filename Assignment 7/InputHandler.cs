using System;
using System.Collections.Generic;

// The Caller class!
// It can also be be Receiver!
// This is essentially a 'Player Controller' class
class InputHandler {


    // This is a collection used to store commands that were given to the player
    // so that we can undo actions.
    Stack<Command> commandStack = new Stack<Command>();

    // Commands
    Command commandLeft;
    Command commandRight;
    Command commandUp;
    Command commandDown;

    public void SetPlayer(Player player) {
        commandUp = new CommandMoveUp(player);
        commandDown = new CommandMoveDown(player);
        commandLeft = new CommandMoveLeft(player);
        commandRight = new CommandMoveRight(player);
    }

    public void Do(string commandStr) {
        switch (commandStr) {
            case "up":
                // Call the appropriate command
                // and add it to the commadStack
                commandUp.Execute();
                commandStack.Push(commandUp);
                break;
            case "down":
                // Call the appropriate command
                // and add it to the commadStack
                commandDown.Execute();
                commandStack.Push(commandDown);
                break;
            case "left":
                // Call the appropriate command
                // and add it to the commadStack
                commandLeft.Execute();
                commandStack.Push(commandLeft);
                break;
            case "right":
                // Call the appropriate command
                // and add it to the commadStack
                commandRight.Execute();
                commandStack.Push(commandRight);
                break;
            case "undo":
                // Here we will get the latest command that was pushed and call the Undo function which
                // will handle all logic for undoing commands
                if (commandStack.Count > 0) {
                    // Get the command at the top of the stack, remove it, and call its Undo() function
                    // Hint: Use the Pop() function on commandStack
                    // https://docs.microsoft.com/en-us/dotnet/api/system.collections.stack.pop?view=netframework-4.7.2
                    commandStack.Pop().Undo();
                }
                break;
        }
    }
}
