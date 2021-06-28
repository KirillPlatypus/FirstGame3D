using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public abstract class GunSound : MonoBehaviour
{
    public abstract string Name {get; set;}
    
    public AudioSource source;

    public abstract void Play();
}
