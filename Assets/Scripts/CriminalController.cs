using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriminalController : MonoBehaviour


{

    public float speed = 3f;

    [SerializeField] Animator criminalAnimator;


    void Start()
    {
        
    }


    void Update()
    {
        movePlayer();
    }


private void movePlayer(){

 
        if (Input.GetKey(KeyCode.W))
        {
            MovePlayer1(Vector3.forward);
            Invoke("CriminalMove", 1f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            MovePlayer1(Vector3.back);
        }

        if (Input.GetKey(KeyCode.A))
        {
            MovePlayer1(Vector3.left);
        }

        if (Input.GetKey(KeyCode.D))
        {
            MovePlayer1(Vector3.right);
        }
}



private void MovePlayer1(Vector3 direction){
        transform.Translate(direction * speed * Time.deltaTime);
        criminalAnimator.SetBool("isRun", true);
}





}
