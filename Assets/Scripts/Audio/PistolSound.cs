using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolSound : GunSound
{
    public override string Name {get; set;}

    public override void Play()
    {
        source.Play();
    }
}
