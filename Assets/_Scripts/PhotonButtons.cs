using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotonButtons : MonoBehaviour {

    public photonHand pHandler;
    public PhotonConnect pConnect;
    //public InputField createRoomInput, joinRoomInput;
    public string createRoomName;
   
    //usabamos para el boton crear 
    /*public void OnClickCreateRoom()
    {
        pHandler.createNewRoom();
    }*/

    public void OnClickJoinRoom()
    {
        pHandler.joinOrCreateRoom();
        pConnect.sectionView2.SetActive(false);
        pConnect.sectionView4.SetActive(true);
    }
}