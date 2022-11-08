namespace RPGClasses
{
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

        public bool KnockOut => (Health==0);    

        public Player(string name, int health)
        {
            Name = name;
            Health = health;
        }           

        public void GetHit(int HitAmount)
        {
            Health -= HitAmount;
        } 

        public void ShowInfo()
        {
            System.Console.WriteLine($"Имя игрока {Name}. Здоровье {Health}");
        }
        
    }
}