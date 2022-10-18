public class Player
{
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    private int _health;
    public int Health
    {
        get { return _health; }
        set { _health = value; }
    }
    

    public Player(string name, int health)
    {
        Name = name;
        Health = health;

    }

    public void KnockOut()
    {
        If (Health == 0) Console.WriteLine("Персонаж оглушен");
    }
    
}