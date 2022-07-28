using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendPanel : MonoBehaviour
{
    public GameObject[] friendpanel = new GameObject[2];
    public GameObject[] frienbutton = new GameObject[2];
    public void Start()
    {
        friendtappanel(0);
    }
    public void friendtappanel(int index)
    {
        for (int i = 0; i < 2; i++)
        {
            friendpanel[i].SetActive(false);
            frienbutton[i].SetActive(false);
        }
        if (index == 0)
        {
           
            TextController.Instance.changeuifriendinfopanel(DataController.Instance.friendinfoindex);
            TextController.Instance.checkcanfirendbox();
            TextController.Instance.checkcanupstone();
            TextController.Instance.friendstatsetting();
            TextController.Instance.frienddiastatsetting();
            TextController.Instance.friendstatsetting1();
            TextController.Instance.frienddiastatsetting1();
            TextController.Instance.friendstatsetting2();
            TextController.Instance.frienddiastatsetting2();
        }
        else if (index == 1)
        {
           
            TextController.Instance.friendupgradesurepanel();
            TextController.Instance.checkcanartifact();
            TextController.Instance.artifactsetting();
            TextController.Instance.artifactsetting1();
            TextController.Instance.artifactsetting2();
            TextController.Instance.artifactsetting3();
            TextController.Instance.artifactsetting4();
            TextController.Instance.changeuifriendartifactinfopanel(DataController.Instance.friendinfoindex);
        }

        friendpanel[index].SetActive(true);
        frienbutton[index].SetActive(true);
    }
}
