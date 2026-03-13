using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundWwise : MonoBehaviour
{
    public AK.Wwise.Event soundEvent;
    void Start()
    {
        soundEvent.Post(gameObject);
    }
}
