using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TriggerEnd : MonoBehaviour {
    public bool finish = false;
    public Text winText;

    // Use this for initialization
    void Start()
    {
        winText.text = "";
    }

    void OnTriggerEnter(Collider other) {

        if (other.name == "Player")
            {
            Debug.Log("Finish");
  
            int count = GameObject.Find("Player").transform.GetComponent<PlayerControl>().count;

            //Gravar em ficheiro
            using (StreamWriter sw = new StreamWriter("Score.txt"))
            {
                // Add some text to the file.
                sw.Write("The last score was: ");
                sw.WriteLine("");
                sw.WriteLine("{0} in 21", count.ToString());
                sw.WriteLine("");
                sw.WriteLine("GOOD LUCK!!!");
            }

                winText.text = "YOU WIN!" + " " + count.ToString() + " / 21";
                resetPlayer(other.gameObject);
                
                
                
            }
    }

    //void FixedUpdate()
    //{
    //    if (GameObject.Find("Player").transform.position.y < -1)
    //    {
    //       GameObject.Find("Player").transform.position = new Vector3(-13.63f, 0.454f, -13.84f);
    //    }

    //}

    // Update is called once per frame
    void resetPlayer (GameObject player) {

        GameObject.Find("Player").transform.GetComponent<PlayerControl>().canRoll = false;
        player.GetComponent<Rigidbody>().isKinematic = true;
    }
}
