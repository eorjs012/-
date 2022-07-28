using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    private static Menu instance;

    public static Menu Instance
    {
        get
        {
            if (instance != null) return instance;
            instance = FindObjectOfType<Menu>();
            if (instance != null) return instance;
            var container = new GameObject("Menu");
            instance = container.AddComponent<Menu>();
            return instance;
        }
    }

    public void mail()
    {
        
        TextController.Instance.mailbox.SetActive(true);

    }
    public void advertisement()
    {
       
        TextController.Instance.advertisementbox.SetActive(true);
        var num = int.Parse(DataController.Instance.resttime);
        TextController.Instance.checkadclosebox();
        AdController.Instance.checkadcorutine();
        AdController.Instance.StopCoroutine("AdStopWatch");
        if (DataController.Instance.adindex == 1)
        {
            
            if (DataController.Instance.checkplusadcooltime >= DataController.Instance.adcooltime)
            {
                DataController.Instance.checkadcooltime = 0;
                AdController.Instance.StopCoroutine("AdStopWatch");
                SmartSecurity.SetInt("checkplusadcooltime", 0);
                DataController.Instance.adcooltime = 0;
                DataController.Instance.adcooltime += 1800;
                SmartSecurity.SetInt("adindex", 0);
                //DataController.Instance.adindex = 0;
                TextController.Instance.adtimerbox.SetActive(false);
            }
            else
            {
                DataController.Instance.adcooltime -= DataController.Instance.checkplusadcooltime;
                SmartSecurity.SetInt("checkplusadcooltime", 0);
               // DataController.Instance.checkplusadcooltime = 0;
                SmartSecurity.SetInt("checkadcooltime", 1);
              //  DataController.Instance.checkadcooltime = 1;
                AdController.Instance.StartCoroutine("AdStopWatch");
                SmartSecurity.SetInt("adindex", 1);
                //DataController.Instance.adcooltime = 1;
                if (DataController.Instance.checkplusadcooltime >= DataController.Instance.adcooltime)
                {
                    DataController.Instance.checkadcooltime = 0;
                    AdController.Instance.StopCoroutine("AdStopWatch");
                    SmartSecurity.SetInt("checkplusadcooltime", 0);
                    DataController.Instance.adcooltime = 0;
                    DataController.Instance.adcooltime += 1800;
                    SmartSecurity.SetInt("adindex", 0);
                    //  DataController.Instance.adindex = 0;
                    TextController.Instance.adtimerbox.SetActive(false);
                }
            }
            
            
        }
        else
        {
            SmartSecurity.SetInt("checkplusadcooltime", 0);
        }
        // AdController.Instance.checkadcooltime();


    }
    public void mission()
    {
       
        TextController.Instance.missionbox.SetActive(true);
      


    }
    public void setting()
    {
       
        TextController.Instance.settingbox.SetActive(true);
       if(DataController.Instance.soundvolumeindex==0)
        {
            TextController.Instance.volumeoff.SetActive(false);
            TextController.Instance.volumeon.SetActive(true);
        }
       else
        {
            TextController.Instance.volumeoff.SetActive(true);
            TextController.Instance.volumeon.SetActive(false);
        }
    }
    public void eventpanel()
    {
       
        TextController.Instance.eventbox.SetActive(true);
    }
    public void rank()
    {
      
        TextController.Instance.rankbox.SetActive(true);
    }
    
}
