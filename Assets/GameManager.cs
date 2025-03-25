using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class GameManager : MonoBehaviour
{

[SerializeField] AudioSource audioSource;
    [SerializeField] PlayableDirector director;
    

    void Start() {
        director.Play();
        audioSource.Play();  // Ensures playback in case Timeline fails
    }
}
