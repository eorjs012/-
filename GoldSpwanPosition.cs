using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldSpwanPosition : MonoBehaviour
{
    public void OnEnable()
    {
        Invoke("off", 1f);
    }
    public void off()
    {
        Destroy(gameObject);
    }
}
