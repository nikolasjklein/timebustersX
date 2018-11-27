using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public GameObject Nade_Normal;
    public GameObject Nade_Energy;
    public GameObject Nade_Fire;
    public GameObject Nade_Ice;
    public GameObject Nade_Pebble;
    public GameObject Nade_Poison;

    public Transform Hand;
    public float throwForce = 10f;

    public GameObject Nade;

    public Material NadeNormal;
    public Material NadeEnergy;
    public Material NadeFire;
    public Material NadeIce;
    public Material NadePebble;
    public Material NadePoison;

    public int nadeState;


	void Start ()
    {
        nadeState = 0;
	}
	
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            nadeState = 0;
        }

        else if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            nadeState = 1;
        }

        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            nadeState = 2;
        }

        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            nadeState = 3;
        }

        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            nadeState = 4;
        }

        else if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            nadeState = 5;
        }

        if (nadeState == 0)
        {
            Nade.GetComponent<Renderer>().sharedMaterial = NadeNormal;

            if (Input.GetButtonDown("Fire1"))
            {
                GameObject NadeNormal = Instantiate(Nade_Normal, Hand.position, Hand.rotation) as GameObject;
                NadeNormal.GetComponent<Rigidbody>().AddForce(Hand.forward * throwForce, ForceMode.Impulse);
            }
        }

        else if (nadeState == 1)
        {
            Nade.GetComponent<Renderer>().sharedMaterial = NadeEnergy;

            if (Input.GetButtonDown("Fire1"))
            {
                GameObject NadeEnergy = Instantiate(Nade_Energy, Hand.position, Hand.rotation) as GameObject;
                NadeEnergy.GetComponent<Rigidbody>().AddForce(Hand.forward * throwForce, ForceMode.Impulse);
            }
        }

        else if (nadeState == 2)
        {
            Nade.GetComponent<Renderer>().sharedMaterial = NadeFire;

            if (Input.GetButtonDown("Fire1"))
            {
                GameObject NadeFire = Instantiate(Nade_Fire, Hand.position, Hand.rotation) as GameObject;
                NadeFire.GetComponent<Rigidbody>().AddForce(Hand.forward * throwForce, ForceMode.Impulse);
            }
        }

        else if (nadeState == 3)
        {
            Nade.GetComponent<Renderer>().sharedMaterial = NadeIce;

            if (Input.GetButtonDown("Fire1"))
            {
                GameObject NadeIce = Instantiate(Nade_Ice, Hand.position, Hand.rotation) as GameObject;
                NadeIce.GetComponent<Rigidbody>().AddForce(Hand.forward * throwForce, ForceMode.Impulse);
            }
        }

        else if (nadeState == 4)
        {
            Nade.GetComponent<Renderer>().sharedMaterial = NadePebble;

            if (Input.GetButtonDown("Fire1"))
            {
                GameObject NadePebble = Instantiate(Nade_Pebble, Hand.position, Hand.rotation) as GameObject;
                NadePebble.GetComponent<Rigidbody>().AddForce(Hand.forward * throwForce, ForceMode.Impulse);
            }
        }

        else if (nadeState == 5)
        {
            Nade.GetComponent<Renderer>().sharedMaterial = NadePoison;

            if (Input.GetButtonDown("Fire1"))
            {
                GameObject NadePoison = Instantiate(Nade_Poison, Hand.position, Hand.rotation) as GameObject;
                NadePoison.GetComponent<Rigidbody>().AddForce(Hand.forward * throwForce, ForceMode.Impulse);
            }
        }
    }
}
