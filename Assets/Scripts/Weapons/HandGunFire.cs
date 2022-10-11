using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunFire : MonoBehaviour
{
    public GameObject handGun;
    public GameObject muzzleFlash;
    public AudioSource gunFire;
    public bool isFiring=false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if(isFiring==false)
            {
                StartCoroutine(GunFire());
            }

        }
    }

    IEnumerator GunFire()
    {
        isFiring = true;
        gunFire.Play();
        handGun.GetComponent<Animator>().Play("HandGunFire");
        muzzleFlash.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        muzzleFlash.SetActive(false);
        yield return new WaitForSeconds(0.05f);
        handGun.GetComponent<Animator>().Play("New State");
        isFiring = false;

    }
}
