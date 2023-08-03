public interface IEnemy
{
    int Health { get; }

    Attack Attack();

    public string TakeDamage(Attack attack);

    
}

public enum AttackType { Burning, Freezing, Radiant, Piercing, Slashing, Bludgeoning, Necrotic, Poison}
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