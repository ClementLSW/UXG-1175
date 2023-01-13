using System;

// A custom script that will be added to MonoBehaviourManager
class ScriptEnemy : MonoBehaviour
{
    public override void Start()
    {
        Console.WriteLine("ScriptEnemy - Start!");
    }

    public override void Update()
    {
        Console.WriteLine("ScriptEnemy - Update!");
    }
}
