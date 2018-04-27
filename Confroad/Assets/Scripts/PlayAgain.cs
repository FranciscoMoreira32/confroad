using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayAgain : MonoBehaviour
{


    public void ResetGame()
    {

        GameObject.Find("Player").transform.GetComponent<PlayerControl>().canRoll = true;
        GameObject.Find("Player").GetComponent<Rigidbody>().isKinematic = false;

        // Contagem a 0
        //GameObject.Find("Player").transform.GetComponent<PlayerControl>().count = 0;

        // Restabelecer moedas


        //Apagar texto
        GameObject.Find("Win Text").GetComponent<Text>().enabled = false;


        //Reposicionar player
        GameObject.Find("Player").transform.position = new Vector3(13f, 5f, 5f);
        

    }

}
