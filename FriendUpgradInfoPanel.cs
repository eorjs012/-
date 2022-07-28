using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendUpgradInfoPanel : MonoBehaviour
{
    public GameObject[] showfrienupgradebutton = new GameObject[5];

    public void showfriendupgradeinfopanel(int index)
    {
        for (int i = 0; i < 5; i++)
        {
            showfrienupgradebutton[i].SetActive(false);
        }
        if (index == 0)
        {

            TextController.Instance.artifactsetting();
        }
        else if (index == 1)
        {
            TextController.Instance.artifactsetting1();

        }
        else if (index == 2)
        {
            TextController.Instance.artifactsetting2();

        }
        else if (index == 3)
        {
            TextController.Instance.artifactsetting3();

        }
        else if (index == 4)
        {
            TextController.Instance.artifactsetting4();

        }

        showfrienupgradebutton[index].SetActive(true);
        DataController.Instance.friendinfoindex = index;
        TextController.Instance.friendupgradesurepanel();
        TextController.Instance.checkcanartifact();
        TextController.Instance.changeuifriendartifactinfopanel(DataController.Instance.friendinfoindex);
    }
}
