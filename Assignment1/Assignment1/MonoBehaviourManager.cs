using System;
using System.Collections.Generic;


// This class will contain and manage all monoBehaviours added to it.
class MonoBehaviourManager
{
    // Internal list of MonoBehaviour objects
    private List<MonoBehaviour> monoBehaviours = new List<MonoBehaviour>();
    
    // Adds a MonoBehaviour object into the list.
    public void Add(MonoBehaviour monoBehaviour)
    {
        monoBehaviours.Add(monoBehaviour);
    }

    // Calls the Start() function of all the MonoBehaviour objects in the list.
    public void Start()
    {
        foreach (MonoBehaviour obj in monoBehaviours)
        {
            obj.Start();
        }
    }

    // Calls the Update() function of all the MonoBehaviour objects in the list.
    public void Update()
    {
        foreach (MonoBehaviour obj in monoBehaviours)
        {
            obj.Update();
        }
    }

}