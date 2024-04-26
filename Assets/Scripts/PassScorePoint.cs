using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassScore : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameManager.singleton.AddScore(1);
    }




}
