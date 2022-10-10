using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSound : MonoBehaviour
{
    public AudioSource racketSound;
    public AudioSource wallSound;


    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "RacketPlayer1" || collision.gameObject.name == "RacketPlayer2")
        {

            this.racketSound.Play();
        }
        else {

            this.wallSound.Play();
        }
    }
}
