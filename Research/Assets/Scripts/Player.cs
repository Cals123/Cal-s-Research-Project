using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Player code for movement of player, must be able to move either direction on x-axis & jump fluidly
//
//
//
//
//

public class Player : MonoBehaviour
{
    [SerializeField] float _playerSpeed = 5;

    Rigidbody2D _rigidBody2D;
    
    

    void Start()
    {
        
    }

    /*
     * NOTES: Initially tried to declare horizontal at class level - not able to use Input.GetAxis there, tried in start but this is not usable in update?
     * referred back to the course, declared the variable as locally as possible, used var as this is short and infers the type.
     * 
     * Got the 
     * 
     * 
     * 
     */
    void Update()
    {
        //float horizontal = Input.GetAxis("Horizontal");       
        var horizontal = Input.GetAxis("Horizontal");         // var allows the compiler to choose which type of value is used.
        if (horizontal < 0)
            Debug.Log("Horizontal negative value detected");
        if (horizontal > 0)
            Debug.Log("Horizontal positive value detected");
    }
}
