namespace Less
{
   class Player
  {
    public string Name;
    public int Health;
    public int Score;
    public int Experience;
    public int Level;
    public bool IsAlive;

        public void TakeDamage(int damage)
        {
            int result = Health - damage;

        if (result <= 0)
            {
                Health = 0;
                IsAlive = false;
            }
        else
            {
                Health = result;
            }    
            
        }
   
  }


}