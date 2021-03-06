using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] ParticleSystem hitVFX;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Bullet(Clone)")
        {
            Instantiate(hitVFX, transform.position, Quaternion.identity);
            Invoke("Die", 1f);
           // Die();
        }


        else { return; }
    }

    private void OnTriggerEnter(Collider other)
    {

            GetComponent<LevelLoader>().ActivateLoseCanvas();
        
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
