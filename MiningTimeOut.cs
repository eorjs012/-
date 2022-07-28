
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MiningTimeOut : MonoBehaviour
{

    public void miningtimeoutpanel(int index)
    {
     
        if (index == 0)
        {
            SoundController.Instance.btndonsoundstart();
            SceneManager.LoadScene(1);
                DataController.Instance.Scenemoveindex = 0;
                DataController.Instance.monstermoveindex = 0;
                DataController.Instance.round = 1;
                MiningController.Instance.miningdongeonlastpanel.SetActive(false);
            DataController.Instance.daymission5index++;
            SfxController.Instance.sfxmainstart();
           
        }
        else if (index == 1)
        {
            SoundController.Instance.btndonsoundstart();
            SceneManager.LoadScene(1);
                DataController.Instance.Scenemoveindex = 0;
                DataController.Instance.monstermoveindex = 0;
                DataController.Instance.round = 1;
                MiningController.Instance.miningdongeonlastpanel.SetActive(false);
            DataController.Instance.daymission5index++;
            SfxController.Instance.sfxmainstart();
           
        }
        else if (index == 2)
        {
            SoundController.Instance.btndonsoundstart();
            SceneManager.LoadScene(1);
                DataController.Instance.Scenemoveindex = 0;
                DataController.Instance.monstermoveindex = 0;
                DataController.Instance.round = 1;
                MiningController.Instance.miningdongeonlastpanel.SetActive(false);
            DataController.Instance.daymission5index++;
            SfxController.Instance.sfxmainstart();
           
        }
        else if (index == 3)
        {
            SoundController.Instance.btndonsoundstart();
            SceneManager.LoadScene(1);
                DataController.Instance.Scenemoveindex = 0;
                DataController.Instance.monstermoveindex = 0;
                DataController.Instance.round = 1;
                MiningController.Instance.miningdongeonlastpanel.SetActive(false);
            DataController.Instance.daymission5index++;
            SfxController.Instance.sfxmainstart();
         
        }
        DataController.Instance.mininginfoindex = index;
      
    }


}
