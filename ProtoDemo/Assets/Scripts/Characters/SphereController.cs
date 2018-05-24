using UnityEngine;
using System.Collections;

public class SphereController : MonoBehaviour
{
    public GameObject CubeReference;
    Vector3 CubeReferencePosition;
    public static float Speed = 0.03f;
    //public Vector2 Distance; //Made into a local variable in EnemyProximity

    public int Timer;
    //Vector3 RandomSpawn; Don't need the field here.

	void Start()
	{
        //Dynamic Reference to our Cube/Player1 GameObject.
        //CubeReference = GameObject.Find("Cube");


        Timer = 1;
	}

	void Update()
	{
        Movement();
        EnemyProximity();
        SpawnEnemy();

	}

    private void SpawnEnemy()
    {
                //Spawn duplicates every 500 ticks
        //The percent operator (symbol) finds the remainder after dividing the 
        //first operand by the second, and this case it is also saying if the
        //remainder is equal to zero, then do the code inside statement.
        if (Timer % 500 == 0)
        {
            //This code can be refactored so you don't even need the Vector3 variable:
            //Vector3 RandomSpawn;
            //RandomSpawn.x = Random.Range(-6.2f, 6.2f);
            //RandomSpawn.y = Random.Range(-3.4f, 3.4f);
            //RandomSpawn.z = transform.position.z;
            float x = Random.Range(-6.2f, 6.2f);
            float y = Random.Range(-3.4f, 3.4f);
            float z = transform.position.z;



            //This makes a new object of the sphere enemy:
            //thi.gameObject means you are instanitating an instance of the gameObject that
            //this SphereController script is attached to.
            //The instantiate can be refactored to have a new Vector3 instead of the RandomSpawn variable:
            //GameObject.Instantiate(this.gameObject, RandomSpawn, transform.rotation);

            GameObject.Instantiate(this.gameObject, new Vector3(x, y, z), transform.rotation);

        }

        //Since the update method is running on a loop, you want to increment timer on every
        //run through of the update to increment to the next highest value. You use this to 
        //know when to spawn another enemy. In this case, 500/60(the frames per second)
        //= about 8 seconds (8.3).
        Timer++;
    }

    private void EnemyProximity()
    {

        //Check distance between Player1 and Enemy.
        //Vector2 Distance;
        //Distance.x = transform.position.x - CubeReferencePosition.x;
        //Distance.y = transform.position.y - CubeReferencePosition.y;

        //Refactored above code to show constructor use for Vector2 with input parameters:
        float x = transform.position.x - CubeReferencePosition.x;
        float y = transform.position.y - CubeReferencePosition.y;
        Vector2 distance = new Vector2(x,y);

        //The above code can also be written as one line:
        //Vector2 Distance = new Vector2(transform.position.x - CubeReferencePosition.x, transform.position.y - CubeReferencePosition.y);

        //If occupying the same space as you, you've been eaten!
        if (((distance.x < 0.1f) && (distance.x > -0.1f)) && ((distance.y < 0.1f) && (distance.y > -0.1f)))
        {

            GameObject.Destroy(CubeReference);
            //Debug.Log("YOU'VE BEEN EATEN!");

            //GameObject.Destroy(CubeReference);
            // Debug.Log("YOU'VE BEEN EATEN!");
        }
    }

    private void Movement()
    {
        //Sphere tracks position of Player1 and follows.

        CubeReferencePosition = CubeReference.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, CubeReferencePosition, Speed);
    }
}