using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldstoreinfo : MonoBehaviour
{
    
    void Start()
    {
        
    }
    public void goldstorediarewardbtn()
    {
        DataController.Instance.gold -= DataController.Instance.goldstorediapapago;
        DataController.Instance.Diamond += DataController.Instance.goldstorediareward;
        TextController.Instance.changeUiMoney();
        DataController.Instance.goldstoredialevel++;
        TextController.Instance.checkgoldstoredia();
        TextController.Instance.checkgoldstoremeet();
        TextController.Instance.checkgoldstorerock();

    }
    public void goldstoremeetrewardbtn()
    {
        DataController.Instance.gold -= DataController.Instance.goldstoremeetpapago;
        DataController.Instance.meet += DataController.Instance.goldstoremeetreward;
        TextController.Instance.changeUiMoney();
        DataController.Instance.goldstoremeetlevel++;
        TextController.Instance.checkgoldstoredia();
        TextController.Instance.checkgoldstoremeet();
        TextController.Instance.checkgoldstorerock();

    }
    public void goldstorerockrewardbtn()
    {
        DataController.Instance.gold -= DataController.Instance.goldstorerockpapago;
        DataController.Instance.rock += DataController.Instance.goldstorerockreward;
        TextController.Instance.changeUiMoney();
        DataController.Instance.goldstorerocklevel++;
        TextController.Instance.checkgoldstoredia();
        TextController.Instance.checkgoldstoremeet();
        TextController.Instance.checkgoldstorerock();
    }
  
}
