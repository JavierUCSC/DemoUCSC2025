using TMPro;
using UnityEngine;

public class ControladorFuerza : MonoBehaviour
{
    [Range(-1f, 1f)]
    public float fuerza = 0f;
    public Rigidbody rigidbody;

    [Min(0)]
    public int contadorMonedas;

    [Range(0f, 100f)]
    public float durabilidad = 100f;

    public TMP_Text textoContador;
    public TMP_Text textoDurabilidad;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.AddForce(0f, 0f, fuerza);
        // this.transform.Translate(0f, 0f, fuerza/10f);
        textoContador.text = contadorMonedas.ToString();
        textoDurabilidad.text = durabilidad.ToString();
    }

    public void ResetParametros()
    {
        contadorMonedas = 0;
        durabilidad = 100f;
    }
}
