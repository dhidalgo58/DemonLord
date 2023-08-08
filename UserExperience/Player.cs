public class Player 
{
    public int Health { get; private set; } = 500;

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

    public enum AttackType { Burning, Freezing, Radiant, Piercing, Slashing, Bludgeoning, Necrotic, Poison }
    public class Attack
    {
        public string Name { get; }
        public int Damage { get; }

        public AttackType Type { get; }

        public Attack(string name, int damage, AttackType type)
        {
            Name = name;
            Damage = damage;
            Type = type;
        }
    }
}
