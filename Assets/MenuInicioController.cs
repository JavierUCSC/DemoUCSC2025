using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicioController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CargaEscena(int indiceEscena)
    {
        StartCoroutine(_EsperaCargaEscena(indiceEscena));
    }
    
    IEnumerator _EsperaCargaEscena(int indiceEscena)
    {
        Debug.Log("ESPERO 5 SEGS");
        yield return new WaitForSeconds(5f);
        Debug.Log("TERMINO LA ESPERA");
        SceneManager.LoadScene(indiceEscena);
    }
}
