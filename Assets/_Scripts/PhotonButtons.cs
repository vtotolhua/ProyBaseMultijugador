using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotonButtons : MonoBehaviour {

    public photonHand pHandler;
    public InputField createRoomInput, joinRoomInput;
    
    public void OnClickCreateRoom()
    {
        pHandler.createNewRoom();
    }

    public void OnClickJoinRoom()
    {
        pHandler.joinOrCreateRoom();
        
    }
 
}