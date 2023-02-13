using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointCounter : MonoBehaviour
{
   
    [SerializeField] private  TMP_Text scoreText;
    private int score;
    [SerializeField] private static List<Gameobject> targets = new List<Gameobject>();
    

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: 0";
    }

    

    void Update()
    {
        
        scoreText.text = "Score: " + score;
    }
    
}
