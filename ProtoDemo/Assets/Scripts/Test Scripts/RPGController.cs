using UnityEngine;
using System.Collections;

public class RPGController : MonoBehaviour
{
	void Start()
	{
        //MethodInputsAndReturns();
        //ValueVsReference();
        Polymorphism();
    }

    void MethodInputsAndReturns()
    {
        //Wizard wizard = new Wizard();
        //wizard.Weapon.WeaponType = "wand";
        ////The return from the method UseWeapon can be put into a variable:
        //string offenseMessage = wizard.Weapon.UseWeapon();
        //Debug.Log(offenseMessage);

        ////Debug.Log(wizard.Weapon.UseWeapon());


        ////Making Weapon its own class has multiple benefits, one here is that it allows
        ////a programmer to make a different weapon for a different object without having to write
        ////the same lines of code in both the Wizard class and the Knight class.
        //Knight knight = new Knight();
        //knight.Weapon.WeaponType = "sword";
        //Debug.Log(knight.Weapon.UseWeapon());

        //wizard.Weapon.Deflect(knight.Weapon.WeaponType);

        //string deffenseMessage = wizard.Weapon.Deflect(knight, 30);
       // Debug.Log(deffenseMessage);
    }

    void ValueVsReference()
    {
        //Illustrating how value types behave:
        //int num1 = 0;
        ////When num2 copies num1, it simply copies the value stored in num1 but doesn't
        ////hold any connection/reference to num1. This contasts with objects as seen with
        ////the wizard. Each value type points to a different memory space.
        //int num2 = num1;
        //num2 = 99;

        //Debug.Log("num1: " + num1); //Retains its original value, 0!

        ////Illustrating how reference types behave:
        //Wizard wizard1 = new Wizard();
        //wizard1.Weapon.WeaponType = "Staff";

        ////Wizard2 copies the reference to wizard1, not the value as num2 two copied num1, 
        ////and does not hold copy it's contents, so when wizard1 changes, wizard2 changes
        ////as well, and vice versa. Each reference type points to the same memory space.
        //Wizard wizard2 = wizard1;
        //wizard2.Weapon.WeaponType = "Orb";

        //Debug.Log("Wizard1 holds: " + wizard1.Weapon.WeaponType); //becomes Orb!

        //Wizard wizard = new Wizard();

        //Knight knight = new Knight();
        //knight.Weapon.WeaponType = "Sword";

        //string defenseMessage = wizard.Weapon.Deflect(knight, 30);
        //Debug.Log(knight.Weapon.WeaponType);
    }

    void Polymorphism()
    {
        //What if you wanted to use the Deflect Method but wanted to input a Wizard
        //instead of a Knight or any other class? You would have a lot of duplicate code
        //if you make different methods to do the same thing for each class. Polymorphism
        //comes to the rescue in exactly this case. First though, I'll have to rewrite
        //the classes so that they all inherit from a common base class, called combatant.
        Wizard wizard = new Wizard();

        Knight knight = new Knight();
        Elf elf = new Elf();

        knight.weapon.WeaponType = "Sword";
        elf.weapon.WeaponType = "Arrow";
        wizard.weapon.WeaponType = "Staff";

        Combatant combatant = wizard;

        string defenseMessage = wizard.weapon.Deflect(combatant, 30);
        Debug.Log(defenseMessage);

        wizard.weapon.DamageSomething(elf);
        Companion spiritFamiliar = new Companion();
        wizard.weapon.DamageSomething(spiritFamiliar);
    }
}