using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeetPanel : MonoBehaviour
{
    public GameObject[] CoinBtn = new GameObject[11];

    public void Start()
    {
        MainTapPanel(0);


    }

    public void MainTapPanel(int index)
    {
        for (int i = 0; i < 11; i++)
        {

            CoinBtn[i].SetActive(false);
        }
        if (index == 0)
        {
            

        }
        else if (index == 1)
        {

           


        }
        else if (index == 2)
        {

          


        }
        else if (index == 3)
        {

           

        }
        else if (index == 4)
        {
           


        }
        else if (index == 5)
        {
           



        }
        else if (index == 6)
        {
           


        }
        else if (index == 7)
        {

            



        }
        else if (index == 8)
        {

          

        }
        else if (index == 9)
        {

           


        }
        else if (index == 10)
        {

           

        }
        CoinBtn[index].SetActive(true);
        DataController.Instance.meetdongeoninfoindex = index;
        TextController.Instance.changeuimeetdongeoninfopanel(DataController.Instance.meetdongeoninfoindex);
        TextController.Instance.checkmeetdongeonbtn();
        TextController.Instance.checkmeetdongeon();
        TextController.Instance.meetdongeonclear();
        TextController.Instance.meetdongeonclear11();



    }

}
