using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPc : MonoBehaviour
{
    [SerializeField] int peticiones = 1000;
    void Start()
    {
        
    }

    void Update()
    {
     if (Input.GetKeyDown(KeyCode.Space))
            {
            Debug.Log("hola mundo");
            StartCoroutine(Prueba());
            }
    }
    

    private IEnumerator Prueba()
    {
        var contador = 0;
        Debug.Log("hola mundo");
        while (contador < peticiones)
        {
            contador++;
            Debug.Log("hola mundo 2");
            yield return null;
        }
        
    }
}
