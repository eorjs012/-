using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiningMonster : MonoBehaviour
{

    private static MiningMonster instance;

    public static MiningMonster Instance
    {
        get
        {
            if (instance != null) return instance;
            instance = FindObjectOfType<MiningMonster>();
            if (instance != null) return instance;
            var container = new GameObject("MiningMonster");
            return instance;
        }
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("wall"))
        {
            if(DataController.Instance.miningcooltime<=0)
            {
                Player.Instance.animator.SetInteger("state", 1);
                MiningController.Instance.miningmoveindex = 1;
            }
            else
            {
                Player.Instance.animator.SetInteger("state", 2);
                MiningController.Instance.miningmoveindex = 2;
                MiningController.Instance.miningvalueResetOnstage();
                mininghpset(DataController.Instance.mininginfoindex);
            }
           


        }
        
    }
    public void mininghpset(int index)
    {
                
        if (index == 0)
        {
            DataController.Instance.MonsterMaxHp = DataController.Instance.miningdongeon0bossmonsterHp;
            DataController.Instance.MonsterNowHp = DataController.Instance.miningdongeon0bossmonsterHp;
          

        }
        else if (index == 1)
        {
            DataController.Instance.MonsterMaxHp = DataController.Instance.miningdongeon1bossmonsterHp;
            DataController.Instance.MonsterNowHp = DataController.Instance.miningdongeon1bossmonsterHp;
        }
        else if (index == 2)
        {
            DataController.Instance.MonsterMaxHp = DataController.Instance.miningdongeon2bossmonsterHp;
            DataController.Instance.MonsterNowHp = DataController.Instance.miningdongeon2bossmonsterHp;
        }
        else if (index == 3)
        {
            DataController.Instance.MonsterMaxHp = DataController.Instance.miningdongeon3bossmonsterHp;
            DataController.Instance.MonsterNowHp = DataController.Instance.miningdongeon3bossmonsterHp;
        }
        DataController.Instance.mininginfoindex = index;
       
    }


    public void miningdie(int index)
    {

        if (index == 0)
        {
            if(DataController.Instance.miningcooltime<=0)
            {
                Player.Instance.animator.SetInteger("state", 1);
                MiningController.Instance.miningmoveindex = 1;
               

            }
            else
            {
                if(DataController.Instance.MonsterNowHp <= 0)
                {
                    MiningTimer.Instance.StopCoroutine("MiningStopWatch");
                    if(DataController.Instance.miningindex ==0)
                    {
                        DataController.Instance.Diamond += DataController.Instance.mining0diareward;
                        DataController.Instance.gold += DataController.Instance.mining0reward;
                        DataController.Instance.miningdie0index++;
                        DataController.Instance.mining0level++;
                        DataController.Instance.mining0clear++;
                        DataController.Instance.tutorialminingdongeon++;
                    }
                    else
                    {
                        DataController.Instance.Diamond += DataController.Instance.mining0diareward;
                        DataController.Instance.gold += DataController.Instance.beforemining0reward;
                        DataController.Instance.miningdie0index++;
                        DataController.Instance.mining0level++;
                        DataController.Instance.mining0clear++;
                        DataController.Instance.tutorialminingdongeon++;
                    }
                  


                }
               
            }
          

        }
        else if(index ==1)
        {
            if(DataController.Instance.miningcooltime<=0)
            {
                Player.Instance.animator.SetInteger("state", 1);
                MiningController.Instance.miningmoveindex = 1;
                
               
            }
            else
            {
                if(DataController.Instance.MonsterNowHp<=0)
                {
                    MiningTimer.Instance.StopCoroutine("MiningStopWatch");
                    if(DataController.Instance.miningindex==0)
                    {
                        DataController.Instance.rock += DataController.Instance.mining1reward;
                        DataController.Instance.Diamond += DataController.Instance.mining1diareward;
                        DataController.Instance.miningdie1index++;
                        DataController.Instance.mining1level++;
                        DataController.Instance.mining1clear++;
                    }
                    else
                    {
                        DataController.Instance.rock += DataController.Instance.beforemining1reward;
                        DataController.Instance.Diamond += DataController.Instance.mining1diareward;
                        DataController.Instance.miningdie1index++;
                        DataController.Instance.mining1level++;
                        DataController.Instance.mining1clear++;
                    }
                   

                }
                
            }
           
            
        }
        else if(index ==2)
        {
            if (DataController.Instance.miningcooltime <= 0)
            {
                Player.Instance.animator.SetInteger("state", 1);
                MiningController.Instance.miningmoveindex = 1;
                

            }
            else
            {
                if (DataController.Instance.MonsterNowHp <= 0)
                {
                    MiningTimer.Instance.StopCoroutine("MiningStopWatch");
                    if (DataController.Instance.miningindex == 0)
                    {
                       
                        DataController.Instance.upgradestone += DataController.Instance.mining2reward;
                        DataController.Instance.Diamond += DataController.Instance.mining2diareward;
                        DataController.Instance.miningdie2index++;
                        DataController.Instance.mining2level++;
                        DataController.Instance.mining2clear++;
                    }
                    else
                    {
                      
                        DataController.Instance.upgradestone += DataController.Instance.beforemining2reward;
                        DataController.Instance.Diamond += DataController.Instance.mining2diareward;
                        DataController.Instance.miningdie2index++;
                        DataController.Instance.mining2level++;
                        DataController.Instance.mining2clear++;
                    }
                   

                }
              
            }       
        }
        else if(index == 3)
        {
            if (DataController.Instance.miningcooltime <= 0)
            {
                Player.Instance.animator.SetInteger("state", 1);
                MiningController.Instance.miningmoveindex = 1;
               


            }
            else
            {
                if (DataController.Instance.MonsterNowHp <= 0)
                {
                    MiningTimer.Instance.StopCoroutine("MiningStopWatch");
                    if (DataController.Instance.miningindex == 0)
                    {
                        DataController.Instance.meet += DataController.Instance.mining3reward;
                        DataController.Instance.Diamond += DataController.Instance.mining3diareward;
                        DataController.Instance.miningdie3index++;
                        DataController.Instance.mining3level++;
                        DataController.Instance.mining3clear++;
                    }
                    else
                    {
                        DataController.Instance.meet += DataController.Instance.beforemining3reward;
                        DataController.Instance.Diamond += DataController.Instance.mining3diareward;
                        DataController.Instance.miningdie3index++;
                        DataController.Instance.mining3level++;
                        DataController.Instance.mining3clear++;
                    }
                    
                   

                }
               
            }
           
        }
        DataController.Instance.mininginfoindex = index;
        MiningController.Instance.miningmonsterspwan(DataController.Instance.mininginfoindex);
        MiningController.Instance.miningdongeoninfopanel(DataController.Instance.mininginfoindex);
        Destroy(gameObject);
    }
}
