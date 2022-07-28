using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventPanel : MonoBehaviour
{
    public GameObject[] eventbtn = new GameObject[3];
    public GameObject[] enentpanel = new GameObject[3];
    
    
    
    void Start()
    {
        MaineventPanel(0);
    }

    public void MaineventPanel(int index)
    {
        for(int i =0; i<3; i++)
        {
            eventbtn[i].SetActive(false);
            enentpanel[i].SetActive(false);
        }
        if(index ==0)
        {
            TextController.Instance.checkeventfree();
            TextController.Instance.checkbuyeventday1();
        }
        else if(index ==1)
        {
           
            TextController.Instance.checkdayevent1();
            TextController.Instance.checkdayevent2();
            TextController.Instance.checkdayevent3();
        }
        else if(index ==2)
        {
           
            TextController.Instance.checkbuyeventday31();
            TextController.Instance.checkbuyeventday32();
            TextController.Instance.checkbuyeventday33();
        }
        eventbtn[index].SetActive(true);
        enentpanel[index].SetActive(true);
    }
    public void eventfreereward()
    {
      
        DataController.Instance.Diamond += 1000;
        DataController.Instance.meetticket += 2;
        DataController.Instance.miningticket += 2;
        DataController.Instance.rockticket += 2;
        DataController.Instance.eventfreeindex++;
        TextController.Instance.changeUiMoney();
        TextController.Instance.checkeventfree();

    }
    public void eventreward0()
    {
        DataController.Instance.Diamond -= 100;
        DataController.Instance.meetticket += 1;
        TextController.Instance.changeUiMoney();
        DataController.Instance.event0index++;
        TextController.Instance.checkdayevent1();
        TextController.Instance.checkdayevent2();
        TextController.Instance.checkdayevent3();
    }
    public void eventreward1()
    {
      
        DataController.Instance.Diamond -= 100;
        DataController.Instance.miningticket += 1;
        TextController.Instance.changeUiMoney();
        DataController.Instance.event1index++;
        TextController.Instance.checkdayevent1();
        TextController.Instance.checkdayevent2();
        TextController.Instance.checkdayevent3();
    }
    public void eventreward2()
    {
       
        DataController.Instance.Diamond -= 100;
        DataController.Instance.rockticket += 1;
        TextController.Instance.changeUiMoney();
        DataController.Instance.event2index++;
        TextController.Instance.checkdayevent1();
        TextController.Instance.checkdayevent2();
        TextController.Instance.checkdayevent3();
    }
    
}
