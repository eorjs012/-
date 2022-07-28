using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;
using TMPro;
using UnityEngine.UI;
using BackEnd;

public class DataController : MonoBehaviour
{
    private static DataController instance;

    public static DataController Instance
    {
        get
        {
            if (instance != null) return instance;
            instance = FindObjectOfType<DataController>();
            if (instance != null) return instance;
            var container = new GameObject("DataController");
            return instance;
        }
    }
    private void Awake()
    {
        var obj = FindObjectsOfType<DataController>();
        if (obj.Length == 1)
        { DontDestroyOnLoad(gameObject); }
        else
        { Destroy(gameObject); }
    }


   


    public void Start()
    {

        if(weaponplus==0)
        {
            weapon0count +=1;
            weapon0level +=1;
            weaponplus += 1;
        }
         
        if(guardplus==0)
        {
            guard0count += 1;
            guard0level += 1;
            guardplus+=1;
        }
       
        if(helmetplus==0)
        {
            helmet0count += 1;
            helmet0level += 1;
            helmetplus+=1;
        }
        
        if(armorplus==0)
        {
            Armor0count += 1;
            armor0level += 1;
            armorplus+=1;
        }
       
        //adcloseindex = 0;
        TutorialsManager.Instance.tutorialinfopanel(tutorialindex);
        //rock = 1000000;
        //gold = 0;
       //PlayerPrefs.DeleteAll();
        // Diamond = 99999999;
      //  upgradestone = 99999999;
        TextController.Instance.StageTextUpdate();
        //stage = 29;
        //nowstage = 30;
        round = 1;
        Scenemoveindex = 0;
        monstermoveindex = 0;
        weapon0index = 1;
        guard0index = 1;
        helmet0index = 1;
        armor0index = 1;
        //weapon0count = 1;
        //weapon0level = 1;
        //weapon0crypower = 0.01f;
        //guard0count = 1;
        // guard0level = 1;
        // helmet0count = 1;
        // helmet0level = 1;
        // Armor0count = 1;
        //armor0level = 1;
        TextController.Instance.changeuiguardinfopanel();
        TextController.Instance.changeuiweaponinfopanel();
       // meetticket = 20;
       // miningticket = 2;
       // rockticket = 5;
        meetstatesetting();
        TextController.Instance.mylevelexpup();
        TextController.Instance.changevaluemylevelslider();
        InvokeRepeating("loaddata", 10, 10);
        tutorialsureindex = 0;
        meetcooltimesetting();
        miningcooltimesetting();
        rockcooltimesetting();
        TextController.Instance.checkrockstagepanel();
        rockstatesetting();

       


    }
  

    public void loaddata()
    {
        //BackEndGameInfo.Instance.InsertPrivateData();
    }
    public int weaponplus
    {
        get { return SmartSecurity.GetInt("weaponplus", 0); }
        set { SmartSecurity.SetInt("weaponplus", value); }
    }
    public int guardplus
    {
        get { return SmartSecurity.GetInt("guardplus", 0); }
        set { SmartSecurity.SetInt("guardplus", value); }
    }
    public int helmetplus
    {
        get { return SmartSecurity.GetInt("helmetplus", 0); }
        set { SmartSecurity.SetInt("helmetplus", value); }
    }
    public int armorplus
    {
        get { return SmartSecurity.GetInt("armorplus", 0); }
        set { SmartSecurity.SetInt("armorplus", value); }
    }
    public int rankupdatetime
    {
        get { return SmartSecurity.GetInt("rankupdatetime", 0); }
        set { SmartSecurity.SetInt("rankupdatetime", value); }
    }

    public int myrank
    {
        get { return SmartSecurity.GetInt("myrank", 0); }
        set { SmartSecurity.SetInt("myrank", value); }
    }

    public int tutorialindex
    {
        get { return SmartSecurity.GetInt("tutorialindex", 0); }
        set { SmartSecurity.SetInt("tutorialindex", value); }
    }
    
    public int tutorialsureindex
    {
        get { return SmartSecurity.GetInt("tutorialsureindex", 0); }
        set { SmartSecurity.SetInt("tutorialsureindex", value); }
    }
    public int tutorialweapon
    {
        get { return SmartSecurity.GetInt("tutorialweapon", 0); }
        set { SmartSecurity.SetInt("tutorialweapon", value); }
    }
    public int tutorialguard
    {
        get { return SmartSecurity.GetInt("tutorialguard", 0); }
        set { SmartSecurity.SetInt("tutorialguard", value); }
    }
    public int tutorialhelmet
    {
        get { return SmartSecurity.GetInt("tutorialhelmet", 0); }
        set { SmartSecurity.SetInt("tutorialhelmet", value); }
    }
    public int tutorialarmor
    {
        get { return SmartSecurity.GetInt("tutorialarmor", 0); }
        set { SmartSecurity.SetInt("tutorialarmor", value); }
    }
    public int tutorialstagemonster
    {
        get { return SmartSecurity.GetInt("tutorialstagemonster", 0); }
        set { SmartSecurity.SetInt("tutorialstagemonster", value); }
    }
    public int tutorialstagebossmonster
    {
        get { return SmartSecurity.GetInt("tutorialstagebossmonster", 0); }
        set { SmartSecurity.SetInt("tutorialstagebossmonster", value); }
    }
    public int tutorialmeetdongeon
    {
        get { return SmartSecurity.GetInt("tutorialmeetdongeon", 0); }
        set { SmartSecurity.SetInt("tutorialmeetdongeon", value); }
    }
    public int tutorialminingdongeon
    {
        get { return SmartSecurity.GetInt("tutorialminingdongeon", 0); }
        set { SmartSecurity.SetInt("tutorialminingdongeon", value); }
    }
    public int tutorialrockdongeon
    {
        get { return SmartSecurity.GetInt("tutorialrockdongeon", 0); }
        set { SmartSecurity.SetInt("tutorialrockdongeon", value); }
    }
    public int monstermoveindex
    {
        get { return SmartSecurity.GetInt("monstermoveindex", 0); }
        set { SmartSecurity.SetInt("monstermoveindex", value); }
    }
   
    public int Scenemoveindex
    {
        get { return SmartSecurity.GetInt("Scenemoveindex", 0); }
        set { SmartSecurity.SetInt("Scenemoveindex", value); }
    }
   
    public int criticalindex
    {
        get { return SmartSecurity.GetInt("criticalindex", 0); }
        set { SmartSecurity.SetInt("criticalindex", value); }
    }
    public int criindex
    {
        get { return SmartSecurity.GetInt("criindex", 0); }
        set { SmartSecurity.SetInt("criindex", value); }
    }
    public int mylevel
    {
        get { return SmartSecurity.GetInt("mylevel", 1); }
        set { SmartSecurity.SetInt("mylevel", value); }
    }
    public float mylevelexp
    {
        get { return SmartSecurity.GetFloat("mylevelexp", 0); }  
        set { SmartSecurity.SetFloat("mylevelexp", value); }
    }
    public float mylevelmaxexp
    {
        get { return SmartSecurity.GetFloat("mylevelmaxexp", 9999999999999); }
        set { SmartSecurity.SetFloat("mylevelmaxexp", value); }
    }
    public float mylevelnowexp
    {
        get { return SmartSecurity.GetFloat("mylevelnowexp", (10 * math.pow(1.5f, mylevel))); }
        set { SmartSecurity.SetFloat("mylevelnowexp", value); }
    }
    public float mylevelbasicexp
    {
        get { return SmartSecurity.GetFloat("mylevelbasicexp", 2); }
        set { SmartSecurity.SetFloat("mylevelbasicexp", value); }
    }
    public float mylevelbossexp
    {
        get { return SmartSecurity.GetFloat("mylevelbossexp", 5); }
        set { SmartSecurity.SetFloat("mylevelbossexp", value); }
    }
    public int mylevelexpreward
    {
        get { return SmartSecurity.GetInt("mylevelexpreward", 500); }
        set { SmartSecurity.SetInt("mylevelexpreward", value); }
    }
    public float mylevelreward
    {
        get { return SmartSecurity.GetFloat("mylevelreward", (100 * math.pow(1.5f, mylevel))); }
        set { SmartSecurity.SetFloat("mylevelreward", value); }
    }

    public double damage   //무기,방패,투구,갑옷,음식강화,음식진화.레벨.패시브,정령,유물,훈장
    {
        get { return double.Parse(SmartSecurity.GetString("damage", ((mytotalpassivedamage + goldupdamage + meetpower + meetrevolpower + amblem0damage + amblem1damage + amblem2damage + amblem3damage + mytotalfrienddamage +mytotalfriendartifactdamage) *weapondamage * guarddamage * helmetdamage * armordamage  ).ToString())); }
        set { SmartSecurity.SetString("damage", value.ToString()); }
    }

    public double weapondamage
    {
        get { return double.Parse(SmartSecurity.GetString("weapondamage", (weapon0power + weapon1power + weapon2power + weapon3power + weapon4power + weapon5power + weapon6power + weapon7power + weapon8power + weapon9power + weapon10power).ToString())); }
        set { SmartSecurity.SetString("weapondamage", value.ToString()); }
    }

    public double guarddamage
    {
        get { return double.Parse(SmartSecurity.GetString("guarddamage", (guard0power + guard1power + guard2power + guard3power + guard4power + guard5power + guard6power + guard7power + guard8power + guard9power + guard10power).ToString())); }
        set { SmartSecurity.SetString("guarddamage", value.ToString()); }
    }
    public double helmetdamage
    {
        get { return double.Parse(SmartSecurity.GetString("helmetdamage", (helmet0power + helmet1power + helmet2power + helmet3power + helmet4power + helmet5power + helmet6power + helmet7power + helmet8power + helmet9power + helmet10power).ToString())); }
        set { SmartSecurity.SetString("helmetdamage", value.ToString()); }
    }
    public double armordamage
    {
        get { return double.Parse(SmartSecurity.GetString("armordamage", (armor0power + armor1power + armor2power + armor3power + armor4power + armor5power + armor6power + armor7power + armor8power + armor9power + armor10power).ToString())); }
        set { SmartSecurity.SetString("armordamage", value.ToString()); }
    }
    public float mytotalpassivedamage
    { 
        get { return SmartSecurity.GetFloat("mytotalpassivedamage",( passiveservedamage+passivedamage+passiveguardservedamage+passiveringservedamage+passiveshoeservedamage+passiveanvilservedamage+passivepickservedamage+passiveluckyservedamage+passivebowservedamage)); }
        set { SmartSecurity.SetFloat("mytotalpassivedamage", value); }
    }
    public float mytotalfrienddamage
    {
        get { return SmartSecurity.GetFloat("mytotalfrienddamage",(1+friend0power+ friend1power+ friend2power+ friend3power+ friend4power)); }
        set { SmartSecurity.SetFloat("mytotalfrienddamage", value); }
    }
    public float mytotalfriendartifactdamage
    {
        get { return SmartSecurity.GetFloat("mytotalfriendartifactdamage", (1+friend0artifactpower+ friend1artifactpower+ friend2artifactpower+ friend3artifactpower+ friend4artifactpower)); }
        set { SmartSecurity.SetFloat("mytotalfriendartifactdamage", value); }
    }
    public float attackspeed
    {
        get { return SmartSecurity.GetFloat("attackspeed", 1 + mytotalhelmetattackspeed ); }
        set { SmartSecurity.SetFloat("attackspeed", value); }
    }
    public float mytotalhelmetattackspeed
    {
        get { return SmartSecurity.GetFloat("mytotalhelmetattackspeed", helmet0attackspeed + helmet1attackspeed + helmet2attackspeed + helmet3attackspeed + helmet4attackspeed + helmet5attackspeed + helmet6attackspeed + helmet7attackspeed + helmet8attackspeed + helmet9attackspeed + helmet10attackspeed + golduppowerspeed+passiveanvilswardspeed); }
        set { SmartSecurity.SetFloat("mytotalhelmetattackspeed", value); }
    }
    public float backgroundspeed
    {
        get { return SmartSecurity.GetFloat("backgroundspeed",0.50f +mytotalarmorbackgroundspeed); }
        set { SmartSecurity.SetFloat("backgroundspeed", value); }
    }
    public float monstermovespeed
    {
        get { return SmartSecurity.GetFloat("monstermovespeed", 0.025f+ mytotalmonstermovespeed); }
        set { SmartSecurity.SetFloat("monstermovespeed", value); }
    }
    public float mytotalarmorbackgroundspeed
    {
        get { return SmartSecurity.GetFloat("mytotalarmorbackgroundspeed", armor0backspeed + armor1backspeed + armor2backspeed + armor3backspeed + armor4backspeed + armor5backspeed + armor6backspeed + armor7backspeed + armor8backspeed + armor9backspeed + armor10backspeed+ passiveshoespeed+ goldupspeed); }
        set { SmartSecurity.SetFloat("mytotalarmorbackgroundspeed", value); }
    }
    public float mytotalmonstermovespeed
    {
        get { return SmartSecurity.GetFloat("mytotalmonstermovespeed",armor0monsterspeed+ armor1monsterspeed+ armor2monsterspeed+ armor3monsterspeed+ armor4monsterspeed+ armor5monsterspeed+ armor6monsterspeed+ armor7monsterspeed+ armor8monsterspeed+ armor9monsterspeed+ armor10monsterspeed+ goldupmosterspeed+ passiveshoemonsterspeed); }
        set { SmartSecurity.SetFloat("mytotalmonstermovespeed", value); }
    }
    public double MonsterMaxHp
    {
        get { return double.Parse(SmartSecurity.GetString("MonsterMaxHp", ("0").ToString())); }
        set { SmartSecurity.SetString("MonsterMaxHp", value.ToString()); }
    }

    public double MonsterNowHp
    {
        get { return double.Parse(SmartSecurity.GetString("MonsterNowHp", ("0").ToString())); }
        set { SmartSecurity.SetString("MonsterNowHp", value.ToString()); }
    }

    public double stagebasicmonsterHp
    {
        get { return double.Parse(SmartSecurity.GetString("stagebasicmonsterHp", (1 * math.pow(1.5f, stage)*(1-friend0diaup/100)).ToString())); }
        set { SmartSecurity.SetString("stagebasicmonsterHp", value.ToString()); }
    }

    public double stagebossmonsterHp
    {
        get { return double.Parse(SmartSecurity.GetString("stagebossmonsterHp", (stagebasicmonsterHp*1.7f*(1- friend1artifactmonsterhpdown/100)).ToString())); }
        set { SmartSecurity.SetString("stagebossmonsterHp", value.ToString()); }
    }
   
   

    public double gold
    {
        get { return double.Parse(SmartSecurity.GetString("gold", (0).ToString())); }
        set { SmartSecurity.SetString("gold", value.ToString()); }
    }

    public double stagebasicgoldreward
    {
        get { return double.Parse(SmartSecurity.GetString("stagebasicgoldreward", (10 * math.pow(1.001f, stage)* (1+friend0goldup+ friend4artifactgoldper+ passiveluckygoldup / 100)).ToString())); }
        set { SmartSecurity.SetString("stagebasicgoldreward", value.ToString()); }
    }

    public double stagebossgoldreward
    {
        get { return double.Parse(SmartSecurity.GetString("stagebossgoldreward", (stagebasicgoldreward * 4 * (1 + friend0goldup+ friend4artifactgoldper+ passiveluckygoldup / 100)).ToString())); }
        set { SmartSecurity.SetString("stagebossgoldreward", value.ToString()); }
    }
    public float adgoldplus
    {
        get { return SmartSecurity.GetFloat("adgoldplus", 1.5f * adindex) ; }
        set { SmartSecurity.SetFloat("adgoldplus", value); }
    }
    public float meetrespawnbossper
    {
        get { return SmartSecurity.GetFloat("meetrespawnbossper", 5+friend2meetbossper); }
        set { SmartSecurity.SetFloat("meetrespawnbossper", value); }
    }

    public int stage
    {
        get { return SmartSecurity.GetInt("stage", 1); }
        set { SmartSecurity.SetInt("stage", value); }
    }
    public int nowstage
    {
        get { return SmartSecurity.GetInt("nowstage", 1); }
        set { SmartSecurity.SetInt("nowstage", value); }
    }


    public int round
    {
        get { return SmartSecurity.GetInt("round", 1); }
        set { SmartSecurity.SetInt("round", value); }
    }
    public int updateindex
    {
        get { return SmartSecurity.GetInt("updateindex", 0); }
        set { SmartSecurity.SetInt("updateindex", value); }
    }
    public int nowupdateindex
    {
        get { return SmartSecurity.GetInt("nowupdateindex", 0); }
        set { SmartSecurity.SetInt("nowupdateindex", value); }
    }
    //돌
    public float rock
    {
        get { return SmartSecurity.GetFloat("rock", 0); }
        set { SmartSecurity.SetFloat("rock", value); }
    }

    public float Diamond
    {
        get { return SmartSecurity.GetFloat("Diamond" ,0); }
        set { SmartSecurity.SetFloat("Diamond", value); }
    }

    //강화석
    public float upgradestone
    {
        get { return SmartSecurity.GetFloat("upgradestone", 0); }
        set { SmartSecurity.SetFloat("upgradestone", value); }
    }
    public float stagebasicupgradestonereward
    { 
        get { return SmartSecurity.GetFloat("stagebasicupgradestonereward", (1 * math.pow(1.0001f, stage))); }
        set { SmartSecurity.SetFloat("stagebasicupgradestonereward", value); }
    }
    public float stagebossupgradestonereward
    {
        get { return SmartSecurity.GetFloat("stagebossupgradestonereward", stagebasicupgradestonereward*3); }
        set { SmartSecurity.SetFloat("stagebossupgradestonereward", value); }
    }
    public float friendupgradestoneper
    {
        get { return SmartSecurity.GetFloat("friendupgradestoneper", 3 + friend1plusupstone); }
        set { SmartSecurity.SetFloat("friendupgradestoneper", value); }
    }
    public int upgradestoneindex
    {
        get { return SmartSecurity.GetInt("upgradestoneindex", 0); }
        set { SmartSecurity.SetInt("upgradestoneindex", value); }
    }
    public int bossupgradestoneindex
    {
        get { return SmartSecurity.GetInt("bossupgradestoneindex", 0); }
        set { SmartSecurity.SetInt("bossupgradestoneindex", value); }
    }
    public float friendupgradestonrandom
    {
        get { return SmartSecurity.GetFloat("friendupgradestonrandom", Random.Range(0,100)); }
        set { SmartSecurity.SetFloat("friendupgradestonrandom", value); }
    }
    public float weaponupgradestone
    {
        get { return SmartSecurity.GetFloat("weaponupgradestone", 0); }
        set { SmartSecurity.SetFloat("weaponupgradestone", value); }
    }
    public float guardupgradestone
    {
        get { return SmartSecurity.GetFloat("guardupgradestone", 0); }
        set { SmartSecurity.SetFloat("guardupgradestone", value); }
    }
    public float helmetupgradestone
    {
        get { return SmartSecurity.GetFloat("helmetupgradestone", 0); }
        set { SmartSecurity.SetFloat("helmetupgradestone", value); }
    }
    public float armorupgradestone
    {
        get { return SmartSecurity.GetFloat("armorupgradestone", 0); }
        set { SmartSecurity.SetFloat("armorupgradestone", value); }
    }
    public float meet

    {
        get { return SmartSecurity.GetFloat("meet", 0); }
        set { SmartSecurity.SetFloat("meet", value); }
    }
    public int meetreward
    {
        get { return SmartSecurity.GetInt("meetreward", 0); }
        set { SmartSecurity.SetInt("meetreward", value); }
    }
    public int meetticket
    {
        get { return SmartSecurity.GetInt("meetticket", 0); }
        set { SmartSecurity.SetInt("meetticket", value); }
    }
    public int cooltime
    {
        get { return SmartSecurity.GetInt("cooltime", 30+ (int)(friend4meettimerup)); }
        set { SmartSecurity.SetInt("cooltime", value); }
    }
    public void meetcooltimesetting()
    {
        cooltime = 30 + (int)(friend4meettimerup);
    }
    public int meetround
    {
        get { return SmartSecurity.GetInt("meetround", 1); }
        set { SmartSecurity.SetInt("meetround", value); }
    }
    public int meetmaxround
    {
        get { return SmartSecurity.GetInt("meetmaxround", 10+(int)(friend4meetroundup)); }
        set { SmartSecurity.SetInt("meetmaxround", value); }
    }
    public float criticalper //방패,캐릭터레벨,기술반지,정령유물
    {
        get { return SmartSecurity.GetFloat("criticalper", (mytotalguardcriticalper+goldupcryper+passiveringcryper+friend2artifactcryper)); }
        set { SmartSecurity.SetFloat("criticalper", value); }
    }
    public float mytotalguardcriticalper
    {
        get { return SmartSecurity.GetFloat("criticalper", guard0cryper+ guard1cryper+ guard2cryper+ guard3cryper+ guard4cryper+ guard5cryper+ guard6cryper+ guard7cryper+ guard8cryper+ guard9cryper+ guard10cryper); }
        set { SmartSecurity.SetFloat("criticalper", value); }
    }
    public float criticaldamage  //무기,캐릭터레벨,기술방패,훈장,정령,정령유물
    {
        get { return SmartSecurity.GetFloat("criticaldamage", (1 + mytotalweaponcridamage + goldupcrydamage + mytotalamblemcridamage + passiveguardcrydamage + mytotalfriendcridamage)); } 
        set { SmartSecurity.SetFloat("criticaldamage", value); }
    }
    public float mytotalamblemcridamage
    {
        get { return SmartSecurity.GetFloat("mytotalamblemcridamage", (amblem1crydamage + amblem2crydamage + amblem3crydamage)); }
        set { SmartSecurity.SetFloat("mytotalamblemcridamage", value); }
    }
    public float mytotalfriendcridamage
    {
        get { return SmartSecurity.GetFloat("mytotalfriendcridamage", (friend1crydamage +friend0artifactcrypower+friend1artifactcrypower+ friend2artifactcrypower+friend3artifactcrypower+friend4artifactcrypower)); }
        set { SmartSecurity.SetFloat("mytotalfriendcridamage", value); }
    }
    public float mytotalweaponcridamage
    {
        get { return SmartSecurity.GetFloat("mytotalweaponcridamage", (weapon0crypower + weapon1crypower + weapon2crypower + weapon3crypower + weapon4crypower + weapon5crypower + weapon6crypower + weapon7crypower + weapon8crypower + weapon9crypower + weapon10crypower)); }
        set { SmartSecurity.SetFloat("mytotalweaponcridamage", value); }
    }
    public int usernameindex
    {
        get { return SmartSecurity.GetInt("usernameindex", 0); }
        set { SmartSecurity.SetInt("usernameindex", value); }
    }
    public string MyNickname
    {
        get { return (SmartSecurity.GetString("MyNickname", Backend.UserNickName));  }
        set { SmartSecurity.SetString("MyNickname", value.ToString()); }
    }

    public string myprivateindata
    {
        get { return (SmartSecurity.GetString("myprivateindata", "0")); }
        set { SmartSecurity.SetString("myprivateindata", value.ToString()); }
    }

    public string nowdate
    {
        get { return (SmartSecurity.GetString("nowdate", "0")); }
        set { SmartSecurity.SetString("nowdate", value.ToString()); }
    }

    public string nowmonth
    {
        get { return (SmartSecurity.GetString("nowmonth", "0")); }
        set { SmartSecurity.SetString("nowmonth", value.ToString()); }
    }
    public string resttime
    {
        get { return (SmartSecurity.GetString("resttime", "0")); }
        set { SmartSecurity.SetString("resttime", value.ToString()); }
    }


