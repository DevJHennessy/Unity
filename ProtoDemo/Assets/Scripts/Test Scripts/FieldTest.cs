using UnityEngine;
using System.Collections;

public class FieldTest : MonoBehaviour
{
    //Creating fields, which are class-level variables, which are accessible to all
    //methods within the class. They are also accessible to other classes. Public fields
    //should be PascalCase and private fields should be prefixed with an underscore: _camelCase.
    string Message = "Hello,";

	void Start()
	{
        Debug.Log(Message);
        Method();
        Debug.Log(Message);
        //Message is a field, which enables it to stay alive between method calls that reference
        //it.
        Method();
        Debug.Log(Message);
        //This outputs: Hello, - Hello, World! - World! on three separate lines.
    }

	void Method()
	{
        Message = Message + "World!";
	}
}