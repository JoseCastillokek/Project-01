using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collect : MonoBehaviour
{
    public Text scoretext;
    public GameObject RedDoor;
    int score = 0;

    private void Start()
    {
        scoretext.text = "Red = " + score.ToString();
        
    }

    private void OnCollisionEnter2D(Collision2D otherObject)
    {
        if (otherObject.gameObject.tag == "coin")
        {
            score++;

           

            if (score == 5)
            {
              scoretext.text = "Red = 5/" + score.ToString();
                Destroy(RedDoor);
            }
            else
            {
                scoretext.text = "Red = " + score.ToString();
            }

            Destroy(otherObject.gameObject);
            Debug.Log(score);
        }
    }

}