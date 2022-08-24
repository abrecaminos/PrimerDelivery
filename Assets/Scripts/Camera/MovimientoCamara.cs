using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    public GameObject target;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

//Metodo de Unity que no está tan en vidriera como "Update" que permite que primero se mueva el player y DESPUES posicionar la camara y de esa manera evitar los glitch cuadra a cuadro, se ve mas fluido
     private void LateUpdate()
    {
        transform.position = target.transform.position;
    }
}
