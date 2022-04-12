public class Weapon
{
    private string name;
    private int damage;

    public Weapon()
    {
        SetDamage();
    }
    
    public string GetName()
    {
        return name;
    }
    
    public int GetDamage()
    {
        return damage;
    }

    public void SetDamage()
    {
        Random rand = new Random();
        this.damage = rand.Next(25, 51);

        if(damage <= 30)
        {
            this.name = "Average Joe";
        }
        else if(damage <= 40)
        {
            this.name = "Not just Joe";
        }
        else
        {
            this.name = "The not so bad Joe";
        }
    }
}