using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour
{
    Vector3 Move;
    //Speed is a static field because it makes the field accessible without instantiating
    //a new object. This makes it shared across all instances.
    public static float Speed = 0.09f;
    const float CamWidthX = 6.2f;
    const float CamHeightY = 3.4f;

    float LeftEdge;
    float RightEdge;
    float BottomEdge;
    float TopEdge;

    float Teleport;
    public bool IsDisappear = false;
    public static int CoolCounter;

	void Start()
	{
        Move = transform.position;

        LeftEdge = CamWidthX * -1;
        RightEdge = CamWidthX;
        BottomEdge = CamHeightY * -1;
        TopEdge = CamHeightY;

	}

	void Update()
	{
        TeleportCheck();

        Movement();

        BoundaryCheck();
	}

    private void LateUpdate()
    {
        ////Check if at the edge of screen and constrain movement if reached

        //if (transform.position.x < LeftEdge)
        //    Move.x = LeftEdge;
        //if (transform.position.x > RightEdge)
        //    Move.x = RightEdge;
        //if (transform.position.y < BottomEdge)
        //    Move.y = BottomEdge;
        //if (transform.position.y > TopEdge)
        //    Move.y = TopEdge;

        //transform.position = Move;
    }

    private void TeleportCheck()
    {
        //Teleport:
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (CoolCounter == 0)
            {
                Teleport = 2f;
                IsDisappear = true;
                CoolCounter = 100;
            }
        }
        else
        {
            Teleport = 0;
            IsDisappear = false;
        }

        CoolCounter--;
        if (CoolCounter < 0)
        {
            CoolCounter = 0;
        }
    }

    private void Movement()
    {
        //Movement (this is responsible for the input from keyboard)
        //Curly Braces/Brackets are optional for conditional statements
        //with only one line of code after them, as shown below:
        if (Input.GetKey(KeyCode.LeftArrow))
            Move.x -= Speed + Teleport;

        if (Input.GetKey(KeyCode.RightArrow))
            Move.x += Speed + Teleport;

        if (Input.GetKey(KeyCode.UpArrow))
            Move.y += Speed + Teleport;

        if (Input.GetKey(KeyCode.DownArrow))
            Move.y -= Speed + Teleport;

        transform.position = Move;
    }

    private void BoundaryCheck()
    {
        //Check if at the edge of screen and constrain movement if reached

        if (transform.position.x < LeftEdge)
            Move.x = LeftEdge;
        if (transform.position.x > RightEdge)
            Move.x = RightEdge;
        if (transform.position.y < BottomEdge)
            Move.y = BottomEdge;
        if (transform.position.y > TopEdge)
            Move.y = TopEdge;

        transform.position = Move;
    }
}