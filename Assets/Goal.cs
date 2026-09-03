using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
    if (collision.CompareTag("Player"))
      {
      Debug.Log("ÉNÉäÉA!");
      }
    }
}
