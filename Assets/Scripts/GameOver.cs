using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text Score;
    // Start is called before the first frame update
    void Start()
    {
        Score.GetComponent<Text>().text = "Score " + GameManger.Instance.GameScore;

        if (PlayerPrefs.GetInt("BestScore") < GameManger.Instance.GameScore)
            PlayerPrefs.SetInt("BestScore", GameManger.Instance.GameScore);
    }

    public void onClickMenu()
    {
        SceneManager.LoadScene("StartScreen");
    }
}

