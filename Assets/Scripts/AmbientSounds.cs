using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientSounds : MonoBehaviour
{
    public AudioSource[] birdSounds;

    private void Start()
    {
        InvokeRepeating("PlaySounds", 1, 5);
    }

    private void PlaySounds()
    {
        int n=Random.Range(0, birdSounds.Length-1);
        birdSounds[n].Play();
    }
}