    public float lastplaytime
    {
        get { return SmartSecurity.GetFloat("lastplaytime", 0); }
        set { SmartSecurity.SetFloat("lastplaytime", value); }
    }



    public string myrankdata
    {
        get { return (SmartSecurity.GetString("myrankdata", "0")); }
        set { SmartSecurity.SetString("myrankdata", value.ToString()); }
    }
    public int deathmodeindex
    {
        get { return SmartSecurity.GetInt("deathmodeindex", 0); }
        set { SmartSecurity.SetInt("deathmodeindex", value); }
    } 
    public int mainpanelindex
    {
        get { return SmartSecurity.GetInt("mainpanelindex", 0); }
        set { SmartSecurity.SetInt("mainpanelindex", value); }
    }
    public int eqpanelindex
    {
        get { return SmartSecurity.GetInt("eqpanelindex", 0); }
        set { SmartSecurity.SetInt("eqpanelindex", value); }
    }

    public int weapon0count
    {
        get { return SmartSecurity.GetInt("weapon0count",0); }
        set { SmartSecurity.SetInt("weapon0count", value); }
    }
    public int weapon1count
    {
        get { return SmartSecurity.GetInt("weapon1count", 0); }
        set { SmartSecurity.SetInt("weapon1count", value); }
    }
    public int weapon2count
    {
        get { return SmartSecurity.GetInt("weapon2count", 0); }
        set { SmartSecurity.SetInt("weapon2count", value); }
    }
    public int weapon3count
    {
        get { return SmartSecurity.GetInt("weapon3count", 0); }
        set { SmartSecurity.SetInt("weapon3count", value); }
    }
    public int weapon4count
    {
        get { return SmartSecurity.GetInt("weapon4count", 0); }
        set { SmartSecurity.SetInt("weapon4count", value); }
    }
    public int weapon5count
    {
        get { return SmartSecurity.GetInt("weapon5count", 0); }
        set { SmartSecurity.SetInt("weapon5count", value); }
    }
    public int weapon6count
    {
        get { return SmartSecurity.GetInt("weapon6count", 0); }
        set { SmartSecurity.SetInt("weapon6count", value); }
    }
    public int weapon7count
    {
        get { return SmartSecurity.GetInt("weapon7count", 0); }
        set { SmartSecurity.SetInt("weapon7count", value); }
    }
    public int weapon8count
    {
        get { return SmartSecurity.GetInt("weapon8count", 0); }
        set { SmartSecurity.SetInt("weapon8count", value); }
    }
    public int weapon9count
    {
        get { return SmartSecurity.GetInt("weapon9count", 0); }
        set { SmartSecurity.SetInt("weapon9count", value); }
    }

    public int weapon10count
    {
        get { return SmartSecurity.GetInt("weapon10count", 0); }
        set { SmartSecurity.SetInt("weapon10count", value); }
    }
   
   
    public int guard0count
    {
        get { return SmartSecurity.GetInt("guard0count", 0); }
        set { SmartSecurity.SetInt("guard0count", value); }
    }
    public int guard1count
    {
        get { return SmartSecurity.GetInt("guard1count", 0); }
        set { SmartSecurity.SetInt("guard1count", value); }
    }
    public int guard2count
    {
        get { return SmartSecurity.GetInt("guard2count", 0); }
        set { SmartSecurity.SetInt("guard2count", value); }
    }
    public int guard3count
    {
        get { return SmartSecurity.GetInt("guard3count", 0); }
        set { SmartSecurity.SetInt("guard3count", value); }
    }
    public int guard4count
    {
        get { return SmartSecurity.GetInt("guard4count", 0); }
        set { SmartSecurity.SetInt("guard4count", value); }
    }
    public int guard5count
    {
        get { return SmartSecurity.GetInt("guard5count", 0); }
        set { SmartSecurity.SetInt("guard5count", value); }
    }
    public int guard6count
    {
        get { return SmartSecurity.GetInt("guard6count", 0); }
        set { SmartSecurity.SetInt("guard6count", value); }
    }
    public int guard7count
    {
        get { return SmartSecurity.GetInt("guard7count", 0); }
        set { SmartSecurity.SetInt("guard7count", value); }
    }
    public int guard8count
    {
        get { return SmartSecurity.GetInt("guard8count", 0); }
        set { SmartSecurity.SetInt("guard8count", value); }
    }
    public int guard9count
    {
        get { return SmartSecurity.GetInt("guard9count", 0); }
        set { SmartSecurity.SetInt("guard9count", value); }
    }

    public int guard10count
    {
        get { return SmartSecurity.GetInt("guard10count", 0); }
        set { SmartSecurity.SetInt("guard10count", value); }
    }
 
    public int helmet0count
    {
        get { return SmartSecurity.GetInt("helmet0count", 0); }
        set { SmartSecurity.SetInt("helmet0count", value); }
    }
    public int helmet1count
    {
        get { return SmartSecurity.GetInt("helmet1count", 0); }
        set { SmartSecurity.SetInt("helmet1count", value); }
    }
    public int helmet2count
    {
        get { return SmartSecurity.GetInt("helmet2count", 0); }
        set { SmartSecurity.SetInt("helmet2count", value); }
    }
    public int helmet3count
    {
        get { return SmartSecurity.GetInt("helmet3count", 0); }
        set { SmartSecurity.SetInt("helmet3count", value); }
    }
    public int helmet4count
    {
        get { return SmartSecurity.GetInt("helmet4count", 0); }
        set { SmartSecurity.SetInt("helmet4count", value); }
    }
    public int helmet5count
    {
        get { return SmartSecurity.GetInt("helmet5count", 0); }
        set { SmartSecurity.SetInt("helmet5count", value); }
    }
    public int helmet6count
    {
        get { return SmartSecurity.GetInt("helmet6count", 0); }
        set { SmartSecurity.SetInt("helmet6count", value); }
    }
    public int helmet7count
    {
        get { return SmartSecurity.GetInt("helmet7count", 0); }
        set { SmartSecurity.SetInt("helmet7count", value); }
    }
    public int helmet8count
    {
        get { return SmartSecurity.GetInt("helmet8count", 0); }
        set { SmartSecurity.SetInt("helmet8count", value); }
    }
    public int helmet9count
    {
        get { return SmartSecurity.GetInt("helmet9count", 0); }
        set { SmartSecurity.SetInt("helmet9count", value); }
    }

    public int helmet10count
    {
        get { return SmartSecurity.GetInt("helmet10count", 0); }
        set { SmartSecurity.SetInt("helmet10count", value); }
    }
  
    public int Armor0count
    {
        get { return SmartSecurity.GetInt("Armor0count", 0) ; }
        set { SmartSecurity.SetInt("Armor0count", value); }
    }
    public int Armor1count
    {
        get { return SmartSecurity.GetInt("Armor1count", 0); }
        set { SmartSecurity.SetInt("Armor1count", value); }
    }
    public int Armor2count
    {
        get { return SmartSecurity.GetInt("Armor2count", 0); }
        set { SmartSecurity.SetInt("Armor2count", value); }
    }
    public int Armor3count
    {
        get { return SmartSecurity.GetInt("Armor3count", 0); }
        set { SmartSecurity.SetInt("Armor3count", value); }
    }
    public int Armor4count
    {
        get { return SmartSecurity.GetInt("Armor4count", 0); }
        set { SmartSecurity.SetInt("Armor4count", value); }
    }
    public int Armor5count
    {
        get { return SmartSecurity.GetInt("Armor5count", 0); }
        set { SmartSecurity.SetInt("Armor5count", value); }
    }
    public int Armor6count
    {
        get { return SmartSecurity.GetInt("Armor6count", 0); }
        set { SmartSecurity.SetInt("Armor6count", value); }
    }
    public int Armor7count
    {
        get { return SmartSecurity.GetInt("Armor7count", 0); }
        set { SmartSecurity.SetInt("Armor7count", value); }
    }
    public int Armor8count
    {
        get { return SmartSecurity.GetInt("Armor8count", 0); }
        set { SmartSecurity.SetInt("Armor8count", value); }
    }
    public int Armor9count
    {
        get { return SmartSecurity.GetInt("Armor9count", 0); }
        set { SmartSecurity.SetInt("Armor9count", value); }
    }

    public int Armor10count
    {
        get { return SmartSecurity.GetInt("Armor10count", 0); }
        set { SmartSecurity.SetInt("Armor10count", value); }
    }
    
 
    public int weaponinfoindex
    {
        get { return SmartSecurity.GetInt("weaponinfoindex", 0); }
        set { SmartSecurity.SetInt("weaponinfoindex", value); }
    }
    public int weaponmixcount
    {
        get { return SmartSecurity.GetInt("weaponmixcount", 0); }
        set { SmartSecurity.SetInt("weaponmixcount", value); }
    }
    public int weapon0level
    {
        get { return SmartSecurity.GetInt("weapon0level",0); }
        set { SmartSecurity.SetInt("weapon0level", value); }
    }
    public int weapon1level
    {
        get { return SmartSecurity.GetInt("weapon1level", 0); }
        set { SmartSecurity.SetInt("weapon1level", value); }
    }
    public int weapon2level
    {
        get { return SmartSecurity.GetInt("weapon2level", 0); }
        set { SmartSecurity.SetInt("weapon2level", value); }
    }
    public int weapon3level
    {
        get { return SmartSecurity.GetInt("weapon3level", 0); }
        set { SmartSecurity.SetInt("weapon3level", value); }
    }
    public int weapon4level
    {
        get { return SmartSecurity.GetInt("weapon4level", 0); }
        set { SmartSecurity.SetInt("weapon4level", value); }
    }
    public int weapon5level
    {
        get { return SmartSecurity.GetInt("weapon5level", 0); }
        set { SmartSecurity.SetInt("weapon5level", value); }
    }
    public int weapon6level
    {
        get { return SmartSecurity.GetInt("weapon6level", 0); }
        set { SmartSecurity.SetInt("weapon6level", value); }
    }
    public int weapon7level
    {
        get { return SmartSecurity.GetInt("weapon7level", 0); }
        set { SmartSecurity.SetInt("weapon7level", value); }
    }
    public int weapon8level
    {
        get { return SmartSecurity.GetInt("weapon8level", 0); }
        set { SmartSecurity.SetInt("weapon8level", value); }
    }
    public int weapon9level
    {
        get { return SmartSecurity.GetInt("weapon9level", 0); }
        set { SmartSecurity.SetInt("weapon9level", value); }
    }
    public int weapon10level
    {
        get { return SmartSecurity.GetInt("weapon10level", 0); }
        set { SmartSecurity.SetInt("weapon10level", value); }
    }


    public float weapon0power //E
    {
        get { return SmartSecurity.GetFloat("weapon0power", 1 * weapon0level); }
        set { SmartSecurity.SetFloat("weapon0power", value); }
    }
    public float weapon1power //D
    {
        get { return SmartSecurity.GetFloat("weapon1power", 2 * weapon1level); }
        set { SmartSecurity.SetFloat("weapon1power", value); }
    }
    public float weapon2power //C
    {
        get { return SmartSecurity.GetFloat("weapon2power", 4 * weapon2level); }
        set { SmartSecurity.SetFloat("weapon2power", value); }
    }
    public float weapon3power //B
    {
        get { return SmartSecurity.GetFloat("weapon3power", 8 * weapon3level); }
        set { SmartSecurity.SetFloat("weapon3power", value); }
    }
    public float weapon4power //A
    {
        get { return SmartSecurity.GetFloat("weapon4power", 16 * weapon4level); }
        set { SmartSecurity.SetFloat("weapon4power", value); }
    }
    public float weapon5power //S
    {
        get { return SmartSecurity.GetFloat("weapon5power", 32 * weapon5level); }
        set { SmartSecurity.SetFloat("weapon5power", value); }
    }
    public float weapon6power //SS
    {
        get { return SmartSecurity.GetFloat("weapon6power", 64 * weapon6level); }
        set { SmartSecurity.SetFloat("weapon6power", value); }
    }
    public float weapon7power //SSS
    {
        get { return SmartSecurity.GetFloat("weapon7power", 128 * weapon7level); }
        set { SmartSecurity.SetFloat("weapon7power", value); }
    }
    public float weapon8power //R
    {
        get { return SmartSecurity.GetFloat("weapon8power", 256 * weapon8level); }
        set { SmartSecurity.SetFloat("weapon8power", value); }
    }
    public float weapon9power //U
    {
        get { return SmartSecurity.GetFloat("weapon9power", 1280 * weapon9level); }
        set { SmartSecurity.SetFloat("weapon9power", value); }
    }
    public float weapon10power //UR
    {
        get { return SmartSecurity.GetFloat("weapon10power", 6400 * weapon10level); }
        set { SmartSecurity.SetFloat("weapon10power", value); }
    }

    public float weapon0crypower

    {
        get { return SmartSecurity.GetFloat("weapon0crypower", 0.01f*weapon0index); }
        set { SmartSecurity.SetFloat("weapon0crypower", value); }
    }
    public float weapon1crypower

    {
        get { return SmartSecurity.GetFloat("weapon1crypower", 0.01f * weapon1index); }
        set { SmartSecurity.SetFloat("weapon1crypower", value); }
    }
    public float weapon2crypower

    {
        get { return SmartSecurity.GetFloat("weapon2crypower", 0.01f * weapon2index); }
        set { SmartSecurity.SetFloat("weapon2crypower", value); }
    }
    public float weapon3crypower

    {
        get { return SmartSecurity.GetFloat("weapon3crypower", 0.01f * weapon3index); }
        set { SmartSecurity.SetFloat("weapon3crypower", value); }
    }
    public float weapon4crypower

    {
        get { return SmartSecurity.GetFloat("weapon4crypower", 0.01f * weapon4index); }
        set { SmartSecurity.SetFloat("weapon4crypower", value); }
    }
    public float weapon5crypower

    {
        get { return SmartSecurity.GetFloat("weapon5crypower", 0.01f * weapon5index); }
        set { SmartSecurity.SetFloat("weapon5crypower", value); }
    }
    public float weapon6crypower

    {
        get { return SmartSecurity.GetFloat("weapon6crypower", 0.01f * weapon6index); }
        set { SmartSecurity.SetFloat("weapon6crypower", value); }
    }
    public float weapon7crypower

    {
        get { return SmartSecurity.GetFloat("weapon7crypower", 0.01f * weapon7index); }
        set { SmartSecurity.SetFloat("weapon7crypower", value); }
    }
    public float weapon8crypower

    {
        get { return SmartSecurity.GetFloat("weapon8crypower", 0.02f * weapon8index); }
        set { SmartSecurity.SetFloat("weapon8crypower", value); }
    }
    public float weapon9crypower

    {
        get { return SmartSecurity.GetFloat("weapon9crypower", 0.03f * weapon9index); }
        set { SmartSecurity.SetFloat("weapon9crypower", value); }
    }
    public float weapon10crypower

    {
        get { return SmartSecurity.GetFloat("weapon10crypower", 0.04f * weapon10index); }
        set { SmartSecurity.SetFloat("weapon10crypower", value); }
    }

    public float weapon0upgradecost

    {
        get { return SmartSecurity.GetFloat("weapon0upgradecost", 10 + 10 * weapon0level); }
        set { SmartSecurity.SetFloat("weapon0upgradecost", value); }
    }
    public float weapon1upgradecost

    {
        get { return SmartSecurity.GetFloat("weapon1upgradecost", 20 + 20 * weapon1level); }
        set { SmartSecurity.SetFloat("weapon1upgradecost", value); }
    }
    public float weapon2upgradecost

    {
        get { return SmartSecurity.GetFloat("weapon2upgradecost", 30 + 30 * weapon2level); }
        set { SmartSecurity.SetFloat("weapon2upgradecost", value); }
    }
    public float weapon3upgradecost

    {
        get { return SmartSecurity.GetFloat("weapon3upgradecost", 40 + 40 * weapon3level); }
        set { SmartSecurity.SetFloat("weapon3upgradecost", value); }
    }
    public float weapon4upgradecost

    {
        get { return SmartSecurity.GetFloat("weapon4upgradecost", 50 + 50 * weapon4level); }
        set { SmartSecurity.SetFloat("weapon4upgradecost", value); }
    }
    public float weapon5upgradecost

    {
        get { return SmartSecurity.GetFloat("weapon5upgradecost", 60 + 60 * weapon5level); }
        set { SmartSecurity.SetFloat("weapon5upgradecost", value); }
    }
    public float weapon6upgradecost

    {
        get { return SmartSecurity.GetFloat("weapon6upgradecost", 70 + 70 * weapon6level); }
        set { SmartSecurity.SetFloat("weapon6upgradecost", value); }
    }
    public float weapon7upgradecost

    {
        get { return SmartSecurity.GetFloat("weapon7upgradecost", 80 + 80 * weapon7level); }
        set { SmartSecurity.SetFloat("weapon7upgradecost", value); }
    }
    public float weapon8upgradecost

    {
        get { return SmartSecurity.GetFloat("weapon8upgradecost", 90 + 90 * weapon8level); }
        set { SmartSecurity.SetFloat("weapon8upgradecost", value); }
    }
    public float weapon9upgradecost

    {
        get { return SmartSecurity.GetFloat("weapon9upgradecost", 100 + 100 * weapon9level); }
        set { SmartSecurity.SetFloat("weapon9upgradecost", value); }
    }
    public float weapon10upgradecost

    {
        get { return SmartSecurity.GetFloat("weapon10upgradecost", 110 + 110 * weapon10level); }
        set { SmartSecurity.SetFloat("weapon10upgradecost", value); }
    }


   
    
     
    public int weapon0index
    {
        get { return SmartSecurity.GetInt("weapon0index", 1); }
        set { SmartSecurity.SetInt("weapon0index", value); }
    }

    public int weapon1index
    {
        get { return SmartSecurity.GetInt("weapon1index", 0); }
        set { SmartSecurity.SetInt("weapon1index", value); }
    }

    public int weapon2index
    {
        get { return SmartSecurity.GetInt("weapon2index", 0); }
        set { SmartSecurity.SetInt("weapon2index", value); }
    }

    public int weapon3index
    {
        get { return SmartSecurity.GetInt("weapon3index", 0); }
        set { SmartSecurity.SetInt("weapon3index", value); }
    }

    public int weapon4index
    {
        get { return SmartSecurity.GetInt("weapon4index", 0); }
        set { SmartSecurity.SetInt("weapon4index", value); }
    }

    public int weapon5index
    {
        get { return SmartSecurity.GetInt("weapon5index", 0); }
        set { SmartSecurity.SetInt("weapon5index", value); }
    }

    public int weapon6index
    {
        get { return SmartSecurity.GetInt("weapon6index", 0); }
        set { SmartSecurity.SetInt("weapon6index", value); }
    }

    public int weapon7index
    {
        get { return SmartSecurity.GetInt("weapon7index", 0); }
        set { SmartSecurity.SetInt("weapon7index", value); }
    }

    public int weapon8index
    {
        get { return SmartSecurity.GetInt("weapon8index", 0); }
        set { SmartSecurity.SetInt("weapon8index", value); }
    }

    public int weapon9index
    {
        get { return SmartSecurity.GetInt("weapon9index", 0); }
        set { SmartSecurity.SetInt("weapon9index", value); }
    }

    public int weapon10index
    {
        get { return SmartSecurity.GetInt("weapon10index", 0); }
        set { SmartSecurity.SetInt("weapon10index", value); }
    }

    public int myweaponindex
    {
        get { return SmartSecurity.GetInt("myweaponindex", 0); }
        set { SmartSecurity.SetInt("myweaponindex", value); }
    }

    public int guardinfoindex
    {
        get { return SmartSecurity.GetInt("guardinfoindex", 0); }
        set { SmartSecurity.SetInt("guardinfoindex", value); }
    }
    public int guardmixcount
    {
        get { return SmartSecurity.GetInt("guardmixcount", 0); }
        set { SmartSecurity.SetInt("guardmixcount", value); }
    }
    public int guard0level
    {
        get { return SmartSecurity.GetInt("guard0level", 0); }
        set { SmartSecurity.SetInt("guard0level", value); }
    }
    public int guard1level
    {
        get { return SmartSecurity.GetInt("guard1level", 0); }
        set { SmartSecurity.SetInt("guard1level", value); }
    }
    public int guard2level
    {
        get { return SmartSecurity.GetInt("guard2level", 0); }
        set { SmartSecurity.SetInt("guard2level", value); }
    }
    public int guard3level
    {
        get { return SmartSecurity.GetInt("guard3level", 0); }
        set { SmartSecurity.SetInt("guard3level", value); }
    }
    public int guard4level
    {
        get { return SmartSecurity.GetInt("guard4level", 0); }
        set { SmartSecurity.SetInt("guard4level", value); }
    }
    public int guard5level
    {
        get { return SmartSecurity.GetInt("guard5level", 0); }
        set { SmartSecurity.SetInt("guard5level", value); }
    }
    public int guard6level
    {
        get { return SmartSecurity.GetInt("guard6level", 0); }
        set { SmartSecurity.SetInt("guard6level", value); }
    }
    public int guard7level
    {
        get { return SmartSecurity.GetInt("guard7level", 0); }
        set { SmartSecurity.SetInt("guard7level", value); }
    }
    public int guard8level
    {
        get { return SmartSecurity.GetInt("guard8level", 0); }
        set { SmartSecurity.SetInt("guard8level", value); }
    }
    public int guard9level
    {
        get { return SmartSecurity.GetInt("guard9level", 0); }
        set { SmartSecurity.SetInt("guard9level", value); }
    }
    public int guard10level
    {
        get { return SmartSecurity.GetInt("guard10level", 0); }
        set { SmartSecurity.SetInt("guard10level", value); }
    }


    public float guard0power //E

    {
        get { return SmartSecurity.GetFloat("guard0power",1 * guard0level); }
        set { SmartSecurity.SetFloat("guard0power", value); }
    }
    public float guard1power //D

    {
        get { return SmartSecurity.GetFloat("guard1power", 2 * guard1level); }
        set { SmartSecurity.SetFloat("guard1power", value); }
    }
    public float guard2power //C

    {
        get { return SmartSecurity.GetFloat("guard2power", 4 * guard2level); }
        set { SmartSecurity.SetFloat("guard2power", value); }
    }
    public float guard3power //B

    {
        get { return SmartSecurity.GetFloat("guard3power", 8 * guard3level); }
        set { SmartSecurity.SetFloat("guard3power", value); }
    }
    public float guard4power //A

    {
        get { return SmartSecurity.GetFloat("guard4power", 16 * guard4level); }
        set { SmartSecurity.SetFloat("guard4power", value); }
    }
    public float guard5power //S

    {
        get { return SmartSecurity.GetFloat("guard5power", 32 * guard5level); }
        set { SmartSecurity.SetFloat("guard5power", value); }
    }
    public float guard6power //SS

    {
        get { return SmartSecurity.GetFloat("guard6power", 64 * guard6level); }
        set { SmartSecurity.SetFloat("guard6power", value); }
    }
    public float guard7power //SSS

    {
        get { return SmartSecurity.GetFloat("guard7power", 128 * guard7level); }
        set { SmartSecurity.SetFloat("guard7power", value); }
    }
    public float guard8power //R

    {
        get { return SmartSecurity.GetFloat("guard8power", 256 * guard8level); }
        set { SmartSecurity.SetFloat("guard8power", value); }
    }
    public float guard9power //U

    {
        get { return SmartSecurity.GetFloat("guard9power", 1280 * guard9level); }
        set { SmartSecurity.SetFloat("guard9power", value); }
    }
    public float guard10power //UR
 
