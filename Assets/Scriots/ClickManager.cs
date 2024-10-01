using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public Transform player;
    

    public void GoToItem(ItemData item) 
    {
        player.position = item.gotoPoint.position;
        Debug.Log("test");
    
    }

}
