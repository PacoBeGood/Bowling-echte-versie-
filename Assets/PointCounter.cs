using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointCounter : MonoBehaviour
{
   
    [SerializeField] private  TMP_Text scoreText;
    private int score;
    [SerializeField] private GameObject ball;
    

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: 0";
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "target")
        {
            score += 1;
            scoreText.text = "Score: " + score;
            Destroy(other);
        }
        if (other.tag == "ball")
        {
            Destroy(other);
           GameObject ball2 =  Instantiate(ball);
           ball2.transform.position = new Vector3(0.501f,-0.851f,0.482f);
        }
    }

    void Update()
    {
        scoreText.text = "Score: " + score;
    }
    
}
