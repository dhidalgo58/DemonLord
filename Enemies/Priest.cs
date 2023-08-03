using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

public class Priest : IEnemy
{
    public int Health { get; private set; } = 20;

    public Attack Attack()
    {
        Random rng = new Random();

        int randomNumber = rng.Next(1, 4);
         
        switch (randomNumber)
        {
            case 1:
                return new Attack("Smite", 10, AttackType.Radiant);
                break;
            case 2:
                return new Attack("Focused Will", 5, AttackType.Radiant);
                break;
            case 3:
                return new Attack("Psychic Scream", 10, AttackType.Radiant);
                break;
            case 4:
                return new Attack("Desperate Prayer", 20, AttackType.Radiant);
                break;            
        }
        Console.WriteLine($"Selected Attack: {Attack}");
    }

    public readonly List<string> Dialogue = new List<string>
    {
        "Your wickedness is an affront to the divine!",
        "Your malevolence will crumble before the holy light!",
        "You're a vessel of darkness, devoid of redemption!",
        "Your soul is tainted beyond salvation!",
        "Your sins have forged a path of destruction!",
        "Your evil deeds will be your downfall!",
        "Your heart is blackened with malevolence!",
        "You are but a pawn in the devil's wicked game!",
        "Your demonic spirit will be banished to the abyss!",
        "Your vile presence defiles this sacred ground!",
        "Your soul is as twisted as a labyrinth of horrors!",
        "You're a disgrace to the divine order!",
        "Your malevolence is no match for the purity of faith!",
        "Your darkness will be cleansed by the holy fire!",
        "Your wicked schemes will unravel like a frayed tapestry!",
        "Your malevolent heart will be shattered by divine judgment!",
        "Your soul is but a vessel for evil's corruption!",
        "Your malevolence is like a thorn in the side of righteousness!",
        "You're a harbinger of doom, but the light will prevail!",
        "Your wickedness will be swept away by the holy tide!",
        "Your demonic presence is an insult to the heavens!",
        "Your dark deeds will haunt you to the end of days!",
        "You're a servant of darkness, but I serve a higher power!",
        "Your malevolence is as fleeting as a passing shadow!",
        "Your wicked soul is destined for eternal damnation!",
        "Your evil spirit will be cleansed in the light of truth!",
        "Your malevolent ways will crumble like a sandcastle!",
        "You're a pawn of darkness, but the divine will triumph!",
        "Your wicked heart will be purified by holy grace!",
        "Your malevolence is no match for the divine wrath!",
        "Your soul is tarnished by the stain of wickedness!",
        "Your demonic aura will be banished from this realm!",
        "You're a vessel of evil, but the heavens are watching!",
        "Your malevolence will be vanquished by sacred light!",
        "Your wicked schemes are but dust in the wind!",
        "Your soul is entangled in the web of malevolence!",
        "You're a puppet of darkness, but I'll cut the strings!",
        "Your malevolent presence is an abomination to the divine!",
        "Your evil deeds will be judged by the heavenly court!",
        "Your wicked heart will be purified in the fires of atonement!",
        "Your malevolence is but a passing storm in the grand design!",
        "Your wicked spirit will tremble before the divine might!",
        "Your darkness will be swallowed by the eternal light!",
        "Your soul is tainted, but redemption is still within reach!",
        "You're a vessel of evil, but I'll channel the divine power!",
        "Your malevolence will be shattered by the sacred word!",
        "Your wickedness is like a fleeting dream in the night!",
        "Your evil ways will be undone by the hand of divinity!",
        "Your malevolent presence is a stain on this sacred land!",
        "Your soul is lost in the depths of darkness, but there's hope for salvation!",
        "You're a minion of evil, but I serve the one true God!",
        "Your malevolence will crumble like a decaying tomb!",
        "Your wicked deeds will be cast into the abyss of oblivion!",
        "Your darkness will be dispelled by the radiant truth!"
    };

    static string GetRandomString(List<string> Dialogue)
    {
        Random rng = new Random();
        int index = rng.Next(Dialogue.Count);
        return Dialogue[index];
    }


    public string TakeDamage(Attack attack)
    {
        if (attack.Type == AttackType.Radiant)
        {
            Health -= (attack.Damage * 2);
        }
        else
        {
            Health -= attack.Damage;
        }
        return "Ouch";
    }
}