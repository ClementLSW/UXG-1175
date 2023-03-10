using System;


class NearbyNPC
{
    bool m_bSawPlayerDie = false;

    public void Notify(string msg)
    {
        switch (msg)
        {
            case "Player Dead":
                DoPlayerDead();
                break;
            default:
                break;
        }
    }

    public void DoPlayerDead()
    {
        if (!m_bSawPlayerDie) { 
            Console.WriteLine("[NPC] Omg! Player died!!?");
            m_bSawPlayerDie = true;
        }

    }
}

