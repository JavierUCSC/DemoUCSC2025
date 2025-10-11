using UnityEngine;

public class Coin : MonoBehaviour
{
    // public float tiempoVida = 5f;
    // public float contadorVida = 0f;

    public Animator animatorCoin;

    public CoinSpawner spawner;
    public AudioSource audio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawner = FindAnyObjectByType<CoinSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.Rotate(0f, 0.1f, 0f);
        // contadorVida = contadorVida + Time.deltaTime;

        // if (contadorVida >= tiempoVida)
        // {
        //     spawner.monedasCreadas.Remove(this.gameObject);
        //     Debug.Log("MONEDA DESTRUIDA");
        //     GameObject.Destroy(this.gameObject);
        // }
    }

    public void DestroyCoin()
    {
        GameObject.Destroy(this.gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ControladorPlayer controladorPlayer = other.gameObject.GetComponent<ControladorPlayer>();
            Debug.Log("ACABA DE PASAR EL PLAYER");
            // other.gameObject.GetComponent<ControladorFuerza>().contadorMonedas++;
            controladorPlayer.contadorCoins++;
            this.GetComponent<Collider>().enabled = false;

            animatorCoin.SetTrigger("activaMoneda");
            audio.Play();
        }
    }
}
