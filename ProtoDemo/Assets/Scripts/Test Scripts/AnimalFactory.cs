using UnityEngine;
using System.Collections;

public class AnimalFactory : MonoBehaviour
{
	void Start()
	{
        Human person = new Human();
        //Below shows the inheritance from class Mammal, which class Human is able to use fields, 
        //properties, and methods from. This inheritance structure is also called a Is-A 
        //containment structure. In other words, a human IS-A mammal.

        //Debug.Log(person.LaysEggs); //the output here is false.

        //Below shows how the object "person" cannot access the static field BiPedal but the class
        //Human can:
        //person. IntelliSence won't show BiPedal anymore with static field.
        //The class Human now only has access to BiPedal
        Human.BiPedal = true;

        //Why would you use a static field? The rule of thumb: you use static fields to designate
        //where some value is shared across all instances (objects). The moment you change the 
        //value, it changes it for all instances of that class. 

        //Would it make sense to change a field that is shared by all of the same class?
        Human Steven = new Human();
        //It doesn't make sense to try and change a field through one object, in this case a person,
        //when the field is shared by the entire Human class, in this case FreeWill.
        //Steven.ChangeFreeWill();

        Human.FreeWill = false;
        //It does make sense to change the field shared by an entire class through the class itself:
        Human.ChangeFreeWill();
        Debug.Log(Human.FreeWill);

	}


}