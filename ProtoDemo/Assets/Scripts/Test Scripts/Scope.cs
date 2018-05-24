using UnityEngine;
using System.Collections;

public class Scope : MonoBehaviour
{
    /* Class "members" are elements immediately within the scope of the class--can be method
     * definitions or variables.
     * A variable that is declared within the immediate scope of the class, which would make it
     * a "member" of the class, is called a field.
     * A field is a special kind of variable because it is accessible to all methods within the
     * class.

    */
	void Start()
	{
	}

	void ScopeTest()
	{
        //if (true)
        //{
        //    string InsideVar = "Is this accessible outside of this scope?";
        //}
        ////The InsideVar is in the scope of the if conditional and is not accessible
        ////outside of it, so the Debug.Log cannot use it.
        //Debug.Log(InsideVar);


        ////Since the string OutsideVar was declared outside of the if statement,
        ////it is accessible inside the if conditional and outside of it.
        //string OutsideVar;
        //if (true)
        //{
        //   OutsideVar = "Accessible to inner scope.";
        //}
        //Debug.Log(OutsideVar);

        //string OutsideVar;

        //if (true)
        //{
        //    OutsideVar = "Accessible to inner scope";
        //    if (true)
        //    {
        //        OutsideVar = "Accessible to inner-inner scope.";
        //        string InsideVar = "inaccessible to outer scope";
        //    }
        //    Debug.Log(InsideVar); //does not work, inaccessible.
        //}
        //Debug.Log(OutsideVar);

    }
}