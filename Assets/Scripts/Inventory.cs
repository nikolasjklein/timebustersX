using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public string[] weapons;

    public Text Weapon0Slot;
    public Text Weapon1Slot;
    public Text Weapon2Slot;
    public Text Weapon3Slot;
    public Text Weapon4Slot;
    public Text Weapon5Slot;
    public Text Weapon6Slot;
    public Text Weapon7Slot;
    public Text Weapon8Slot;


    void Start ()
    {
        if (weapons[0] == null)
        {
            Weapon0Slot.text = "null";
        }

        if (weapons[1] == null)
        {
            Weapon1Slot.text = "null";
        }

        if (weapons[2] == null)
        {
            Weapon2Slot.text = "null";
        }

        if (weapons[3] == null)
        {
            Weapon3Slot.text = "null";
        }

        if (weapons[4] == null)
        {
            Weapon4Slot.text = "null";
        }

        if (weapons[5] == null)
        {
            Weapon5Slot.text = "null";
        }

        if (weapons[6] == null)
        {
            Weapon6Slot.text = "null";
        }

        if (weapons[7] == null)
        {
            Weapon7Slot.text = "null";
        }

        if (weapons[8] == null)
        {
            Weapon8Slot.text = "null";
        }
    }
	
	void Update () {
		
	}
}
