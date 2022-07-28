using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardBox : MonoBehaviour
{
    public void surebox1()
    {
       
        TextController.Instance.Guardsurebox1.SetActive(true);
    }

    public void surebox11()
    {
      
        TextController.Instance.Guardsurebox11.SetActive(true);
    }

    public void guardbox1()
    {
        for (int i = 0; i < 10; i++)
        {
            TextController.Instance.guardboxlist[i].SetActive(false);
        }
        DataController.Instance.Diamond -= 100;
        DataController.Instance.repeatmission3index++;
        TextController.Instance.checkrepeatmission3();
        TextController.Instance.changeUiMoney();
        TextController.Instance.missionbox.SetActive(false);
        TextController.Instance.guardinfopanel.SetActive(false);
        TextController.Instance.Guardpanel.SetActive(true);
        TextController.Instance.guardgetupgradestone();
        TextController.Instance.checkcanguardbox();
        TextController.Instance.changeuiguardcount();
        TextController.Instance.changeuiguardinfopanel();
        TextController.Instance.guardstatsetting();
        TextController.Instance.checkguardindex();
        TextController.Instance.checkcanupgradeguard();
        TextController.Instance.checkcanmixguard();
        TextController.Instance.checkcanwearguard();
        
    }

    public void guardbox11()
    {
        for (int i = 0; i < 10; i++)
        {
            TextController.Instance.guardboxlist[i].SetActive(true);
        }
        DataController.Instance.Diamond -= 1000;
        DataController.Instance.repeatmission3index+=11;
        TextController.Instance.checkrepeatmission3();
        TextController.Instance.changeUiMoney();
        TextController.Instance.missionbox.SetActive(false);
        TextController.Instance.guardinfopanel.SetActive(false);
        TextController.Instance.Guardpanel.SetActive(true);
        TextController.Instance.guardgetupgradestone11();
        TextController.Instance.checkcanguardbox();
        TextController.Instance.changeuiguardcount();
        TextController.Instance.changeuiguardinfopanel();
        TextController.Instance.guardstatsetting();
        TextController.Instance.checkguardindex();
        TextController.Instance.checkcanupgradeguard();
        TextController.Instance.checkcanmixguard();
        TextController.Instance.checkcanwearguard();
        DataController.Instance.tutorialguard++;
        TutorialsManager.Instance.checktutorial3();
        TutorialsManager.Instance.tutorialinfopanel(DataController.Instance.tutorialindex);
    }
}
