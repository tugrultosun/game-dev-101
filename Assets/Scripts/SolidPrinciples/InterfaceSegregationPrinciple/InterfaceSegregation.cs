

// fat interface
public interface IPlayerFat
{
    public void Move();

    public void Attack();

    public void BlockDamage();

    public void CastSpell();

    public void GainXp();

    public void Heal();

    public void RangedAttack();
}
/// <summary>
/// here we segregate a big interface to smaller interfaces 
/// which is specified by abilities and behaviors of
/// different types of players
/// </summary>


public interface IPlayer
{
    public void Move();

    public void GainXp();

}

public interface ICaster
{
    public void CastSpell();
}

public interface IRanger
{
    public void RangedAttack();

}

public interface IHealer
{   
    public void Heal();

}

public interface ICombatAbility
{
    public void Attack();

    public void BlockDamage();


}