using UnityEngine;

public class DemoPoli : MonoBehaviour
{
    public string nombrePersonaje = "Jefe Gorgory";
    public float velocidad = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.transform.position);
        this.transform.Translate(velocidad * (new Vector3(0f, 0f, 0.01f)));
        this.transform.Rotate(0f, 0.1f, 0f);
    }
}
