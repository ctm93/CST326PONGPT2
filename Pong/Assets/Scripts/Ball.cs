using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
  public int amplify = 1000;
  private Vector3 impactValue = Vector3.zero;
  public float impulseStrength = 5f;

  public AudioSource ballSound;

    void Start()
    {
        ballSound = GetComponent<AudioSource>();

        float sx = Random.Range(0, 2) == 0 ? -1 : 1;
        float sy = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent <Rigidbody>().velocity = new Vector3(impulseStrength * sx, impulseStrength * sy, 0f);

    }


    void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"I hit the {collision.collider.name}");
        ballSound.Play();

    }



}
