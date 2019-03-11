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
        
        
        float So = transform.position.x;
        float S = So + horizontalInput * SpeedFactor * Time.deltaTime;
        transform.position = new Vector3(S, transform.position.y, transform.position.z);
    }
}
