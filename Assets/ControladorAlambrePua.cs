using UnityEngine;

public class ControladorAlambrePua : MonoBehaviour
{
    public Animator animatorPadre;
    public float danio = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ALGO COLISIONO CONMIGO! Se llama '" + collision.gameObject.name + "'");
        animatorPadre.SetTrigger("hurt");

        if (collision.gameObject.tag == "Player")
        {
            // Estoy chocando con la bola!
            collision.gameObject.GetComponent<ControladorFuerza>().durabilidad -= danio;
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Estoy chocando con la bola!
            if (collision.gameObject.GetComponent<ControladorFuerza>().durabilidad > 0f)
                collision.gameObject.GetComponent<ControladorFuerza>().durabilidad -= danio / 10f;
            else
                collision.gameObject.GetComponent<ControladorFuerza>().durabilidad = 0f;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("MENOS MAL SALÍ DE AHI. ESO DOLIÓ!");
        }
    }
}
