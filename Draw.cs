using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Draw : MonoBehaviour
{
    public float sec;
    public Text timerTt;



    public void OnEnable()
    {
        sec = 20;
        StartCoroutine("StopWatch");
    }
    IEnumerator StopWatch()
    {
        //쿨타임이 시작될때

        while (sec > 0)
        {
            timerTt.text = "남은 시간 : " + sec + "";
            sec--;
            yield return new WaitForSeconds(1f);
        }
        if (sec == 0)
        {//쿨타임이다됬을떄 못꺰. 무한모드입장;;

            DataController.Instance.deathmodeindex = 0;
            TextController.Instance.deathmodemove();
        }

    }
}
