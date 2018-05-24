using UnityEngine;
using System.Collections;

public class Person
{
    //Public fields use PascalCase and private use _camelCase:
    //Since these are public fields, they are PascalCase:
    public string Name;
    public string Gender;
    public int Age;

    public void DoAging()
    {
        Age++;
    }

    //Method overloading example:
    public void DoAging(int amount)
    {
        Age += amount;
    }

}