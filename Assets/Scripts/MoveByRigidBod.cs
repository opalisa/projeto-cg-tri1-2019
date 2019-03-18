using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByRigidBod : MonoBehaviour
{
    
    
    [SerializeField]
   private float SpeedFactor = 10f;

   private Rigidbody2D Rb;

   
    void Start()
    {
        Rb = GetComponent <Rigidbody2D>(); //referencia p/ rigidbody
    }

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal"); // variavel terá um valor de -1 até 1. o zero significa que não está apertando
        float verticalInput = Input.GetAxisRaw("Vertical");

        Rb.velocity = new Vector3(horizontalInput, verticalInput, 0f) * SpeedFactor;
    }
}
