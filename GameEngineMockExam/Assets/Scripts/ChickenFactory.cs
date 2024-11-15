using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class ChickenFactory : MonoBehaviour
{
    public static GameObject CreateChicken(bool isEvil)
    {

        string type = isEvil ? "EvilChicken" : "Chicken";

        return
        ObjectPool.instance.GetObject(type);
    }
}
