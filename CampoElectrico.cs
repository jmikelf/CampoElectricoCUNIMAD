using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampoElectrico : MonoBehaviour
{
    public int alturaCampo, larguraCampo;
    public int[,] campo;
    public NodoCampo Nodo;
    public NodoCampo[] nodos;
    public CargaElectrica[] cargasColocadas;
    // Start is called before the first frame update
    void Start()
    {
        nodos = new NodoCampo[larguraCampo * alturaCampo];
        CrearCampoElectrico();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CrearCampoElectrico()
    {
        for (int i=0, z=0; z<alturaCampo; z++)
        {
            for (int x=0; x<larguraCampo; x++)
            {
                CrearNodo(x, z, i++);
            }
        }
    }

    public void CrearNodo(int x, int z, int i)
    {
        Vector3 posicion;
        posicion.x = x * 2f;
		posicion.y = 0f;
		posicion.z = z * 2f;

        NodoCampo nuevoNodo = nodos[i] = Instantiate<NodoCampo>(Nodo);
        nuevoNodo.transform.SetParent(transform, false);
        nuevoNodo.transform.localPosition = posicion;
    }
}
