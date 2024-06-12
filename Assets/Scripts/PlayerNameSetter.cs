using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNameSetter : MonoBehaviour
{
    //Called by OnEndEdit InputField in scene
    public void SetPlayerName(string name)
    {
        GameManager.Instance.SetPlayerName(name);
    }
}
