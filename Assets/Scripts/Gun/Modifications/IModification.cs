using UnityEngine.Audio;
using UnityEngine;
namespace Gun.Modifications
{
    public interface IAudioModification
    {
        AudioClip clip {get; set;}
    }

    public interface IAmmoModification
    {
        int ammo {get; set;}
    }
}