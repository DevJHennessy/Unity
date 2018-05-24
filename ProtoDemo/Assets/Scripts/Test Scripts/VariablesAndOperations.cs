using UnityEngine;
using System.Collections;

public class VariablesAndOperations : MonoBehaviour
{
	void Start()
	{
        //Calling the method named MyMethod:
        //MyMethod();
        // MyMethod2();
        MyMethod3();
	}

    //Method definition containing instructions.
    void MyMethod()
    {
        //Strings:
        //You are passing in the string argument into the log method:
        //Debug.Log("Hello World!");

        //string str1 = "Hello ";
        //string str2 = "World!";
        //Debug.Log(str1 + str2);

        //Integers:
        //int x = 2 + 6;
        //Debug.Log(x);

        //int x = 2;
        //x = 5;
        //x = 22;
        //Debug.Log(x);

        //int x = 2;
        //Debug.Log(x * x);
        //Debug.Log(x / x);
        //Debug.Log(x - x);

        //int x = 5;
        //This shows 20 in the console log.
        //x = ((x * x) - x);


        //This shows 50: Using the parenthesis shows how to control operations,
        //creating your own order of operations. This isn't just used in math, but 
        //also in conditional statements.
        //x = ((x + x) * x);
        //Debug.Log(x);
    }

    void MyMethod2()
    {
        //Floats: Numbers with decimals. Doubles can also be used, but doubles
        //take up more memory because they give you double the accuracy (more decimals).
        //Unity strictly enforces the f postfix for float values, example:
        //x = 1.9f;

        //float x;
        //x = 1.9f;
        //Debug.Log(x);

        //Example of what happens when dividing an integer and expecting a decimal 
        //as the remainder. Results show only a 1 instead of 1.5 because int only
        //deals with whole numbers. The compiler truncates the decimal.
        //int x = 3;
        //int y = 2;
        //Debug.Log(x / y);

        //The exact same calculation with floats give you the correct remainder:
        //float x = 3f;
        //float y = 2f;
        //Debug.Log(x / y);

        //Starting with int and converting to float: This is done with casting.
        int x = 3;
        int y = 2;
        float z = (float)x / (float)y; //This is casting int to float.
        Debug.Log(z);



    }

    void MyMethod3()
    {
        //Bools are either true or false: They are often used in conditionals.
        bool val;
        val = true;
        val = false;

        Debug.Log(val);
    }
}