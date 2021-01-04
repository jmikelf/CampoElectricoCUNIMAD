using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargaElectrica : MonoBehaviour
{
    public enum TipoDeCarga {Negativa = -1, Neutra= 0, Positiva=1}
    public TipoDeCarga tipo = TipoDeCarga.Neutra;
    public Vector3 posicion;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
