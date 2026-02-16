using System;

namespace Projekt;

public class Enemy
{
    public string Name;
    public int HP;
    public int AP;
    public int MP;

    public List<string> Moves = ["Attack", "Defend", "Spells", "Do nothing"];
    public List<string> Spells = [];
    public List<string> Abilities = [];
    
}
