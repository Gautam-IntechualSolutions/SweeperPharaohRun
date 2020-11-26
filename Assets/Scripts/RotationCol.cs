using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCol : MonoBehaviour
{

    public int whichSide;
    int Roate = 1;
    public int RotateEnd;
    private void Start()
    {
        if (whichSide == 1)
            StartCoroutine(Rotation1(GameManger.Instance.speed));
        else if (whichSide == 2)
        {
            StartCoroutine(Rotation3(GameManger.Instance.speed));
            Roate = RotateEnd + 1;
        }
    }
    IEnumerator Rotation3(float sec)
    {
        transform.rotation = Quaternion.Euler(0.0f, 0, Roate);
        Roate--;
        yield return new WaitForSeconds(sec);

        if (Roate == RotateEnd)
            StartCoroutine(Rotation4(GameManger.Instance.speed));
        else
            StartCoroutine(Rotation3(GameManger.Instance.speed));


    }
    IEnumerator Rotation4(float sec)
    {
        transform.rotation = Quaternion.Euler(0.0f, 0, Roate);
        Roate++;
        yield return new WaitForSeconds(sec);

        if (Roate == 0)
            StartCoroutine(Rotation3(GameManger.Instance.speed));
        else
            StartCoroutine(Rotation4(GameManger.Instance.speed));


    }
    IEnumerator Rotation2(float sec)
    {
        transform.rotation = Quaternion.Euler(0.0f, 0, Roate);
        Roate--;
        yield return new WaitForSeconds(sec);

        if (Roate == 0)
            StartCoroutine(Rotation1(GameManger.Instance.speed));
        else
            StartCoroutine(Rotation2(GameManger.Instance.speed));


    }

    IEnumerator Rotation1(float sec)
    {

        transform.rotation = Quaternion.Euler(0.0f, 0, Roate);
        Roate++;

        yield return new WaitForSeconds(sec);

        if (Roate == RotateEnd)
            StartCoroutine(Rotation2(GameManger.Instance.speed));
        else
            StartCoroutine(Rotation1(GameManger.Instance.speed));
    }
}



