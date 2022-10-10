using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunPickup : MonoBehaviour
{
    public GameObject realHandGun;
    public GameObject fakeHandGun;
    public AudioSource GunPickup;

    void OnTriggerEnter(Collider other)
    {
        realHandGun.SetActive(true);
        fakeHandGun.SetActive(false);
        GunPickup.Play();
    }
}
