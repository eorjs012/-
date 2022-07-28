using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionPanel : MonoBehaviour
{
    public GameObject[] missionkind = new GameObject[2];
    public GameObject[] missionreward = new GameObject[2];
    // Start is called before the first frame update
    public void OnEnable()
    {
        TextController.Instance.changeuidaymissioncount();
        TextController.Instance.checkdaymission1();
        TextController.Instance.checkdaymission2();
        TextController.Instance.checkdaymission3();
        TextController.Instance.checkdaymission4();
        TextController.Instance.checkdaymission5();
        TextController.Instance.checkrepeatmission0();
        TextController.Instance.checkrepeatmission1();
        TextController.Instance.checkrepeatmission2();
        TextController.Instance.checkrepeatmission3();
        TextController.Instance.checkrepeatmission4();
        TextController.Instance.checkrepeatmission5();
        TextController.Instance.checkrepeatmission6();
        TextController.Instance.checkrepeatmission7();
        TextController.Instance.checkrepeatmission8();
        TextController.Instance.checkrepeatmission9();
        TextController.Instance.checkrepeatmission10();
        TextController.Instance.checkrepeatmission11();
    }
    void Start()
    {
        missioninfopanel(0);

    }

    
    public void missioninfopanel(int index)
    {
        for (int i = 0; i < 2; i++)
        {
          
            missionkind[i].SetActive(false);
            missionreward[i].SetActive(false);
        }
        if(index==0)
        {
            
            TextController.Instance.changeuidaymissioncount();
            TextController.Instance.checkdaymissionpanel0();
            TextController.Instance.checkdaymissionpanel1();
            TextController.Instance.checkdaymissionpanel2();
            TextController.Instance.checkdaymissionpanel3();
            TextController.Instance.checkdaymissionpanel4();
            TextController.Instance.checkdaymissionpanel5();



        }
        else if(index==1)
        {
            TextController.Instance.checkrepeatmission0();
            TextController.Instance.checkrepeatmission1();
            TextController.Instance.checkrepeatmission2();
            TextController.Instance.checkrepeatmission3();
            TextController.Instance.checkrepeatmission4();
            TextController.Instance.checkrepeatmission5();
            TextController.Instance.checkrepeatmission6();
            TextController.Instance.checkrepeatmission7();
            TextController.Instance.checkrepeatmission8();
            TextController.Instance.checkrepeatmission9();
            TextController.Instance.checkrepeatmission10();
            TextController.Instance.checkrepeatmission11();
        }
        missionkind[index].SetActive(true);
        missionreward[index].SetActive(true);
      



    }
    //일일 미션 
    public void missionreward0() //미션 5회완료 
    {
       
        DataController.Instance.daymissionbtn0index++;
        DataController.Instance.Diamond += 500;
        DataController.Instance.daymissionpanel0index++;
        TextController.Instance.changeUiMoney();
        TextController.Instance.daymission0btn.SetActive(false);
        TextController.Instance.daymissionclearpanel1.SetActive(true);
        TextController.Instance.checkmissionimage.SetActive(false);
        TextController.Instance.checkdaymissionrewardimage.SetActive(false);
        TextController.Instance.checkdaymission0();
        TextController.Instance.checkdaymissionpanel0();
        TextController.Instance.changeuidaymissioncount();
    }
    public void missionreward1() //캐릭터 레벨강화
    {
       
        DataController.Instance.daymissionbtn1index++;
        DataController.Instance.daymission0index++;
        DataController.Instance.Diamond += 100;
        DataController.Instance.daymissionpanel1index++;
        TextController.Instance.changeUiMoney();
        TextController.Instance.daymission1btn.SetActive(false);
        TextController.Instance.daymissionclearpanel2.SetActive(true);
        TextController.Instance.checkmissionimage.SetActive(false);
        TextController.Instance.checkdaymissionrewardimage.SetActive(false);
        TextController.Instance.checkdaymission0();
        TextController.Instance.checkdaymissionpanel1();
        TextController.Instance.changeuidaymissioncount();
    }
    public void missionreward2() //장비강화
    {
        
        DataController.Instance.daymissionbtn2index++;
        DataController.Instance.daymission0index++;
        DataController.Instance.Diamond += 100;
        DataController.Instance.daymissionpanel2index++;
        TextController.Instance.changeUiMoney();
        TextController.Instance.daymission2btn.SetActive(false);
        TextController.Instance.daymissionclearpanel3.SetActive(true);
        TextController.Instance.checkmissionimage.SetActive(false);
        TextController.Instance.checkdaymissionrewardimage.SetActive(false);
        TextController.Instance.checkdaymission0();
        TextController.Instance.checkdaymissionpanel2();
        TextController.Instance.changeuidaymissioncount();
    }
    public void missionreward3() //음식던전입장
    {
       
        DataController.Instance.daymissionbtn3index++;
        DataController.Instance.daymission0index++;
        DataController.Instance.Diamond += 100;
        DataController.Instance.daymissionpanel3index++;
        TextController.Instance.changeUiMoney();
        TextController.Instance.daymission3btn.SetActive(false);
        TextController.Instance.daymissionclearpanel4.SetActive(true);
        TextController.Instance.checkmissionimage.SetActive(false);
        TextController.Instance.checkdaymissionrewardimage.SetActive(false);
        TextController.Instance.checkdaymission0();
        TextController.Instance.checkdaymissionpanel3();
        TextController.Instance.changeuidaymissioncount();
    }
    public void missionreward4() //채광던전입장
    {
       
        DataController.Instance.daymissionbtn4index++;
        DataController.Instance.daymission0index++;
        DataController.Instance.Diamond += 100;
        DataController.Instance.daymissionpanel4index++;
        TextController.Instance.changeUiMoney();
        TextController.Instance.daymission4btn.SetActive(false);
        TextController.Instance.daymissionclearpanel5.SetActive(true);
        TextController.Instance.checkmissionimage.SetActive(false);
        TextController.Instance.checkdaymissionrewardimage.SetActive(false);
        TextController.Instance.checkdaymission0();
        TextController.Instance.checkdaymissionpanel4();
        TextController.Instance.changeuidaymissioncount();
    }
    public void missionreward5() //수호자던전입장
    {
        
        DataController.Instance.daymissionbtn5index++;
        DataController.Instance.daymission0index++;
        DataController.Instance.Diamond += 100;
        DataController.Instance.daymissionpanel5index++;
        TextController.Instance.changeUiMoney();
        TextController.Instance.daymission5btn.SetActive(false);
        TextController.Instance.daymissionclearpanel6.SetActive(true);
        TextController.Instance.checkmissionimage.SetActive(false);
        TextController.Instance.checkdaymissionrewardimage.SetActive(false);
        TextController.Instance.checkdaymission0();
        TextController.Instance.checkdaymissionpanel5();
        TextController.Instance.changeuidaymissioncount();
    }
    //반복미션
    public void repeatmissionreward0() //스테이지 진행횟수
    {
       
        int clearcount = DataController.Instance.repeatmission0index / DataController.Instance.repeatmission0maxindex;
        DataController.Instance.Diamond += DataController.Instance.repeatmission0reward * clearcount;
        DataController.Instance.repeatmission0index -= DataController.Instance.repeatmission0reward * clearcount;
        TextController.Instance.changeUiMoney();
        TextController.Instance.checkrepeatmission0();
        TextController.Instance.repeatmission0btn.SetActive(false);
        TextController.Instance.checkmissionimage.SetActive(false);
        TextController.Instance.checkrewardimage.SetActive(false);

    }
    public void repeatmissionreward1()//몬스터처치횟수
    {
       
        int clearcount = DataController.Instance.repeatmission1index / DataController.Instance.repeatmission1maxindex;
        DataController.Instance.Diamond += DataController.Instance.repeatmission1reward * clearcount;
        DataController.Instance.repeatmission1index -= DataController.Instance.repeatmission1reward * clearcount;
        TextController.Instance.changeUiMoney();
        TextController.Instance.checkrepeatmission1();
        TextController.Instance.repeatmission1btn.SetActive(false);
        TextController.Instance.checkmissionimage.SetActive(false);
        TextController.Instance.checkrewardimage.SetActive(false);

    }
    public void repeatmissionreward2()//보스몬스터처치횟수
    {
       
        int clearcount = DataController.Instance.repeatmission2index / DataController.Instance.repeatmission2maxindex;
        DataController.Instance.Diamond += DataController.Instance.repeatmission2reward * clearcount;
        DataController.Instance.repeatmission2index -= DataController.Instance.repeatmission2reward * clearcount;
        TextController.Instance.changeUiMoney();
        TextController.Instance.checkrepeatmission2();
        TextController.Instance.repeatmission2btn.SetActive(false);
        TextController.Instance.checkmissionimage.SetActive(false);
        TextController.Instance.checkrewardimage.SetActive(false);
    }
    public void repeatmissionreward3()//장비뽑기
    {
      
        int clearcount = DataController.Instance.repeatmission3index / DataController.Instance.repeatmission3maxindex;
        DataController.Instance.Diamond += DataController.Instance.repeatmission3reward * clearcount;
        DataController.Instance.repeatmission3index -= DataController.Instance.repeatmission3reward * clearcount;
        TextController.Instance.changeUiMoney();
        TextController.Instance.checkrepeatmission3();
        TextController.Instance.repeatmission3btn.SetActive(false);
        TextController.Instance.checkmissionimage.SetActive(false);
        TextController.Instance.checkrewardimage.SetActive(false);
    }
    public void repeatmissionreward4()//장비강화
    {
       
        int clearcount = DataController.Instance.repeatmission4index / DataController.Instance.repeatmission4maxindex;
        DataController.Instance.Diamond += DataController.Instance.repeatmission4reward * clearcount;
        DataController.Instance.repeatmission4index -= DataController.Instance.repeatmission4reward * clearcount;
        TextController.Instance.changeUiMoney();
        TextController.Instance.checkrepeatmission4();
        TextController.Instance.repeatmission4btn.SetActive(false);
        TextController.Instance.checkmissionimage.SetActive(false);
        TextController.Instance.checkrewardimage.SetActive(false);
    }
    public void repeatmissionreward11() //장비합성
    {
        int clearcount = DataController.Instance.repeatmission11index / DataController.Instance.repeatmission11maxindex;
        DataController.Instance.Diamond += DataController.Instance.repeatmission11reward * clearcount;
        DataController.Instance.repeatmission11index -= DataController.Instance.repeatmission11reward * clearcount;
        TextController.Instance.changeUiMoney();
        TextController.Instance.checkrepeatmission11();
        TextController.Instance.repeatmission11btn.SetActive(false);
        TextController.Instance.checkmissionimage.SetActive(false);
        TextController.Instance.checkrewardimage.SetActive(false);
    }
    public void repeatmissionreward5()//캐릭터레벨강화
    {
       
        int clearcount = DataController.Instance.repeatmission5index / DataController.Instance.repeatmission5maxindex;
        DataController.Instance.Diamond += DataController.Instance.repeatmission5reward * clearcount;
        DataController.Instance.repeatmission5index -= DataController.Instance.repeatmission5reward * clearcount;
        TextController.Instance.changeUiMoney();
        TextController.Instance.checkrepeatmission5();
        TextController.Instance.repeatmission5btn.SetActive(false);
        TextController.Instance.checkmissionimage.SetActive(false);
        TextController.Instance.checkrewardimage.SetActive(false);
    }
    public void repeatmissionreward6()//던전입장
    {
       
        int clearcount = DataController.Instance.repeatmission6index / DataController.Instance.repeatmission6maxindex;
        DataController.Instance.Diamond += DataController.Instance.repeatmission6reward * clearcount;
        DataController.Instance.repeatmission6index -= DataController.Instance.repeatmission6reward * clearcount;
        TextController.Instance.changeUiMoney();
        TextController.Instance.checkrepeatmission6();
        TextController.Instance.repeatmission6btn.SetActive(false);
        TextController.Instance.checkmissionimage.SetActive(false);
        TextController.Instance.checkrewardimage.SetActive(false);
    }
    public void repeatmissionreward7()//캐릭터기술강화
    {
      
        int clearcount = DataController.Instance.repeatmission7index / DataController.Instance.repeatmission7maxindex;
        DataController.Instance.Diamond += DataController.Instance.repeatmission7reward * clearcount;
        DataController.Instance.repeatmission7index -= DataController.Instance.repeatmission7reward * clearcount;
        TextController.Instance.changeUiMoney();
        TextController.Instance.checkrepeatmission7();
        TextController.Instance.repeatmission7btn.SetActive(false);
        TextController.Instance.checkmissionimage.SetActive(false);
        TextController.Instance.checkrewardimage.SetActive(false);
    }
    public void repeatmissionreward8() //동료소환
    {
       
        int clearcount = DataController.Instance.repeatmission8index / DataController.Instance.repeatmission8maxindex;
        DataController.Instance.Diamond += DataController.Instance.repeatmission8reward * clearcount;
        DataController.Instance.repeatmission8index -=  clearcount;
        TextController.Instance.changeUiMoney();
        TextController.Instance.checkrepeatmission8();
        TextController.Instance.repeatmission8btn.SetActive(false);
        TextController.Instance.checkmissionimage.SetActive(false);
        TextController.Instance.checkrewardimage.SetActive(false);

    }
    public void repeatmissionreward9()//동료강화
    {
       
        int clearcount = DataController.Instance.repeatmission9index / DataController.Instance.repeatmission9maxindex;
        DataController.Instance.Diamond += DataController.Instance.repeatmission9reward * clearcount;
        DataController.Instance.repeatmission9index -= DataController.Instance.repeatmission9reward * clearcount;
        TextController.Instance.changeUiMoney();
        TextController.Instance.checkrepeatmission9();
        TextController.Instance.repeatmission9btn.SetActive(false);
        TextController.Instance.checkmissionimage.SetActive(false);
        TextController.Instance.checkrewardimage.SetActive(false);
    }
    public void repeatmissionreward10()//유물강화
    {
       
        int clearcount = DataController.Instance.repeatmission10index / DataController.Instance.repeatmission10maxindex;
        DataController.Instance.Diamond += DataController.Instance.repeatmission10reward * clearcount;
        DataController.Instance.repeatmission10index -= DataController.Instance.repeatmission10reward * clearcount;
        TextController.Instance.changeUiMoney();
        TextController.Instance.checkrepeatmission10();
        TextController.Instance.repeatmission10btn.SetActive(false);
        TextController.Instance.checkmissionimage.SetActive(false);
        TextController.Instance.checkrewardimage.SetActive(false);

    }
   public void allbtn()
   {
       
        repeatmissionreward0();
        repeatmissionreward1();
        repeatmissionreward2();
        repeatmissionreward3();
        repeatmissionreward4();
        repeatmissionreward5();
        repeatmissionreward6();
        repeatmissionreward7();
        repeatmissionreward8();
        repeatmissionreward9();
        repeatmissionreward10();
        repeatmissionreward11();
    }
}
