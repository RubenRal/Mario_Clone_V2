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
            float x = Random.Range(-30f, 30f);
            UnityEngine.Vector3 position = new UnityEngine.Vector3(x, 0, 0); 
            UnityEngine.Quaternion rotation = new UnityEngine.Quaternion();
            Instantiate(coinPrefab, position, rotation);
            

        }


        
    }
}
