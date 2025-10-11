using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorMeta : MonoBehaviour
{
    public ControladorPartida controladorPartida;
    public AudioSource audioFinal;
    public bool llegoMeta = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(_EsperaLlegada());
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("EL PLAYER ENTRO EN LA ZONA");

            controladorPartida.terminoPartida = true;
            //audioFinal.Play();
            llegoMeta = true;
        }
    }

    IEnumerator _EsperaLlegada()
    {
        Debug.Log("ESPERANDO LLEGADA DE PLAYER");
        yield return new WaitUntil(() => llegoMeta == true);
        audioFinal.Play();
        Debug.Log("PLAYER LLEGO A LA META!");

        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(0);
    }
}
