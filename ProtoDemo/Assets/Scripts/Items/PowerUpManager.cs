using UnityEngine;
using System.Collections;

public class PowerUpManager : MonoBehaviour
{
    public GameObject PowerUpPrefab;
    int Timer;
    public static int PowerUpMeter;

    public bool IsPowered;


    void Start()
	{
        IsPowered = false;
        Timer = 1;
        PowerUpMeter = 50; //default 'bonus' at startup.


    }

    void Update()
	{
        //Spawns a PowerUp every 300 ticks.
        if (Timer % 300 ==0)
        {
            Vector3 randomSpawn = new Vector3(
                Random.Range(-6.2f, 6.2f),
                Random.Range(-3.4f, 3.4f),
                transform.position.z);

            transform.position = randomSpawn;

            GameObject gO = GameObject.Instantiate(PowerUpPrefab, randomSpawn, transform.rotation);
            //Casting to GameObject to make variable gO a GameObject. In Unity Lesson,
            //has to do this, but no error is given for this version of software, and gO
            //appears to be a GameObject without casting.
            //GameObject gO = (GameObject)GameObject.Instantiate(PowerUpPrefab, randomSpawn, transform.rotation);
            //This method overload of Instantiate returns a GameObject
            //The reason why we didn't need to return anything before was because
            //you don't have to return anything for the method in Unity. The compilier
            //will ignore if no return type is put in, but accept a return if one is
            //put in.

            //Now that we have this local return reference gO, we can do what we want with
            //it. In this case we just want to parent it to another GameObject. For that
            //we access the parent property that's part of the GameObject's transform.
            gO.transform.parent = gameObject.transform;

        }
        if (Input.GetKeyDown(KeyCode.Z) && !IsPowered && PowerUpMeter > 0)
        {
            //Start PowerUp mode:
            TimeChange(0.5f);

            //Refactored into its own method.
            //IsPowered = true;
            ////Effects of PowerUp mode: Cut Speed in half:
            //CubeController.speed = CubeController.speed * 0.5f;
            //SphereController.Speed = SphereController.Speed * 0.5f;
        }
        //If already PoweredUp, then cancel:
        else if (Input.GetKeyDown(KeyCode.Z) && IsPowered)
        {
            //Cancel Powerup
            //IsPowered = false;
            //Go back to regular speed:
            TimeChange(2f);
            //Refactored:
            //CubeController.Speed = CubeController.Speed * 2;
            //SphereController.Speed = SphereController.Speed * 2;
        }

        if (IsPowered)
        {
            PowerUpMeter--;

            //Once the PowerUpMeter hits 0, you exit PowerUp mode (the IsPowered state).
            if (PowerUpMeter == 0)
            {
                //IsPowered = false;
                //Cancel the PowerUp effects, returning to normal speed.
                TimeChange(2f);
                //Refactored:
                //CubeController.Speed = CubeController.Speed * 2;
                //SphereController.Speed = SphereController.Speed * 2;
            }
            //Debug.Log(PowerUpMeter);
        }
        Timer++;
	}

    //Simulating slowing down and speeding up time:
    private void TimeChange(float speedFactor)
    {
        CubeController.Speed = CubeController.Speed * speedFactor;
        SphereController.Speed = SphereController.Speed * speedFactor;
        IsPowered = !IsPowered;
    }
}