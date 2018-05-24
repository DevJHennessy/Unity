using UnityEngine;
using System.Collections;

public class LerpTest : MonoBehaviour
{
    float Accumulator = 0.001f;

    float Output = 0f;

    private void Start()
    {
        //Dynamically create, attach, and set properties of SpriteRenderer
        SpriteRenderer renderer = gameObject.AddComponent<SpriteRenderer>();
        renderer.sprite = Resources.Load<Sprite>("Images/Tabors");
        renderer.sortingLayerName = "Player1";
        renderer.color = new Color(0, 1, 0.3f, 1);
    }

    private void OnGUI()
    {

        var style = new GUIStyle();
        style.fontSize = 35;
        GUI.contentColor = Color.magenta;

        //GUI.Label(
        //    new Rect(105, 250, Screen.width, Screen.height),
        //    string.Format("<b>LERP Accumulator: {0}</b>"), Accumulator.ToString()), style);

        GUI.Label(new Rect(105, 250, Screen.width, Screen.height), string.Format("<b>LERP Accumulator: {0}</b>", Accumulator.ToString()), style);


        GUI.Label(new Rect(105, 280, Screen.width, Screen.height),
            string.Format("<b>LERP Output: {0}</b>", Output.ToString()), style);
    }


    void Update()
    {
        //Vector3 temp = new Vector3(LerpTypes(), 1, 1);
        //transform.position = temp;
         transform.position = new Vector3(LerpTypes(), 1, 1);

    }

    float LerpTypes()
    {
        #region - Accumulator Types
        //Accumulator Type2: Linear, fixed accumulator:
        //Accumulator += 0.004f;
        //Speeding up faster and faster with an exponential accumulator:
        //Accumulator Type1: Exponential, doubling Accumulator every time it's called.
        Accumulator += Accumulator * 0.08f;
        #endregion

        #region - LERP Types
        //Lerp Type1: Constant trasition, fixed "From":
        //Output = Mathf.Lerp(-5f, 5f, Accumulator);

        //Lerp Type2: Smooth transition, no Accumulator required:
        Output = Mathf.Lerp(Output, 5f, 0.02f);

        //Output = Mathf.Lerp(transform.position.x, 5f, 0.02f);



        #endregion


        return Output;

        //The third parameter is a percentage between the first and second float 
        //parameters. Fifty percent between -5 and 5 would be 0 and would be shown on
        //every frame. What we need to do is change the third parameter over time
        //so that it continues to represent a progressive percentage point between the 
        //first two, -5 and 5.
        //Output = Mathf.Lerp(-5f, 5f, 0.5f);
        //This is why the Accumulator is used, because it is constantly increasing the 
        //value with each Update call.

    }
}