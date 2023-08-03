public class Warrior : IEnemy 
{
    public int Health { get; private set; } = 60;
    

    public Attack Attack()
    {
        Random rng = new Random();

        int randomNumber = rng.Next(1, 4);

        switch (randomNumber)
        {
            case 1:
                return new Attack("Demon Slayer Slash", 10, AttackType.Slashing);
                break;
            case 2:
                return new Attack("ULTRA TIGER HUNT!", 5, AttackType.Bludgeoning);
                break;
            case 3:
                return new Attack("Heroic Throw", 10, AttackType.Piercing);
                break;
            case 4:
                return new Attack("Slam", 15, AttackType.Bludgeoning);
                break;
        }
        Console.WriteLine($"Selected Attack: {Attack}");
    }

    public string TakeDamage(Attack attack)
    {
        if (attack.Type == AttackType.Bludgeoning)
        {
            Health -= attack.Damage / 2;
        }
        else if (attack.Type == AttackType.Slashing)
        {
            Health -= (int)Math.Round((double)attack.Damage * 1.25);
        }
        else
        {
            Health -= attack.Damage;
        }
        
        return "Ouch";
    }

    public readonly List<string> Dialogue = new List<string>
    {
        "You fight like a snail in molasses!",
        "Is that the best you can muster, Demon? Pathetic!",
        "Your dark magic won't save you from my blade!",
        "You're nothing but a coward hiding behind shadows!",
        "I've faced scarier children in a pillow fight!",
        "Your malevolence is no match for my valor!",
        "Your dark arts are as feeble as a newborn's cry!",
        "You're a stain on the battlefield, unworthy of a warrior's challenge!",
        "You swing your staff like a toddler with a toy!",
        "Your wickedness is no match for my unyielding strength!",
        "I'll cleave through your darkness with a single stroke!",
        "You're slower than a snail stuck in molasses!",
        "Your malevolence is like a gust of wind against a mountain!",
        "I'll turn your dark lair into a heap of rubble!",
        "Your malevolent schemes are as transparent as glass!",
        "You'll crumble under the weight of my mighty blows!",
        "Your evil presence won't intimidate a true warrior!",
        "You're a disgrace to all those who wield a weapon!",
        "I'll send you back to the shadows where you belong!",
        "Your dark aura won't protect you from my blade's fury!",
        "You're a pathetic excuse for a Demon Lord!",
        "I'll slice through your malevolence like a hot knife through butter!",
        "Your wicked heart will quiver before my battle cries!",
        "You'll feel the wrath of my sword in every bone of your wretched body!",
        "Your malevolence will be nothing but a forgotten memory!",
        "I've seen more formidable foes in my sleep!",
        "Your dark magic won't save you from the taste of defeat!",
        "Your evil plots are as laughable as a jester's performance!",
        "You're a disgrace to the art of combat!",
        "Your malevolence will crumble under my relentless assault!",
        "I'll shatter your dark ambitions like glass!",
        "Your wicked ways won't last a heartbeat against my valor!",
        "You're a pitiful excuse for a Demon Lord, unworthy of respect!",
        "Your dark minions are nothing but a nuisance!",
        "I'll send you back to the depths where you belong!",
        "Your malevolent heart is colder than ice!",
        "You're a weakling hiding behind dark illusions!",
        "Your evil lair will be reduced to ashes in my wake!",
        "You'll meet your end at the tip of my blade!",
        "Your malevolence is like a flickering candle in the wind!",
        "I'll crush your wickedness with the force of a thousand warriors!",
        "Your dark magic is as predictable as the sunrise!",
        "You're no match for a true warrior's strength and skill!",
        "Your evil deeds will be erased from history!",
        "I'll show you the true meaning of courage and valor!",
        "Your malevolence will crumble before my unyielding resolve!",
        "You're a shadow of true power, weak and pitiful!",
        "Your dark aura will fade before the light of my righteousness!",
        "I'll cut through your malevolence like a blade through cloth!",
        "Your wicked schemes will unravel before my might!",
        "You're a pitiful excuse for a Demon Lord, unworthy of fear!",
        "Your malevolence will be silenced by my battle cries!",
        "I'll bring an end to your reign of darkness!",
    };

    static string GetRandomString(List<string> Dialogue)
    {
        Random rng = new Random();
        int index = rng.Next(Dialogue.Count);
        return Dialogue[index];
    }
}
