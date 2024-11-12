using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Audio;

public class Audionew : MonoBehaviour
{

    public Sound[] sounds;

    private void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.audiosouz = gameObject.AddComponent<AudioSource>();
            s.audiosouz.clip = s.clip;

            s.audiosouz.volume = s.volume;
            s.audiosouz.pitch = s.pitch;
            s.audiosouz.loop = true; 
        }
    }

    public void Play (string name)
    {
       Sound s =  Array.Find(sounds, Sound => Sound.name == name);
        if (s == null)
            return;
        s.audiosouz.Play();
    }
}
