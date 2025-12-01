using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class ControladorEsqueleto : ControladorNPC
{
    /////////////////////////////////////////////
    
    #region ATRIBUTOS

    public float rangoDeteccion = 10f;
    public float distanciaMinima = 2f;
    public LayerMask layerDeteccion;
    public Transform root;

    public Transform playerObjetivo;
    public Unity.AI.Navigation.Samples.CustomRandomWalk randomWalk;
   

    #endregion

    /////////////////////////////////////////////

    #region CALLBACKS

    void Start()
    {
        comportamiento = Comportamiento.agresivo;
        
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        base.Update();

        // SENSAMOS SI PILLAMOS AL PLAYER

        Vector3[] direcciones = new Vector3[3];
      

        direcciones[0] = root.forward;
        direcciones[1] = (root.forward + root.right).normalized;
        direcciones[2] = (root.forward - root.right).normalized;
        
        for(int i=0; i<3; i++)
        {
            Debug.DrawRay(root.position, direcciones[i] * rangoDeteccion, Color.green);

            RaycastHit hit;
            if (Physics.Raycast(root.position, direcciones[i], out hit, rangoDeteccion, layerDeteccion))
            {
                Log("PLAYER DETECTADO!: " + hit.collider.gameObject.name);
                playerObjetivo = hit.collider.gameObject.transform;
            }
        }

        // SI EL ESQUELETO VE AL PLAYER
        // desactiva las posiciones random y lo comienza a seguir
        if(playerObjetivo != null)
        {
            randomWalk.randomFuncionando = false;
            if(Vector3.Distance(this.transform.position, playerObjetivo.position) > 2f)
            {
                animator.SetBool("ataque", false);
                randomWalk.velocidad.actualMax = randomWalk.velocidad.corriendo;
                randomWalk.CambiaObjetivo(playerObjetivo.position);    
            }
            else
            {
                randomWalk.velocidad.actualMax = 0f;
                animator.SetBool("ataque", true);
            }
        }
    }

    public float GetDistanciaObjetivo(Vector3 objetivo)
    {
        return (objetivo - this.transform.position).magnitude;
    }

    #endregion

    /////////////////////////////////////////////

    #region METODOS

    public void RandomizeIndiceGolpe()
    {
        animator.SetInteger("golpeIndice", Random.Range(1,6));
        animator.SetTrigger("golpe");
    }

    public void PlayAudioMuerte(AudioClip clip)
    {
        this.GetComponent<AudioSource>().clip = clip;
        this.GetComponent<AudioSource>().Play();
    }


    #endregion

    /////////////////////////////////////////////
    
    #region UTILS

    public void Log(string mensaje)
    {
        Debug.Log(mensaje);
    }

    #endregion

    /////////////////////////////////////////////

    #region CORRUTINAS

    #endregion

    /////////////////////////////////////////////

    #region DEFINICION DATOS

    #endregion

    /////////////////////////////////////////////
}
