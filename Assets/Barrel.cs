using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    public float timeDelay = 2f;
    public float startTimer;

    public int damage = 10;
    public float explosiveForce = 20f;
    public float explosiveRadius = 15f;

    public void Update()
    {
        startTimer += Time.deltaTime;
        if (startTimer >= timeDelay)
        {
            Explode();
        }
    }

    public void Explode()
    {
        Collider[] coll = Physics.OverlapSphere(transform.position, explosiveRadius);

        /*
        for (int i = 0; i < coll.Length; i++)
        {
            if (coll[i].gameObject.GetComponent <PlayerController_Green>())
            {
                coll[i].gameObject.GetComponent<PlayerController_Green>().TakeDamage(damage);
                coll[i].gameObject.GetComponent<Rigidbody>().AddExplosionForce(explosiveForce, transform.position, explosionRadius);
            }
        }
        */

        Destroy(gameObject);
    }
}
