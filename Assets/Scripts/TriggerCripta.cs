using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCripta : MonoBehaviour




{

[SerializeField]
[Range(2,10)]
private float cooldown;

[SerializeField]
Transform nextPortal;

private float timeInPortal = 0;



private void OnTriggerEnter(Collider other) {
    timeInPortal = 0;
}

private void OnTriggerExit(Collider other) {
    Debug.Log("on exit trigger : " + other.gameObject.name);
}

private void OnTriggerStay(Collider other) {
    timeInPortal += Time.deltaTime;

    if (timeInPortal >= cooldown){
        other.transform.position = nextPortal.position;

    }
  
   // Debug.Log("prueba");
}

}
