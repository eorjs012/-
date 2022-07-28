using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using System;
using Random = UnityEngine.Random;

public class AdController : MonoBehaviour
{

    private static AdController instance;

    public static AdController Instance
    {
        get
        {
            if (instance != null) return instance;
            instance = FindObjectOfType<AdController>();
            if (instance != null) return instance;
            var container = new GameObject("AdController");
            instance = container.AddComponent<AdController>();
            return instance;
        }
    }

    public void OnEnable()
    {
     

    }
    public RewardedAd rewardedAd;

    // Start is called before the first frame update
    void Start()
    {
      
        MobileAds.Initialize(initStatus => { });

        string adUnitId;
#if UNITY_ANDROID
        adUnitId = "ca-app-pub-6070570658064571/8425033707"; //ca-app-pub-6070570658064571/8425033707 ca-app-pub-3940256099942544/5224354917
#elif UNITY_IPHONE
            adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
            adUnitId = "unexpected_platform";
#endif

        this.rewardedAd = new RewardedAd(adUnitId);

        // Called when an ad request has successfully loaded.
        this.rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
        // Called when an ad request failed to load.
        //this.rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        // Called when an ad is shown.
        this.rewardedAd.OnAdOpening += HandleRewardedAdOpening;
        // Called when an ad request failed to show.
        this.rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        // Called when the user should be rewarded for interacting with the ad.
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        // Called when the ad is closed.
        this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        this.rewardedAd.LoadAd(request);
    }

    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdLoaded event received");
    }

    public void HandleRewardedAdFailedToLoad(object sender, AdErrorEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardedAdFailedToLoad event received with message: "
            + args.Message);
    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdOpening event received");
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardedAdFailedToShow event received with message: "
            + args.Message);
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdClosed event received");
        CreateAndLoadRewardedAd();
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        
        if(DataController.Instance.rewardadindex == 0)  //광고 시청보상 
        {
            var BH = GameObject.FindGameObjectWithTag("monster");
            Destroy(BH);
            TextController.Instance.monsterspwanposition.transform.position = new Vector3(-4.25f, 1.2f, 0);
            Player.Instance.animator.SetInteger("state", 0);
            DataController.Instance.monstermoveindex = 0;
            var a = Random.Range(0, 10);
            var b = Instantiate(TextController.Instance.stagebasicmonster[a], TextController.Instance.monsterspwanposition.transform.position, Quaternion.identity);
            b.transform.SetParent(TextController.Instance.monsterspwanposition.transform);
            DataController.Instance.Diamond += 200;
            TextController.Instance.changeUiMoney();
            SmartSecurity.SetInt("adindex", 1);
            SmartSecurity.SetInt("checkadcooltime", 1);
            // DataController.Instance.adindex = 1;
            TextController.Instance.checkadbox();
            StartCoroutine("AdStopWatch");
            
        }
        else if(DataController.Instance.rewardadindex == 1)   //광고 휴식보상
        {
            var BH = GameObject.FindGameObjectWithTag("monster");
            Destroy(BH);
            TextController.Instance.monsterspwanposition.transform.position = new Vector3(-4.25f, 1.2f, 0);
            Player.Instance.animator.SetInteger("state", 0);
            DataController.Instance.monstermoveindex = 0;
            var a = Random.Range(0, 10);
            var b = Instantiate(TextController.Instance.stagebasicmonster[a], TextController.Instance.monsterspwanposition.transform.position, Quaternion.identity);
            b.transform.SetParent(TextController.Instance.monsterspwanposition.transform);
            int num = int.Parse(DataController.Instance.resttime);
            DataController.Instance.gold += num * DataController.Instance.stagebasicgoldreward / 5;
            DataController.Instance.upgradestone += num + DataController.Instance.stagebasicupgradestonereward / 50;    //초당 0.2개씩 
            TextController.Instance.changeUiMoney();
            TimeController.Instance.restpanel.SetActive(false);
            DataController.Instance.rewardadindex = 0;
           
        }
      
    }

    private void UserChoseToWatchAd()
    {
        if (rewardedAd.IsLoaded())
        {
            if (DataController.Instance.adcloseindex == 0) //광고제거 안했을때 
            {
                var BH = GameObject.FindGameObjectWithTag("monster");
                Destroy(BH);
                rewardedAd.Show();
            }
            else  //광고제거 했을때 
            {
                if (DataController.Instance.rewardadindex == 0)
                {
                    DataController.Instance.Diamond += 200;
                    TextController.Instance.changeUiMoney();
                    SmartSecurity.SetInt("adindex", 1);
                    SmartSecurity.SetInt("checkadcooltime", 1);
                    // DataController.Instance.adindex = 1;
                    TextController.Instance.checkadbox();
                    StartCoroutine("AdStopWatch");
                    StageMonster.Instance.die();
                   
                }
                else if (DataController.Instance.rewardadindex == 1)
                {
                    int num = int.Parse(DataController.Instance.resttime);
                    DataController.Instance.gold += num * DataController.Instance.stagebasicgoldreward / 5;
                    DataController.Instance.upgradestone += num * DataController.Instance.stagebasicupgradestonereward / 50;    //초당 0.2개씩 
                    TextController.Instance.changeUiMoney();
                    TimeController.Instance.restpanel.SetActive(false);
                    DataController.Instance.rewardadindex = 0;
                    
                }
               
            }
           
        }
        else
        {
            CreateAndLoadRewardedAd();
        }
    }

    public void CreateAndLoadRewardedAd()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3940256099942544/5224354917";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
            string adUnitId = "unexpected_platform";
#endif

        this.rewardedAd = new RewardedAd(adUnitId);

        // Called when an ad request has successfully loaded.
        this.rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
        // Called when an ad request failed to load.
        //this.rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        // Called when an ad is shown.
        this.rewardedAd.OnAdOpening += HandleRewardedAdOpening;
        // Called when an ad request failed to show.
        this.rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        // Called when the user should be rewarded for interacting with the ad.
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        // Called when the ad is closed.
        this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        this.rewardedAd.LoadAd(request);
    }
   
    public Text timerTt;
    
    IEnumerator AdStopWatch()
    {
        //쿨타임이 시작될때
        
        while (DataController.Instance.adcooltime > 0)
        {

            //timerTt.text = string.Format("{0:D2}:{1:D2}", min, sec);
            // timerTt.text = DataController.Instance.adcooltime + "";
            timerTt.text = DataController.Instance.adcooltimemin + " : " + DataController.Instance.adcooltimesec;
             DataController.Instance.adcooltime--;
            yield return new WaitForSeconds(1f);
        }
        if (DataController.Instance.adcooltime <= 0)
        {//쿨타임이다됬을떄 쿨타임박스끄기;
            TextController.Instance.adtimerbox.SetActive(false);
            SmartSecurity.SetInt("adindex", 0);
           // DataController.Instance.adindex = 0;
            TextController.Instance.checkadbox();
            StageMonster.Instance.die();
            DataController.Instance.adcooltime += 1800;
        }
        
    }
    public void checkadcorutine()
    {
        if (DataController.Instance.adindex == 1)
        {
            TextController.Instance.adtimerbox.SetActive(true);
        }
        else
        {
            TextController.Instance.adtimerbox.SetActive(false);
        }
    }
    public void checkadcooltime()
    {
        DataController.Instance.checkadcooltime = 0;
      
    }
    
}