    {
        get { return SmartSecurity.GetFloat("guard10power", 6400 * guard10level); }
        set { SmartSecurity.SetFloat("guard10power", value); }
    }

    public float guard0cryper

    {
        get { return SmartSecurity.GetFloat("guard0cryper", 50*guard0index); } 
        set { SmartSecurity.SetFloat("guard0cryper", value); } 
    }
    public float guard1cryper

    {
        get { return SmartSecurity.GetFloat("guard1cryper", 50 * guard1index); }
        set { SmartSecurity.SetFloat("guard1cryper", value); }
    }
    public float guard2cryper

    {
        get { return SmartSecurity.GetFloat("guard2cryper", 50 * guard2index); }
        set { SmartSecurity.SetFloat("guard2cryper", value); }
    }
    public float guard3cryper

    {
        get { return SmartSecurity.GetFloat("guard3cryper", 50 * guard3index); }
        set { SmartSecurity.SetFloat("guard3cryper", value); }
    }
    public float guard4cryper

    {
        get { return SmartSecurity.GetFloat("guard4cryper", 50 * guard4index); }
        set { SmartSecurity.SetFloat("guard4cryper", value); }
    }
    public float guard5cryper

    {
        get { return SmartSecurity.GetFloat("guard5cryper", 50 * guard5index); }
        set { SmartSecurity.SetFloat("guard5cryper", value); }
    }
    public float guard6cryper

    {
        get { return SmartSecurity.GetFloat("guard6cryper", 50 * guard6index); }
        set { SmartSecurity.SetFloat("guard6cryper", value); }
    }
    public float guard7cryper

    {
        get { return SmartSecurity.GetFloat("guard7cryper", 50 * guard7index); }
        set { SmartSecurity.SetFloat("guard7cryper", value); }
    }
    public float guard8cryper

    {
        get { return SmartSecurity.GetFloat("guard8cryper", 150 * guard8index); }
        set { SmartSecurity.SetFloat("guard8cryper", value); }
    }
    public float guard9cryper

    {
        get { return SmartSecurity.GetFloat("guard9cryper", 200 * guard9index); }
        set { SmartSecurity.SetFloat("guard9cryper", value); }
    }
    public float guard10cryper

    {
        get { return SmartSecurity.GetFloat("guard10cryper", 250 * guard10index); }
        set { SmartSecurity.SetFloat("guard10cryper", value); }
    }

    public float guard0upgradecost

    {
        get { return SmartSecurity.GetFloat("guard0upgradecost", 10 + 10 * guard0level); }
        set { SmartSecurity.SetFloat("guard0upgradecost", value); }
    }
    public float guard1upgradecost

    {
        get { return SmartSecurity.GetFloat("guard1upgradecost", 20 + 20 * guard1level); }
        set { SmartSecurity.SetFloat("guard1upgradecost", value); }
    }
    public float guard2upgradecost

    {
        get { return SmartSecurity.GetFloat("guard2upgradecost", 30 + 30 * guard2level); }
        set { SmartSecurity.SetFloat("guard2upgradecost", value); }
    }
    public float guard3upgradecost

    {
        get { return SmartSecurity.GetFloat("guard3upgradecost", 40 + 40 * guard3level); }
        set { SmartSecurity.SetFloat("guard3upgradecost", value); }
    }
    public float guard4upgradecost

    {
        get { return SmartSecurity.GetFloat("guard4upgradecost", 50 + 50 * guard4level); }
        set { SmartSecurity.SetFloat("guard4upgradecost", value); }
    }
    public float guard5upgradecost

    {
        get { return SmartSecurity.GetFloat("guard5upgradecost", 60 + 60 * guard5level); }
        set { SmartSecurity.SetFloat("guard5upgradecost", value); }
    }
    public float guard6upgradecost

    {
        get { return SmartSecurity.GetFloat("guard6upgradecost", 70 + 70 * guard6level); }
        set { SmartSecurity.SetFloat("guard6upgradecost", value); }
    }
    public float guard7upgradecost

    {
        get { return SmartSecurity.GetFloat("guard7upgradecost", 80 + 80 * guard7level); }
        set { SmartSecurity.SetFloat("guard7upgradecost", value); }
    }
    public float guard8upgradecost

    {
        get { return SmartSecurity.GetFloat("guard8upgradecost", 90 + 90 * guard8level); }
        set { SmartSecurity.SetFloat("guard8upgradecost", value); }
    }
    public float guard9upgradecost

    {
        get { return SmartSecurity.GetFloat("guard9upgradecost", 100 + 100 * guard9level); }
        set { SmartSecurity.SetFloat("guard9upgradecost", value); }
    }
    public float guard10upgradecost

    {
        get { return SmartSecurity.GetFloat("guard10upgradecost", 110 + 110 * guard10level); }
        set { SmartSecurity.SetFloat("guard10upgradecost", value); }
    }

    
     
     
    public int guard0index
    {
        get { return SmartSecurity.GetInt("guard0index", 1); }
        set { SmartSecurity.SetInt("guard0index", value); }
    }

    public int guard1index
    {
        get { return SmartSecurity.GetInt("guard1index", 0); }
        set { SmartSecurity.SetInt("guard1index", value); }
    }

    public int guard2index
    {
        get { return SmartSecurity.GetInt("guard2index", 0); }
        set { SmartSecurity.SetInt("guard2index", value); }
    }

    public int guard3index
    {
        get { return SmartSecurity.GetInt("guard3index", 0); }
        set { SmartSecurity.SetInt("guard3index", value); }
    }

    public int guard4index
    {
        get { return SmartSecurity.GetInt("guard4index", 0); }
        set { SmartSecurity.SetInt("guard4index", value); }
    }

    public int guard5index
    {
        get { return SmartSecurity.GetInt("guard5index", 0); }
        set { SmartSecurity.SetInt("guard5index", value); }
    }

    public int guard6index
    {
        get { return SmartSecurity.GetInt("guard6index", 0); }
        set { SmartSecurity.SetInt("guard6index", value); }
    }

    public int guard7index
    {
        get { return SmartSecurity.GetInt("guard7index", 0); }
        set { SmartSecurity.SetInt("guard7index", value); }
    }

    public int guard8index
    {
        get { return SmartSecurity.GetInt("guard8index", 0); }
        set { SmartSecurity.SetInt("guard8index", value); }
    }

    public int guard9index
    {
        get { return SmartSecurity.GetInt("guard9index", 0); }
        set { SmartSecurity.SetInt("guard9index", value); }
    }

    public int guard10index
    {
        get { return SmartSecurity.GetInt("guard10index", 0); }
        set { SmartSecurity.SetInt("guard10index", value); }
    }

    public int myguardindex
    {
        get { return SmartSecurity.GetInt("myguardindex", 0); }
        set { SmartSecurity.SetInt("myguardindex", value); }
    }

    public int helmetinfoindex
    {
        get { return SmartSecurity.GetInt("helmetinfoindex", 0); }
        set { SmartSecurity.SetInt("helmetinfoindex", value); }
    }
    public int helmetmixcount
    {
        get { return SmartSecurity.GetInt("helmetmixcount", 0); }
        set { SmartSecurity.SetInt("helmetmixcount", value); }
    }
    public int helmet0level
    {
        get { return SmartSecurity.GetInt("helmet0level", 0); }
        set { SmartSecurity.SetInt("helmet0level", value); }
    }
    public int helmet1level
    {
        get { return SmartSecurity.GetInt("helmet1level", 0); }
        set { SmartSecurity.SetInt("helmet1level", value); }
    }
    public int helmet2level
    {
        get { return SmartSecurity.GetInt("helmet2level", 0); }
        set { SmartSecurity.SetInt("helmet2level", value); }
    }
    public int helmet3level
    {
        get { return SmartSecurity.GetInt("helmet3level", 0); }
        set { SmartSecurity.SetInt("helmet3level", value); }
    }
    public int helmet4level
    {
        get { return SmartSecurity.GetInt("helmet4level", 0); }
        set { SmartSecurity.SetInt("helmet4level", value); }
    }
    public int helmet5level
    {
        get { return SmartSecurity.GetInt("helmet5level", 0); }
        set { SmartSecurity.SetInt("helmet5level", value); }
    }
    public int helmet6level
    {
        get { return SmartSecurity.GetInt("helmet6level", 0); }
        set { SmartSecurity.SetInt("helmet6level", value); }
    }
    public int helmet7level
    {
        get { return SmartSecurity.GetInt("helmet7level", 0); }
        set { SmartSecurity.SetInt("helmet7level", value); }
    }
    public int helmet8level
    {
        get { return SmartSecurity.GetInt("helmet8level", 0); }
        set { SmartSecurity.SetInt("helmet8level", value); }
    }
    public int helmet9level
    {
        get { return SmartSecurity.GetInt("helmet9level", 0); }
        set { SmartSecurity.SetInt("helmet9level", value); }
    }
    public int helmet10level
    {
        get { return SmartSecurity.GetInt("helmet10level", 0); }
        set { SmartSecurity.SetInt("helmet10level", value); }
    }


    public float helmet0power //E
    {
        get { return SmartSecurity.GetFloat("helmet0power", 1 * helmet0level); }
        set { SmartSecurity.SetFloat("helmet0power", value); }
    }
    public float helmet1power //D
         
    {
        get { return SmartSecurity.GetFloat("helmet1power", 2 * helmet1level); }
        set { SmartSecurity.SetFloat("helmet1power", value); }
    }
    public float helmet2power //C
 
    {
        get { return SmartSecurity.GetFloat("helmet2power", 4 * helmet2level); }
        set { SmartSecurity.SetFloat("helmet2power", value); }
    }
    public float helmet3power //B

    {
        get { return SmartSecurity.GetFloat("helmet3power", 8 * helmet3level); }
        set { SmartSecurity.SetFloat("helmet3power", value); }
    }
    public float helmet4power //A 

    {
        get { return SmartSecurity.GetFloat("helmet4power", 16 * helmet4level); }
        set { SmartSecurity.SetFloat("helmet4power", value); }
    }
    public float helmet5power //S

    {
        get { return SmartSecurity.GetFloat("helmet5power", 32 * helmet5level); }
        set { SmartSecurity.SetFloat("helmet5power", value); }
    }
    public float helmet6power //SS 

    {
        get { return SmartSecurity.GetFloat("helmet6power", 64 * helmet6level); }
        set { SmartSecurity.SetFloat("helmet6power", value); }
    }
    public float helmet7power //SSS

    {
        get { return SmartSecurity.GetFloat("helmet7power", 128 * helmet7level); }
        set { SmartSecurity.SetFloat("helmet7power", value); }
    }
    public float helmet8power //R

    {
        get { return SmartSecurity.GetFloat("helmet8power", 256 * helmet8level); }
        set { SmartSecurity.SetFloat("helmet8power", value); }
    }
    public float helmet9power //U

    {
        get { return SmartSecurity.GetFloat("helmet9power", 1280 * helmet9level); }
        set { SmartSecurity.SetFloat("helmet9power", value); }
    }
    public float helmet10power //UR 

    {
        get { return SmartSecurity.GetFloat("helmet10power", 6400 * helmet10level); }
        set { SmartSecurity.SetFloat("helmet10power", value); }
    }

    public float helmet0attackspeed

    {
        get { return SmartSecurity.GetFloat("helmet0attackspeed", 0.05f*helmet0index); }
        set { SmartSecurity.SetFloat("helmet0attackspeed", value); }
    }
    public float helmet1attackspeed

    {
        get { return SmartSecurity.GetFloat("helmet1attackspeed", 0.05f * helmet1index); }
        set { SmartSecurity.SetFloat("helmet1attackspeed", value); }
    }
    public float helmet2attackspeed

    {
        get { return SmartSecurity.GetFloat("helmet2attackspeed", 0.05f * helmet2index); }
        set { SmartSecurity.SetFloat("helmet2attackspeed", value); }
    }
    public float helmet3attackspeed

    {
        get { return SmartSecurity.GetFloat("helmet3attackspeed", 0.05f * helmet3index); }
        set { SmartSecurity.SetFloat("helmet3attackspeed", value); }
    }
    public float helmet4attackspeed

    {
        get { return SmartSecurity.GetFloat("helmet4attackspeed", 0.05f * helmet4index); }
        set { SmartSecurity.SetFloat("helmet4attackspeed", value); }
    }
    public float helmet5attackspeed

    {
        get { return SmartSecurity.GetFloat("helmet5attackspeed", 0.05f * helmet5index); }
        set { SmartSecurity.SetFloat("helmet5attackspeed", value); }
    }
    public float helmet6attackspeed

    {
        get { return SmartSecurity.GetFloat("helmet6attackspeed", 0.05f * helmet6index); }
        set { SmartSecurity.SetFloat("helmet6attackspeed", value); }
    }
    public float helmet7attackspeed

    {
        get { return SmartSecurity.GetFloat("helmet7attackspeed", 0.05f * helmet7index); }
        set { SmartSecurity.SetFloat("helmet7attackspeed", value); }
    }
    public float helmet8attackspeed

    {
        get { return SmartSecurity.GetFloat("helmet8attackspeed", 0.1f * helmet8index); }
        set { SmartSecurity.SetFloat("helmet8attackspeed", value); }
    }
    public float helmet9attackspeed

    {
        get { return SmartSecurity.GetFloat("helmet9attackspeed", 0.2f * helmet9index); }
        set { SmartSecurity.SetFloat("helmet9attackspeed", value); }
    }
    public float helmet10attackspeed

    {
        get { return SmartSecurity.GetFloat("helmet10attackspeed", 0.3f * helmet10index); }
        set { SmartSecurity.SetFloat("helmet10attackspeed", value); }
    }

    public float helmet0upgradecost

    {
        get { return SmartSecurity.GetFloat("helmet0upgradecost", 10 + 10 * helmet0level); }
        set { SmartSecurity.SetFloat("helmet0upgradecost", value); }
    }
    public float helmet1upgradecost

    {
        get { return SmartSecurity.GetFloat("helmet1upgradecost", 20 + 20 * helmet1level); }
        set { SmartSecurity.SetFloat("helmet1upgradecost", value); }
    }
    public float helmet2upgradecost

    {
        get { return SmartSecurity.GetFloat("helmet2upgradecost", 30 + 30 * helmet2level); }
        set { SmartSecurity.SetFloat("helmet2upgradecost", value); }
    }
    public float helmet3upgradecost

    {
        get { return SmartSecurity.GetFloat("helmet3upgradecost", 40 + 40 * helmet3level); }
        set { SmartSecurity.SetFloat("helmet3upgradecost", value); }
    }
    public float helmet4upgradecost

    {
        get { return SmartSecurity.GetFloat("helmet4upgradecost", 50 + 50 * helmet4level); }
        set { SmartSecurity.SetFloat("helmet4upgradecost", value); }
    }
    public float helmet5upgradecost

    {
        get { return SmartSecurity.GetFloat("helmet5upgradecost", 60 + 60 * helmet5level); }
        set { SmartSecurity.SetFloat("helmet5upgradecost", value); }
    }
    public float helmet6upgradecost

    {
        get { return SmartSecurity.GetFloat("helmet6upgradecost", 70 + 70 * helmet6level); }
        set { SmartSecurity.SetFloat("helmet6upgradecost", value); }
    }
    public float helmet7upgradecost

    {
        get { return SmartSecurity.GetFloat("helmet7upgradecost", 80 + 80 * helmet7level); }
        set { SmartSecurity.SetFloat("helmet7upgradecost", value); }
    }
    public float helmet8upgradecost

    {
        get { return SmartSecurity.GetFloat("helmet8upgradecost", 90 + 90 * helmet8level); }
        set { SmartSecurity.SetFloat("helmet8upgradecost", value); }
    }
    public float helmet9upgradecost

    {
        get { return SmartSecurity.GetFloat("helmet9upgradecost", 100 + 100 * helmet9level); }
        set { SmartSecurity.SetFloat("helmet9upgradecost", value); }
    }
    public float helmet10upgradecost

    {
        get { return SmartSecurity.GetFloat("helmet10upgradecost", 110 + 110 * helmet10level); }
        set { SmartSecurity.SetFloat("helmet10upgradecost", value); }
    }

   
    public int helmet0index
    {
        get { return SmartSecurity.GetInt("helmet0index", 1); }
        set { SmartSecurity.SetInt("helmet0index", value); }
    }

    public int helmet1index
    {
        get { return SmartSecurity.GetInt("helmet1index", 0); }
        set { SmartSecurity.SetInt("helmet1index", value); }
    }

    public int helmet2index
    {
        get { return SmartSecurity.GetInt("helmet2index", 0); }
        set { SmartSecurity.SetInt("helmet2index", value); }
    }

    public int helmet3index
    {
        get { return SmartSecurity.GetInt("helmet3index", 0); }
        set { SmartSecurity.SetInt("helmet3index", value); }
    }

    public int helmet4index
    {
        get { return SmartSecurity.GetInt("helmet4index", 0); }
        set { SmartSecurity.SetInt("helmet4index", value); }
    }

    public int helmet5index
    {
        get { return SmartSecurity.GetInt("helmet5index", 0); }
        set { SmartSecurity.SetInt("helmet5index", value); }
    }

    public int helmet6index
    {
        get { return SmartSecurity.GetInt("helmet6index", 0); }
        set { SmartSecurity.SetInt("helmet6index", value); }
    }

    public int helmet7index
    {
        get { return SmartSecurity.GetInt("helmet7index", 0); }
        set { SmartSecurity.SetInt("helmet7index", value); }
    }

    public int helmet8index
    {
        get { return SmartSecurity.GetInt("helmet8index", 0); }
        set { SmartSecurity.SetInt("helmet8index", value); }
    }

    public int helmet9index
    {
        get { return SmartSecurity.GetInt("helmet9index", 0); }
        set { SmartSecurity.SetInt("helmet9index", value); }
    }

    public int helmet10index
    {
        get { return SmartSecurity.GetInt("helmet10index", 0); }
        set { SmartSecurity.SetInt("helmet10index", value); }
    }

    public int myhelmetindex
    {
        get { return SmartSecurity.GetInt("myhelmetindex", 0); }
        set { SmartSecurity.SetInt("myhelmetindex", value); }
    }
    public int armorinfoindex
    {
        get { return SmartSecurity.GetInt("armorinfoindex", 0); }
        set { SmartSecurity.SetInt("armorinfoindex", value); }
    }
    public int armormixcount
    {
        get { return SmartSecurity.GetInt("armormixcount", 0); }
        set { SmartSecurity.SetInt("armormixcount", value); }
    }
    public int armor0level
    {
        get { return SmartSecurity.GetInt("armor0level", 0) ; }
        set { SmartSecurity.SetInt("armor0level", value); }
    }
    public int armor1level
    {
        get { return SmartSecurity.GetInt("armor1level", 0); }
        set { SmartSecurity.SetInt("armor1level", value); }
    }
    public int armor2level
    {
        get { return SmartSecurity.GetInt("armor2level", 0); }
        set { SmartSecurity.SetInt("armor2level", value); }
    }
    public int armor3level
    {
        get { return SmartSecurity.GetInt("armor3level", 0); }
        set { SmartSecurity.SetInt("armor3level", value); }
    }
    public int armor4level
    {
        get { return SmartSecurity.GetInt("armor4level", 0); }
        set { SmartSecurity.SetInt("armor4level", value); }
    }
    public int armor5level
    {
        get { return SmartSecurity.GetInt("armor5level", 0); }
        set { SmartSecurity.SetInt("armor5level", value); }
    }
    public int armor6level
    {
        get { return SmartSecurity.GetInt("armor6level", 0); }
        set { SmartSecurity.SetInt("armor6level", value); }
    }
    public int armor7level
    {
        get { return SmartSecurity.GetInt("armor7level", 0); }
        set { SmartSecurity.SetInt("armor7level", value); }
    }
    public int armor8level
    {
        get { return SmartSecurity.GetInt("armor8level", 0); }
        set { SmartSecurity.SetInt("armor8level", value); }
    }
    public int armor9level
    {
        get { return SmartSecurity.GetInt("armor9level", 0); }
        set { SmartSecurity.SetInt("armor9level", value); }
    }
    public int armor10level
    {
        get { return SmartSecurity.GetInt("armor10level", 0); }
        set { SmartSecurity.SetInt("armor10level", value); }
    }


    public float armor0power //E

    {
        get { return SmartSecurity.GetFloat("armor0power", 1 * armor0level); }
        set { SmartSecurity.SetFloat("armor0power", value); }
    }
    public float armor1power //D

    {
        get { return SmartSecurity.GetFloat("armor1power", 2 * armor1level); }
        set { SmartSecurity.SetFloat("armor1power", value); }
    }
    public float armor2power //C

    {
        get { return SmartSecurity.GetFloat("armor2power", 4 * armor2level); }
        set { SmartSecurity.SetFloat("armor2power", value); }
    }
    public float armor3power //B

    {
        get { return SmartSecurity.GetFloat("armor3power", 8 * armor3level); }
        set { SmartSecurity.SetFloat("armor3power", value); }
    }
    public float armor4power //A

    {
        get { return SmartSecurity.GetFloat("armor4power", 16 * armor4level); }
        set { SmartSecurity.SetFloat("armor4power", value); }
    }
    public float armor5power //S

    {
        get { return SmartSecurity.GetFloat("armor5power", 32 * armor5level); }
        set { SmartSecurity.SetFloat("armor5power", value); }
    }
    public float armor6power //SS

    {
        get { return SmartSecurity.GetFloat("armor6power", 64 * armor6level); }
        set { SmartSecurity.SetFloat("armor6power", value); }
    }
    public float armor7power //SSS

    {
        get { return SmartSecurity.GetFloat("armor7power", 128 * armor7level); }
        set { SmartSecurity.SetFloat("armor7power", value); }
    }
    public float armor8power //R

    {
        get { return SmartSecurity.GetFloat("armor8power", 256 * armor8level); }
        set { SmartSecurity.SetFloat("armor8power", value); }
    }
    public float armor9power //U

    {
        get { return SmartSecurity.GetFloat("armor9power", 1280 * armor9level); }
        set { SmartSecurity.SetFloat("armor9power", value); }
    }
    public float armor10power //UR

    {
        get { return SmartSecurity.GetFloat("armor10power", 6400 * armor10level); }
        set { SmartSecurity.SetFloat("armor10power", value); }
    }

    public float armor0backspeed
    {
        get { return SmartSecurity.GetFloat("armor0backspeed", 0.02f * armor0index); }
        set { SmartSecurity.SetFloat("armor0backspeed", value); }
    }
    public float armor1backspeed

    {
        get { return SmartSecurity.GetFloat("armor1backspeed", 0.02f*armor1index); }
        set { SmartSecurity.SetFloat("armor1backspeed", value); }
    }
    public float armor2backspeed

    {
        get { return SmartSecurity.GetFloat("armor2backspeed", 0.02f*armor2index); }
        set { SmartSecurity.SetFloat("armor2backspeed", value); }
    }
    public float armor3backspeed

    {
        get { return SmartSecurity.GetFloat("armor3backspeed", 0.02f*armor3index); }
        set { SmartSecurity.SetFloat("armor3backspeed", value); }
    }
    public float armor4backspeed

    {
        get { return SmartSecurity.GetFloat("armor4backspeed", 0.02f*armor4index); }
        set { SmartSecurity.SetFloat("armor4backspeed", value); }
    }
    public float armor5backspeed

    {
        get { return SmartSecurity.GetFloat("armor5backspeed", 0.02f*armor5index); }
        set { SmartSecurity.SetFloat("armor5backspeed", value); }
    }
    public float armor6backspeed

