using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Vector3 target;

    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * 2);
        if (Vector3.Distance(transform.position, target) < 0.1f)
        {
            if (tag == "NormalChicken") GameManager.instance.AddChicken();
            ObjectPool.instance.ReturnObject(gameObject.tag, gameObject);
        }

    }
}
