using System;

// A custom script that will be added to MonoBehaviourManager
class ScriptPlayer : MonoBehaviour
{
    public override void Start()
    {
        Console.WriteLine("ScriptPlayer - Start!");
    }

    public override void Update()
    {
        Console.WriteLine("ScriptPlayer - Update!");
    }
}
