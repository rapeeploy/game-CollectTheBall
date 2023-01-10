using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController controller;
    public Coin coinManager;
    public Coin5 coin5Manager;
    public Bomb5 bmb5Manager;
    private float speed = 5.0f;
    
    void Start()
    {
        coinManager = GameObject.Find("Coin").GetComponent<Coin>();
        coin5Manager = GameObject.Find("Coin5").GetComponent<Coin5>();
        bmb5Manager = GameObject.Find("Bomb5").GetComponent<Bomb5>();
        controller = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * speed);
    }
    
   
}
