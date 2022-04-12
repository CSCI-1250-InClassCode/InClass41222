public class Ninja
{
    private string name;
    private int healthMax;
    private int healthCurrent;
    private double power;
    private Weapon weapon;
    private bool evil;

    public Ninja(string name)
    {
        SetName(name);
    }

    public void SetName(string name)
    {
        this.name = name.ToUpper();

        Random rand = new Random();

        healthMax = 250; 
        weapon = null;       
        
        if(this.name.Contains('Q') || this.name.Contains('X') || this.name.Contains('Z') )
        {
            healthCurrent = 250;
            power = 1;
        }
        else
        {
            healthCurrent = rand.Next(healthMax) + 1;
            power = rand.NextDouble();
        }

        if(this.name[0] == 'A' || this.name[0] == 'M')
        {
            evil = false;
        }
        else
        {
            evil = true;
        }   
    }

    public string GetName()
    {
        return name;
    }
    public int GetCurrentHealth()
    {
        return healthCurrent;
    }

    public int GetMaxHealth()
    {
        return healthMax;
    }

    public bool IsEvil()
    {
        return evil;
    }

    public double GetPower()
    {
        return power;
    }

    public Weapon GetWeapon()
    {
        return weapon;
    }

    public void SetWeapon(Weapon weapon)
    {
        this.weapon = weapon;
    }

    public int Attack()
    {
        int attack = 10;

        if(weapon is null)
        {
            return attack;
        }
        else
        {
            return attack + weapon.GetDamage();
        }
    }
    public int BigOleChop()
    {
        int attack = (int)(10 * power) + 10;

        if(weapon is null)
        {
            return attack;
        }
        else
        {
            return attack + (int)(weapon.GetDamage() * power) + weapon.GetDamage();
        }
    }

    public int TakeDamage(int damage)
    {
        healthCurrent = healthCurrent - damage;
        return damage;

        //return healthCurrent -= damage;
    }

}