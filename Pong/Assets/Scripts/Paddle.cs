using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //private float movement;
    public bool paddle1Move;
    public float speed = 5f;
    public AudioSource paddleSound1;


    void Update()
    {
        if(paddle1Move)
        {
            transform.Translate(0f, Input.GetAxis("Player1") * speed * Time.deltaTime, 0f);
        }
        else
        {
            transform.Translate(0f, Input.GetAxis("Player2") * speed * Time.deltaTime, 0f);
        }

    }




}
