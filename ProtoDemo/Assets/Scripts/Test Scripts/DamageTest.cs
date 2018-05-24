using UnityEngine;
using System.Collections;

public class DamageTest : MonoBehaviour
{
    int _healthPoints = 100;
	void Start()
	{
        DealDamage();
        DealDamage();

        Debug.Log(_healthPoints);
	}

	void DealDamage()
	{
        _healthPoints -= 5;
	}
}