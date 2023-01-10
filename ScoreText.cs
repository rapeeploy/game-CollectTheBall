using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public Coin coinManager;
    public Coin5 coin5Manager;
    public Bomb5 bmb5Manager;
    
    // Start is called before the first frame update
    void Start()
    {
         score = 0;
    }

    // Update is called once per frame
    void Update()
    {
         scoreText.text="Score: " + score;
    }

     private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            score++;
            coinManager.SpawnCoin();
            coinManager.AddCoin();
        }

        if(score == 10){
           coin5Manager.SpawnCoin5();
        }
        
        if(other.gameObject.tag == "Coin5"){
            Destroy(other.gameObject);
            score = score+5;
            coin5Manager.SpawnCoin5();
            coin5Manager.AddCoin5();
        }

        if(score == 5){
            bmb5Manager.SpawnBomb5();
        }
        if(other.gameObject.tag == "Bomb5")
        {
            Destroy(other.gameObject);
            score = score-5;
            bmb5Manager.SpawnBomb5();
            bmb5Manager.AddBomb5();
        }
       // if(score == 10){
        //    coin5Manager.SpawnCoin5();
       // }   
       
    }

    
}
