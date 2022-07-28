using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeetPlayer : MonoBehaviour
{
    private static MeetPlayer instance;

    public static MeetPlayer Instance
    {
        get
        {
            if (instance != null) return instance;
            instance = FindObjectOfType<MeetPlayer>();
            if (instance != null) return instance;
            var container = new GameObject("MeetPlayer");
            return instance;
        }
    }

    public Animator meetanimator;
    public void Start()
    {
        meetanimator = GetComponent<Animator>();
        meetanimator.SetFloat("attackspeed", DataController.Instance.attackspeed);

    }
    public void meetdamage()
    {

        var b = Random.Range(0, 10000);
        if (DataController.Instance.criticalper > b)
        {
            //크리
          //  TextController.Instance.addcridmgon(DataController.Instance.damage * DataController.Instance.criticaldamage);
            DataController.Instance.criticalindex = 1;
           // DataController.Instance.MonsterNowHp -= DataController.Instance.damage * DataController.Instance.criticaldamage;

        }
        else
        {
            //일반
          //  TextController.Instance.adddmgon(DataController.Instance.damage);
            DataController.Instance.criticalindex = 0;
          //  DataController.Instance.MonsterNowHp -= DataController.Instance.damage;


        }

     //   if (DataController.Instance.MonsterNowHp <= 0)
      //  {
        //    Player.Instance.animator.SetInteger("state", 0);
         //   DataController.Instance.monstermoveindex = 0;
          //  StageMonster.Instance.die();
     //   }

       // TextController.Instance.changevalueStageMosnterHp();
    //    DataController.Instance.damagespwan();
    }
}
