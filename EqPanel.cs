using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EqPanel : MonoBehaviour
{
    public GameObject[] TopPanels = new GameObject[4];
    public GameObject[] TopBtn = new GameObject[4];

    public void Start()
    {
        MainTopPanel(0);
    }

    public void MainTopPanel(int index)
    {
        TextController.Instance.weaponinfopanel.SetActive(false);
        TextController.Instance.guardinfopanel.SetActive(false);
        TextController.Instance.helmetinfopanel.SetActive(false);
        TextController.Instance.armorinfopanel.SetActive(false);
        for (int i = 0; i < 4; i++)
        {
            TopPanels[i].SetActive(false);
            TopBtn[i].SetActive(false);
        }
        if (index == 0)
        {
            
            TextController.Instance.checkcanupgradeweapon();
            TextController.Instance.checkcanweaponbox();
            TextController.Instance.changeuiweaponcount();
            TextController.Instance.weaponlv();
            TextController.Instance.weaponstatsetting();
            TextController.Instance.checkcanmixweapon();
        }
        else if (index == 1)
        {
           
            TextController.Instance.checkcanupgradeguard();
            TextController.Instance.checkcanguardbox();
            TextController.Instance.changeuiguardcount();
            TextController.Instance.guardlv();
            TextController.Instance.guardstatsetting();
            TextController.Instance.checkcanmixguard();
        }
        else if (index == 2)
        {
           
            TextController.Instance.checkcanhelmetbox();
            TextController.Instance.changeuihelmetcount();
            TextController.Instance.helmetlv();
            TextController.Instance.helmetstatsetting();
            TextController.Instance.checkcanmixhelmet();
        }
        else if (index == 3)
        {
           
            TextController.Instance.checkcanarmorbox();
            TextController.Instance.changeuiarmorcount();
            TextController.Instance.armorlv();
            TextController.Instance.armorstatsetting();
            TextController.Instance.checkcanmixarmor();
        }
        TopPanels[index].SetActive(true);
        TopBtn[index].SetActive(true);
        DataController.Instance.eqpanelindex = index;
    }
}
