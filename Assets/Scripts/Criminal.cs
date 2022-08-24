using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Criminal : MonoBehaviour
{

/* [SerializeField]
[Range(0, 2)] private int CriminalNumber = 0; */
    
[SerializeField]
[Range(1f, 10f)] private float speed = 2f;




    
enum Criminales {adelante, movido, stalker};

    //Guardamos una referencia al transform del player para movernos en su dirección.
    [SerializeField] Transform playerTransform;

[SerializeField] private Criminales criminales;
    
   

    // Start is called before the first frame update
    void Start()
    {
        

         
/*         if (CriminalNumber == 1){
        Debug.Log(name + "va para adelante");
        }*/
    } 

    // Update is called once per frame
    void Update()
    {
        switch (criminales) {

        case Criminales.adelante:
          MoveForwardOne();
            break; 

        case Criminales.movido:
            RotateAroundPlayer();
            break; 

        case Criminales.stalker:
            ChasePlayer();
            break; 

        }
         
    }

    private void RotateAroundPlayer()
    {
        // Puedo rotar antes de moverme para que el enemigo quede de frente al player (lo mire).
        LookPlayer();
        // Rotate Around permite "orbitar" al rededor de una posición.
        transform.RotateAround(playerTransform.position, Vector3.up, 10f * Time.deltaTime);
        Debug.Log(name + " se mueve alrededor");
    }

    private void ChasePlayer()
    {
        LookPlayer();
        // Con la resta vectorial obtengo la dirección que me permite desplazarme hacia el player.
        Vector3 direction = (playerTransform.position - transform.position);
        //transform.Translate(direction * speed * Time.deltaTime);
        // Uso la magnitude para avanzar solo hasta cierta distancia (y no superponer el enemigo)
        
        
        if (direction.magnitude > 1f)
        {
           // Uso normalized para trasformar el vector en un vector de magnitud uno (para avanzar de forma gradual y constante cada frame)
           transform.position += direction.normalized * speed * Time.deltaTime;
        }

        Debug.Log(name + " stalkea");
    }

    private void MoveForwardOne()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    
    private void LookPlayer()
    {
        // Método para rotar "inmediatamente" hacia un trasform.
        //transform.LookAt(playerTransform);
        // Forma para rotar "gradualmente" hacia un trasform.
        Quaternion newRotation = Quaternion.LookRotation(playerTransform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 1.5f * Time.deltaTime);
    }

}
