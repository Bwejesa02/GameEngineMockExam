using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    public static ObjectPool instance;

    Dictionary<string, Queue<GameObject>> pool = new();

    public static object Instance { get; internal set; }

    private void Awake()
    {
        instance = this;
    }

    public GameObject GetObject(string type)
    {
        if (pool.ContainsKey(type) && pool[type].Count > 0)
            return pool[type].Dequeue();
        return Instantiate(Resources.Load<GameObject>(type));
    }

    public void ReturnObject(string type, GameObject obj)
    {
        obj.SetActive(true);
        if (!pool.ContainsKey(type)) pool[type] = new Queue<GameObject>();
        pool[type].Enqueue(obj);
    }

}
