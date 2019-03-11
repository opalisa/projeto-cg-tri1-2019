using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simplemove : MonoBehaviour
{
        [SerializeField] //pode ser editado no unity
        private float SpeedFactor = 1f; //// não pode ser acessado por outros

    void Start()
    {

    }

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal"); // variavel terá um valor de -1 até 1. o zero significa que não está apertando
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 velocity = new Vector3 (horizontalInput, verticalInput, 0f) * SpeedFactor;
        
        transform.position = transform.position + velocity * Time.deltaTime;
    }
}
