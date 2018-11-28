using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item_PickMeUp : MonoBehaviour
{
    public Canvas PlayCanvas;
    public Text PickMeUpText;
    public GameObject Player;

    public void Start()
    {
        PickMeUpText.gameObject.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        PickMeUpText.gameObject.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        PickMeUpText.gameObject.SetActive(false);
    }
	
	void Update ()
    {
		
	}
}
