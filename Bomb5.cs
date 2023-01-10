using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb5 : MonoBehaviour
{
    public GameObject bomb5Object;
    private float bmb5 = 0;

    public void SpawnBomb5()
    {
        Instantiate(bomb5Object, new Vector3(Random.Range(-8.0f,8.0f), 0.76f, Random.Range(-8.0f,8.0f)),Quaternion.identity);
    }

    //void Start()
    //{
        

    void Update()
    {
        
    }
    public void AddBomb5()
    {
        bmb5++;
        Debug.Log(bmb5);
    }
    
}
