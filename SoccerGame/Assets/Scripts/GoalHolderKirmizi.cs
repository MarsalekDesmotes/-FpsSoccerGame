using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalHolderKirmizi : MonoBehaviour
{
    public AudioSource crowd_audio;
    public static int k�rm�z�tak�mgol;
 
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            k�rm�z�tak�mgol++;
        crowd_audio.Play();
        }
        

    }
}
