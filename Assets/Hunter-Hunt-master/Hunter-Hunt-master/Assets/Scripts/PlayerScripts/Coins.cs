using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public GameObject Coin;

    private void Update()
    {
        Coin.transform.Rotate(0.0f, 1.0f, 0.0f);    
    }
}
