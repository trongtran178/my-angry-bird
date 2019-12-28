using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float health = 4f;

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        Debug.Log(collisionInfo.relativeVelocity.magnitude);
        if (collisionInfo.relativeVelocity.magnitude > health)
        {
            Debug.Log(collisionInfo.relativeVelocity.magnitude);
            Die();
        }
        
        // Debug.Log(collisionInfo.relativeVelocity.magnitude);
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
