using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelThrow : MonoBehaviour
{
    public GameObject barrelPrefab;
    public Transform Hand;
    public float throwForce = 10f;

    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject grenadeBlue = Instantiate(barrelPrefab, Hand.position, Hand.rotation) as GameObject;
            grenadeBlue.GetComponent<Rigidbody>().AddForce(Hand.forward * throwForce, ForceMode.Impulse);
        }
    }
}
