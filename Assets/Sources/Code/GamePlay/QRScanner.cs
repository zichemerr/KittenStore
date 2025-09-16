using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class QRScanner : MonoBehaviour
{
    private float  _fullBarNumber;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<QRCode>())
        {
            
        }
    }

    private UniTask ScanAsync()
    {
        
    }
}


public class QRCode : MonoBehaviour
{
    
}