    {
        get { return SmartSecurity.GetFloat("armor6backspeed", 0.02f*armor6index); }
        set { SmartSecurity.SetFloat("armor6backspeed", value); }
    }
    public float armor7backspeed

    {
        get { return SmartSecurity.GetFloat("armor7backspeed", 0.02f*armor7index); }
        set { SmartSecurity.SetFloat("armor7backspeed", value); }
    }
    public float armor8backspeed

    {
        get { return SmartSecurity.GetFloat("armor8backspeed", 0.03f*armor8index); }
        set { SmartSecurity.SetFloat("armor8backspeed", value); }
    }
    public float armor9backspeed

    {
        get { return SmartSecurity.GetFloat("armor9backspeed", 0.04f*armor9index); }
        set { SmartSecurity.SetFloat("armor9backspeed", value); }
    }
    public float armor10backspeed

    {
        get { return SmartSecurity.GetFloat("armor10backspeed", 0.05f*armor10index); }
        set { SmartSecurity.SetFloat("armor10backspeed", value); }
    }

    public float armor0upgradecost

    {
        get { return SmartSecurity.GetFloat("armor0upgradecost", 10 + 10 * armor1level); }
        set { SmartSecurity.SetFloat("armor0upgradecost", value); }
    }
    public float armor1upgradecost

    {
        get { return SmartSecurity.GetFloat("armor1upgradecost", 20 + 20 * armor2level); }
        set { SmartSecurity.SetFloat("armor1upgradecost", value); }
    }
    public float armor2upgradecost

    {
        get { return SmartSecurity.GetFloat("armor2upgradecost", 30 + 30 * armor3level); }
        set { SmartSecurity.SetFloat("armor2upgradecost", value); }
    }
    public float armor3upgradecost

    {
        get { return SmartSecurity.GetFloat("armor3upgradecost", 40 + 40 * armor4level); }
        set { SmartSecurity.SetFloat("armor3upgradecost", value); }
    }
    public float armor4upgradecost

    {
        get { return SmartSecurity.GetFloat("armor4upgradecost", 50 + 50 * armor5level); }
        set { SmartSecurity.SetFloat("armor4upgradecost", value); }
    }
    public float armor5upgradecost

    {
        get { return SmartSecurity.GetFloat("armor5upgradecost", 60 + 60 * armor6level); }
        set { SmartSecurity.SetFloat("armor5upgradecost", value); }
    }
    public float armor6upgradecost

    {
        get { return SmartSecurity.GetFloat("armor6upgradecost", 70 + 70 * armor7level); }
        set { SmartSecurity.SetFloat("armor6upgradecost", value); }
    }
    public float armor7upgradecost

    {
        get { return SmartSecurity.GetFloat("armor7upgradecost", 80 + 80 * armor8level); }
        set { SmartSecurity.SetFloat("armor7upgradecost", value); }
    }
    public float armor8upgradecost

    {
        get { return SmartSecurity.GetFloat("armor8upgradecost", 90 + 90 * armor9level); }
        set { SmartSecurity.SetFloat("armor8upgradecost", value); }
    }
    public float armor9upgradecost

    {
        get { return SmartSecurity.GetFloat("armor9upgradecost", 100 + 100 * armor10level); }
        set { SmartSecurity.SetFloat("armor9upgradecost", value); }
    }
    public float armor10upgradecost

    {
        get { return SmartSecurity.GetFloat("armor10upgradecost", 110 + 110 * armor0level); }
        set { SmartSecurity.SetFloat("armor10upgradecost", value); }
    }


    public int armor0index
    {
        get { return SmartSecurity.GetInt("armor0index", 1); }
        set { SmartSecurity.SetInt("armor0index", value); }
    }

    public int armor1index
    {
        get { return SmartSecurity.GetInt("armor1index", 0); }
        set { SmartSecurity.SetInt("armor1index", value); }
    }

    public int armor2index
    {
        get { return SmartSecurity.GetInt("armor2index", 0); }
        set { SmartSecurity.SetInt("armor2index", value); }
    }

    public int armor3index
    {
        get { return SmartSecurity.GetInt("armor3index", 0); }
        set { SmartSecurity.SetInt("armor3index", value); }
    }

    public int armor4index
    {
        get { return SmartSecurity.GetInt("armor4index", 0); }
        set { SmartSecurity.SetInt("armor4index", value); }
    }

    public int armor5index
    {
        get { return SmartSecurity.GetInt("armor5index", 0); }
        set { SmartSecurity.SetInt("armor5index", value); }
    }

    public int armor6index
    {
        get { return SmartSecurity.GetInt("armor6index", 0); }
        set { SmartSecurity.SetInt("armor6index", value); }
    }

    public int armor7index
    {
        get { return SmartSecurity.GetInt("armor7index", 0); }
        set { SmartSecurity.SetInt("armor7index", value); }
    }

    public int armor8index
    {
        get { return SmartSecurity.GetInt("armor8index", 0); }
        set { SmartSecurity.SetInt("armor8index", value); }
    }

    public int armor9index
    {
        get { return SmartSecurity.GetInt("armor9index", 0); }
        set { SmartSecurity.SetInt("armor9index", value); }
    }

    public int armor10index
    {
        get { return SmartSecurity.GetInt("armor10index", 0); }
        set { SmartSecurity.SetInt("armor10index", value); }
    }
    public int myarmorindex
    {
        get { return SmartSecurity.GetInt("myarmorindex", 0); }
        set { SmartSecurity.SetInt("myarmorindex", value); }
    }
    public float armor0monsterspeed
    {
        get { return SmartSecurity.GetFloat("armor0monsterspeed", 0.001f * armor0index); }
        set { SmartSecurity.SetFloat("armor0monsterspeed", value); }
    }
    public float armor1monsterspeed
    {
        get { return SmartSecurity.GetFloat("armor0monsterspeed", 0.001f * armor1index); }
        set { SmartSecurity.SetFloat("armor0monsterspeed", value); }
    }
    public float armor2monsterspeed
    {
        get { return SmartSecurity.GetFloat("armor0monsterspeed", 0.001f * armor2index); }
        set { SmartSecurity.SetFloat("armor0monsterspeed", value); }
    }
    public float armor3monsterspeed
    {
        get { return SmartSecurity.GetFloat("armor0monsterspeed", 0.001f * armor3index); }
        set { SmartSecurity.SetFloat("armor0monsterspeed", value); }
    }
    public float armor4monsterspeed
    {
        get { return SmartSecurity.GetFloat("armor0monsterspeed", 0.001f * armor4index); }
        set { SmartSecurity.SetFloat("armor0monsterspeed", value); }
    }
    public float armor5monsterspeed
    {
        get { return SmartSecurity.GetFloat("armor0monsterspeed", 0.001f * armor5index); }
        set { SmartSecurity.SetFloat("armor0monsterspeed", value); }
    }
    public float armor6monsterspeed
    {
        get { return SmartSecurity.GetFloat("armor0monsterspeed", 0.001f * armor6index); }
        set { SmartSecurity.SetFloat("armor0monsterspeed", value); }
    }
    public float armor7monsterspeed
    {
        get { return SmartSecurity.GetFloat("armor0monsterspeed", 0.001f * armor7index); }
        set { SmartSecurity.SetFloat("armor0monsterspeed", value); }
    }
    public float armor8monsterspeed
    {
        get { return SmartSecurity.GetFloat("armor0monsterspeed", 0.0015f * armor8index); }
        set { SmartSecurity.SetFloat("armor0monsterspeed", value); }
    }
    public float armor9monsterspeed
    {
        get { return SmartSecurity.GetFloat("armor0monsterspeed", 0.002f * armor9index); }
        set { SmartSecurity.SetFloat("armor0monsterspeed", value); }
    }
    public float armor10monsterspeed
    {
        get { return SmartSecurity.GetFloat("armor0monsterspeed", 0.0025f * armor10index); }
        set { SmartSecurity.SetFloat("armor0monsterspeed", value); }
    }
    public int meetlevel
    {
        get { return SmartSecurity.GetInt("meetlevel", 0); }
        set { SmartSecurity.SetInt("meetlevel", value); }
    }

    public float meetupgraecost
    {
        get { return SmartSecurity.GetFloat("meetupgraecost", 140 + 140 * meetlevel); }
        set { SmartSecurity.SetFloat("meetupgraecost", value); }
    }

    public int meetrevolulevel
    {
        get { return SmartSecurity.GetInt("meetrevolulevel", 0); }
        set { SmartSecurity.SetInt("meetrevolulevel", value); }
    }

    public float meetrevolucost
    {
        get { return SmartSecurity.GetFloat("meetrevolucost", 2000+2000*meetrevolulevel); }
        set { SmartSecurity.SetFloat("meetrevolucost", value); }
    }

    public float meetpower

    {
        get { return SmartSecurity.GetFloat("meetpower",100 * meetlevel); }
        set { SmartSecurity.SetFloat("meetpower", value); }
    }

    public float meetrevolpower

    {
        get { return SmartSecurity.GetFloat("meetrevolpower", 1500 * meetrevolulevel); }
        set { SmartSecurity.SetFloat("meetrevolpower", value); }
    }
    public int levelweaponindex
    {
        get { return SmartSecurity.GetInt("levelweaponindex", 0); }
        set { SmartSecurity.SetInt("levelweaponindex", value); }
    }
    public int levelguardindex
    {
        get { return SmartSecurity.GetInt("levelguardindex", 0); }
        set { SmartSecurity.SetInt("levelguardindex", value); }
    }
    public int levelhelmetindex
    {
        get { return SmartSecurity.GetInt("levelhelmetindex", 0); }
        set { SmartSecurity.SetInt("levelhelmetindex", value); }
    }
    public int levelarmorindex
    {
        get { return SmartSecurity.GetInt("levelarmorindex", 0); }
        set { SmartSecurity.SetInt("levelarmorindex", value); }
    }
    public float goldupgradecost

    {
        get { return SmartSecurity.GetFloat("goldupgradecost", 10+40 * goldlevel*(1- friend0artifactlevelgolddown/100)); }
        set { SmartSecurity.SetFloat("goldupgradecost", value); }
    }

    public float goldtenupgradecost

    {
        get { return SmartSecurity.GetFloat("goldtenupgradecost", 0); }
        set { SmartSecurity.SetFloat("goldtenupgradecost", value); }
    }

    public float goldhundupgradecost

    {
        get { return SmartSecurity.GetFloat("goldhundupgradecost", 0); }
        set { SmartSecurity.SetFloat("goldhundupgradecost", value); }
    }
    public int goldlevel
    {
        get { return SmartSecurity.GetInt("goldlevel", 0); }
        set { SmartSecurity.SetInt("goldlevel", value); }
    }
    public float goldupdamage

    {
        get { return SmartSecurity.GetFloat("goldupdamage",1+17 * goldlevel); }
        set { SmartSecurity.SetFloat("goldupdamage", value); }
    }
   
  
    public float goldupcrydamage
    {
        get { return SmartSecurity.GetFloat("goldupcrydamage", 0.00001f * goldlevel); }
        set { SmartSecurity.SetFloat("goldupcrydamage", value); }
    }
  
    public float goldupcryper

    {
        get { return SmartSecurity.GetFloat("goldupcryper", 0.05f * goldlevel); }
        set { SmartSecurity.SetFloat("goldupcryper", value); }
    }

    public float goldupspeed

    {
        get { return SmartSecurity.GetFloat("goldupspeed", 0.00001f * goldlevel); }
        set { SmartSecurity.SetFloat("goldupspeed", value); }
    }
    public float goldupmosterspeed

    {
        get { return SmartSecurity.GetFloat("goldupmosterspeed", 0.00005f * goldlevel); }
        set { SmartSecurity.SetFloat("goldupmosterspeed", value); }
    }
    public float golduppowerspeed

    {
        get { return SmartSecurity.GetFloat("golduppowerspeed", 0.001f * goldlevel); }
        set { SmartSecurity.SetFloat("golduppowerspeed", value); }
    }


    public int passiveindex
    {
        get { return SmartSecurity.GetInt("passiveindex", 0); }
        set { SmartSecurity.SetInt("passiveindex", value); }
    }
    public int passiveswardlevel
    {
        get { return SmartSecurity.GetInt("passiveswardlevel", 0); }
        set { SmartSecurity.SetInt("passiveswardlevel", value); }
    }

    public float passivedamage   //공격력증가

    {
        get { return SmartSecurity.GetFloat("passivedamage", 10 * passiveswardlevel); }
        set { SmartSecurity.SetFloat("passivedamage", value); }
    }
    public float passiveservedamage //공격력증가
    {
        get { return SmartSecurity.GetFloat("passiveservedamage", 10 * passiveswardlevel); }
        set { SmartSecurity.SetFloat("passiveservedamage", value); }
    }

    public float passiveupgradecost

    {
        get { return SmartSecurity.GetFloat("passiveupgradecost", 10+10 * passiveswardlevel); }
        set { SmartSecurity.SetFloat("passiveupgradecost", value); }
    }

    public float passivetenupgradecost

    {
        get { return SmartSecurity.GetFloat("passivetenupgradecost", 0); }
        set { SmartSecurity.SetFloat("passivetenupgradecost", value); }
    }

    public int passiveguardlevel
    {
        get { return SmartSecurity.GetInt("passiveguardlevel", 0); }
        set { SmartSecurity.SetInt("passiveguardlevel", value); }
    }

    public float passiveguardcrydamage  //크리대미지증가

    {
        get { return SmartSecurity.GetFloat("passiveguardcrydamage", 0.0001f * passiveguardlevel); }
        set { SmartSecurity.SetFloat("passiveguardcrydamage", value); }
    }
    public float passiveguardservedamage  //공격력증가

    {
        get { return SmartSecurity.GetFloat("passiveguardservedamage", 10 * passiveguardlevel); }
        set { SmartSecurity.SetFloat("passiveguardservedamage", value); }
    }

    public float passiveguardupgradecost

    {
        get { return SmartSecurity.GetFloat("passiveguardupgradecost", 10+10 * passiveguardlevel); }
        set { SmartSecurity.SetFloat("passiveguardupgradecost", value); }
    }

    public float passiveguardtenupgradecost

    {
        get { return SmartSecurity.GetFloat("passiveguardtenupgradecost", 0); }
        set { SmartSecurity.SetFloat("passiveguardtenupgradecost", value); }
    }
    public int passiveringlevel //반지
    {
        get { return SmartSecurity.GetInt("passiveringlevel", 0); }
        set { SmartSecurity.SetInt("passiveringlevel", value); }
    }

    public float passiveringcryper  //크리확률증가

    {
        get { return SmartSecurity.GetFloat("passiveringcryper", 1 * passiveringlevel); }
        set { SmartSecurity.SetFloat("passiveringcryper", value); }
    }
    public float passiveringservedamage  //공격력증가
    {
        get { return SmartSecurity.GetFloat("passiveringservedamage", 10 * passiveringlevel); }
        set { SmartSecurity.SetFloat("passiveringservedamage", value); }
    }


    public float passiveringupgradecost

    {
        get { return SmartSecurity.GetFloat("passiveringupgradecost", 10+10 * passiveringlevel); }
        set { SmartSecurity.SetFloat("passiveringupgradecost", value); }
    }

    public float passiveringtenupgradecost

    {
        get { return SmartSecurity.GetFloat("passiveringtenupgradecost", 0); }
        set { SmartSecurity.SetFloat("passiveringtenupgradecost", value); }
    }
    public int passiveanvillevel //대장간 레벨
    {
        get { return SmartSecurity.GetInt("passiveanvillevel", 0); }
        set { SmartSecurity.SetInt("passiveanvillevel", value); }
    }

    public float passiveanvilswardspeed  //공격속도증가

    {
        get { return SmartSecurity.GetFloat("passiveanvilswardspeed", 0.001f * passiveanvillevel); }
        set { SmartSecurity.SetFloat("passiveanvilswardspeed", value); }
    }
    public float passiveanvilservedamage  //대미지증가

    {
        get { return SmartSecurity.GetFloat("passiveanvilservedamage", 10 * passiveanvillevel); }
        set { SmartSecurity.SetFloat("passiveanvilservedamage", value); }
    }


    public float passiveanvilupgradecost

    {
        get { return SmartSecurity.GetFloat("passiveanvilupgradecost", 10+10 * passiveanvillevel); }
        set { SmartSecurity.SetFloat("passiveanvilupgradecost", value); }
    }

    public float passiveanviltenupgradecost

    {
        get { return SmartSecurity.GetFloat("passiveanviltenupgradecost", 0); }
        set { SmartSecurity.SetFloat("passiveanviltenupgradecost", value); }
    }

    public int passiveshoelevel //신발 레벨
    {
        get { return SmartSecurity.GetInt("passiveshoelevel", 0); }
        set { SmartSecurity.SetInt("passiveshoelevel", value); }
    }

    public float passiveshoespeed
    {
        get { return SmartSecurity.GetFloat("passiveshoespeed", 0.0001f * passiveshoelevel); }
        set { SmartSecurity.SetFloat("passiveshoespeed", value); }
    }
    public float passiveshoemonsterspeed  //이동속도증가
    {
        get { return SmartSecurity.GetFloat("passiveshoemonsterspeed", 0.00005f * passiveshoelevel); }
        set { SmartSecurity.SetFloat("passiveshoemonsterspeed", value); }
    }
    public float passiveshoeservedamage //대미지증가
    {
        get { return SmartSecurity.GetFloat("passiveshoeservedamage", 10 * passiveshoelevel); }
        set { SmartSecurity.SetFloat("passiveshoeservedamage", value); }
    }

    public float passiveshoeupgradecost
    {
        get { return SmartSecurity.GetFloat("passiveshoeupgradecost", 10+10 * passiveshoelevel); }
        set { SmartSecurity.SetFloat("passiveshoeupgradecost", value); }
    }

    public float passiveshoetenupgradecost
    {
        get { return SmartSecurity.GetFloat("passiveshoetenupgradecost", 0); }
        set { SmartSecurity.SetFloat("passiveshoetenupgradecost", value); }
    }
    public int passiveluckylevel //클러버 레벨
    {
        get { return SmartSecurity.GetInt("passiveluckylevel", 0); }
        set { SmartSecurity.SetInt("passiveluckylevel", value); }
    }

    public float passiveluckygoldup //사냥골드획득량증가
    {
        get { return SmartSecurity.GetFloat("passiveluckygoldup", 0.001f * passiveluckylevel); }
        set { SmartSecurity.SetFloat("passiveluckygoldup", value); }
    }
    public float passiveluckyservedamage //대미지증가
    {
        get { return SmartSecurity.GetFloat("passiveluckyservedamage", 10 * passiveluckylevel); }
        set { SmartSecurity.SetFloat("passiveluckyservedamage", value); }
    }


    public float passiveluckyupgradecost
    {
        get { return SmartSecurity.GetFloat("passiveluckyupgradecost", 10+10 * passiveluckylevel); }
        set { SmartSecurity.SetFloat("passiveluckyupgradecost", value); }
    }

    public float passiveluckytenupgradecost
    {
        get { return SmartSecurity.GetFloat("passiveluckytenupgradecost", 0); }
        set { SmartSecurity.SetFloat("passiveluckytenupgradecost", value); }
    }
    public int passivepicklevel //곡괭이 레벨
    {
        get { return SmartSecurity.GetInt("passivepicklevel", 0); }
        set { SmartSecurity.SetInt("passivepicklevel", value); }
    }

    public float passivepickrockup //돌멩이증가(채광던전보상증가)
    {
        get { return SmartSecurity.GetFloat("passivepickrockup", 0.0005f * passivepicklevel); }
        set { SmartSecurity.SetFloat("passivepickrockup", value); }
    }
    public float passivepickservedamage //대미지증가
    {
        get { return SmartSecurity.GetFloat("passivepickservedamage", 10 * passivepicklevel); }
        set { SmartSecurity.SetFloat("passivepickservedamage", value); }
    }
    public float passivepickupgradecost
    {
        get { return SmartSecurity.GetFloat("passivepickupgradecost",10+ 10 * passivepicklevel); }
        set { SmartSecurity.SetFloat("passivepickupgradecost", value); }
    }
    public float passivepicktenupgradecost
    {
        get { return SmartSecurity.GetFloat("passivepicktenupgradecost", 0); }
        set { SmartSecurity.SetFloat("passivepicktenupgradecost", value); }
    }
    public int passivebowlevel //화살통 레벨
    {
        get { return SmartSecurity.GetInt("passivebowlevel", 0); }
        set { SmartSecurity.SetInt("passivebowlevel", value); }
    }

    public float passivebowmeetup  //음식던전보상증가
    {
        get { return SmartSecurity.GetFloat("passivebowmeetup", 0.0005f * passivebowlevel); }
        set { SmartSecurity.SetFloat("passivebowmeetup", value); }
    }
    public float passivebowservedamage //대미지증가
    {
        get { return SmartSecurity.GetFloat("passivebowservedamage", 10 * passivebowlevel); }
        set { SmartSecurity.SetFloat("passivebowservedamage", value); }
    }

    public float passivebowupgradecost
    {
        get { return SmartSecurity.GetFloat("passivebowupgradecost", 10+10 * passivebowlevel); }
        set { SmartSecurity.SetFloat("passivebowupgradecost", value); }
    }

    public float passivebowtenupgradecost
    {
        get { return SmartSecurity.GetFloat("passivebowtenupgradecost", 0); }
        set { SmartSecurity.SetFloat("passivebowtenupgradecost", value); }
    }
   
