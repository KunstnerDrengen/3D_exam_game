using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;

public class Soundmaneger : MonoBehaviour
{   
    // instance of a new soundmanager
    public static Soundmaneger Instance_sound;
    [SerializeField]

    // reference to other script
    public Library_sound sfxLibrary;

    private void Awake()
    {
        
        //makes sure there is only one instance of the new gameobject
       if (Instance_sound != null)
        {
            Destroy(gameObject);
        }
       else
        {
            Instance_sound = this;
        }
    }
    
    public void playclips(string soundname, Vector3 position)
    {
        
        if (soundname != null)
        {
            sfxLibrary.GetClipFromName(soundname,position);
            AudioSource audioSource = (AudioSource)gameObject.AddComponent(typeof(AudioSource));
            audioSource.clip = sfxLibrary.GetClipFromName(soundname,position);
            audioSource.outputAudioMixerGroup = sfxLibrary.Mixergroup;
            audioSource.spatialBlend = 0.8f; 
            audioSource.Play();
            audioSource.transform.localPosition = position;
            //DestroyTimer.Destroy(audioSource,2.0f);
        }
        else
        {
            return;
        }
    }
}

