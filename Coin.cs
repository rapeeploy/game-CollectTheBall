using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject coinObject;
    private float coin = 0;

    public void SpawnCoin()
    {
        Instantiate(coinObject, new Vector3(Random.Range(-8.0f,8.0f), 0.76f, Random.Range(-8.0f,8.0f)),Quaternion.identity);
    }

    void Start()
    {
        SpawnCoin();
        SpawnCoin();
        SpawnCoin();
    }

    void Update()
    {
        
    }
    public void AddCoin()
    { 
        coin++;
        Debug.Log(coin);
    }
}
