using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiningBackGround : MonoBehaviour
{
    Material myMaterial1;



    void Start()
    {
        myMaterial1 = GetComponent<Renderer>().material;

    }


    void Update()
    {
        if (MiningController.Instance.miningmoveindex == 0)
        {
            float newOffsetX = myMaterial1.mainTextureOffset.x +DataController.Instance.backgroundspeed * Time.deltaTime;
            Vector2 newOffset = new Vector2(newOffsetX, 0);
            myMaterial1.mainTextureOffset = newOffset;

        }
    }
}
