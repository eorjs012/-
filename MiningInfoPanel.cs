using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiningInfoPanel : MonoBehaviour
{
    public void Start()
    {
        showmininginfopanel(0);
    }
    public GameObject[] showminnigbutton = new GameObject[4];

    public void showmininginfopanel(int index)
    {
        for (int i = 0; i < 4; i++)
        {
            showminnigbutton[i].SetActive(false);
        }
        if (index == 0)
        {
          
            TextController.Instance.miningdongeonsetting();
            TextController.Instance.beforeminingdongeonsetting();
        }
        else if (index == 1)
        {
            
            TextController.Instance.miningdongeonsetting1();
            TextController.Instance.beforeminingdongeonsetting1();

        }
        else if (index == 2)
        {
           
            TextController.Instance.miningdongeonsetting2();
            TextController.Instance.beforeminingdongeonsetting2();

        }
        else if (index == 3)
        {
           
            TextController.Instance.miningdongeonsetting3();
            TextController.Instance.beforeminingdongeonsetting3();

        }
        showminnigbutton[index].SetActive(true);
        DataController.Instance.mininginfoindex = index;
        TextController.Instance.changeuimininginfopanel(DataController.Instance.mininginfoindex);
        TextController.Instance.checkcanbeforeminingdongeon();

    }
}
