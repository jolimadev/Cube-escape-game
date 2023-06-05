using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f; 
    // Start is called before the first frame update
    void Start()
    {

        PrintInstructions();
        
    }
        //updaye is called once per frame
    void Update()
    {
         MovePlayer();   
    }

    void PrintInstructions()
    {
        // Debug.Log("Hallo AudioVisual Legend");
        // Debug.Log("You can do this, don't gave up");
        // Debug.Log("Be Stoic, be resilient..fuck haters");
    }
    void MovePlayer() 
    {
    //variables
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed; 
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;       
        transform.Translate(xValue,0,zValue); //execution
        
    }
   
}


