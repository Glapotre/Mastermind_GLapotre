using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pawn : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


        if(Physics.Raycast(ray, out hit))
        {


Debug.Log(hit.collider.gameObject.name);



        }
        
    }
}
