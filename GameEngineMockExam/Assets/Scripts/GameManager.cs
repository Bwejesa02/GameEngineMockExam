using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int chickenCount = 0;

    private void Awake()
    {
        
        instance = this;
        
    }

    public void AddChicken()
    {
        chickenCount++;
    }
}
