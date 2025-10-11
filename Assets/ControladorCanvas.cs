using TMPro;
using UnityEngine;

public class ControladorCanvas : MonoBehaviour
{
    public ControladorPlayer controladorPlayer;
    public ControladorPartida controladorPartida;
    public TMP_Text textCoins;
    public TMP_Text textTiempo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controladorPlayer = FindAnyObjectByType<ControladorPlayer>();
        controladorPartida = FindAnyObjectByType<ControladorPartida>();
    }

    // Update is called once per frame
    void Update()
    {
        textCoins.text = controladorPlayer.contadorCoins.ToString();
        textTiempo.text = ((int)controladorPartida.segundos).ToString();
    }
}
