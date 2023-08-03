public class Mage : IEnemy 
{
    public int Health { get; private set; } = 40;

    public Attack Attack()
    {
        Random rng = new Random();

        int randomNumber = rng.Next(1, 4);

        switch (randomNumber)
        {
            case 1:
                return new Attack("FireBall", 15, AttackType.Burning);
                break;
            case 2:
                return new Attack("Ice Spear", 10, AttackType.Freezing);
                break;
            case 3:
                return new Attack("Baleful Strike", 10, AttackType.Piercing);
                break;
            case 4:
                return new Attack("Shocking Orb", 15, AttackType.Radiant);
                break;
        }
        Console.WriteLine($"Selected Attack: {Attack}");
    }

    public readonly List<string> Dialogue = new List<string>
    { 
        "Your darkness is as feeble as your mind!",
        "You're nothing more than a pathetic fiend!",
        "Your malevolence is laughable!",
        "Is that the best you can conjure, Demon?",
        "Your reign of terror ends here and now!",
        "You couldn't scare a kitten with that demeanor!",
        "You're an abomination to the magical arts!",
        "I've faced stronger goblins than you!",
        "Your dark magic is as stale as week-old bread!",
        "You're a disgrace to the underworld!",
        "You're not even worth the magic it takes to defeat you!",
        "I've seen scarier clowns at the circus!",
        "You must have been born on a full moon; that's the only explanation for your lunacy!",
        "Your dark aura is just a façade for your insecurities!",
        "Your evil plans are as predictable as the sunrise!",
        "You're so vile that even the rats wouldn't keep you as company!",
        "Your malevolence is matched only by your incompetence!",
        "Do you even know the difference between a curse and a blessing?",
        "You're about as threatening as a toothless dragon!",
        "Your wickedness is only outdone by your lack of charm!",
        "Your dark minions are just as pitiful as you are!",
        "The only thing you'll conquer is a buffet table!",
        "You must have majored in failure at demon school!",
        "Your demonic cackle sounds like a dying donkey!",
        "Your evil schemes are as transparent as glass!",
        "You couldn't spell 'spell' if your life depended on it!",
        "You're so repulsive, even the underworld wouldn't claim you!",
        "Your dark magic is weaker than a baby's first steps!",
        "You must have a degree in idiocy from the School of Malevolence!",
        "Your evil deeds are about as impressive as a party trick!",
        "I've met ogres with better manners than you!",
        "Your darkness is so dim it couldn't even light a candle!",
        "You're the punchline of every demon joke!",
        "Your evil laugh is more annoying than a broken record!",
        "You're a walking disaster in a poorly tailored cloak!",
        "I've seen zombies with more life in them than you!",
        "Your evil fortress is just a glorified dollhouse!",
        "You're a disgrace to the demonic realm!",
        "Your dark spells are as powerful as a sneeze!",
        "You're so unoriginal, even your shadow cringes!",
        "Your wickedness is surpassed only by your bad breath!",
        "You must have been cursed with incompetence at birth!",
        "Your malevolence is like a mosquito's bite; irritating but inconsequential!",
        "You're the poster child for demonic disappointment!",
        "Your minions are as useful as a broken wand!",
        "Your evil plots are as shallow as a dried-up well!",
        "You're so predictable, even a crystal ball could see through you!",
        "Your dark aura is like a cloud of stink that follows you everywhere!",
        "You're a textbook example of evil gone wrong!",
        "Your demonic legacy will be nothing but a footnote in history!",
        "You're so pathetic, even the goblins wouldn't invite you to their party!",
        "Your malevolence is as empty as your soul!"    
    };

    static string GetRandomString(List<string> Dialogue)
    {
        Random rng = new Random();
        int index = rng.Next(Dialogue.Count);
        return Dialogue[index];
    }

    public string TakeDamage(Attack attack)
    {
        if (attack.Type == AttackType.Freezing)
        {
            Health -= (int)Math.Round((double)attack.Damage * .75);;
        }
        else if (attack.Type == AttackType.Radiant)
        {
            Health -= (attack.Damage * 2);
        }
        else 
        {
            Health -= attack.Damage;
        }
        
        return "Ouch!";
        
    }
}
