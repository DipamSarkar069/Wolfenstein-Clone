using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmoCount : MonoBehaviour
{
    public static int maxAmmo;
    public GameObject ammoDisplay;

    // Update is called once per frame
    void Update()
    {
        ammoDisplay.GetComponent<Text>().text = "" + maxAmmo;
    }
}
