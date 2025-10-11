using UnityEngine;

public class ControladorPartida : MonoBehaviour
{
    public bool terminoPartida = false;
    [Min(0)]
    public float segundos = 0;
    public ControladorPlayer controladorPlayer;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (terminoPartida == false)
        {
            segundos += Time.deltaTime;
        }
        else
        {
            Debug.Log("TERMINÓ LA PARTIDA! Juntaste " + controladorPlayer.contadorCoins + " monedas!");
        }
    }
}
