using UnityEngine;
using System.Collections;

public class PersonFactory : MonoBehaviour
{
	void Start()
	{
        //Public fields use PascalCase and private use _camelCase:
        Person person1 = new Person();
        person1.Name = "Link";
        person1.Gender = "Male";
        person1.Age = 17;

        Debug.Log(person1.Name);
        Debug.Log(person1.Gender);
        Debug.Log(person1.Age);

        Person person2 = new Person();
        person2.Name = "Zelda";
        person2.Gender = "Female";
        person2.Age = 19;

        Debug.Log(person2.Name);
        Debug.Log(person2.Gender);
        Debug.Log(person2.Age);

        person1.DoAging();
        person2.DoAging();

        Debug.Log(person1.Age);
        Debug.Log(person2.Age);

        //Overloaded method example using the second DoAging method.
        person1.DoAging(5);
    }


}