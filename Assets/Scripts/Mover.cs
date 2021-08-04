using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //changing these values in the inspector will not change anything here.
    [SerializeField] float moveSpeed = 0.02f;

    // Start is called before the first frame update
    void Start()
    {
        ////access the "Transform" component of the related game object of this script (which is "Player (Dodgy)" here)
        ////Translate adds the given numbers to the current pos of the game object
        ////and this move will just happens once!
        //transform.Translate(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;//to make it "frame independent" in any computer with any speed

        //anything in the update, is executed in every fram
        //so if my computer is currently runnig at 60 frame/sec, this line will move the player 60 times per sec to positive x axis at 0.01m
        transform.Translate(xValue, 0, zValue);
    }
}
