using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBorder : MonoBehaviour
{

    public ScoreUI score;
    public GameObject Player2Goal;
    public GameObject Player1Goal;
    public Color redcolor;
    public Color bluecolor;
    void OnCollisionEnter(Collision col)
    {

        Ball ball = col.gameObject.GetComponent<Ball>();
        
     
 
        if (ball != null)
        {

            score.scorePlayerRight++;

            col.gameObject.GetComponent<Renderer>().material.color = Color.magenta;

            ball.transform.position = new Vector3(0f, 1f, 0f);

        }
        

    }

}
