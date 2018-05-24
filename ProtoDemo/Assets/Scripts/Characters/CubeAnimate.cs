using UnityEngine;
using System.Collections;

public class CubeAnimate : MonoBehaviour
{

	void Update()
	{
        //GetComponent has a generic method.
        SpriteRenderer cubeRenderer = GetComponent<SpriteRenderer>();
        Color color = cubeRenderer.color;
        //Getting the CubeController so that we can access the IsDisappear property.
        //CubeController cubeController = GetComponent<CubeController>();

        //if (cubeController.IsDisappear) //If teleport is engaged, write in some logic later.
        //Shorthand to access properties.
        if (GetComponent<CubeController>().IsDisappear) //If teleport is engaged, write in some logic later.
        {
                color.a = 0;
        }
        else
        {
            //When dealing with floats to mean colors, 1f is 100% of the 255 RGBA scale.
            color.a = Mathf.Lerp(color.a, 1f, 0.029f);
        }

        cubeRenderer.color = color;
    }
}