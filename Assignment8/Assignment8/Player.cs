// Player is a subject
class Player
{
    //List<IObserver> m_observerList = new List<IObserver>();

    int HP = 3; // Player HP

    // TODO:
    // Here we will declare the delegate and the events based on the delegate.
    // This first event declaration has been done for you.
    //
    public delegate void Notify();
    public event Notify EventWalkLeft;
    public event Notify EventWalkRight;
    public event Notify EventWalkUp;
    public event Notify EventWalkDown;
    public event Notify EventDied;

    public void MoveLeft()
    {
        Console.WriteLine("Player Moving Left");
        //NotifyObservers("Player Left");
        EventWalkLeft?.Invoke();
    }

    public void MoveRight()
    {
        Console.WriteLine("Player Moving Right");
        //NotifyObservers("Player Right");
        EventWalkRight?.Invoke();
    }

    public void MoveUp()
    {
        Console.WriteLine("Player Moving Up");
        //NotifyObservers("Player Up");
        EventWalkUp?.Invoke();
    }

    public void MoveDown()
    {
        Console.WriteLine("Player Moving Down");
        //NotifyObservers("Player Down");
        EventWalkDown?.Invoke();
    }

    public void TakeDamage()
    {
        Console.WriteLine("HP is now: {0}", --HP);
        if (HP <= 0)
        {
            //NotifyObservers("Player Dead");
            EventDied?.Invoke();
        }
    }

   
}

