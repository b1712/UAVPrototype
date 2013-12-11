using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Helicopter1 : MonoBehaviour {

    float x = -150;
    float y = 65;
    float z = -20;
    
   public void Start() {
       //this.gameObject.
       this.gameObject.transform.position = new Vector3(-150, 65, -20);
       
    
    }

   public void Update() {

       y = y - 0.1f;
       this.gameObject.transform.position = new Vector3(x, y, z);

    }


}

