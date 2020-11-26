using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    AudioSource[] Sound;
    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        Sound = gameObject.GetComponents<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {


    }

    public void StopBackgroudmusic()
    {
        Sound[0].volume = 0;
    }
    public void PlayBackgroudmusic()
    {
        Sound[0].volume = 1;
    }

    public void Tap()
    {
        if (PlayerPrefs.GetInt("Volume") == 0)
            Sound[1].Play();
    }


    public void GameOverSound()
    {
        if (PlayerPrefs.GetInt("Volume") == 0)
            Sound[2].Play();
    }

    public void ScoreSound()
    {
        if (PlayerPrefs.GetInt("Volume") == 0)
            Sound[3].Play();
    }
}
