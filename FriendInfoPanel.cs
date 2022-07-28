using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendInfoPanel : MonoBehaviour
{
    public GameObject[] showfrienbutton = new GameObject[5];

    public void Start()
    {
        showfriendinfopanel(0);
    }
    public void showfriendinfopanel(int index)
    {
        for (int i = 0; i < 5; i++)
        {
            showfrienbutton[i].SetActive(false);
        }
        if (index == 0)
        {
          
            TextController.Instance.friendstatsetting();
            TextController.Instance.frienddiastatsetting();

        }
        else if (index == 1)
        {
          
            TextController.Instance.friendstatsetting1();
            TextController.Instance.frienddiastatsetting1();
        }
        else if (index == 2)
        {
           
            TextController.Instance.friendstatsetting2();
            TextController.Instance.frienddiastatsetting2();
        }
        else if (index == 3)
        {
           
            TextController.Instance.friendstatsetting3();
            TextController.Instance.frienddiastatsetting3();
        }
        else if (index == 4)
        {
          
            TextController.Instance.friendstatsetting4();
            TextController.Instance.frienddiastatsetting4();
        }

        showfrienbutton[index].SetActive(true);
        DataController.Instance.friendinfoindex = index;
        TextController.Instance.checkcanfirendbox();
        TextController.Instance.changeuifriendinfopanel(DataController.Instance.friendinfoindex);
        TextController.Instance.checkcanupstone();


    }
}
