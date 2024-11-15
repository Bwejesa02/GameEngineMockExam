using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static void Spawn(int count)
    {
        for (int i = 0; i < count; i++)
        {
            bool isEvil = Random.value < 0.05f; 
            GameObject chicken = ChickenFactory.CreateChicken(isEvil);
            chicken.SetActive(true);
        }
    }
}

