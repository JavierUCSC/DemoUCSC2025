using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Unity.AI.Navigation.Samples
{
    /// <summary>
    /// Walk to a random position and repeat
    /// </summary>
    [RequireComponent(typeof(NavMeshAgent))]
    public class CustomRandomWalk : MonoBehaviour
    {
        public float m_Range = 25.0f;
        NavMeshAgent m_Agent;

        public Velocidad velocidad;

        public Animator animator;

        public List<Transform> posicionesObjetivo;

        public bool randomFuncionando = true;

        void Start()
        {
            m_Agent = GetComponent<NavMeshAgent>();
            velocidad.actual = 0f;
            velocidad.actualMax = velocidad.caminata;
        }

        void Update()
        {
            
            m_Agent.speed = velocidad.actual;
            animator.SetFloat("velocidad", velocidad.actual);

            if (m_Agent.pathPending || !m_Agent.isOnNavMesh || m_Agent.remainingDistance > 0.1f)
            {
                if(m_Agent.remainingDistance > 0.1f)
                {
                    if(velocidad.actual < velocidad.actualMax)
                        velocidad.actual += Time.deltaTime;
                    else if(velocidad.actual > velocidad.actualMax)
                        velocidad.actual -= Time.deltaTime * 5f;
                }

                return;
            }
                
            if(randomFuncionando == true)
                m_Agent.destination = m_Range * Random.insideUnitCircle;
        }

        public void CambiaObjetivo(Vector3 nuevoObjetivo)
        {
            m_Agent.destination = nuevoObjetivo;
        }

        public void ResetObjetivo()
        {
            
        }

        // public void DetenerRandomWalk()
        // {
        //     randomFuncionando = false;
        //     m_Agent.Stop();
        //     animator.SetFloat("velocidad", 0f);
        //     animator.SetTrigger("ataque");
        // }

        // public void ActivarRandomWalk()
        // {
        //     randomFuncionando = true;
        //     m_Agent.Resume();
        // }

        [System.Serializable]
        public struct Velocidad
        {
            public float actual;
            public float actualMax;
            public float caminata;
            public float corriendo;
        }
    }
}