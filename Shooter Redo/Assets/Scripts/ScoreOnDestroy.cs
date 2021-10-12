using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOnDestroy : MonoBehaviour
{
    public int ScoreValue = 50;
    private AudioSource mAudioSrc;


    void OnDestroy()
    {
        GameController.Score += ScoreValue;
    }

    void Start()
    {

    }
}
