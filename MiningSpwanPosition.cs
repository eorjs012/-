using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiningSpwanPosition : MonoBehaviour
{
    public void Update()
    {
        if (MiningController.Instance.miningmoveindex == 0)
        {
            //기본 0.08
            transform.Translate(new Vector3(-(DataController.Instance.monstermovespeed), 0, 0));
        }

    }
}
