using System;

// A custom script that will be added to MonoBehaviourManager
class ScriptDoor : MonoBehaviour
{
    public override void Start()
    {
        Console.WriteLine("ScriptDoor - Start!");
    }

    public override void Update()
    {
        Console.WriteLine("ScriptDoor - Update!");
    }
}