    public int friendinfoindex
    {
        get { return SmartSecurity.GetInt("friendinfoindex", 0); }
        set { SmartSecurity.SetInt("friendinfoindex", value); }
    }
    public int friend0index
    {
        get { return SmartSecurity.GetInt("friend0index", 0); }
        set { SmartSecurity.SetInt("friend0index", value); }
    }
    public int friend1index
    {
        get { return SmartSecurity.GetInt("friend1index", 0); }
        set { SmartSecurity.SetInt("friend1index", value); }
    }
    public int friend2index
    {
        get { return SmartSecurity.GetInt("friend2index", 0); }
        set { SmartSecurity.SetInt("friend2index", value); }
    }
    public int friend3index
    {
        get { return SmartSecurity.GetInt("friend3index", 0); }
        set { SmartSecurity.SetInt("friend3index", value); }
    }
    public int friend4index
    {
        get { return SmartSecurity.GetInt("friend4index", 0); }
        set { SmartSecurity.SetInt("friend4index", value); }
    }
    public int friend0artifact
    {
        get { return SmartSecurity.GetInt("friend0artifact", 0); }
        set { SmartSecurity.SetInt("friend0artifact", value); }
    }
    public int friend1artifact
    {
        get { return SmartSecurity.GetInt("friend1artifact", 0); }
        set { SmartSecurity.SetInt("friend1artifact", value); }
    }
    public int friend2artifact
    {
        get { return SmartSecurity.GetInt("friend2artifact", 0); }
        set { SmartSecurity.SetInt("friend2artifact", value); }
    }
    public int friend3artifact
    {
        get { return SmartSecurity.GetInt("friend3artifact", 0); }
        set { SmartSecurity.SetInt("friend3artifact", value); }
    }
    public int friend4artifact
    {
        get { return SmartSecurity.GetInt("friend4artifact", 0); }
        set { SmartSecurity.SetInt("friend4artifact", value); }
    }
    public int friend0level
    {
        get { return SmartSecurity.GetInt("friend0level", 0); }
        set { SmartSecurity.SetInt("friend0level", value); }
    }
    public int friend1level
    {
        get { return SmartSecurity.GetInt("friend1level", 0); }
        set { SmartSecurity.SetInt("friend1level", value); }
    }
    public int friend2level
    {
        get { return SmartSecurity.GetInt("friend2level", 0); }
        set { SmartSecurity.SetInt("friend2level", value); }
    }
    public int friend3level
    {
        get { return SmartSecurity.GetInt("friend3level", 0); }
        set { SmartSecurity.SetInt("friend3level", value); }
    }
    public int friend4level
    {
        get { return SmartSecurity.GetInt("friend4level", 0); }
        set { SmartSecurity.SetInt("friend4level", value); }
    }
    public float friend0upgradecost  //최대 100강 
    {
        get { return SmartSecurity.GetFloat("friend0upgradecost", 10 + 10 * friend0level); }
        set { SmartSecurity.SetFloat("friend0upgradecost", value); }
    }
    public float friend1upgradecost
    {
        get { return SmartSecurity.GetFloat("friend1upgradecost", 10 + 10 * friend1level); }
        set { SmartSecurity.SetFloat("friend1upgradecost", value); }
    }
    public float friend2upgradecost
    {
        get { return SmartSecurity.GetFloat("friend2upgradecost", 10 + 10 * friend2level); }
        set { SmartSecurity.SetFloat("friend2upgradecost", value); }
    }
    public float friend3upgradecost
    {
        get { return SmartSecurity.GetFloat("friend3upgradecost", 10 + 10 * friend3level); }
        set { SmartSecurity.SetFloat("friend3upgradecost", value); }
    }
    public float friend4upgradecost
    {
        get { return SmartSecurity.GetFloat("friend4upgradecost", 10 + 10 * friend4level); }
        set { SmartSecurity.SetFloat("friend4upgradecost", value); }
    }
    public int friend0dialevel   //최대 10강 
    {
        get { return SmartSecurity.GetInt("friend0dialevel", 0); }
        set { SmartSecurity.SetInt("friend0dialevel", value); }
    }
    public int friend1dialevel
    {
        get { return SmartSecurity.GetInt("friend1dialevel", 0); }
        set { SmartSecurity.SetInt("friend1dialevel", value); }
    }
    public int friend2dialevel
    {
        get { return SmartSecurity.GetInt("friend2dialevel", 0); }
        set { SmartSecurity.SetInt("friend2dialevel", value); }
    }
    public int friend3dialevel
    {
        get { return SmartSecurity.GetInt("friend3dialevel", 0); }
        set { SmartSecurity.SetInt("friend3dialevel", value); }
    }
    public int friend4dialevel
    {
        get { return SmartSecurity.GetInt("friend4dialevel", 0); }
        set { SmartSecurity.SetInt("friend4dialevel", value); }
    }
    public float friend0diaupgradecost //최대10강
    {
        get { return SmartSecurity.GetFloat("friend0diaupgradecost", 100 + 100 * friend0dialevel); }
        set { SmartSecurity.SetFloat("friend0diaupgradecost", value); }
    }
    public float friend1diaupgradecost
    {
        get { return SmartSecurity.GetFloat("friend1diaupgradecost", 100 + 100 * friend1dialevel); }
        set { SmartSecurity.SetFloat("friend1diaupgradecost", value); }
    }
    public float friend2diaupgradecost
    {
        get { return SmartSecurity.GetFloat("friend2diaupgradecost", 100 + 100 * friend2dialevel); }
        set { SmartSecurity.SetFloat("friend2diaupgradecost", value); }
    }
    public float friend3diaupgradecost
    {
        get { return SmartSecurity.GetFloat("friend3diaupgradecost", 100 + 100 * friend3dialevel); }
        set { SmartSecurity.SetFloat("friend3diaupgradecost", value); }
    }
    public float friend4diaupgradecost
    {
        get { return SmartSecurity.GetFloat("friend4diaupgradecost", 100 + 100 * friend4dialevel); }
        set { SmartSecurity.SetFloat("friend4diaupgradecost", value); }
    }
    public float friend0power   //100강 10강
    {
        get { return SmartSecurity.GetFloat("friend0power", (friend0level * 10) + (friend0dialevel * 100)); }
        set { SmartSecurity.SetFloat("friend0power", value); }
    }
    public float friend1power
    {
        get { return SmartSecurity.GetFloat("friend1power", (friend1level * 10) + (friend1dialevel * 100)); }
        set { SmartSecurity.SetFloat("friend1power", value); }
    }
    public float friend2power
    {
        get { return SmartSecurity.GetFloat("friend2power", (friend2level * 10) + (friend2dialevel * 100)); }
        set { SmartSecurity.SetFloat("friend2power", value); }
    }
    public float friend3power
    {
        get { return SmartSecurity.GetFloat("friend3power", (friend3level * 10) + (friend3dialevel * 100)); }
        set { SmartSecurity.SetFloat("friend3power", value); }
    }
    public float friend4power
    {
        get { return SmartSecurity.GetFloat("friend4power", (friend4level * 10) + (friend4dialevel * 100)); }
        set { SmartSecurity.SetFloat("friend4power", value); }
    }
    public float friend0diaup   //라운드몬스터체력감소
    {
        get { return SmartSecurity.GetFloat("friend0diaup", (friend0level * 0.04f) + (friend0dialevel * 0.1f)); }  //5퍼감소
        set { SmartSecurity.SetFloat("friend0diaup", value); }
    }
    public float friend0goldup //사냥골드증가
    {
        get { return SmartSecurity.GetFloat("friend0goldup", (friend0level * 0.09f) + (friend0dialevel * 0.1f)); }  //10퍼증가
        set { SmartSecurity.SetFloat("friend0goldup", value); }
    }
    public float friend1crydamage //치명타 공격력 증가
    {
        get { return SmartSecurity.GetFloat("friend1crydamage", (friend1level * 0.0001f) + (friend1dialevel * 0.004f)); }
        set { SmartSecurity.SetFloat("friend1crydamage", value); }
    }
    public float friend1plusupstone //사냥강화석 획득확률증가
    {
        get { return SmartSecurity.GetFloat("friend1plusupstone", (friend1level * 0.04f) + (friend1dialevel * 0.1f)); }   //5퍼증가
        set { SmartSecurity.SetFloat("friend1plusupstone", value); }
    }
    public float friend2meetbossper  //음식던전 보스 등장확률증가
    {
        get { return SmartSecurity.GetFloat("friend2meetbossper", (friend2level * 0.09f) + (friend2dialevel * 0.1f)); }  //10퍼증가
        set { SmartSecurity.SetFloat("friend2meetbossper", value); }
    }
    public float friend2rockbossper  //채광던전 보스 등장확률증가
    {
        get { return SmartSecurity.GetFloat("friend2rockbossper", (friend2level * 0.09f) + (friend2dialevel * 0.1f)); } //10퍼증가
        set { SmartSecurity.SetFloat("friend2rockbossper", value); }
    }
    public float friend3meetbossreward //음식던전 보상증가
    {
        get { return SmartSecurity.GetFloat("friend3meetbossreward", (friend3level * 0.09f) + (friend3dialevel * 0.1f)); }  //10퍼증가
        set { SmartSecurity.SetFloat("friend3meetbossreward", value); }
    }
    
    public float friend3rockbossreward //채광던전 보상증가
    {
        get { return SmartSecurity.GetFloat("friend3rockbossreward", (friend3level * 0.09f) + (friend3dialevel * 0.1f)); }  //10퍼증가
        set { SmartSecurity.SetFloat("friend3rockbossreward", value); }
    }

    public float friend4meetroundup //음식던전 라운드증가
    {
        get { return SmartSecurity.GetFloat("friend4meetroundup", (friend4dialevel * 1)); } //Max 10 round 증가
        set { SmartSecurity.SetFloat("friend4meetroundup", value); }
    }
    public float friend4meettimerup //음식던전 제한시간증가
    {
        get { return SmartSecurity.GetFloat("friend4meettimerup", friend4dialevel * 3); }  //다이아 강화 3초증가 Max 30
        set { SmartSecurity.SetFloat("friend4meettimerup", value); }
    }
 
  
    public int friend0artifactlevel  //유물강화레벨 //최대 100강
    {
        get { return SmartSecurity.GetInt("friend0artifactlevel", 0); }
        set { SmartSecurity.SetInt("friend0artifactlevel", value); }
    }
    public int friend1artifactlevel
    {
        get { return SmartSecurity.GetInt("friend1artifactlevel", 0); }
        set { SmartSecurity.SetInt("friend1artifactlevel", value); }
    }
    public int friend2artifactlevel
    {
        get { return SmartSecurity.GetInt("friend2artifactlevel", 0); }
        set { SmartSecurity.SetInt("friend2artifactlevel", value); }
    }
    public int friend3artifactlevel
    {
        get { return SmartSecurity.GetInt("friend3artifactlevel", 0); }
        set { SmartSecurity.SetInt("friend3artifactlevel", value); }
    }
    public int friend4artifactlevel
    {
        get { return SmartSecurity.GetInt("friend4artifactlevel", 0); }
        set { SmartSecurity.SetInt("friend4artifactlevel", value); }
    }

    public float friend0artifactupgradecost //유물강화비용
    {
        get { return SmartSecurity.GetFloat("friend0artifactupgradecost", 100 + 100 * friend0artifactlevel); }
        set { SmartSecurity.SetFloat("friend0artifactupgradecost", value); }
    }
    public float friend1artifactupgradecost
    {
        get { return SmartSecurity.GetFloat("friend1artifactupgradecost", 100 + 100 * friend1artifactlevel); }
        set { SmartSecurity.SetFloat("friend1artifactupgradecost", value); }
    }
    public float friend2artifactupgradecost
    {
        get { return SmartSecurity.GetFloat("friend2artifactupgradecost", 100 + 100 * friend2artifactlevel); }
        set { SmartSecurity.SetFloat("friend2artifactupgradecost", value); }
    }
    public float friend3artifactupgradecost
    {
        get { return SmartSecurity.GetFloat("friend3artifactupgradecost", 100 + 100 * friend3artifactlevel); }
        set { SmartSecurity.SetFloat("friend3artifactupgradecost", value); }
    }
    public float friend4artifactupgradecost
    {
        get { return SmartSecurity.GetFloat("friend4artifactupgradecost", 100 + 100 * friend4artifactlevel); }
        set { SmartSecurity.SetFloat("friend4artifactupgradecost", value); }
    }
    public float friend0artifactper //유물강화성공확률
    {
        get { return SmartSecurity.GetFloat("friend0artifactper", 100 - friend0artifactlevel); }
        set { SmartSecurity.SetFloat("friend0artifactper", value); }
    }
    public float friend1artifactper
    {
        get { return SmartSecurity.GetFloat("friend1artifactper", 100 - friend1artifactlevel); }
        set { SmartSecurity.SetFloat("friend1artifactper", value); }
    }
    public float friend2artifactper
    {
        get { return SmartSecurity.GetFloat("friend2artifactper", 100 - friend2artifactlevel); }
        set { SmartSecurity.SetFloat("friend2artifactper", value); }
    }
    public float friend3artifactper
    {
        get { return SmartSecurity.GetFloat("friend3artifactper", 100 - friend3artifactlevel); }
        set { SmartSecurity.SetFloat("friend3artifactper", value); }
    }
    public float friend4artifactper
    {
        get { return SmartSecurity.GetFloat("friend4artifactper", 100 - friend4artifactlevel); }
        set { SmartSecurity.SetFloat("friend4artifactper", value); }
    }
    public float friend0artifactpower //유물공격력증가
    {
        get { return SmartSecurity.GetFloat("friend0artifactpower", friend0artifactlevel * 1000); }
        set { SmartSecurity.SetFloat("friend0artifactpower", value); }
    }
    public float friend1artifactpower
    {
        get { return SmartSecurity.GetFloat("friend1artifactpower", friend1artifactlevel * 1000); }
        set { SmartSecurity.SetFloat("friend1artifactpower", value); }
    }
    public float friend2artifactpower
    {
        get { return SmartSecurity.GetFloat("friend2artifactpower", friend2artifactlevel * 1000); }
        set { SmartSecurity.SetFloat("friend2artifactpower", value); }
    }
    public float friend3artifactpower
    {
        get { return SmartSecurity.GetFloat("friend3artifactpower", friend3artifactlevel * 1000); }
        set { SmartSecurity.SetFloat("friend3artifactpower", value); }
    }
    public float friend4artifactpower
    {
        get { return SmartSecurity.GetFloat("friend4artifactpower", friend4artifactlevel * 1000); }
        set { SmartSecurity.SetFloat("friend4artifactpower", value); }
    }
    public float friend0artifactcrypower //유물크리대미지
    {
        get { return SmartSecurity.GetFloat("friend0artifactcrypower", friend0artifactlevel * 0.0004f); }
        set { SmartSecurity.SetFloat("friend0artifactcrypower", value); }
    }
    public float friend1artifactcrypower
    {
        get { return SmartSecurity.GetFloat("friend1artifactcrypower", friend1artifactlevel * 0.0004f); }
        set { SmartSecurity.SetFloat("friend1artifactcrypower", value); }
    }
    public float friend2artifactcrypower
    {
        get { return SmartSecurity.GetFloat("friend2artifactcrypower", friend2artifactlevel * 0.0004f); }
        set { SmartSecurity.SetFloat("friend2artifactcrypower", value); }
    }
    public float friend3artifactcrypower
    {
        get { return SmartSecurity.GetFloat("friend3artifactcrypower", friend3artifactlevel * 0.0004f); }
        set { SmartSecurity.SetFloat("friend3artifactcrypower", value); }
    }
    public float friend4artifactcrypower
    {
        get { return SmartSecurity.GetFloat("friend4artifactcrypower", friend4artifactlevel * 0.0004f); }
        set { SmartSecurity.SetFloat("friend4artifactcrypower", value); }
    }
    public float friend0artifactlevelgolddown //캐릭터레벨강화비용감소  5퍼감소
    {
        get { return SmartSecurity.GetFloat("friend0artifactlevelgolddown", friend0artifactlevel * 0.05f); }
        set { SmartSecurity.SetFloat("friend0artifactlevelgolddown", value); }
    }

    public float friend1artifactmonsterhpdown //스테이지보스몬스터체력감소  5퍼감소
    {
        get { return SmartSecurity.GetFloat("friend1artifactmonsterhpdown", friend1artifactlevel * 0.05f); }
        set { SmartSecurity.SetFloat("friend1artifactmonsterhpdown", value); }
    }

    public float friend2artifactcryper //크리확률증가
    {
        get { return SmartSecurity.GetFloat("friend2artifactcryper", friend2artifactlevel * 10); }
        set { SmartSecurity.SetFloat("friend2artifactcryper", value); }
    }
    public float friend3artifactbossper //음식,채광던전보상증가  10퍼증가
    {
        get { return SmartSecurity.GetFloat("friend3artifactbossper", friend3artifactlevel * 0.1f); }
        set { SmartSecurity.SetFloat("friend3artifactbossper", value); }
    }
    public float friend4artifactgoldper //골드 획득량증가   10퍼증가
    {
        get { return SmartSecurity.GetFloat("friend4artifactgoldper", friend4artifactlevel * 0.1f); }
        set { SmartSecurity.SetFloat("friend4artifactgoldper", value); }
    }

 
  
