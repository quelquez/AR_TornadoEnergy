using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip audioOpenSoda, audioBubbles;

    public void PlayAudio()
    {
        _audioSource.clip = audioOpenSoda;
        _audioSource.Play();
    }
}
