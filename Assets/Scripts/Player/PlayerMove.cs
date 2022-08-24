using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 3f;
    // Start is called before the first frame update
    public GameObject munition;

    private float cameraAxisX = 0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        RotatePlayer();

        if (Input.GetKey(KeyCode.W))
        {
            MovePlayer(Vector3.forward);
        }

        if (Input.GetKey(KeyCode.S))
        {
            MovePlayer(Vector3.back);
        }

        if (Input.GetKey(KeyCode.A))
        {
            MovePlayer(Vector3.left);
        }

        if (Input.GetKey(KeyCode.D))
        {
            MovePlayer(Vector3.right);
        }

/*         if (Input.GetKeyUp(KeyCode.E))
        {
            Shoot();
        } */

    }

    private void MovePlayer(Vector3 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

/*     private void Shoot()
    {   
        Debug.Log("piu piu piu");
        Instantiate(munition, transform.position, transform.rotation);
    } */
 public void RotatePlayer()
    {
        /*
        Obtengo el valor del input del cursor (Que en Mouse X va de -1(izquierda) a 1(derecha))
        en función de que tan a la izquierda o derecha se mueve el mouse.
        */
        cameraAxisX += Input.GetAxis("Mouse X");
        // Forma para rotar "inmediatamente" hacia una nueva rotación creada con el método Euler (a partir de los ejes x,y,z)
        //transform.rotation = Quaternion.Euler(0,cameraAxisX * 0.1f, 0);
        // Forma para rotar "gradualmente" hacia una nueva rotación con Lerp.
        Quaternion newRotation = Quaternion.Euler(0, cameraAxisX, 0);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 2.5f * Time.deltaTime);
    }







}