    public int meetdongeoninfoindex
    {
        get { return SmartSecurity.GetInt("meetdongeoninfoindex", 0); }
        set { SmartSecurity.SetInt("meetdongeoninfoindex", value); }
    }
    public int meetdongeon0index //던전 1층
    {
        get { return SmartSecurity.GetInt("meetdongeon0index", 0); }
        set { SmartSecurity.SetInt("meetdongeon0index", value); }
    }
    public int meetdongeon1index
    {
        get { return SmartSecurity.GetInt("meetdongeon1index", 0); }
        set { SmartSecurity.SetInt("meetdongeon1index", value); }
    }
    public int meetdongeon2index
    {
        get { return SmartSecurity.GetInt("meetdongeon2index", 0); }
        set { SmartSecurity.SetInt("meetdongeon2index", value); }
    }
    public int meetdongeon3index
    {
        get { return SmartSecurity.GetInt("meetdongeon3index", 0); }
        set { SmartSecurity.SetInt("meetdongeon3index", value); }
    }
    public int meetdongeon4index
    {
        get { return SmartSecurity.GetInt("meetdongeon4index", 0); }
        set { SmartSecurity.SetInt("meetdongeon4index", value); }
    }
    public int meetdongeon5index
    {
        get { return SmartSecurity.GetInt("meetdongeon5index", 0); }
        set { SmartSecurity.SetInt("meetdongeon5index", value); }
    }
    public int meetdongeon6index
    {
        get { return SmartSecurity.GetInt("meetdongeon6index", 0); }
        set { SmartSecurity.SetInt("meetdongeon6index", value); }
    }
    public int meetdongeon7index
    {
        get { return SmartSecurity.GetInt("meetdongeon7index", 0); }
        set { SmartSecurity.SetInt("meetdongeon7index", value); }
    }
    public int meetdongeon8index
    {
        get { return SmartSecurity.GetInt("meetdongeon8index", 0); }
        set { SmartSecurity.SetInt("meetdongeon8index", value); }
    }
    public int meetdongeon9index
    {
        get { return SmartSecurity.GetInt("meetdongeon9index", 0); }
        set { SmartSecurity.SetInt("meetdongeon9index", value); }
    }
    public int meetdongeon10index
    {
        get { return SmartSecurity.GetInt("meetdongeon10index", 0); }
        set { SmartSecurity.SetInt("meetdongeon10index", value); }
    }
    public int meetdongeon0reward //일반몬스터
    {
        get { return SmartSecurity.GetInt("meetdongeon0reward", 10 * (1 +(int) (friend3meetbossreward+ friend3artifactbossper+passivebowmeetup / 100))); }
        set { SmartSecurity.SetInt("meetdongeon0reward", value); }
    }
    public int meetdongeon1reward
    {
        get { return SmartSecurity.GetInt("meetdongeon1reward", 20 * (1 + (int) (friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100))); }
        set { SmartSecurity.SetInt("meetdongeon1reward", value); }
    }
    public int meetdongeon2reward
    {
        get { return SmartSecurity.GetInt("meetdongeon2reward", 40 * (1 + (int) (friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100))); }
        set { SmartSecurity.SetInt("meetdongeon2reward", value); }
    }
    public int meetdongeon3reward
    {
        get { return SmartSecurity.GetInt("meetdongeon3reward", 80 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100))); }
        set { SmartSecurity.SetInt("meetdongeon3reward", value); }
    }
    public int meetdongeon4reward
    {
        get { return SmartSecurity.GetInt("meetdongeon4reward", 160 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100))); }
        set { SmartSecurity.SetInt("meetdongeon4reward", value); }
    }
    public int meetdongeon5reward
    {
        get { return SmartSecurity.GetInt("meetdongeon5reward", 320 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100))); }
        set { SmartSecurity.SetInt("meetdongeon5reward", value); }
    }
    public int meetdongeon6reward
    {
        get { return SmartSecurity.GetInt("meetdongeon6reward", 640 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100))); }
        set { SmartSecurity.SetInt("meetdongeon6reward", value); }
    }
    public int meetdongeon7reward
    {
        get { return SmartSecurity.GetInt("meetdongeon7reward", 1280 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100))); }
        set { SmartSecurity.SetInt("meetdongeon7reward", value); }
    }
    public int meetdongeon8reward
    {
        get { return SmartSecurity.GetInt("meetdongeon8reward", 2560 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100))); }
        set { SmartSecurity.SetInt("meetdongeon8reward", value); }
    }
    public int meetdongeon9reward
    {
        get { return SmartSecurity.GetInt("meetdongeon9reward", 5120 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100))); }
        set { SmartSecurity.SetInt("meetdongeon9reward", value); }
    }
    public int meetdongeon10reward
    {
        get { return SmartSecurity.GetInt("meetdongeon10reward", 10240 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100))); }
        set { SmartSecurity.SetInt("meetdongeon10reward", value); }
    }
    public int meetdongeon0bossreward   //보스몬스터
    {
        get { return SmartSecurity.GetInt("meetdongeon0bossreward", 20 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100))); }
        set { SmartSecurity.SetInt("meetdongeon0bossreward", value); }
    }
    public int meetdongeon1bossreward   
    {
        get { return SmartSecurity.GetInt("meetdongeon1bossreward", 40 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100))); }
        set { SmartSecurity.SetInt("meetdongeon1bossreward", value); }
    }
    public int meetdongeon2bossreward
    {
        get { return SmartSecurity.GetInt("meetdongeon2bossreward", 80 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100))); }
        set { SmartSecurity.SetInt("meetdongeon2bossreward", value); }
    }
    public int meetdongeon3bossreward
    {
        get { return SmartSecurity.GetInt("meetdongeon3bossreward", 160 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100))); }
        set { SmartSecurity.SetInt("meetdongeon3bossreward", value); }
    }
    public int meetdongeon4bossreward
    {
        get { return SmartSecurity.GetInt("meetdongeon4bossreward", 320 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100))); }
        set { SmartSecurity.SetInt("meetdongeon4bossreward", value); }
    }

    public int meetdongeon5bossreward
    {
        get { return SmartSecurity.GetInt("meetdongeon5bossreward", 640 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100))); }
        set { SmartSecurity.SetInt("meetdongeon5bossreward", value); }
    }
    public int meetdongeon6bossreward
    {
        get { return SmartSecurity.GetInt("meetdongeon6bossreward", 1280 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100))); }
        set { SmartSecurity.SetInt("meetdongeon6bossreward", value); }
    }
    public int meetdongeon7bossreward
    {
        get { return SmartSecurity.GetInt("meetdongeon7bossreward", 2560 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100))); }
        set { SmartSecurity.SetInt("meetdongeon7bossreward", value); }
    }
    public int meetdongeon8bossreward
    {
        get { return SmartSecurity.GetInt("meetdongeon8bossreward", 5120 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100))); }
        set { SmartSecurity.SetInt("meetdongeon8bossreward", value); }
    }
    public int meetdongeon9bossreward
    {
        get { return SmartSecurity.GetInt("meetdongeon9bossreward", 10240 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100))); }
        set { SmartSecurity.SetInt("meetdongeon9bossreward", value); }
    }
    public int meetdongeon10bossreward
    {
        get { return SmartSecurity.GetInt("meetdongeon10bossreward", 20480 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100))); }
        set { SmartSecurity.SetInt("meetdongeon10bossreward", value); }
    }
    public float meetrewardper
    {
        get { return SmartSecurity.GetFloat("meetrewardper", friend3meetbossreward+ passivebowmeetup); }
        set { SmartSecurity.SetFloat("meetrewardper", value); }
    }

    public int meetdongeonlevel
    {
        get { return SmartSecurity.GetInt("meetdongeonlevel", 0); }
        set { SmartSecurity.SetInt("meetdongeonlevel", value); }
    }
    public double meetdongeon0basicmonsterHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon0basicmonsterHp", (100).ToString())); }
        set { SmartSecurity.SetString("meetdongeon0basicmonsterHp", value.ToString()); }
    }
    public double meetdongeon1basicmonsterHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon1basicmonsterHp", (895* meetdongeon0plusHp).ToString())); }
        set { SmartSecurity.SetString("meetdongeon1basicmonsterHp", value.ToString()); }
    }
    public double meetdongeon2basicmonsterHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon2basicmonsterHp", (895*meetdongeon0plusHp* meetdongeon1plusHp).ToString())); }
        set { SmartSecurity.SetString("meetdongeon2basicmonsterHp", value.ToString()); }
    }
    public double meetdongeon3basicmonsterHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon3basicmonsterHp", (895 * meetdongeon0plusHp * meetdongeon1plusHp * meetdongeon2plusHp).ToString())); }
        set { SmartSecurity.SetString("meetdongeon3basicmonsterHp", value.ToString()); }
    }
    public double meetdongeon4basicmonsterHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon4basicmonsterHp", (895 * meetdongeon0plusHp * meetdongeon1plusHp * meetdongeon2plusHp * meetdongeon3plusHp).ToString())); }
        set { SmartSecurity.SetString("meetdongeon4basicmonsterHp", value.ToString()); }
    }
    public double meetdongeon5basicmonsterHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon5basicmonsterHp", (895 * meetdongeon0plusHp * meetdongeon1plusHp * meetdongeon2plusHp * meetdongeon3plusHp * meetdongeon4plusHp).ToString())); }
        set { SmartSecurity.SetString("meetdongeon5basicmonsterHp", value.ToString()); }
    }
    public double meetdongeon6basicmonsterHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon6basicmonsterHp", (895 * meetdongeon0plusHp * meetdongeon1plusHp * meetdongeon2plusHp * meetdongeon3plusHp * meetdongeon4plusHp * meetdongeon5plusHp).ToString())); }
        set { SmartSecurity.SetString("meetdongeon6basicmonsterHp", value.ToString()); }
    }
    public double meetdongeon7basicmonsterHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon7basicmonsterHp", (895 * meetdongeon0plusHp * meetdongeon1plusHp * meetdongeon2plusHp * meetdongeon3plusHp * meetdongeon4plusHp * meetdongeon5plusHp * meetdongeon6plusHp).ToString())); }
        set { SmartSecurity.SetString("meetdongeon7basicmonsterHp", value.ToString()); }
    }
    public double meetdongeon8basicmonsterHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon8basicmonsterHp", (895 * meetdongeon0plusHp * meetdongeon1plusHp * meetdongeon2plusHp * meetdongeon3plusHp * meetdongeon4plusHp * meetdongeon5plusHp * meetdongeon6plusHp * meetdongeon7plusHp).ToString())); }
        set { SmartSecurity.SetString("meetdongeon8basicmonsterHp", value.ToString()); }
    }
    public double meetdongeon9basicmonsterHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon9basicmonsterHp", (895 * meetdongeon0plusHp * meetdongeon1plusHp * meetdongeon2plusHp * meetdongeon3plusHp * meetdongeon4plusHp * meetdongeon5plusHp * meetdongeon6plusHp * meetdongeon7plusHp * meetdongeon8plusHp).ToString())); }
        set { SmartSecurity.SetString("meetdongeon9basicmonsterHp", value.ToString()); }
    }
    public double meetdongeon10basicmonsterHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon10basicmonsterHp", (895 * meetdongeon0plusHp * meetdongeon1plusHp * meetdongeon2plusHp * meetdongeon3plusHp * meetdongeon4plusHp * meetdongeon5plusHp * meetdongeon6plusHp * meetdongeon7plusHp * meetdongeon8plusHp * meetdongeon9plusHp).ToString())); }
        set { SmartSecurity.SetString("meetdongeon10basicmonsterHp", value.ToString()); }
    }

    public double meetdongeon0bossmonsterHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon0bossmonsterHp", (100).ToString())); }
        set { SmartSecurity.SetString("meetdongeon0bossmonsterHp", value.ToString()); }
    }
    public double meetdongeon1bossmonsterHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon1bossmonsterHp", (895*meetdongeon0plusHp).ToString())); }
        set { SmartSecurity.SetString("meetdongeon1bossmonsterHp", value.ToString()); }
    }
    public double meetdongeon2bossmonsterHp

    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon2bossmonsterHp", (895 * meetdongeon0plusHp * meetdongeon1plusHp).ToString())); }
        set { SmartSecurity.SetString("meetdongeon2bossmonsterHp", value.ToString()); }
    }
    public double meetdongeon3bossmonsterHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon3bossmonsterHp", (895 * meetdongeon0plusHp * meetdongeon1plusHp * meetdongeon2plusHp).ToString())); }
        set { SmartSecurity.SetString("meetdongeon3bossmonsterHp", value.ToString()); }
    }
    public double meetdongeon4bossmonsterHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon4bossmonsterHp", (895 * meetdongeon0plusHp * meetdongeon1plusHp * meetdongeon2plusHp * meetdongeon3plusHp).ToString())); }
        set { SmartSecurity.SetString("meetdongeon4bossmonsterHp", value.ToString()); }
    }
    public double meetdongeon5bossmonsterHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon5bossmonsterHp", (895 * meetdongeon0plusHp * meetdongeon1plusHp * meetdongeon2plusHp * meetdongeon3plusHp * meetdongeon4plusHp).ToString())); }
        set { SmartSecurity.SetString("meetdongeon5bossmonsterHp", value.ToString()); }
    }
    public double meetdongeon6bossmonsterHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon6bossmonsterHp", (895 * meetdongeon0plusHp * meetdongeon1plusHp * meetdongeon2plusHp * meetdongeon3plusHp * meetdongeon4plusHp * meetdongeon5plusHp).ToString())); }
        set { SmartSecurity.SetString("meetdongeon6bossmonsterHp", value.ToString()); }
    }
    public double meetdongeon7bossmonsterHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon7bossmonsterHp", (895 * meetdongeon0plusHp * meetdongeon1plusHp * meetdongeon2plusHp * meetdongeon3plusHp * meetdongeon4plusHp * meetdongeon5plusHp * meetdongeon6plusHp).ToString())); }
        set { SmartSecurity.SetString("meetdongeon7bossmonsterHp", value.ToString()); }
    }
    public double meetdongeon8bossmonsterHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon8bossmonsterHp", (895 * meetdongeon0plusHp * meetdongeon1plusHp * meetdongeon2plusHp * meetdongeon3plusHp * meetdongeon4plusHp * meetdongeon5plusHp * meetdongeon6plusHp * meetdongeon7plusHp).ToString())); }
        set { SmartSecurity.SetString("meetdongeon8bossmonsterHp", value.ToString()); }
    }
    public double meetdongeon9bossmonsterHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon9bossmonsterHp", (895 * meetdongeon0plusHp * meetdongeon1plusHp * meetdongeon2plusHp * meetdongeon3plusHp * meetdongeon4plusHp * meetdongeon5plusHp * meetdongeon6plusHp * meetdongeon7plusHp * meetdongeon8plusHp).ToString())); }
        set { SmartSecurity.SetString("meetdongeon9bossmonsterHp", value.ToString()); }
    }
    public double meetdongeon10bossmonsterHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon10bossmonsterHp", (895 * meetdongeon0plusHp * meetdongeon1plusHp * meetdongeon2plusHp * meetdongeon3plusHp * meetdongeon4plusHp * meetdongeon5plusHp * meetdongeon6plusHp * meetdongeon7plusHp * meetdongeon8plusHp * meetdongeon9plusHp).ToString())); }
        set { SmartSecurity.SetString("meetdongeon10bossmonsterHp", value.ToString()); }
    }
    public double meetdongeon0plusHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon0plusHp", (100000000000).ToString())); }
        set { SmartSecurity.SetString("meetdongeon0plusHp", value.ToString()); }
    }
    public double meetdongeon1plusHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon1plusHp", (1000000000000).ToString())); }
        set { SmartSecurity.SetString("meetdongeon1plusHp", value.ToString()); }
    }
    public double meetdongeon2plusHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon2plusHp", (1000000000000).ToString())); }
        set { SmartSecurity.SetString("meetdongeon2plusHp", value.ToString()); }
    }
    public double meetdongeon3plusHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon3plusHp", (1000000000000).ToString())); }
        set { SmartSecurity.SetString("meetdongeon3plusHp", value.ToString()); }
    }
    public double meetdongeon4plusHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon4plusHp", (1000000000000).ToString())); }
        set { SmartSecurity.SetString("meetdongeon4plusHp", value.ToString()); }
    }
    public double meetdongeon5plusHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon5plusHp", (1000000000000).ToString())); }
        set { SmartSecurity.SetString("meetdongeon5plusHp", value.ToString()); }
    }
    public double meetdongeon6plusHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon6plusHp", (1000000000000).ToString())); }
        set { SmartSecurity.SetString("meetdongeon6plusHp", value.ToString()); }
    }
    public double meetdongeon7plusHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon7plusHp", (1000000000000).ToString())); }
        set { SmartSecurity.SetString("meetdongeon7plusHp", value.ToString()); }
    }
    public double meetdongeon8plusHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon8plusHp", (1000000000000).ToString())); }
        set { SmartSecurity.SetString("meetdongeon8plusHp", value.ToString()); }
    }
    public double meetdongeon9plusHp
    {
        get { return double.Parse(SmartSecurity.GetString("meetdongeon9plusHp", (1000000000000).ToString())); }
        set { SmartSecurity.SetString("meetdongeon9plusHp", value.ToString()); }
    }

    public int meetrewardpapago
    {
        get { return SmartSecurity.GetInt("meetrewardpapago", 0); }
        set { SmartSecurity.SetInt("meetrewardpapago", value); }
    }
    public int meetreward0toppapago
    {
        get { return SmartSecurity.GetInt("meetreward0toppapago", 0); }
        set { SmartSecurity.SetInt("meetreward0toppapago", value); }
    }
    public int meetreward1toppapago
    {
        get { return SmartSecurity.GetInt("meetrewardtoppapago", 0); }
        set { SmartSecurity.SetInt("meetrewardtoppapago", value); }
    }
    public int meetreward2toppapago
    {
        get { return SmartSecurity.GetInt("meetrewardtoppapago", 0); }
        set { SmartSecurity.SetInt("meetrewardtoppapago", value); }
    }
    public int meetreward3toppapago
    {
        get { return SmartSecurity.GetInt("meetrewardtoppapago", 0); }
        set { SmartSecurity.SetInt("meetrewardtoppapago", value); }
    }
    public int meetreward4toppapago
    {
        get { return SmartSecurity.GetInt("meetrewardtoppapago", 0); }
        set { SmartSecurity.SetInt("meetrewardtoppapago", value); }
    }
    public int meetreward5toppapago
    {
        get { return SmartSecurity.GetInt("meetrewardtoppapago", 0); }
        set { SmartSecurity.SetInt("meetrewardtoppapago", value); }
    }
    public int meetreward6toppapago
    {
        get { return SmartSecurity.GetInt("meetrewardtoppapago", 0); }
        set { SmartSecurity.SetInt("meetrewardtoppapago", value); }
    }
    public int meetreward7toppapago
    {
        get { return SmartSecurity.GetInt("meetrewardtoppapago", 0); }
        set { SmartSecurity.SetInt("meetrewardtoppapago", value); }
    }
    public int meetreward8toppapago
    {
        get { return SmartSecurity.GetInt("meetrewardtoppapago", 0); }
        set { SmartSecurity.SetInt("meetrewardtoppapago", value); }
    }
    public int meetreward9toppapago
    {
        get { return SmartSecurity.GetInt("meetrewardtoppapago", 0); }
        set { SmartSecurity.SetInt("meetrewardtoppapago", value); }
    }
    public int meetreward10toppapago
    {
        get { return SmartSecurity.GetInt("meetrewardtoppapago", 0); }
        set { SmartSecurity.SetInt("meetrewardtoppapago", value); }
    }

    public string[] meetdongeonflow = new string[11];

    
    public Sprite[] weaponimagelist = new Sprite[11];
    public Sprite[] guardimagelist = new Sprite[11];
    public Sprite[] helmetimagelist = new Sprite[11];
    public Sprite[] Armorimagelist = new Sprite[11];
    public Sprite[] armorimagearml = new Sprite[11];
    public Sprite[] armorimagearmr = new Sprite[11];
    public Sprite[] armorimagefinger = new Sprite[11];
    public Sprite[] armorimageforearml = new Sprite[11];
    public Sprite[] armorimageforearmr = new Sprite[11];
    public Sprite[] armorimagehandl = new Sprite[11];
    public Sprite[] armorimagehandr = new Sprite[11];
    public Sprite[] armorimagelegl = new Sprite[11];
    public Sprite[] armorimagelegr = new Sprite[11];
    public Sprite[] armorimagepelvis = new Sprite[11];
    public Sprite[] armorimageshinl = new Sprite[11];
    public Sprite[] armorimageshinr = new Sprite[11];
    public Sprite[] armorimagesleever = new Sprite[11];
    public void meetstatesetting()
    {
        meetdongeon0reward = 10 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100));
        meetdongeon1reward = 20 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100));
        meetdongeon2reward = 40 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100));
        meetdongeon3reward = 80 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100));
        meetdongeon4reward = 160 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100));
        meetdongeon5reward = 320 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100));
        meetdongeon6reward = 640 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100));
        meetdongeon7reward = 1280 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100));
        meetdongeon8reward = 2560 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100));
        meetdongeon9reward = 5120 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100));
        meetdongeon10reward = 10240 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100));
        meetdongeon0bossreward = 20 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100));
        meetdongeon1bossreward = 40 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100));
        meetdongeon2bossreward = 80 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100));
        meetdongeon3bossreward = 160 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100));
        meetdongeon4bossreward = 320 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100));
        meetdongeon5bossreward = 640 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100));
        meetdongeon6bossreward = 1280 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100));
        meetdongeon7bossreward = 2560 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100));
        meetdongeon8bossreward = 5120 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100));
        meetdongeon9bossreward = 10240 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100));
        meetdongeon10bossreward = 20480 * (1 + (int)(friend3meetbossreward + friend3artifactbossper + passivebowmeetup / 100));



    }
    public int miningticket
    {
        get { return SmartSecurity.GetInt("miningticket", 0); }
        set { SmartSecurity.SetInt("miningticket", value); }
    }
    public int mininginfoindex  
    {
        get { return SmartSecurity.GetInt("mininginfoindex", 0); }
        set { SmartSecurity.SetInt("mininginfoindex", value); }
    }
    public int mining0index // 
    {
        get { return SmartSecurity.GetInt("mining0index", 0); }
        set { SmartSecurity.SetInt("mining0index", value); }
    }
    public int mining1index //
    {
        get { return SmartSecurity.GetInt("mining1index", 0); }
        set { SmartSecurity.SetInt("mining1index", value); }
    }
    public int mining2index //
    {
        get { return SmartSecurity.GetInt("mining2index", 0); }
        set { SmartSecurity.SetInt("mining2index", value); }
    }
    public int mining3index //
    {
        get { return SmartSecurity.GetInt("mining3index", 0); }
        set { SmartSecurity.SetInt("mining3index", value); }
    }
    public int mining0level //물
    {
        get { return SmartSecurity.GetInt("mining0level", 0); }
        set { SmartSecurity.SetInt("mining0level", value); }
    }
    public int mining1level //불
    {
        get { return SmartSecurity.GetInt("mining1level", 0); }
        set { SmartSecurity.SetInt("mining1level", value); }
    }
    public int mining2level //땅
    {
        get { return SmartSecurity.GetInt("mining2level", 0); }
        set { SmartSecurity.SetInt("mining2level", value); }
    }
    public int mining3level //빛
    {
        get { return SmartSecurity.GetInt("mining3level", 0); }
        set { SmartSecurity.SetInt("mining3level", value); }
    }
    public int mining0clear //물
    {
        get { return SmartSecurity.GetInt("mining0clear", 0); }
        set { SmartSecurity.SetInt("mining0clear", value); }
    }
    public int mining1clear //불
    {
        get { return SmartSecurity.GetInt("mining1clear", 0); }
        set { SmartSecurity.SetInt("mining1clear", value); }
    }
    public int mining2clear //땅
    {
        get { return SmartSecurity.GetInt("mining2clear", 0); }
        set { SmartSecurity.SetInt("mining2clear", value); }
    }
    public int mining3clear //빛
    {
        get { return SmartSecurity.GetInt("mining3clear", 0); }
        set { SmartSecurity.SetInt("mining3clear", value); }
    }
    public int miningindex //빛
    {
        get { return SmartSecurity.GetInt("miningindex", 0); }
        set { SmartSecurity.SetInt("miningindex", value); }
    }
    public int mining0reward
    {
        get { return SmartSecurity.GetInt("mining0reward", 1000 + 1000 *mining0level); }
        set { SmartSecurity.SetInt("mining0reward", value); }
    }
    public int beforemining0reward
    {
        get { return SmartSecurity.GetInt("beforemining0reward", 1000 + 1000 * (mining0level-1)); }
        set { SmartSecurity.SetInt("beforemining0reward", value); }
    }
    public int mining0diareward
    {
        get { return SmartSecurity.GetInt("mining0diareward", 200); }
        set { SmartSecurity.SetInt("mining0diareward", value); }
    }
    public int mining1reward
    {
        get { return SmartSecurity.GetInt("mining1reward", 500+300*mining1level); }
        set { SmartSecurity.SetInt("mining1reward", value); }
    }
    public int beforemining1reward
    {
        get { return SmartSecurity.GetInt("beforemining1reward", 500 + 300 * (mining1level-1)); }
        set { SmartSecurity.SetInt("beforemining1reward", value); }
    }
    public int mining1diareward
    {
        get { return SmartSecurity.GetInt("mining1diareward", 200 ); }
        set { SmartSecurity.SetInt("mining1diareward", value); }
    }
    public int mining2reward
    {
        get { return SmartSecurity.GetInt("mining2reward", 1000+500*mining2level); }
        set { SmartSecurity.SetInt("mining2reward", value); }
    }
    public int beforemining2reward
    {
        get { return SmartSecurity.GetInt("beforemining2reward", 1000 + 500 * (mining2level-1)); }
        set { SmartSecurity.SetInt("beforemining2reward", value); }
    }
    public int mining2diareward
    {
        get { return SmartSecurity.GetInt("mining2diareward", 200 ); }
        set { SmartSecurity.SetInt("mining2diareward", value); }
    }
    public int mining3reward
    {
        get { return SmartSecurity.GetInt("mining3reward", 100+100*mining3level); }
        set { SmartSecurity.SetInt("mining3reward", value); }
    }
    public int beforemining3reward
    {
        get { return SmartSecurity.GetInt("beforemining3reward", 100 + 100 * (mining3level-1)); }
        set { SmartSecurity.SetInt("beforemining3reward", value); }
    }
    public int mining3diareward
    {
        get { return SmartSecurity.GetInt("mining3diareward", 200); }
        set { SmartSecurity.SetInt("mining3diareward", value); }
    }
    public int miningzero0reward
    {
        get { return SmartSecurity.GetInt("miningzero0reward", 0); }
        set { SmartSecurity.SetInt("miningzero0reward", value); }
    }
    public int miningzero0diareward
    {
        get { return SmartSecurity.GetInt("miningzero0diareward", 0); }
        set { SmartSecurity.SetInt("miningzero0diareward", value); }
    }
    public int miningzero1reward
    {
        get { return SmartSecurity.GetInt("miningzero1reward", 0); }
        set { SmartSecurity.SetInt("miningzero1reward", value); }
    }
    public int miningzero1diareward
    {
        get { return SmartSecurity.GetInt("miningzero1diareward", 0); }
        set { SmartSecurity.SetInt("miningzero1diareward", value); }
    }
    public int miningzero2reward
    {
        get { return SmartSecurity.GetInt("miningzero2reward", 0); }
        set { SmartSecurity.SetInt("miningzero2reward", value); }
    }
    public int miningzero2diareward
    {
        get { return SmartSecurity.GetInt("miningzero2diareward", 0); }
        set { SmartSecurity.SetInt("miningzero2diareward", value); }
    }
    public int miningzero3reward
    {
        get { return SmartSecurity.GetInt("miningzero3reward", 0); }
        set { SmartSecurity.SetInt("miningzero3reward", value); }
    }
    public int miningzero3diareward
    {
        get { return SmartSecurity.GetInt("miningzero3diareward", 0); }
        set { SmartSecurity.SetInt("miningzero3diareward", value); }
    }
    public int miningplus0reward
    {
        get { return SmartSecurity.GetInt("miningplus0reward", 0); }
        set { SmartSecurity.SetInt("miningplus0reward", value); }
    }
    public int miningplus0diareward
    {
        get { return SmartSecurity.GetInt("miningplus0diareward", 0); }
        set { SmartSecurity.SetInt("miningplus0diareward", value); }
    }
    public int miningplus1reward
    {
        get { return SmartSecurity.GetInt("miningplus1reward", 0); }
        set { SmartSecurity.SetInt("miningplus1reward", value); }
    }
    public int miningplus1diareward
    {
        get { return SmartSecurity.GetInt("miningplus1diareward", 0); }
        set { SmartSecurity.SetInt("miningplus1diareward", value); }
    }
    public int miningplus2reward
    {
        get { return SmartSecurity.GetInt("miningplus2reward", 0); }
        set { SmartSecurity.SetInt("miningplus2reward", value); }
    }
    public int miningplus2diareward
    {
        get { return SmartSecurity.GetInt("miningplus2diareward", 0); }
        set { SmartSecurity.SetInt("miningplus2diareward", value); }
    }
    public int miningplus3reward
    {
        get { return SmartSecurity.GetInt("miningplus3reward", 0); }
        set { SmartSecurity.SetInt("miningplus3reward", value); }
    }
    public int miningplus3diareward
    {
        get { return SmartSecurity.GetInt("miningplus3diareward", 0); }
        set { SmartSecurity.SetInt("miningplus3diareward", value); }
    }
    public double miningdongeon0bossmonsterHp //물
    {
        get { return double.Parse(SmartSecurity.GetString("miningdongeon0bossmonsterHp", (80* miningdongeon0plusHp).ToString())); }
        set { SmartSecurity.SetString("miningdongeon0bossmonsterHp", value.ToString()); }
    }
    public double miningdongeon1bossmonsterHp //불
    {
        get { return double.Parse(SmartSecurity.GetString("miningdongeon1bossmonsterHp", (80 * miningdongeon1plusHp).ToString())); }
        set { SmartSecurity.SetString("miningdongeon1bossmonsterHp", value.ToString()); }
    }
    public double miningdongeon2bossmonsterHp //땅
    {
        get { return double.Parse(SmartSecurity.GetString("miningdongeon2bossmonsterHp", (80 * miningdongeon2plusHp).ToString())); }
        set { SmartSecurity.SetString("miningdongeon2bossmonsterHp", value.ToString()); }
    }
    public double miningdongeon3bossmonsterHp //빛
    {
        get { return double.Parse(SmartSecurity.GetString("miningdongeon3bossmonsterHp", (80 * miningdongeon3plusHp).ToString())); }
        set { SmartSecurity.SetString("miningdongeon3bossmonsterHp", value.ToString()); }
    }
    public double miningdongeon0plusHp //물
    {
        get { return double.Parse(SmartSecurity.GetString("miningdongeon0plusHp", math.pow(5, (double)mining0level).ToString())); }
        set { SmartSecurity.SetString("miningdongeon0plusHp", value.ToString()); }
    }
    public double miningdongeon1plusHp //불
    {
        get { return double.Parse(SmartSecurity.GetString("miningdongeon1plusHp", math.pow(5, (double)mining1level).ToString())); }
        set { SmartSecurity.SetString("miningdongeon1plusHp", value.ToString()); }
    }
    public double miningdongeon2plusHp //땅
    {
        get { return double.Parse(SmartSecurity.GetString("miningdongeon2plusHp", math.pow(5, (double)mining2level).ToString())); }
        set { SmartSecurity.SetString("miningdongeon2plusHp", value.ToString()); }
    }
    public double miningdongeon3plusHp //빛
    {
        get { return double.Parse(SmartSecurity.GetString("miningdongeon3plusHp", math.pow(5, (double)mining3level).ToString())); }
        set { SmartSecurity.SetString("miningdongeon3plusHp", value.ToString()); }
    }
    public int miningcooltime
    {
        get { return SmartSecurity.GetInt("miningcooltime", 20); }
        set { SmartSecurity.SetInt("miningcooltime", value); }
    }
    public void miningcooltimesetting()
    {
        miningcooltime = 20;
    }
    public int miningdie0index
    {
        get { return SmartSecurity.GetInt("miningdie0index", 0); }
        set { SmartSecurity.SetInt("miningdie0index", value); }
    }
    public int mininground0index
    {
        get { return SmartSecurity.GetInt("mininground0index", 0); }
        set { SmartSecurity.SetInt("mininground0index", value); }
    }
    public int miningmaxround0index
    {
        get { return SmartSecurity.GetInt("miningmaxround0index", 1); }
        set { SmartSecurity.SetInt("miningmaxround0index", value); }
    }
    public int miningdie1index
    {
        get { return SmartSecurity.GetInt("miningdie1index", 0); }
        set { SmartSecurity.SetInt("miningdie1index", value); }
    }
    public int miningdie2index
    {
        get { return SmartSecurity.GetInt("miningdie2index", 0); }
        set { SmartSecurity.SetInt("miningdie2index", value); }
    }
    public int miningdie3index
    {
        get { return SmartSecurity.GetInt("miningdie3index", 0); }
        set { SmartSecurity.SetInt("miningdie3index", value); }
    }
    public int mining0rewardpapago
    {
        get { return SmartSecurity.GetInt("mining0rewardpapago", 0); }
        set { SmartSecurity.SetInt("mining0rewardpapago", value); }
    }
    public int mining1rewardpapago
    {
        get { return SmartSecurity.GetInt("mining1rewardpapago", 0); }
        set { SmartSecurity.SetInt("mining1rewardpapago", value); }
    }
    public int mining2rewardpapago
    {
        get { return SmartSecurity.GetInt("mining2rewardpapago", 0); }
        set { SmartSecurity.SetInt("mining2rewardpapago", value); }
    }
    public int mining3rewardpapago
    {
        get { return SmartSecurity.GetInt("mining3rewardpapago", 0); }
        set { SmartSecurity.SetInt("mining3rewardpapago", value); }
    }
    public int mining0diarewardpapago
    {
        get { return SmartSecurity.GetInt("mining0diarewardpapago", 0); }
        set { SmartSecurity.SetInt("mining0diarewardpapago", value); }
    }
    public int mining1diarewardpapago
    {
        get { return SmartSecurity.GetInt("mining1diarewardpapago", 0); }
        set { SmartSecurity.SetInt("mining1diarewardpapago", value); }
    }
    public int mining2diarewardpapago
    {
        get { return SmartSecurity.GetInt("mining2diarewardpapago", 0); }
        set { SmartSecurity.SetInt("mining2diarewardpapago", value); }
    }
    public int mining3diarewardpapago
    {
        get { return SmartSecurity.GetInt("mining3diarewardpapago", 0); }
        set { SmartSecurity.SetInt("mining3diarewardpapago", value); }
    }
    public int ambleminfoindex
    {
        get { return SmartSecurity.GetInt("ambleminfoindex", 0); }
        set { SmartSecurity.SetInt("ambleminfoindex", value); }
    }
    public int amblem0index
    {
        get { return SmartSecurity.GetInt("amblem0index", 0); }
        set { SmartSecurity.SetInt("amblem0index", value); }
    }
    public int amblem1index
    {
        get { return SmartSecurity.GetInt("amblem1index", 0); }
        set { SmartSecurity.SetInt("amblem1index", value); }
    }
    public int amblem2index
    {
        get { return SmartSecurity.GetInt("amblem2index", 0); }
        set { SmartSecurity.SetInt("amblem2index", value); }
    }
    public int amblem3index
    {
        get { return SmartSecurity.GetInt("amblem3index", 0); }
        set { SmartSecurity.SetInt("amblem3index", value); }
    }
    public float amblem0damage //공격력 1%증가 
    {
        get { return SmartSecurity.GetFloat("amblem0damage", 100 * amblem0index); }
        set { SmartSecurity.SetFloat("amblem0damage", value); }
    }
    public float amblem1damage //공격력 2%증가
    {
        get { return SmartSecurity.GetFloat("amblem1damage", 200 * amblem1index); }
        set { SmartSecurity.SetFloat("amblem1damage", value); }
    }
    public float amblem1crydamage //치명타 1%증가
    {
        get { return SmartSecurity.GetFloat("amblem1crydamage", 0.01f * amblem1index); }
        set { SmartSecurity.SetFloat("amblem1crydamage", value); }
    }
    public float amblem2damage //공격력 3%증가
    {
        get { return SmartSecurity.GetFloat("amblem2damage", 300 * amblem2index); }
        set { SmartSecurity.SetFloat("amblem2damage", value); }
    }
    public float amblem2crydamage //치명타 2%증가
    {
        get { return SmartSecurity.GetFloat("amblem2crydamage", 0.02f * amblem2index); }
        set { SmartSecurity.SetFloat("amblem2crydamage", value); }
    }
    public float amblem3damage //공격력 5%증가
    {
        get { return SmartSecurity.GetFloat("amblem3damage", 400 * amblem3index); }
        set { SmartSecurity.SetFloat("amblem3damage", value); }
    }
    public float amblem3crydamage //치명타 5%증가
    {
        get { return SmartSecurity.GetFloat("amblem3crydamage", 0.05f * amblem3index); }
        set { SmartSecurity.SetFloat("amblem3crydamage", value); }
    }
    public int rockcooltime
    {
        get { return SmartSecurity.GetInt("rockcooltime", 10); }
        set { SmartSecurity.SetInt("rockcooltime", value); }
    }
    public void rockcooltimesetting()
    {
        rockcooltime = 10;
    }
    public int rockticket
    {
        get { return SmartSecurity.GetInt("rockticket", 0); }
        set { SmartSecurity.SetInt("rockticket", value); }
    }
    public int rockinfoindex
    {
        get { return SmartSecurity.GetInt("rockinfoindex", 0); }
        set { SmartSecurity.SetInt("rockinfoindex", value); }
    }
    public int rock0stage
    {
        get { return SmartSecurity.GetInt("rock0stage", 0); }
        set { SmartSecurity.SetInt("rock0stage", value); }
    }
    public int rock1stage
    {
        get { return SmartSecurity.GetInt("rock1stage", 0); }
        set { SmartSecurity.SetInt("rock1stage", value); }
    }
    public int rock2stage
    {
        get { return SmartSecurity.GetInt("rock2stage", 0); }
        set { SmartSecurity.SetInt("rock2stage", value); }
    }
    public int rock3stage
    {
        get { return SmartSecurity.GetInt("rock3stage", 0); }
        set { SmartSecurity.SetInt("rock3stage", value); }
    }
    public int rock4stage
    {
        get { return SmartSecurity.GetInt("rock4stage", 0); }
        set { SmartSecurity.SetInt("rock4stage", value); }
    }
    public float rockrespwanbossper
    {
        get { return SmartSecurity.GetFloat("rockrespwanbossper", 5+friend2rockbossper); }
        set { SmartSecurity.SetFloat("rockrespwanbossper", value); }
    }
    public double rockdongeon0basicmonsterhp 
    {
        get { return double.Parse(SmartSecurity.GetString("rockdongeon0basicmonsterhp", (10 + (1*math.pow(1.5f, rock0stage))).ToString())); }
        set { SmartSecurity.SetString("rockdongeon0basicmonsterhp", value.ToString()); }
    }
    public double rockdongeon1basicmonsterhp
    {
        get { return double.Parse(SmartSecurity.GetString("rockdongeon1basicmonsterhp", (150 + (1 * math.pow(1.6f, rock1stage))).ToString())); }
        set { SmartSecurity.SetString("rockdongeon1basicmonsterhp", value.ToString()); }
    }
    public double rockdongeon2basicmonsterhp
    {
        get { return double.Parse(SmartSecurity.GetString("rockdongeon2basicmonsterhp", (150 + (1 * math.pow(1.7f, rock2stage))).ToString())); }
        set { SmartSecurity.SetString("rockdongeon2basicmonsterhp", value.ToString()); }
    }
    public double rockdongeon3basicmonsterhp
    {
        get { return double.Parse(SmartSecurity.GetString("rockdongeon3basicmonsterhp", (150 + (1 * math.pow(1.8f, rock3stage))).ToString())); }
        set { SmartSecurity.SetString("rockdongeon3basicmonsterhp", value.ToString()); }
    }
    public double rockdongeon4basicmonsterhp
    {
        get { return double.Parse(SmartSecurity.GetString("rockdongeon4basicmonsterhp", (150 + (1 * math.pow(1.9f, rock4stage))).ToString())); }
        set { SmartSecurity.SetString("rockdongeon4basicmonsterhp", value.ToString()); }
    }
    public double rockdongeon0bossmonsterhp
    {
        get { return double.Parse(SmartSecurity.GetString("rockdongeon0bossmonsterhp", (150 + (10 * math.pow(1.5f, rock0stage))).ToString())); }
        set { SmartSecurity.SetString("rockdongeon0bossmonsterhp", value.ToString()); }
    }
    public double rockdongeon1bossmonsterhp
    {
        get { return double.Parse(SmartSecurity.GetString("rockdongeon1bossmonsterhp", (150 + (1 * math.pow(1.6f, rock1stage))).ToString())); }
        set { SmartSecurity.SetString("rockdongeon1bossmonsterhp", value.ToString()); }
    }
    public double rockdongeon2bossmonsterhp
    {
        get { return double.Parse(SmartSecurity.GetString("rockdongeon2bossmonsterhp", (150 + (1 * math.pow(1.7f, rock2stage))).ToString())); }
        set { SmartSecurity.SetString("rockdongeon2bossmonsterhp", value.ToString()); }
    }
    public double rockdongeon3bossmonsterhp
    {
        get { return double.Parse(SmartSecurity.GetString("rockdongeon3bossmonsterhp", (150 + (1 * math.pow(1.8f, rock3stage))).ToString())); }
        set { SmartSecurity.SetString("rockdongeon3bossmonsterhp", value.ToString()); }
    }
    public double rockdongeon4bossmonsterhp
    {
        get { return double.Parse(SmartSecurity.GetString("rockdongeon4bossmonsterhp", (150 + (1 * math.pow(1.9f, rock4stage))).ToString())); }
        set { SmartSecurity.SetString("rockdongeon4bossmonsterhp", value.ToString()); }
    }
   
    public int rock0rewardpapago
    {
        get { return SmartSecurity.GetInt("rock0rewardpapago", 10+10*rock0stage*(int)(1+ friend3rockbossreward + friend3artifactbossper+passivepickrockup / 100)); }
        set { SmartSecurity.SetInt("rock0rewardpapago", value); }
    }
    public int rock1rewardpapago
    {
        get { return SmartSecurity.GetInt("rock1rewardpapago", 20+20 * rock1stage * (int)(1 + friend3rockbossreward + friend3artifactbossper + passivepickrockup / 100)); }
        set { SmartSecurity.SetInt("rock1rewardpapago", value); }
    }
    public int rock2rewardpapago
    {
        get { return SmartSecurity.GetInt("rock2rewardpapago", 30+30 * rock2stage * (int)(1 + friend3rockbossreward + friend3artifactbossper + passivepickrockup / 100)); }
        set { SmartSecurity.SetInt("rock2rewardpapago", value); }
    }
    public int rock3rewardpapago
    {
        get { return SmartSecurity.GetInt("rock3rewardpapago", 40+40 * rock3stage * (int)(1 + friend3rockbossreward + friend3artifactbossper + passivepickrockup / 100)); }
        set { SmartSecurity.SetInt("rock3rewardpapago", value); }
    }
    public int rock4rewardpapago
    {
        get { return SmartSecurity.GetInt("rock4rewardpapago", 50+50 * rock4stage * (int)(1 + friend3rockbossreward + friend3artifactbossper + passivepickrockup / 100)); }
        set { SmartSecurity.SetInt("rock4rewardpapago", value); }
    }
    public int rock0bossrewardpapago
    {
        get { return SmartSecurity.GetInt("rock0bossrewardpapago", 20+20 * rock0stage * (int)(1 + friend3rockbossreward + friend3artifactbossper + passivepickrockup / 100)); }
        set { SmartSecurity.SetInt("rock0bossrewardpapago", value); }
    }
    public int rock1bossrewardpapago
    {
        get { return SmartSecurity.GetInt("rock1bossrewardpapago", 40+40 * rock1stage * (int)(1 + friend3rockbossreward + friend3artifactbossper + passivepickrockup / 100)); }
        set { SmartSecurity.SetInt("rock1bossrewardpapago", value); }
    }
    public int rock2bossrewardpapago
    {
        get { return SmartSecurity.GetInt("rock2bossrewardpapago", 60+60 * rock2stage * (int)(1 + friend3rockbossreward + friend3artifactbossper + passivepickrockup / 100)); }
        set { SmartSecurity.SetInt("rock2bossrewardpapago", value); }
    }
    public int rock3bossrewardpapago
    {
        get { return SmartSecurity.GetInt("rock3bossrewardpapago", 80+80 * rock3stage * (int)(1 + friend3rockbossreward + friend3artifactbossper + passivepickrockup / 100)); }
        set { SmartSecurity.SetInt("rock3bossrewardpapago", value); }
    }
    public int rock4bossrewardpapago
    {
        get { return SmartSecurity.GetInt("rock4bossrewardpapago", 100+100 * rock4stage * (int)(1 + friend3rockbossreward + friend3artifactbossper + passivepickrockup / 100)); }
        set { SmartSecurity.SetInt("rock4bossrewardpapago", value); }
    }
    public void rockstatesetting()
    {
        rock0rewardpapago = 10+10 * rock0stage * (int)(1 + friend3rockbossreward + friend3artifactbossper / 100);
        rock1rewardpapago = 20+20 * rock1stage * (int)(1 + friend3rockbossreward + friend3artifactbossper / 100);
        rock2rewardpapago = 30+30 * rock2stage * (int)(1 + friend3rockbossreward + friend3artifactbossper / 100);
        rock3rewardpapago = 40+40 * rock3stage * (int)(1 + friend3rockbossreward + friend3artifactbossper / 100);
        rock4rewardpapago = 50+50 * rock4stage * (int)(1 + friend3rockbossreward + friend3artifactbossper / 100);
        rock0bossrewardpapago = 20+20 * rock0stage * (int)(1 + friend3rockbossreward + friend3artifactbossper / 100);
        rock1bossrewardpapago = 40+40 * rock1stage * (int)(1 + friend3rockbossreward + friend3artifactbossper / 100);
        rock2bossrewardpapago = 60+60 * rock2stage * (int)(1 + friend3rockbossreward + friend3artifactbossper / 100);
        rock3bossrewardpapago = 80+80 * rock3stage * (int)(1 + friend3rockbossreward + friend3artifactbossper / 100);
        rock4bossrewardpapago = 100+100 * rock4stage * (int)(1 + friend3rockbossreward + friend3artifactbossper / 100);
    }
    public int rock0rewardtoppapago
    {
        get { return SmartSecurity.GetInt("rock0rewardtoppapago", 0); }
        set { SmartSecurity.SetInt("rock0rewardtoppapago", value); }
    }
    public int rock1rewardtoppapago
    {
        get { return SmartSecurity.GetInt("rock1rewardtoppapago", 0); }
        set { SmartSecurity.SetInt("rock1rewardtoppapago", value); }
    }
    public int rock2rewardtoppapago
    {
        get { return SmartSecurity.GetInt("rock2rewardtoppapago", 0); }
        set { SmartSecurity.SetInt("rock2rewardtoppapago", value); }
    }
    public int rock3rewardtoppapago
    {
        get { return SmartSecurity.GetInt("rock3rewardtoppapago", 0); }
        set { SmartSecurity.SetInt("rock3rewardtoppapago", value); }
    }
    public int rock4rewardtoppapago
    {
        get { return SmartSecurity.GetInt("rock4rewardtoppapago", 0); }
        set { SmartSecurity.SetInt("rock4rewardtoppapago", value); }
    }
    public int rock0papago
    {
        get { return SmartSecurity.GetInt("rock0papago", 0); }
        set { SmartSecurity.SetInt("rock0papago", value); }
    }
    public int rock1papago
    {
        get { return SmartSecurity.GetInt("rock1papago", 0); }
        set { SmartSecurity.SetInt("rock1papago", value); }
    }
    public int rock2papago
    {
        get { return SmartSecurity.GetInt("rock2papago", 0); }
        set { SmartSecurity.SetInt("rock2papago", value); }
    }
    public int rock3papago
    {
        get { return SmartSecurity.GetInt("rock3papago", 0); }
        set { SmartSecurity.SetInt("rock3papago", value); }
    }
    public int rock4papago
    {
        get { return SmartSecurity.GetInt("rock4papago", 0); }
        set { SmartSecurity.SetInt("rock4papago", value); }
    }
    public int daymissionindex
    {
        get { return SmartSecurity.GetInt("daymissionindex", 0); }
        set { SmartSecurity.SetInt("daymissionindex", value); }
    }
    public int daymission0index //일일보상
    {
        get { return SmartSecurity.GetInt("daymission0index", 0); }
        set { SmartSecurity.SetInt("daymission0index", value); }
    }
    public int daymission1index //캐릭터레벨강화
    {
        get { return SmartSecurity.GetInt("daymission1index", 0); }
        set { SmartSecurity.SetInt("daymission1index", value); }
    }
    public int daymission2index //장비강화
    {
        get { return SmartSecurity.GetInt("daymission2index", 0); }
        set { SmartSecurity.SetInt("daymission2index", value); }
    }
    public int daymission3index //음식던전
    {
        get { return SmartSecurity.GetInt("daymission3index", 0); }
        set { SmartSecurity.SetInt("daymission3index", value); }
    }
    public int daymission4index //채광던전
    {
        get { return SmartSecurity.GetInt("daymission4index", 0); }
        set { SmartSecurity.SetInt("daymission4index", value); }
    }
    public int daymission5index //수호자던전
    {
        get { return SmartSecurity.GetInt("daymission5index", 0); }
        set { SmartSecurity.SetInt("daymission5index", value); }
    }
    public int daymissionpanel0index
    {
        get { return SmartSecurity.GetInt("daymissionpanel0index", 0); }
        set { SmartSecurity.SetInt("daymissionpanel0index", value); }
    }
    public int daymissionpanel1index
    {
        get { return SmartSecurity.GetInt("daymissionpanel1index", 0); }
        set { SmartSecurity.SetInt("daymissionpanel1index", value); }
    }
    public int daymissionpanel2index
    {
        get { return SmartSecurity.GetInt("daymissionpanel2index", 0); }
        set { SmartSecurity.SetInt("daymissionpanel2index", value); }
    }
    public int daymissionpanel3index
    {
        get { return SmartSecurity.GetInt("daymissionpanel3index", 0); }
        set { SmartSecurity.SetInt("daymissionpanel3index", value); }
    }
    public int daymissionpanel4index
    {
        get { return SmartSecurity.GetInt("daymissionpanel4index", 0); }
        set { SmartSecurity.SetInt("daymissionpanel4index", value); }
    }
    public int daymissionpanel5index
    {
        get { return SmartSecurity.GetInt("daymissionpanel5index", 0); }
        set { SmartSecurity.SetInt("daymissionpanel5index", value); }
    }
    public int daymissionbtn0index
    {
        get { return SmartSecurity.GetInt("daymissionbtn0index", 0); }
        set { SmartSecurity.SetInt("daymissionbtn0index", value); }
    }
    public int daymissionbtn1index
    {
        get { return SmartSecurity.GetInt("daymissionbtn1index", 0); }
        set { SmartSecurity.SetInt("daymissionbtn1index", value); }
    }
    public int daymissionbtn2index
    {
        get { return SmartSecurity.GetInt("daymissionbtn2index", 0); }
        set { SmartSecurity.SetInt("daymissionbtn2index", value); }
    }
    public int daymissionbtn3index
    {
        get { return SmartSecurity.GetInt("daymissionbtn3index", 0); }
        set { SmartSecurity.SetInt("daymissionbtn3index", value); }
    }
    public int daymissionbtn4index
    {
        get { return SmartSecurity.GetInt("daymissionbtn4index", 0); }
        set { SmartSecurity.SetInt("daymissionbtn4index", value); }
    }
    public int daymissionbtn5index
    {
        get { return SmartSecurity.GetInt("daymissionbtn5index", 0); }
        set { SmartSecurity.SetInt("daymissionbtn5index", value); }
    }
    public int repeatmissionindex
    {
        get { return SmartSecurity.GetInt("repeatmissionindex", 0); }
        set { SmartSecurity.SetInt("repeatmissionindex", value); }
    }
    public int repeatmission0index  //스테이지 진행
    {
        get { return SmartSecurity.GetInt("repeatmission0index", 0); }
        set { SmartSecurity.SetInt("repeatmission0index", value); }
    }
    public int repeatmission1index //몬스터처치
    {
        get { return SmartSecurity.GetInt("repeatmission1index", 0); }
        set { SmartSecurity.SetInt("repeatmission1index", value); }
    }
    public int repeatmission2index  //보스몬스터처치
    {
        get { return SmartSecurity.GetInt("repeatmission2index", 0); }
        set { SmartSecurity.SetInt("repeatmission2index", value); }
    }
    public int repeatmission3index  //장비뽑기
    {
        get { return SmartSecurity.GetInt("repeatmission3index", 0); }
        set { SmartSecurity.SetInt("repeatmission3index", value); }
    }
    public int repeatmission4index  //장비강화
    {
        get { return SmartSecurity.GetInt("repeatmission4index", 0); }
        set { SmartSecurity.SetInt("repeatmission4index", value); }
    }
    public int repeatmission11index  //장비합성
    {
        get { return SmartSecurity.GetInt("repeatmission11index", 0); }
        set { SmartSecurity.SetInt("repeatmission11index", value); }
    }
    public int repeatmission5index //캐릭터레벨강화
    {
        get { return SmartSecurity.GetInt("repeatmission5index", 0); }
        set { SmartSecurity.SetInt("repeatmission5index", value); }
    }
    public int repeatmission6index  //던전입장
    {
        get { return SmartSecurity.GetInt("repeatmission6index", 0); }
        set { SmartSecurity.SetInt("repeatmission6index", value); }
    }
    public int repeatmission7index //캐릭터기술강화
    {
        get { return SmartSecurity.GetInt("repeatmission7index", 0); }
        set { SmartSecurity.SetInt("repeatmission7index", value); }
    }
    public int repeatmission8index //동료소환
    {
        get { return SmartSecurity.GetInt("repeatmission8index", 0); }
        set { SmartSecurity.SetInt("repeatmission8index", value); }
    }
    public int repeatmission9index //동료강화
    {
        get { return SmartSecurity.GetInt("repeatmission9index", 0); }
        set { SmartSecurity.SetInt("repeatmission9index", value); }
    }
    public int repeatmission10index //유물강화
    {
        get { return SmartSecurity.GetInt("repeatmission10index", 0); }
        set { SmartSecurity.SetInt("repeatmission10index", value); }
    }
   
    public int repeatmission0reward
    {
        get { return SmartSecurity.GetInt("repeatmission0reward",  10 ); }
        set { SmartSecurity.SetInt("repeatmission0reward", value); }
    }
    public int repeatmission1reward
    {
        get { return SmartSecurity.GetInt("repeatmission1reward", 10); }
        set { SmartSecurity.SetInt("repeatmission1reward", value); }
    }
    public int repeatmission2reward
    {
        get { return SmartSecurity.GetInt("repeatmission2reward", 10); }
        set { SmartSecurity.SetInt("repeatmission2reward", value); }
    }
    public int repeatmission3reward
    {
        get { return SmartSecurity.GetInt("repeatmission3reward", 10 ); }
        set { SmartSecurity.SetInt("repeatmission3reward", value); }
    }
    public int repeatmission4reward
    {
        get { return SmartSecurity.GetInt("repeatmission4reward", 10 ); }
        set { SmartSecurity.SetInt("repeatmission4reward", value); }
    }
    public int repeatmission11reward
    {
        get { return SmartSecurity.GetInt("repeatmission11reward", 10); }
        set { SmartSecurity.SetInt("repeatmission11reward", value); }
    }
    public int repeatmission5reward
    {
        get { return SmartSecurity.GetInt("repeatmission5reward", 10); }
        set { SmartSecurity.SetInt("repeatmission5reward", value); }
    }
    public int repeatmission6reward
    {
        get { return SmartSecurity.GetInt("repeatmission6reward", 10 ); }
        set { SmartSecurity.SetInt("repeatmission6reward", value); }
    }
    public int repeatmission7reward
    {
        get { return SmartSecurity.GetInt("repeatmission7reward", 10); }
        set { SmartSecurity.SetInt("repeatmission7reward", value); }
    }
    public int repeatmission8reward
    {
        get { return SmartSecurity.GetInt("repeatmission8reward", 100); }
        set { SmartSecurity.SetInt("repeatmission8reward", value); }
    }
    public int repeatmission9reward
    {
        get { return SmartSecurity.GetInt("repeatmission9reward", 10); }
        set { SmartSecurity.SetInt("repeatmission9reward", value); }
    }
    public int repeatmission10reward
    {
        get { return SmartSecurity.GetInt("repeatmission10reward", 10 ); }
        set { SmartSecurity.SetInt("repeatmission10reward", value); }
    }
    public int repeatmission0maxindex 
    {
        get { return SmartSecurity.GetInt("repeatmission0maxindex", 10 ); }
        set { SmartSecurity.SetInt("repeatmission0maxindex", value); }
    }
    public int repeatmission1maxindex
    {
        get { return SmartSecurity.GetInt("repeatmission1maxindex", 10); }
        set { SmartSecurity.SetInt("repeatmission1maxindex", value); }
    }
    public int repeatmission2maxindex
    {
        get { return SmartSecurity.GetInt("repeatmission2maxindex", 10); }
        set { SmartSecurity.SetInt("repeatmission2maxindex", value); }
    }
    public int repeatmission3maxindex
    {
        get { return SmartSecurity.GetInt("repeatmission3maxindex", 10 ); }
        set { SmartSecurity.SetInt("repeatmission3maxindex", value); }
    }
    public int repeatmission4maxindex
    {
        get { return SmartSecurity.GetInt("repeatmission4maxindex", 10 ); }
        set { SmartSecurity.SetInt("repeatmission4maxindex", value); }
    }
    public int repeatmission11maxindex
    {
        get { return SmartSecurity.GetInt("repeatmission11maxindex", 10); }
        set { SmartSecurity.SetInt("repeatmission11maxindex", value); }
    }
    public int repeatmission5maxindex
    {
        get { return SmartSecurity.GetInt("repeatmission5maxindex", 10 ); }
        set { SmartSecurity.SetInt("repeatmission5maxindex", value); }
    }
    public int repeatmission6maxindex
    {
        get { return SmartSecurity.GetInt("repeatmission6maxindex", 10 ); }
        set { SmartSecurity.SetInt("repeatmission6maxindex", value); }
    }
    public int repeatmission7maxindex
    {
        get { return SmartSecurity.GetInt("repeatmission7maxindex", 10 ); }
        set { SmartSecurity.SetInt("repeatmission7maxindex", value); }
    }
    public int repeatmission8maxindex
    {
        get { return SmartSecurity.GetInt("repeatmission8maxindex", 1); }
        set { SmartSecurity.SetInt("repeatmission8maxindex", value); }
    }
    public int repeatmission9maxindex
    {
        get { return SmartSecurity.GetInt("repeatmission9maxindex", 10); }
        set { SmartSecurity.SetInt("repeatmission9maxindex", value); }
    }
    public int repeatmission10maxindex
    {
        get { return SmartSecurity.GetInt("repeatmission10maxindex", 10 ); }
        set { SmartSecurity.SetInt("repeatmission10maxindex", value); }
    }
    public int goldstoredialevel
    {
        get { return SmartSecurity.GetInt("goldstoredialevel", 0); }
        set { SmartSecurity.SetInt("goldstoredialevel", value); }
    }
    public int goldstoremeetlevel
    {
        get { return SmartSecurity.GetInt("goldstoremeetlevel", 0); }
        set { SmartSecurity.SetInt("goldstoremeetlevel", value); }
    }
    public int goldstorerocklevel
    {
        get { return SmartSecurity.GetInt("goldstorerocklevel", 0); }
        set { SmartSecurity.SetInt("goldstorerocklevel", value); }
    }
    public float goldstorediapapago
    {
        get { return SmartSecurity.GetFloat("goldstorediapapago",math.pow(2, (float)goldstoredialevel+1)); }
        set { SmartSecurity.SetFloat("goldstorediapapago", value); }
    }
    public float goldstoremeetpapago
    {
        get { return SmartSecurity.GetFloat("goldstoremeetpapago", math.pow(2, (float)goldstoremeetlevel + 1)); }
        set { SmartSecurity.SetFloat("goldstoremeetpapago", value); }
    }
    public float goldstorerockpapago
    {
        get { return SmartSecurity.GetFloat("goldstorerockpapago", math.pow(2, (float)goldstorerocklevel + 1)); }
        set { SmartSecurity.SetFloat("goldstorerockpapago", value); }
    }
    public int goldstorediareward
    {
        get { return SmartSecurity.GetInt("goldstorediareward", 10+ goldstorediaplusreward); }
        set { SmartSecurity.SetInt("goldstorediareward", value); }
    }
    public int goldstoremeetreward
    {
        get { return SmartSecurity.GetInt("goldstoremeetreward", 50+50* goldstoremeetplusreward); }
        set { SmartSecurity.SetInt("goldstoremeetreward", value); }
    }
    public int goldstorerockreward
    {
        get { return SmartSecurity.GetInt("goldstorerockreward", 100+100* goldstorerockplusreward); }
        set { SmartSecurity.SetInt("goldstorerockreward", value); }
    }
    public int goldstorediaplusreward
    {
        get { return SmartSecurity.GetInt("goldstorediaplusreward", goldstoredialevel / 10); }
        set { SmartSecurity.SetInt("goldstorediaplusreward", value); }
    }
    public int goldstoremeetplusreward
    {
        get { return SmartSecurity.GetInt("goldstoremeetplusreward", goldstoremeetlevel / 10); }
        set { SmartSecurity.SetInt("goldstoremeetplusreward", value); }
    }
    public int goldstorerockplusreward
    {
        get { return SmartSecurity.GetInt("goldstorerockplusreward", goldstorerocklevel / 10); }
        set { SmartSecurity.SetInt("goldstorerockplusreward", value); }
    }
    public int firstgameindex  //첫유저 1
    {
        get { return SmartSecurity.GetInt("firstgameindex", 0); }
        set { SmartSecurity.SetInt("firstgameindex", value); }
    }
    public int rewardrestindex  //휴식보상체크
    {
        get { return SmartSecurity.GetInt("rewardrestindex", 0); }
        set { SmartSecurity.SetInt("rewardrestindex", value); }
    }
    public int eventday0index  //이벤트 1
    {
        get { return SmartSecurity.GetInt("eventday0index", 0); }
        set { SmartSecurity.SetInt("eventday0index", value); }
    }
    public int eventdaydia0index //이벤트3 다이아
    {
        get { return SmartSecurity.GetInt("eventdaydia0index", 0); }
        set { SmartSecurity.SetInt("eventdaydia0index", value); }
    }
    public int eventdayticket0index //이벤트3 입장권
    {
        get { return SmartSecurity.GetInt("eventdaydia0index", 0); }
        set { SmartSecurity.SetInt("eventdaydia0index", value); }
    }
    public int eventdaytotal0index //이벤트3 통합
    {
        get { return SmartSecurity.GetInt("eventdaytotal0index", 0); }
        set { SmartSecurity.SetInt("eventdaytotal0index", value); }
    }
    public int event0index
    {
        get { return SmartSecurity.GetInt("event0index", 0); }
        set { SmartSecurity.SetInt("event0index", value); }
    }
    public int event1index
    {
        get { return SmartSecurity.GetInt("event1index", 0); }
        set { SmartSecurity.SetInt("event1index", value); }
    }
    public int event2index
    {
        get { return SmartSecurity.GetInt("event2index", 0); }
        set { SmartSecurity.SetInt("event2index", value); }
    }
    public int event0maxindex
    {
        get { return SmartSecurity.GetInt("event0maxindex", 10); }
        set { SmartSecurity.SetInt("event0maxindex", value); }
    }
    public int event1maxindex
    {
        get { return SmartSecurity.GetInt("event1maxindex", 10); }
        set { SmartSecurity.SetInt("event1maxindex", value); }
    }
    public int event2maxindex
    {
        get { return SmartSecurity.GetInt("event2maxindex", 10); }
        set { SmartSecurity.SetInt("event2maxindex", value); }
    }
    public int passbuy1index //실버패스 구매보상
    {
        get { return SmartSecurity.GetInt("passbuy1index", 0); }
        set { SmartSecurity.SetInt("passbuy1index", value); }
    }
    public int passbuy2index //골드패스 구매보상
    {
        get { return SmartSecurity.GetInt("passbuy2index", 0); }
        set { SmartSecurity.SetInt("passbuy2index", value); }
    }
    public int passbuy3index //플래패스 구매보상
    {
        get { return SmartSecurity.GetInt("passbuy3index", 0); }
        set { SmartSecurity.SetInt("passbuy3index", value); }
    }
    public int passbuy4index //다이아패스 구매보상
    {
        get { return SmartSecurity.GetInt("passbuy4index", 0); }
        set { SmartSecurity.SetInt("passbuy4index", value); }
    }
    public int passpanel1index //실버패스패널
    {
        get { return SmartSecurity.GetInt("passpanel1index", 0); }
        set { SmartSecurity.SetInt("passpanel1index", value); }
    }
    public int passpanel2index //골드패스패널
    {
        get { return SmartSecurity.GetInt("passpanel2index", 0); }
        set { SmartSecurity.SetInt("passpanel2index", value); }
    }
    public int passpanel3index //플래패스패널
    {
        get { return SmartSecurity.GetInt("passpanel3index", 0); }
        set { SmartSecurity.SetInt("passpanel3index", value); }
    }
    public int passpanel4index //다이아패스패널
    {
        get { return SmartSecurity.GetInt("passpanel4index", 0); }
        set { SmartSecurity.SetInt("passpanel4index", value); }
    }
    public int passday0index //수호자패스 매일보상
    {
        get { return SmartSecurity.GetInt("passday0index", 0); }
        set { SmartSecurity.SetInt("passday0index", value); }
    }
    public int passday1index //실버패스 매일보상
    {
        get { return SmartSecurity.GetInt("passday1index", 0); }
        set { SmartSecurity.SetInt("passday1index", value); }
    }
    public int passday2index //골드패스 매일보상
    {
        get { return SmartSecurity.GetInt("passday2index", 0); }
        set { SmartSecurity.SetInt("passday2index", value); }
    }
    public int passday3index //플래패스 매일보상
    {
        get { return SmartSecurity.GetInt("passday3index", 0); }
        set { SmartSecurity.SetInt("passday3index", value); }
    }
    public int passday4index //다이아패스 매일보상
    {
        get { return SmartSecurity.GetInt("passday4index", 0); }
        set { SmartSecurity.SetInt("passday4index", value); }
    }
    public int passguardian0index //무료패스보상체크
    {
        get { return SmartSecurity.GetInt("passguardian0index", 0); }
        set { SmartSecurity.SetInt("passguardian0index", value); }
    }
    public int passguardian1index 
    {
        get { return SmartSecurity.GetInt("passguardian1index", 0); }
        set { SmartSecurity.SetInt("passguardian1index", value); }
    }
    public int passguardian2index
    {
        get { return SmartSecurity.GetInt("passguardian2index", 0); }
        set { SmartSecurity.SetInt("passguardian2index", value); }
    }
    public int passguardian3index
    {
        get { return SmartSecurity.GetInt("passguardian3index", 0); }
        set { SmartSecurity.SetInt("passguardian3index", value); }
    }
    public int passguardian4index
    {
        get { return SmartSecurity.GetInt("passguardian4index", 0); }
        set { SmartSecurity.SetInt("passguardian4index", value); }
    }
    public int passguardian5index
    {
        get { return SmartSecurity.GetInt("passguardian5index", 0); }
        set { SmartSecurity.SetInt("passguardian5index", value); }
    }
    public int passguardian6index
    {
        get { return SmartSecurity.GetInt("passguardian6index", 0); }
        set { SmartSecurity.SetInt("passguardian6index", value); }
    }
    public int passguardian7index
    {
        get { return SmartSecurity.GetInt("passguardian7index", 0); }
        set { SmartSecurity.SetInt("passguardian7index", value); }
    }
    public int passguardian8index
    {
        get { return SmartSecurity.GetInt("passguardian8index", 0); }
        set { SmartSecurity.SetInt("passguardian8index", value); }
    }
    public int passguardian9index
    {
        get { return SmartSecurity.GetInt("passguardian9index", 0); }
        set { SmartSecurity.SetInt("passguardian9index", value); }
    }
    public int passsilver0index //실버패스보상체크
    {
        get { return SmartSecurity.GetInt("passsilver0index", 0); }
        set { SmartSecurity.SetInt("passsilver0index", value); }
    }
    public int passsilver1index
    {
        get { return SmartSecurity.GetInt("passsilver1index", 0); }
        set { SmartSecurity.SetInt("passsilver1index", value); }
    }
    public int passsilver2index
    {
        get { return SmartSecurity.GetInt("passsilver2index", 0); }
        set { SmartSecurity.SetInt("passsilver2index", value); }
    }
    public int passsilver3index
    {
        get { return SmartSecurity.GetInt("passsilver3index", 0); }
        set { SmartSecurity.SetInt("passsilver3index", value); }
    }
    public int passsilver4index
    {
        get { return SmartSecurity.GetInt("passsilver4index", 0); }
        set { SmartSecurity.SetInt("passsilver4index", value); }
    }
    public int passsilver5index
    {
        get { return SmartSecurity.GetInt("passsilver5index", 0); }
        set { SmartSecurity.SetInt("passsilver5index", value); }
    }
    public int passsilver6index
    {
        get { return SmartSecurity.GetInt("passsilver6index", 0); }
        set { SmartSecurity.SetInt("passsilver6index", value); }
    }
    public int passsilver7index
    {
        get { return SmartSecurity.GetInt("passsilver7index", 0); }
        set { SmartSecurity.SetInt("passsilver7index", value); }
    }
    public int passsilver8index
    {
        get { return SmartSecurity.GetInt("passsilver8index", 0); }
        set { SmartSecurity.SetInt("passsilver8index", value); }
    }
    public int passsilver9index
    {
        get { return SmartSecurity.GetInt("passsilver9index", 0); }
        set { SmartSecurity.SetInt("passsilver9index", value); }
    }
    public int passgold0index //골드패스체크
    {
        get { return SmartSecurity.GetInt("passgold0index", 0); }
        set { SmartSecurity.SetInt("passgold0index", value); }
    }
    public int passgold1index 
    {
        get { return SmartSecurity.GetInt("passgold1index", 0); }
        set { SmartSecurity.SetInt("passgold1index", value); }
    }
    public int passgold2index
    {
        get { return SmartSecurity.GetInt("passgold2index", 0); }
        set { SmartSecurity.SetInt("passgold2index", value); }
    }
    public int passgold3index
    {
        get { return SmartSecurity.GetInt("passgold3index", 0); }
        set { SmartSecurity.SetInt("passgold3index", value); }
    }
    public int passgold4index
    {
        get { return SmartSecurity.GetInt("passgold4index", 0); }
        set { SmartSecurity.SetInt("passgold4index", value); }
    }
    public int passgold5index
    {
        get { return SmartSecurity.GetInt("passgold5index", 0); }
        set { SmartSecurity.SetInt("passgold5index", value); }
    }
    public int passgold6index
    {
        get { return SmartSecurity.GetInt("passgold6index", 0); }
        set { SmartSecurity.SetInt("passgold6index", value); }
    }
    public int passgold7index
    {
        get { return SmartSecurity.GetInt("passgold7index", 0); }
        set { SmartSecurity.SetInt("passgold7index", value); }
    }
    public int passgold8index
    {
        get { return SmartSecurity.GetInt("passgold8index", 0); }
        set { SmartSecurity.SetInt("passgold8index", value); }
    }
    public int passgold9index
    {
        get { return SmartSecurity.GetInt("passgold9index", 0); }
        set { SmartSecurity.SetInt("passgold9index", value); }
    }
    public int passpl0index //플래패스보상체크
    {
        get { return SmartSecurity.GetInt("passpl0index", 0); }
        set { SmartSecurity.SetInt("passpl0index", value); }
    }
    public int passpl1index
    {
        get { return SmartSecurity.GetInt("passpl1index", 0); }
        set { SmartSecurity.SetInt("passpl1index", value); }
    }
    public int passpl2index
    {
        get { return SmartSecurity.GetInt("passpl2index", 0); }
        set { SmartSecurity.SetInt("passpl2index", value); }
    }
    public int passpl3index
    {
        get { return SmartSecurity.GetInt("passpl3index", 0); }
        set { SmartSecurity.SetInt("passpl3index", value); }
    }
    public int passpl4index
    {
        get { return SmartSecurity.GetInt("passpl4index", 0); }
        set { SmartSecurity.SetInt("passpl4index", value); }
    }
    public int passpl5index
    {
        get { return SmartSecurity.GetInt("passpl5index", 0); }
        set { SmartSecurity.SetInt("passpl5index", value); }
    }
    public int passpl6index
    {
        get { return SmartSecurity.GetInt("passpl6index", 0); }
        set { SmartSecurity.SetInt("passpl6index", value); }
    }
    public int passpl7index
    {
        get { return SmartSecurity.GetInt("passpl7index", 0); }
        set { SmartSecurity.SetInt("passpl7index", value); }
    }
    public int passpl8index
    {
        get { return SmartSecurity.GetInt("passpl8index", 0); }
        set { SmartSecurity.SetInt("passpl8index", value); }
    }
    public int passpl9index
    {
        get { return SmartSecurity.GetInt("passpl9index", 0); }
        set { SmartSecurity.SetInt("passpl9index", value); }
    }
    public int passdia0index //다이아패스보상체크
    {
        get { return SmartSecurity.GetInt("passdia0index", 0); }
        set { SmartSecurity.SetInt("passdia0index", value); }
    }
    public int passdia1index
    {
        get { return SmartSecurity.GetInt("passdia1index", 0); }
        set { SmartSecurity.SetInt("passdia1index", value); }
    }
    public int passdia2index
    {
        get { return SmartSecurity.GetInt("passdia2index", 0); }
        set { SmartSecurity.SetInt("passdia2index", value); }
    }
    public int passdia3index
    {
        get { return SmartSecurity.GetInt("passdia3index", 0); }
        set { SmartSecurity.SetInt("passdia3index", value); }
    }
    public int passdia4index
    {
        get { return SmartSecurity.GetInt("passdia4index", 0); }
        set { SmartSecurity.SetInt("passdia4index", value); }
    }
    public int passdia5index
    {
        get { return SmartSecurity.GetInt("passdia5index", 0); }
        set { SmartSecurity.SetInt("passdia5index", value); }
    }
    public int passdia6index
    {
        get { return SmartSecurity.GetInt("passdia6index", 0); }
        set { SmartSecurity.SetInt("passdia6index", value); }
    }
    public int passdia7index
    {
        get { return SmartSecurity.GetInt("passdia7index", 0); }
        set { SmartSecurity.SetInt("passdia7index", value); }
    }
    public int passdia8index
    {
        get { return SmartSecurity.GetInt("passdia8index", 0); }
        set { SmartSecurity.SetInt("passdia8index", value); }
    }
    public int passdia9index
    {
        get { return SmartSecurity.GetInt("passdia9index", 0); }
        set { SmartSecurity.SetInt("passdia9index", value); }
    }
    public int daystore0index
    {
        get { return SmartSecurity.GetInt("daystore0index", 0); }
        set { SmartSecurity.SetInt("daystore0index", value); }
    }
    public int daystore1index
    {
        get { return SmartSecurity.GetInt("daystore1index", 0); }
        set { SmartSecurity.SetInt("daystore1index", value); }
    }
    public int daystore2index
    {
        get { return SmartSecurity.GetInt("daystore2index", 0); }
        set { SmartSecurity.SetInt("daystore2index", value); }
    }
    public int daystore3index
    {
        get { return SmartSecurity.GetInt("daystore3index", 0); }
        set { SmartSecurity.SetInt("daystore3index", value); }
    }
    public int daystore4index
    {
        get { return SmartSecurity.GetInt("daystore4index", 0); }
        set { SmartSecurity.SetInt("daystore4index", value); }
    }
    public int eventfreeindex
    {
        get { return SmartSecurity.GetInt("eventfreeindex", 0); }
        set { SmartSecurity.SetInt("eventfreeindex", value); }
    }
    public float audiovolum
    {
        get { return SmartSecurity.GetFloat("audiovolum", 0); }
        set { SmartSecurity.SetFloat("audiovolum", value); }
    }
    public int adcooltime
    {
        get { return SmartSecurity.GetInt("adcooltime", 1800); }
        set { SmartSecurity.SetInt("adcooltime", value); }

    }
    public int checkadcooltime
    {
        get { return SmartSecurity.GetInt("checkadcooltime", 0); }
        set { SmartSecurity.SetInt("checkadcooltime", value); }

    }
    public int checkplusadcooltime
    {
        get { return SmartSecurity.GetInt("checkplusadcooltime", 0); }
        set { SmartSecurity.SetInt("checkplusadcooltime", value); }

    }
    public int adcooltimemin
    {
        get { return SmartSecurity.GetInt("adcooltimemin", adcooltime/60); }
        set { SmartSecurity.SetInt("adcooltimemin", value); }

    }
    public int adcooltimesec
    {
        get { return SmartSecurity.GetInt("adcooltimesec", adcooltime%60); }
        set { SmartSecurity.SetInt("adcooltimesec", value); }

    }
 
   
    public int adindex
    {
        get { return SmartSecurity.GetInt("adindex", 0); }
        set { SmartSecurity.SetInt("adindex", value); }
    }
    public int adcloseindex
    {
        get { return SmartSecurity.GetInt("adcloseindex", 0); }
        set { SmartSecurity.SetInt("adcloseindex", value); }
    }
    public int rewardadindex
    {
        get { return SmartSecurity.GetInt("rewardadindex", 0); }
        set { SmartSecurity.SetInt("rewardadindex", value); }
    }
    public int soundvolumeindex

    {
        get { return SmartSecurity.GetInt("soundvolumeindex", 0); }
        set { SmartSecurity.SetInt("soundvolumeindex", value); }
    }

}
