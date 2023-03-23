using System;

// The player class
// You should not need to modify this!
class Player
{
    private int x;
    private int y;
    private string name;

    public Player(string name) {
        this.x = 0;
        this.y = 0;
        this.name = name;
    }
    
    public string Name { get { return name; } }
    public int X { get { return x; } }
    public int Y { get { return y; } }

    public void MoveLeft()
    {
        --x;
    }

    public void MoveRight()
    {
        ++x;
    }

    public void MoveUp()
    {
        ++y;
    }

    public void MoveDown()
    {
        --y;
    }
}
