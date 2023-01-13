using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    // Entry point of the program
    static void Main()
    {
        MonoBehaviourManager mgr = new MonoBehaviourManager();
        mgr.Add(new ScriptDoor());
        mgr.Add(new ScriptEnemy());
        mgr.Add(new ScriptPlayer());
        
        mgr.Start();
        for(int i = 0; i < 3; ++i) {
            mgr.Update();
        }
    }
}

