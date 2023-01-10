using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin5 : MonoBehaviour
{
    public GameObject coin5Object;
    private float coin5 = 0;

    public void SpawnCoin5()
    {
        Instantiate(coin5Object, new Vector3(Random.Range(-8.0f,8.0f), 0.76f, Random.Range(-8.0f,8.0f)),Quaternion.identity);
    }

    void Start()
    {
        //SpawnCoin5();
    }

    void Update()
    {
        
    }
    public void AddCoin5()
    { 
        coin5++;
        Debug.Log(coin5);
    }
}
