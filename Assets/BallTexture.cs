using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeCoaching;

public class BallTexture : MonoBehaviour
{
    // Start is called before the first frame update
   
          private float response;
    
    string url = "https://media.istockphoto.com/id/637918362/photo/come-with-me.jpg?b=1&s=170667a&w=0&k=20&c=SnR3W4JuzLDHmQAFDOH9lulkB_Vhl0vE4sJnYA6VQss=";

    [SerializeField] private GameObject imagePrefab;
    

    void Start()
    {
         StartCoroutine(Request.getImage(url, (response) =>
          {
            Debug.Log("test");
            float width = response.width;
            float height = response.height;
            GameObject original = imagePrefab;
            GameObject image = Instantiate(original);
            image.transform.rotation = original.transform.rotation;
            if (width > height)
            {
              float ratio = (float)width / height;
              width = 2;
              height = width / ratio;
            }
            else
            {
              float ratio = (float)height / width;
              height = 2;
              width = height / ratio;
            }

           
            image.transform.position = new Vector3(original.transform.position.x,original.transform.position.y,original.transform.position.z); // waar in de wereld moet de afbeelding komen
            image.transform.Rotate(0,-90,0);


            image.GetComponent<Renderer>().material.mainTexture = response;
            image.SetActive(true);
          }));
    }
  
}
  
