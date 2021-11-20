using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update

    public Sound[] sounds;

    private void Awake() //runs before the start
    {
        foreach (Sound sound in sounds)
        {
            sound.source = gameObject.AddComponent<AudioSource>(); //create AudioSource

            //get newly created AudioSource, get its clip, change the clip into the clip from the sound array
            sound.source.clip = sound.clip;

            //similarly do the samething with volume and pitch
            sound.source.volume = sound.volume;
            sound.source.pitch = sound.pitch;

            sound.source.loop = sound.Loop;
        }
    }

    //so other scripts are able to play the sound files by their name
    public void Play(string name)
    {
        //create new Sound Class, and find data within the sounds array that matches name given by the Play function
        Sound sound = Array.Find(sounds, sound => sound.name == name); //name in array must be equal to name given by play

        sound.source.Play();//getting the value, look at the Sound source and Playing it.
    }
}