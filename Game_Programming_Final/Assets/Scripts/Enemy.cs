using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Health damage;

    public GameObject hitPoints;

   
    // Start is called before the first frame update
    void Start()
    {
        damage = hitPoints.GetComponent<Health>();           //declare damage function and health components script 
    }


    public bool left;

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D coll)                 //declare trigger for damage function and conditions for emeny collisions
    {
        if (coll.tag == "Player")
        {
            damage.TakeDamage(1);
        }

        if (coll.tag == "Enemy" && left == true)
        {
            left = false;
        }

        else if (coll.tag == "Enemy" && left == false)
        {
            left = true;
        }
    }

    void OnCollisionEnter2D(Collision2D other)               //log collisions to console
    {
        Debug.Log("Hit");
    }

}

