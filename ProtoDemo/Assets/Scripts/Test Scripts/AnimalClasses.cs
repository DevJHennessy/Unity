using UnityEngine;
using System.Collections;

public class Mammal
{
    public bool LaysEggs = false;
}


public class Human : Mammal
{
    //public bool BiPedal = true;

    //Adding the keyword static makes the field not accessible to the instance (the objects of the
    //class) but to the class itself. To access BiPedal, you would use Human. and BiPedal would
    //show up.
    public static bool BiPedal = true;
    public string Gender;
    public int Age;

    //Either all Humans have FreeWill or none of them do.
    public static bool FreeWill;

    //Methods can also be static. You would want to do this when that method does some process
    //that changes a static field. This method changes the static field FreeWill.
    public static void ChangeFreeWill()
    {
        //FreeWill equals the opposite of FreeWill. Whatever FreeWill is, if it's true is becomes
        //false, if it's false it becomes true.
        FreeWill = !FreeWill;
        //A static method does not have access to a non-static field. This method has no way of
        //knowing which instance of Age this refers to:
        //Age = 21;
    }

}

public class Dog : Mammal
{
    public bool BiPedal = false;
}