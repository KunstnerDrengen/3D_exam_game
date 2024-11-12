using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public struct SoundEffect
{
    //https://www.youtube.com/watch?v=jEoobucfoL4&ab_channel=Raycastly
    // Group ID string
    public string groupID;
    
    //Array of audioclips with different soundeffects
    public AudioClip[] clips;

    //Target the SFX should be played at
    public GameObject Soundtarget;
}
public class Library_sound : MonoBehaviour
{
    //Array storing the audioclips, audiomixer etc as a class
    public SoundEffect[] SoundSFX;

    // Audiomixer group, assigning the clips to an audiomixer
    public AudioMixerGroup Mixergroup;

    //getclipfromname creates a public audioclip and gets a ranodm clip/clipname from the array of audioclips
    public AudioClip GetClipFromName(string clipname, Vector3 Position)
    {
        
        //Loops each sound sfx in the current array
        foreach (var SoundEffect in SoundSFX)
        {
            //if the name matches the string name it gets a random clip in the array
            if (SoundEffect.groupID == clipname)
            {
                Position = SoundEffect.Soundtarget.transform.position;
                return SoundEffect.clips[Random.Range(0, SoundEffect.clips.Length)]; 
            }
        }
        // if it finds nothing, return null.
        return null; 
    }
}
