using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject pistol;
    [SerializeField] bool canShoot;
    AudioSource uziSFX;

    // Start is called before the first frame update
    void Start()
    {
        canShoot = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (canShoot == true && Input.GetMouseButtonDown(0))
        {
            Fire();
            GetComponent<AudioSource>().Play();
        }

    }

    void Fire()

    {
        Instantiate(bullet, pistol.transform.position, Quaternion.identity);
    }

}
