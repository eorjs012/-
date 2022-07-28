using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DmgText : MonoBehaviour
{
    public Text damagett;
    public void OnEnable()
    {
        gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        if(DataController.Instance.Scenemoveindex == 0) 
        {
            if (DataController.Instance.criindex == 0)
            {
                damagett.text = TextController.Instance.ChangeDouble(DataController.Instance.damage);
            }
            else
            {
                damagett.text = TextController.Instance.ChangeDouble(DataController.Instance.damage * DataController.Instance.criticaldamage);
            }
            Invoke("Destroyobj", 0.5f);

        }
        else if(DataController.Instance.Scenemoveindex ==1)
        {
            if (MeetController.Instance.meetcriticalindex == 0)
            { //일반
                damagett.text = MeetController.Instance.MeetChangeDouble(DataController.Instance.damage);

            }
            else
            { //크리

                damagett.text = MeetController.Instance.MeetChangeDouble(DataController.Instance.damage * DataController.Instance.criticaldamage);
            }
            Invoke("Destroyobj", 0.5f);

        }
        else if(DataController.Instance.Scenemoveindex == 2)
        {
           if(RockController.Instance.rockcriticalindex == 0)
           { //일반
                damagett.text = RockController.Instance.RockChangeDouble(DataController.Instance.damage);
           }
           else
           { //크리
                damagett.text = RockController.Instance.RockChangeDouble(DataController.Instance.damage * DataController.Instance.criticaldamage);
           }
            Invoke("Destroyobj", 0.5f);
        }
        else if(DataController.Instance.Scenemoveindex == 3)
        {
            if (MiningController.Instance.miningcriticalindex == 0)
            { //일반
                damagett.text = MiningController.Instance.MiningChangeDouble(DataController.Instance.damage);
            }
            else
            { //크리
                damagett.text = MiningController.Instance.MiningChangeDouble(DataController.Instance.damage * DataController.Instance.criticaldamage);
            }
            Invoke("Destroyobj", 0.5f);

        }
    }

    public void Destroyobj()
    {
        Destroy(gameObject);
    }
    
}
