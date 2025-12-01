using UnityEngine;
using UnityEngine.Events;

public class ControladorArma : MonoBehaviour
{
    public ControladorObjetivoGolpeable objetivoGolpeado;
    public float ataque = 5f;


    void OnTriggerEnter(Collider other)
    {
        string tag = other.gameObject.tag;

        if(tag == "Golpeable" || tag == "Player")
        {
            Debug.Log("GOLPEE ALGO");
            objetivoGolpeado = other.gameObject.GetComponent<ControladorObjetivoGolpeable>();
            objetivoGolpeado.alGolpearObjetivo.Invoke(ataque);
        }
    }
}
