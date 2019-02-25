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
        float So = transform.position.x;
        float S = So * SpeedFactor;
        transform.position = new Vector3(S + 0.1f, transform.position.y, transform.position.z);
    }
}
