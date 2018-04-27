using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Loader : MonoBehaviour
{

    public void StartGame()
    {
        GameObject.Find("Player").transform.GetComponent<PlayerControl>().canRoll = true;
        GameObject.Find("btn_Start").SetActive(false);
        GameObject.Find("btn_Settings").SetActive(false);
        //GameObject.Find("btn_PlayAgain").SetActive(true);

    }

}
