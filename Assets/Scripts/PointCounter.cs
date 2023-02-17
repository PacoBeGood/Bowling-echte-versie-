using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PointCounter : MonoBehaviour
{

    [SerializeField] private TMP_Text scoreText;
    private int score = 0;
    [SerializeField] List<Pin> pins;
    [SerializeField] List<GameObject> pin;
    [SerializeField] private Button resetButton;
    private bool pointGiven;


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: 0";
        resetButton.onClick.AddListener(Reset);
    }



    void Update()
    {
        foreach (Pin p in pins)
        {
            if (p.transform.position.y < 0.15f)
            {
                if (pointGiven == false) {

                
                score += 1;
                 p.hasFallen = true;
                 pointGiven = true; 
                 }
                 if (pointGiven == true)
                 {
                    p.hasFallen = true;
                 }


                if (p.hasFallen == true)
                {
                    foreach (GameObject b in pin)
                    {
                        Destroy(b);
                    }
                }


            }
        }
        scoreText.text = "Score: " + score;
    }

    void Reset()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
