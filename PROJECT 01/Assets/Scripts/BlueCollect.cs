using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BlueCollect : MonoBehaviour
{
    public Text scoretext;
    public GameObject BLUEDOOR;
    int score = 0;

    private void Start()
    {
        scoretext.text = "Blue = " + score.ToString();

    }

    private void OnCollisionEnter2D(Collision2D otherObject)
    {
        if (otherObject.gameObject.tag == "Coin2")
        {
            score++;



            if (score == 5)
            {
                scoretext.text = "Blue = 5/" + score.ToString();
                Destroy(BLUEDOOR);
            }
            else
            {
                scoretext.text = "Blue = " + score.ToString();
            }

            Destroy(otherObject.gameObject);
            Debug.Log(score);
        }
    }

}