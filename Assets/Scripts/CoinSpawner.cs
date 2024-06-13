using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{

    float timer;
    public GameObject coinPrefab; 


    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= 2f)

        {
            timer = 0;
            float y = Random.Range(75f, 95f);
            float x = Random.Range(110f, 210f);
            UnityEngine.Vector3 position = new UnityEngine.Vector3(x, y, 0); 
            UnityEngine.Quaternion rotation = new UnityEngine.Quaternion();
            Instantiate(coinPrefab, position, rotation);
            

        }


        
    }
}
