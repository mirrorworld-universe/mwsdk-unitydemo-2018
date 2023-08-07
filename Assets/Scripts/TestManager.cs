using System.Collections;
using System.Collections.Generic;
using MirrorWorld;
using UnityEngine;
using UnityEngine.UI;

public class TestManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonsClicked()
    {
        var btnName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        if (btnName == "BtnLogin")
        {
            MWSDK.StartLogin((loginRes)=> {
                Debug.Log("Login success! Response:"+JsonUtility.ToJson(loginRes));
            });
        }
        else if (btnName == "BtnOpenWallet")
        {
            MWSDK.OpenWallet(()=> {
                Debug.Log("You have logged out.");
            });
        }
        else if (btnName == "BtnIsLogged")
        {
            MWSDK.IsLogged((isLogged)=> {
                Debug.Log("Your login status is:"+isLogged);
            });
        }
        else
        {
            Debug.Log("Unknown button name:"+btnName);
        }
    }
}
