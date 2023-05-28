using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    public Text scoreText;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector2(transform.position.x - 5, transform.position.y); 
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x + 5, transform.position.y);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Apple")
        {
            score += 5;
            scoreText.text = Convert.ToString(score);
            Destroy(other.gameObject);
        }
    }
}
