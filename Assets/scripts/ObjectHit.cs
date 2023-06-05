using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player" )
        {  
        // Debug.Log("BUmped into the Wall");
        GetComponent<MeshRenderer>().material.color = Color.magenta; //go to documents of unity Static Properties
        gameObject.tag = "Hit";
    }
   }
}
