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
                if (p.hasFallen == false) {

                
                score += 1;
                 p.hasFallen = true;
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
