using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if(!isPlayer1Goal)
            {
                Debug.Log("Player 2 Scored...");
                GameObject.Find("GameManage").GetComponent<GameManage>().Player1Scored();
            }

            else
            {
                Debug.Log("Player 1 Scored...");
                GameObject.Find("GameManage").GetComponent<GameManage>().Player2Scored();
            }
        }
    }
}