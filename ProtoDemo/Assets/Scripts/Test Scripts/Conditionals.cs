using UnityEngine;
using System.Collections;

public class Conditionals : MonoBehaviour
{
	void Start()
	{
        StateHandler();
	}

	void RunConditionals()
	{
        //int x = 50;

        ////In the if statement is an equivalence operation:
        ////The x is the left operand and the 100 is the right operand.
        ////This is called a binary operator becauser there are two operands.
        //if (x == 100)
        //{
        //    Debug.Log("The operands ARE equivalent.");
        //}
        //else if (x == 100 / 2)
        //{
        //    Debug.Log("x is quivalent to half of 100.");
        //}
        //else
        //{
        //    Debug.Log("The operands are NOT equivalent.");
        //}

        ////Greater than or equal to operators:
        //int x = 100;

        //if (x >= 100)
        //{
        //    Debug.Log("x is GREATER than or EQUAL to 100.");
        //}
        //else
        //{
        //    Debug.Log("x is LESS than 100.");
        //}
    }

    void RunConditionals2()
    {
        //int x = 101;

        ////The exclamation sign can be read as NOT.
        //if (x != 100) //if x is NOT equal to 100.
        //{
        //    Debug.Log("x is not equivalent to 100");
        //}
        //else
        //{
        //    Debug.Log("x is equivalent to 100.");
        //}

        //The exclamation can also be used on a single operand, making it a 
        //unary operator.

        //If it's true that x is not equivalent to 100, then execute the code.

        int x = 101;

        if (!(x == 100))
        {
            Debug.Log("x is not equivalent to 100");
        }
        else
        {
            Debug.Log("x is equivalent to 100.");
        }

    }

    void RunConditionals3()
    {
        //bool val = true;

        //if (val) //the conditional automatically asserts true.
        //{
        //    Debug.Log("val is TRUE!");
        //}
        //else
        //{
        //    Debug.Log("val is FALSE!");
        //}

        //bool val = true;

        //if (!val) //the not operator checks to see if it is false. Val is true though.
        //{
        //    Debug.Log("val is FALSE!");
        //}
        //else
        //{
        //    Debug.Log("val is TRUE!");
        //}

        bool val = true;

        val = !val;
        Debug.Log(val);
        //The !NOT operator can be used to switch bools
        val = !val;
        Debug.Log(val);

        val = !val;
        Debug.Log(val);
    }

    void RunConditionals4()
    {
        //Simulating button presses:
        //bool isButtonAPressed = true;
        //bool isButtonBPressed = false;

        //if (isButtonAPressed && isButtonBPressed)
        //{
        //    Debug.Log("Button conditional evaluates as TRUE!");
        //}
        //else
        //{
        //    Debug.Log("Button conditional evaluates as FALSE!");
        //}

        //bool isButtonAPressed = true;
        //bool isButtonBPressed = false;

        ////Only one has to be true with an OR operator:
        //if (isButtonAPressed || isButtonBPressed)
        //{
        //    Debug.Log("Button conditional evaluates as TRUE!");
        //}
        //else
        //{
        //    Debug.Log("Button conditional evaluates as FALSE!");
        //}

        //Nested if statements:
        //Simulating button presses:
        bool isButtonAPressed = true;
        bool isButtonBPressed = true;

        if (isButtonAPressed)
        {
            //A benefit to doing nesting is that you can additional code before
            //the second evaluation:
            Debug.Log("ButtonA evaluates as TRUE!");
            if (isButtonBPressed)
            {
                Debug.Log("ButtonA and ButtonB evaluate as TRUE!");
            }
        }
        else
        {
            Debug.Log("Button conditional evaluates as FALSE!");
        }
    }

    void StateHandler()
    {
        bool isInvincible = false; //Default setting
        bool grabbedPowerUp = false; //Default setting
        int damageRating; //default


        grabbedPowerUp = true;

        //Curly brackets are optional for conditional statements with only
        //one line of code after them.

        //isInvincible is dependent on whether the grabbedPowerUp is true.
        //If it is, then isInvincible is also true:
        if (grabbedPowerUp)
        {
            isInvincible = true;
        }
        else
        {
            isInvincible = false;
        }

        //Another conditional block the evaluates whether isInvincible is true:
        if (isInvincible)
        {
            damageRating = 0;
            //TODO - put in a countdown timer conditional.
        }
        else
        {
            damageRating = 100;
        }
    

        Debug.Log(isInvincible);
        Debug.Log(damageRating);
    }

}