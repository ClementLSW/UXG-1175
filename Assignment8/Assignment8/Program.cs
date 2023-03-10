using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        // Create our objects here
        Game game = new Game();
        Player player = new Player();
        NearbyNPC npc = new NearbyNPC();
        Achievement achievement = new Achievement();

        // This is old code that we want to refactor.
        // It is left here for student's reference.
        //
        // Register the Observers to the Subject (Player)
        //
        // player.RegisterObserver(game);  
        // player.RegisterObserver(npc);
        // player.RegisterObserver(achievement);

        // This is new code that we want to refactor to.
        // 
        // Here we will register the appropriate Observer's function to the appropriate Player's events
        //
        player.EventWalkLeft += achievement.DoAchievementLeft;
        player.EventWalkRight += achievement.DoAchievementRight;
        player.EventWalkUp += achievement.DoAchievementUp;
        player.EventWalkDown += achievement.DoAchievementDown;
        player.EventDied += achievement.DoAchievementDie;
        player.EventDied += game.GameOver;
        player.EventDied += npc.DoPlayerDead;

        // Emulate commands
        player.MoveLeft();
        player.MoveLeft();
        player.MoveLeft();
        player.MoveLeft();
        player.MoveLeft();
        
        player.MoveRight();
        player.MoveRight();
        player.MoveRight();
        player.MoveRight();
        player.MoveRight();
        
        player.MoveUp();
        player.MoveUp();
        player.MoveUp();
        player.MoveUp();
        player.MoveUp();
        
        player.MoveDown();
        player.MoveDown();
        player.MoveDown();
        player.MoveDown();
        player.MoveDown();
        
        player.TakeDamage();
        player.TakeDamage();
        player.TakeDamage();
        
    }
}

