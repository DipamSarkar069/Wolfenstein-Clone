using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAI : MonoBehaviour
{
    public string hitTag;
    public float fireRate = 0.5f;

    public bool lookingAtPlayer=false;
    public bool isFiring = false;

    public GameObject soldier;

    public AudioSource enemyFire;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            hitTag = hit.transform.tag;
        }
        if(hitTag=="Player" && isFiring==false)
        {
            StartCoroutine(EnemyFire());
        }
        else if(hitTag!="Player")
        {
            soldier.GetComponent<Animator>().Play("demo_combat_idle");
            lookingAtPlayer = false;
        }
    }

    IEnumerator EnemyFire()
    {
        isFiring = true;
        soldier.GetComponent<Animator>().Play("demo_combat_shoot",-1,0);
        soldier.GetComponent<Animator>().Play("demo_combat_shoot");
        enemyFire.Play();
        lookingAtPlayer = true;
        yield return new WaitForSeconds(fireRate);
        isFiring = false;

    }
}
