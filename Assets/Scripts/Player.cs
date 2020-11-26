using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public Text Text_Score;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTrigerEnter2D(Collision2D col)
    {
        Debug.Log("Trigered");
    }

    void OnCollisionEnter2D(Collision2D col)
    {


        if (col.gameObject.name == "score1" || col.gameObject.name == "score2" || col.gameObject.name == "score3" || col.gameObject.name == "score4")
        {
            col.gameObject.SetActive(false);
            GameManger.Instance.GameScore++;
            AudioManager.Instance.ScoreSound();

            if (GameManger.Instance.GameScore % 5 == 0)
            {
                GameManger.Instance.ScreenSpeed += 50;
            }
            Text_Score.GetComponent<Text>().text = "" + GameManger.Instance.GameScore;
        }
        else
        {
            AudioManager.Instance.GameOverSound();
            SceneManager.LoadScene("GameOver");
        }
        
        

    }
}

