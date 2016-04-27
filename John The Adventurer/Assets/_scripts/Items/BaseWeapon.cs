using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseStatItem {

	public enum WeaponTypes
    {
      SWORD,
      DAGGER,
      BOW,
      STAFF,
      SHIELD

    }
    private WeaponTypes weaponType;
    

    public WeaponTypes WeaponType
    {
        get { return weaponType; }
        set { weaponType = value; }
    }
    
}
