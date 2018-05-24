using UnityEngine;
using System.Collections;

public class NPC
{

}

public class Companion : NPC
{

}

public class Combatant
{
    public Weapon weapon = new Weapon("rusty sword", 100);
}

public class Wizard : Combatant
{
    
}

public class Knight : Combatant
{
   
}

public class Elf : Combatant
{

}

//This type of containment is also called a Has-A object containment structure, where when the 
//wizard is instantiated, it can have a weapon. The wizard Has-A weapon.
public class Weapon
{

    public string WeaponType;
    private int Degradation;

    //Constructors don't have return types.
    public Weapon(string weaponType, int degradation)
    {
        this.WeaponType = weaponType;
        this.Degradation = degradation;
    }

    public string UseWeapon() //<--This is called a method signature. All its code inside is the method definition.
    {
        string phrase = "The player has struck with the weapon: ";
        string combinePhrase = phrase + WeaponType;
        return combinePhrase;
        //return "The player has struck with the weapon: " + WeaponType;
    }

    //The relationship between the input parameters and the rest of the method definition is it's
    //like a form you get to fill out which already has a bunch of prewrtitten stuff, stuff you can't
    //change and stays the same with every form copied. That information that can't change when you
    //pick up a new form, or call it, is much like the hard-coded contents of the method definition.
    //And each time you call the method, the hard-coded info stays the same, but a form always has
    //a bunch of blank areas that expect you to input some new information, the same way the method
    //input parameters do.
    //changing Knight knight input paramter back to string weaponType.
    //changing string weaponType back to Knight knight

    //Changing input parameter from Knight to Combatant
    public string Deflect(Combatant combatant, int degradation)
    {
        Degradation -= degradation;
        //Since phrase is a local variable and not a field, it can have a different value, as it does
        //here compared to the UseWeapon method.
        //string phrase = "You deflected the combatant's: " + weapon +
        //    "a nd degraded your weapon to " + Degradation;
        //return phrase;
        //Debug.Log(phrase); //This showed the message when the method was called.
        string phrase = string.Format(
            "You deflected the {0}'s {1} and degraded your weapon to {2}",
            combatant.GetType(),
            combatant.weapon.WeaponType,
            Degradation);

        combatant.weapon.WeaponType = "Broken " + combatant.weapon.WeaponType;
        return phrase;

        //No longer passing in a reference but a value: this was used when passing in
        //string weaponType in the method parameters.
        //return weaponType = "Broken " + WeaponType;

    }

    public void DamageSomething(object anObject)
    {
        //Do something that damages the object.
    }

}