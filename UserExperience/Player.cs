public class Player 
{
    public int Health { get; set; }

    public string TakeDamage(Attack attack)
    {
        int damageAmount;

        switch (attack.Type)
        {
            case AttackType.Burning:
                damageAmount = (int)Math.Round((double)attack.Damage * 0.75);
                break;
            case AttackType.Radiant:
                damageAmount = attack.Damage * 4;
                break;
            case AttackType.Piercing:
                damageAmount = (int)Math.Round((double)attack.Damage * 1.75);
                break;
            case AttackType.Freezing:
                damageAmount = (int)Math.Round((double)attack.Damage * 2);
                break;
            default:
                damageAmount = attack.Damage;
                break;
        }

        Health -= damageAmount;

        Health = Math.Max(Health, 0);

        return "Ouch!";

    }

    
}
