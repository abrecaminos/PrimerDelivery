using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
private void OnCollisionEnter(Collision other) {
    Debug.Log(other.gameObject.name);

    if (other.gameObject.CompareTag("Alimento")) {
Destroy(other.gameObject);
    }
    
  //  Debug.Log("prueba");
}

private void OnCollisionExit(Collision other) {
    
}

private void OnCollisionStay(Collision other) {
            //Debug.Log("on stay: " + other.gameObject.name);
  
   // Debug.Log("prueba");
}
}
