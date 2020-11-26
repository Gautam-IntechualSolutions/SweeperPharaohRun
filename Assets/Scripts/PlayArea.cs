using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayArea : MonoBehaviour
{

    public GameObject Background1;
    public GameObject Background2;
    public GameObject Score1;
    public GameObject Score2;
    public GameObject Score3;
    public GameObject Score4;


    // Update is called once per frame
    void Update()
    {
        Background1.transform.Translate(Vector3.down * Time.deltaTime * GameManger.Instance.ScreenSpeed);
        Background2.transform.Translate(Vector3.down * Time.deltaTime * GameManger.Instance.ScreenSpeed);


        if (Background1.GetComponent<RectTransform>().localPosition.y <= -1920)
        {
            Background1.GetComponent<RectTransform>().localPosition = new Vector3(0.0f, 1920.0f, 0.0f);
            Background2.GetComponent<RectTransform>().localPosition = new Vector3(0.0f, 0.0f, 0.0f);
            Score1.gameObject.SetActive(true);
            Score2.gameObject.SetActive(true);


        }
        if (Background2.GetComponent<RectTransform>().localPosition.y <= -1920)
        {
            Background2.GetComponent<RectTransform>().localPosition = new Vector3(0.0f, 1920.0f, 0.0f);
            Background1.GetComponent<RectTransform>().localPosition = new Vector3(0.0f, 0.0f, 0.0f);
            Score3.gameObject.SetActive(true);
            Score4.gameObject.SetActive(true);
        }
    }
}
