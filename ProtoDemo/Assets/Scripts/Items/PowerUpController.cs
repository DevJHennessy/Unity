using UnityEngine;
using System.Collections;

public class PowerUpController : MonoBehaviour
{
    GameObject CubeReference;
    //public int PowerUpMeter;
    public int Timer = 1;

	void Start()
	{
        CubeReference = GameObject.Find("Cube");
        //PowerUpMeter = 50; //default 'bonus' at startup.

	}

	void Update ()
	{
        DestroyPowerUp();
        AnimatePowerUp();
    }

    private bool AtePowerUp()
    {
        //Eat or Destroy PowerUp

        Vector2 distance = new Vector2(
            transform.position.x - CubeReference.transform.position.x,
            transform.position.y - CubeReference.transform.position.y);

        //Determines whether or not Cube is near PowerUp (within 0.5 units):
        if (((distance.x < 0.5f) && (distance.x > -0.5f)) && ((distance.y < 0.5f) && (distance.y > -0.5f)))
            return true;
        else
            return false;

    }

    private void DestroyPowerUp()
    {
        Timer++;
        if (AtePowerUp())
        {
            GameObject.Destroy(this.gameObject);
            PowerUpManager.PowerUpMeter += 100;
            //Debug.Log(PowerUpManager.PowerUpMeter);
            //PowerUpMeter += 100;
        }

        //After 140 ticks, the powerup is destroyed:
        if (Timer % 140 == 0)
        {
            GameObject.Destroy(this.gameObject);

        }
    }

    private void AnimatePowerUp()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(1, 1, 1), 0.05f);
    }
}