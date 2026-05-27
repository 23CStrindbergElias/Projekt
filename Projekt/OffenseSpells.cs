using Projekt;
// Basklass för OffenseSpells, Fireball, Iceshard, osv 
public class OffenseSpells
{
    public string Name {get; protected set;}


    // Metod för Use, finns dock override i andra basklasser
    public virtual void Use(Hero caster, Enemy enemy)
    {

    }
}
