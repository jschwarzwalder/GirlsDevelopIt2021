using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;



public class RecycleItem : MonoBehaviour
{
    public enum disposal { RECYCLE, TRASH, COMPOST}

    [SerializeField] string description;
    [SerializeField] disposal wayToDispose;
    [SerializeField] string successMessage;
    [SerializeField] string failureMessage;

    [SerializeField] Text textBox;
    [SerializeField] Canvas canvas;
    [SerializeField] DisposalButton[] disposalButtons;
    [SerializeField] Button exitButton;

    public void sortItem(){
        
        textBox.text = description;
        exitButton.gameObject.SetActive(false);
        canvas.gameObject.SetActive(true);
         foreach (DisposalButton button in disposalButtons){
            button.gameObject.SetActive(true);
            button.setRecycleItem(this);
        }
        

    }

    public void disposeItem(disposal disposalType){
        if (disposalType == wayToDispose) {
            textBox.text = successMessage;
        } else {
            textBox.text = failureMessage;
        }

        foreach (DisposalButton button in disposalButtons){
            button.gameObject.SetActive(false);
        }

        exitButton.gameObject.SetActive(true);

    }


}
