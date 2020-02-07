using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    int EnemyHealth = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    void DeductPoints(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

    void Update()
    {
        if (EnemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
