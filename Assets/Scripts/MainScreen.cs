using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainScreen : MonoBehaviour
{
    public Text Score;
    public GameObject Music;
    public GameObject Volume;


    // Start is called before the first frame update
    void Start()
    {

        GameObject[] objects = GameObject.FindGameObjectsWithTag("AudioManager");

        Score.GetComponent<Text>().text = "Best Score " + PlayerPrefs.GetInt("BestScore");

        if (objects.Length > 1)
            Destroy(objects[0]);


        if (PlayerPrefs.GetInt("Music") == 0)
        {
            Music.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Music_On");
            AudioManager.Instance.PlayBackgroudmusic();

        }
        else
        {
            AudioManager.Instance.StopBackgroudmusic();
            Music.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Music_Off");
        }


        if (PlayerPrefs.GetInt("Volume") == 0)
            Volume.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Volume_On");
        else
            Volume.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Volume_Off");

    }

    public void ClickOnMusic()
    {
        AudioManager.Instance.Tap();

        if (PlayerPrefs.GetInt("Music") == 0)
        {
            PlayerPrefs.SetInt("Music", 1);
            Music.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Music_Off");
            AudioManager.Instance.StopBackgroudmusic();

        }
        else
        {
            PlayerPrefs.SetInt("Music", 0);
            Music.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Music_On");
            AudioManager.Instance.PlayBackgroudmusic();

        }
    }

    public void ClickOnVolume()
    {
        AudioManager.Instance.Tap();

        if (PlayerPrefs.GetInt("Volume") == 0)
        {
            PlayerPrefs.SetInt("Volume", 1);
            Volume.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Volume_Off");
        }
        else
        {
            PlayerPrefs.SetInt("Volume", 0);
            Volume.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Volume_On");

        }
    }

    public void onClickPlay()
    {

        SceneManager.LoadScene("GameScreen");
    }

}
