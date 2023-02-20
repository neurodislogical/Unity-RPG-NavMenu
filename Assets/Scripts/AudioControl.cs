using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public static AudioControl instance;

    private void Awake()
    {
        //Prevent audio cut out between scenes
        DontDestroyOnLoad(this.gameObject);

        // If the variable is null, set this audio as the instance
        if (instance == null)
        {
            instance = this;
        }
        // If there is already a MusicControl instance active the cuts audio
        else
        {
            Destroy(gameObject);
        }
    }
}
