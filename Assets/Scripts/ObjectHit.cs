using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    //this is a callback, which means whenever sth hits this game object and event takes place 
    //and by this way, we will be noticed. 
    //the object which hit this object, is called "collision"
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //change the color of the wall when sth hits it by accessing the mesh renderer and changing its material
            GetComponent<MeshRenderer>().material.color = Color.red;

            gameObject.tag = "Hit";
        }
    }
}
