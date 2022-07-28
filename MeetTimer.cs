using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MeetTimer : MonoBehaviour
{
    public int sec;
    public Text timerTt;
    private static MeetTimer instance;

    public static MeetTimer Instance
    {
        get
        {
            if (instance != null) return instance;
            instance = FindObjectOfType<MeetTimer>();
            if (instance != null) return instance;
            var container = new GameObject("MeetTimer");
            return instance;
        }
    }
    public void OnEnable()
    {
        sec = DataController.Instance.cooltime;
        StartCoroutine("MeetStopWatch");
        
    }
    IEnumerator MeetStopWatch()
    {
        //쿨타임이 시작될때
        MeetController.Instance.meetdeongeononindex = 1;
        while (sec > 0)
        {

            timerTt.text = sec+" 초";
            sec--;
            yield return new WaitForSeconds(1f);
        }
        if (sec <= 0)
        {//쿨타임이다됬을떄 못꺰. 메인씬이동;;

            MeetController.Instance.meetdeongeononindex = 0;
            Destroy(MeetController.Instance.meetmonsterspwanposition);
            Player.Instance.animator.SetInteger("state", 1);
            MeetController.Instance.meetmoveindex = 1;
            timerTt.text = "0" + " 초";
            MeetController.Instance.meettimeoutbox.SetActive(true);
        }
       
    }
}
