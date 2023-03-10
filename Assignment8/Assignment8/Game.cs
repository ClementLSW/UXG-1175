using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Game
{
    bool m_bGameOver = false;
    public bool IsGameOver { get => m_bGameOver; }
  
    public void Notify(string msg)
    {
        switch(msg)
        {
            case "Player Dead":
                GameOver();
                break;
        }
    }

    public void GameOver()
    {
        Console.WriteLine("[Game] Game is over");
        m_bGameOver = true;
    }


}

