using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MiningTimer : MonoBehaviour
{
    private static MiningTimer instance;

    public static MiningTimer Instance
    {
        get
        {
            if (instance != null) return instance;
            instance = FindObjectOfType<MiningTimer>();
            if (instance != null) return instance;
            var container = new GameObject("MiningTimer");
            return instance;
        }
    }
    public int sec;
    public Text timerTt;
    public void OnEnable()
    {
        sec = DataController.Instance.miningcooltime;
        StartCoroutine("MiningStopWatch");
    }
    IEnumerator MiningStopWatch()
    {
        //쿨타임이 시작될때
        while (sec > 0)
        {

            timerTt.text = "제한 시간 : "+sec + " 초";
            sec--;
            yield return new WaitForSeconds(1f);
        }
        if (sec <= 0)
        {//쿨타임이다됬을떄 못꺰. 메인씬이동;;
            Destroy(MiningController.Instance.miningmonsterspwanposition);
            Player.Instance.animator.SetInteger("state", 1);
            MiningController.Instance.miningmoveindex = 1;
            timerTt.text = "제한 시간 : " + "0" + " 초";
            MiningController.Instance.miningdongeonlastpanel.SetActive(true);
           
        }

    }
}
