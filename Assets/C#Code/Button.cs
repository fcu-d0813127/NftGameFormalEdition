using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Button : MonoBehaviour
{
    string entry;
    public Text display;
    void Start() {
        if(this.gameObject.name != "Entry"){
            entry = this.gameObject.name;
        }
    }
    public void oncld(){
        string name =  EventSystem.current.currentSelectedGameObject.name;
        if(name == "Exit"){
            SceneManager.LoadScene("SampleScene");
        }
        else if(name == "Entry"){
            Debug.Log("You entry " + entry);
        }
        else{
            GameObject texttemp = GameObject.Find("message");
            texttemp.GetComponent<TextMeshProUGUI>().text = name;
            GameObject.Find("Entry").GetComponent<Button>().SetButton(entry);
        }
    }

    public void SetButton(string temp){
        entry = temp;
    }
}