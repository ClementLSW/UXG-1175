using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Achievement
{
    private int walkedLeft = 0;
    private int walkedRight = 0;
    private int walkedUp = 0;
    private int walkedDown = 0;
    private bool died = false;
    private const int WALK_TIMES = 3;

    public void Notify(string msg)
    {
        switch(msg)
        {
            case "Player Left":
                DoAchievementLeft();
                break;
            case "Player Right":
                DoAchievementRight();
                break;
            case "Player Up":
                DoAchievementUp();
                break;
            case "Player Down":
                DoAchievementDown();
                break;
            case "Player Died":
                DoAchievementDie();
                break;
            default:
                break;
        }
    }

    public void DoAchievementLeft()
    {
        if (++walkedLeft == WALK_TIMES)
            Console.WriteLine("[Achievement] Walked left {0} times!", WALK_TIMES);
    }

    public void DoAchievementRight()
    {
        if (++walkedRight == WALK_TIMES)
            Console.WriteLine("[Achievement] Walked right {0} times!", WALK_TIMES);
    }

    public void DoAchievementUp()
    {
        if (++walkedUp == WALK_TIMES)
            Console.WriteLine("[Achievement] Walked up {0} times!", WALK_TIMES);
    }

    public void DoAchievementDown()
    {
        if (++walkedDown == WALK_TIMES)
            Console.WriteLine("[Achievement] Walked down {0} times!", WALK_TIMES);
    }

    public void DoAchievementDie()
    {
        if (died == false)
        {
            Console.WriteLine("[Achievement] You died!");
            died = true;
        }
    }
}

