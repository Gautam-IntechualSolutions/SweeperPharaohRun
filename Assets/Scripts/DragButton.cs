using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragButton : MonoBehaviour
{

    private RectTransform Obj;
    public GameObject playerObj;
    Vector2 vecobj;

    private void Awake()
    {
        Obj = GetComponent<RectTransform>();
    }

    public void Drag()
    {

        if ((playerObj.transform.position.y > 130 && playerObj.transform.position.y < 1500) && (playerObj.transform.position.x > 100 && playerObj.transform.position.x < 980))
playerObj.transform.position = Input.mousePosition;

        if(playerObj.transform.position.y <= 130 && playerObj.transform.position.x <= 100)
            playerObj.transform.position = new Vector3(101, 131, 0);
        else if (playerObj.transform.position.y <= 130 && playerObj.transform.position.x >= 980)
            playerObj.transform.position = new Vector3(979, 131, 0);
        else if (playerObj.transform.position.y >= 1500 && playerObj.transform.position.x >= 980)
            playerObj.transform.position = new Vector3(979, 1490, 0);
        else if (playerObj.transform.position.y >= 1500 && playerObj.transform.position.x <= 100)
            playerObj.transform.position = new Vector3(101, 1490, 0);
        else if (playerObj.transform.position.y <= 130)
            playerObj.transform.position = new Vector3(playerObj.transform.position.x, 131,0);
        else if(playerObj.transform.position.y >= 1500)
            playerObj.transform.position = new Vector3(playerObj.transform.position.x, 1490, 0);
        else if (playerObj.transform.position.x <= 100)
            playerObj.transform.position = new Vector3(101, playerObj.transform.position.y, 0);
        else if (playerObj.transform.position.x >= 980)
            playerObj.transform.position = new Vector3(979, playerObj.transform.position.y, 0);


        //if (playerObj.transform.localPosition.x > 440 && playerObj.transform.localPosition.y < )
        //{
        //    playerObj.transform.localPosition = new Vector3(430, 0, 0);
        //    //  playerObj.transform.localPosition = new Vector3(440, playerObj.transform.localPosition.y, playerObj.transform.localPosition.z);
        //}
        //else if (playerObj.transform.localPosition.x < -440)
        //{
        //    playerObj.transform.localPosition = new Vector3(-430, 0, 0);
        //    // playerObj.transform.localPosition = new Vector3(-440, playerObj.transform.localPosition.y, playerObj.transform.localPosition.z);
        //}
        //else if (playerObj.transform.localPosition.y > 550)
        //{
        //    playerObj.transform.localPosition = new Vector3(0, 540, 0);
        //    // playerObj.transform.localPosition = new Vector3(playerObj.transform.localPosition.x, 550, playerObj.transform.localPosition.z);
        //}
        //else if (playerObj.transform.localPosition.y < -960)
        //{
        //    playerObj.transform.localPosition = new Vector3(0, -950, 0);
        //    // playerObj.transform.localPosition = new Vector3(playerObj.transform.localPosition.x, -960, playerObj.transform.localPosition.z);
        //}
        //else
        //{
        //    playerObj.transform.localPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        //}
    }

}

