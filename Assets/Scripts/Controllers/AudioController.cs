using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    static AudioSource sound = new AudioSource();

    public static void playAudio(string audioName) 
    {
        print("Audioclips/" + audioName);
        sound.clip = Resources.Load<AudioClip>("Audioclips/" + audioName);
        sound.Play();
    }
}

