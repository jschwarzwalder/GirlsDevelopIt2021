using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitRecycleInfoPanel : MonoBehaviour
{
    public void onClick(){
        gameObject.transform.parent.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
