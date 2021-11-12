using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisposalButton : MonoBehaviour
{

    [SerializeField] RecycleItem.disposal disposalType;
    private RecycleItem recycleItem;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void setRecycleItem(RecycleItem item) {
        recycleItem = item;
    }

    public void buttonPushed(){
        recycleItem.disposeItem(disposalType);
    }
}
