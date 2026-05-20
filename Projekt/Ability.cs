using Projekt;

public class Ability
{
    // Namnet och damage på ability
    public string Name;
    public int Damage;

    // Use för offensive ability
    public virtual void Use(Hero hero, Enemy enemy)
    {

    }
    
    // Use för defensive ability
    public virtual void Use(Hero hero, Hero target)
    {

    }
}
