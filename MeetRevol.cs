using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeetRevol : MonoBehaviour
{
    public void meetupgrade()
    {
      
        DataController.Instance.meet -= DataController.Instance.meetupgraecost;
        DataController.Instance.meetlevel++;
        TextController.Instance.meetstatsetting();
        TextController.Instance.checkcanupbtn();
        TextController.Instance.changeUiMoney();

    }

    public void meetrevolution()
    {
       
        DataController.Instance.meet -= DataController.Instance.meetrevolucost;
        DataController.Instance.meetrevolulevel++;
        TextController.Instance.meetrevolstatsetting();
        TextController.Instance.checkcanupbtn();
        TextController.Instance.changeUiMoney();


    }
}
