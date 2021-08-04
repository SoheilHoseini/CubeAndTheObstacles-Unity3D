using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 5;
    new MeshRenderer renderer;
    Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        //make the cube invisible at the start of the game
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;

        //at the begining it should not fall
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait)
        {
            renderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
