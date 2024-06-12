using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinController : MonoBehaviour
{
      
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        //Desactiva la moneda
        //gameObject.SetActive(false);

        //Destruye la moneda
        Destroy(gameObject);


    }





}
