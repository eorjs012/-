using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinDongeonBox : MonoBehaviour
{
    public void dongeonsure()
    {
       
        TextController.Instance.checkmeetdongeon();
        TextController.Instance.meetdongeonsurepanel.SetActive(true);

    }
    public void DongeonGoBtn()
    {
       
        TextController.Instance.missionbox.SetActive(false);
         DataController.Instance.meetticket -= 1;
         DataController.Instance.tutorialmeetdongeon++;
         DataController.Instance.daymission3index++;
         DataController.Instance.repeatmission6index++;
         TextController.Instance.checkrepeatmission6();
         TextController.Instance.changeUiMoney();
         SceneManager.LoadScene(2);
         DataController.Instance.Scenemoveindex = 1;
         DataController.Instance.meetrewardpapago = 0;
         DataController.Instance.meetround = 1;
         DataController.Instance.meetcooltimesetting();
         TextController.Instance.checkmeetdongeon();
         TextController.Instance.meetdongeonclear();
         TextController.Instance.meetdongeonclear11();
        SfxController.Instance.sfxmainstart();




    }
    public void dongeonclearsure()
    {
        
        TextController.Instance.meetdongeonclear();
         TextController.Instance.meetclearsurepanel.SetActive(true);
      
       
        
    }
    public void meetclear()
    {
       
        DataController.Instance.meetticket -= 1;
        DataController.Instance.meet += SmartSecurity.GetInt("meetreward" + DataController.Instance.meetdongeoninfoindex + "toppapago");
        TextController.Instance.changeUiMoney();
        TextController.Instance.meetdongeonclear();
        TextController.Instance.meetdongeonclear11();
        TextController.Instance.checkmeetdongeon();
        DataController.Instance.repeatmission6index++;
        DataController.Instance.daymission3index++;
        TextController.Instance.checkrepeatmission6();

    }
    public void dongeonclearsure11()
    {
      
        TextController.Instance.meetdongeonclear11();
        TextController.Instance.meetclearsurepanel11.SetActive(true);
       
    }
    public void meetclear11()
    {
       
        DataController.Instance.meetticket -= 10;
        DataController.Instance.meet += SmartSecurity.GetInt("meetreward" + DataController.Instance.meetdongeoninfoindex + "toppapago") * 10;
        TextController.Instance.changeUiMoney();
        TextController.Instance.meetdongeonclear11();
        TextController.Instance.meetdongeonclear();
        TextController.Instance.checkmeetdongeon();
        DataController.Instance.repeatmission6index+=10;
        DataController.Instance.daymission3index+=10;
        TextController.Instance.checkrepeatmission6();


    }
}
