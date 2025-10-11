using UnityEngine;

public class DemoCubo : MonoBehaviour
{
    public int nivel;
    public float salud;
    public string nombre = "Kratos";
    public bool esInvencible = false;
    public Vector3 spawnInicial;
    public GameObject objeto;
    public Light luzDireccional;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("HOLA SOY EL START");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("HOLA SOY EL UPDATE");
    }
}
