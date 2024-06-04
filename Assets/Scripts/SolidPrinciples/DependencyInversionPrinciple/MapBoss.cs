using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapBoss : MonoBehaviour
{
    //map boss now depends on weapon interface,we can introduce new weapon types without affecting mapboss
    private IWeapon weapon;
    
    public void SetWeapon(IWeapon weapon)
    {
        this.weapon = weapon;
    }

    public void Attack()
    {
        weapon.Fire();
    }
}
