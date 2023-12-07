using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //variables
    public GameObject Boundary;                               //declare GameObject variable

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Boundary.transform.position.x, transform.position.y, -10);                //declare transform camera function for the tartget variable
    }
}
