using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinObject;
    public List<Transform> spawnPoints;
    public int monedasTotales = 1;

    public List<GameObject> monedasCreadas;

    public List<int> indexUtilizados;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        monedasCreadas = new List<GameObject>();
        indexUtilizados = new List<int>();

        for (int i = 0; i < monedasTotales; i++)
        {
            SpawnCoin("0" + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //SpawnCoin();
    }

    public void SpawnCoin(string nombreNuevo)
    {
        int randomIndex = Random.Range(0, spawnPoints.Count);
        
        Vector3 posicionSpawn = spawnPoints[randomIndex].position;
        string nombrePrefab = coinObject.name;

        Debug.Log("MONEDA CREADA");
        GameObject objetoCreado = GameObject.Instantiate(coinObject);
        objetoCreado.transform.position = posicionSpawn;
        objetoCreado.name = nombrePrefab + "_" + nombreNuevo;

        monedasCreadas.Add(objetoCreado);
    }
}
