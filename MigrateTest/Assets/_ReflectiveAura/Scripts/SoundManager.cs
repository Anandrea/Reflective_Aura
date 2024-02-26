using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioSource backgroundSource;
    [SerializeField] AudioSource effectSource;
    [SerializeField] AudioClip happy;
    [SerializeField] AudioClip sad;
    [SerializeField] AudioClip angry;
    [SerializeField] AudioClip rain;
    [SerializeField] AudioClip birds;
    [SerializeField] AudioClip fire;

    public void AngrySound()
    {
        backgroundSource.clip = angry;
        backgroundSource.Play();
        effectSource.clip = fire;
        effectSource.Play();
    }

    public void HappySound()
    {
        backgroundSource.clip = happy;
        backgroundSource.Play();
        effectSource.clip = birds;
        effectSource.Play();
    }

    public void SadSound()
    {
        backgroundSource.clip = sad;
        backgroundSource.Play();
        effectSource.clip = rain;
        effectSource.Play();
    }

    public void NeutralSound()
    {
        backgroundSource.Stop();
        effectSource.Stop();
    }
}
