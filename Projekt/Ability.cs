using Projekt;

public class Ability
{
    // Namnet och damage på ability
    public string Name {get; protected set;}
    public int Damage {get; protected set;}

    // Use för offensive ability
    public virtual void Use(Hero hero, Enemy enemy)
    {

    }
    
    // Use för defensive ability
    public virtual void Use(Hero hero, Hero target)
    {

    }
}
