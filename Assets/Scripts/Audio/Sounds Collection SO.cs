using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SoundsCollectionSO : ScriptableObject
{
    [Header("Music")] 
    public SoundSO[] AmbientMusic;

    [Header("SFX")] 
    public SoundSO[] ItemPickup;
    public SoundSO[] MonsterNoise;
}
