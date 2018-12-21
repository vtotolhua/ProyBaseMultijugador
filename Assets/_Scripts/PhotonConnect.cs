using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonConnect : MonoBehaviour {

    public string versionname = "0.1";
    public GameObject sectionView1, sectionView2, sectionView3, sectionView4;

    private void Awake ()
    {
        PhotonNetwork.ConnectUsingSettings(versionname);
        //Debug.Log("Conectando a photon...");
    }

    public void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby(TypedLobby.Default);
        //Debug.Log("Conectados a Photon");
    }

    public void OnJoinedLobby()
    {
        sectionView1.SetActive(false);
        sectionView2.SetActive(true);
        //Debug.Log("Estamos en el lobby");
    }
    private void OnDisconnectedFromPhoton()
    {
            sectionView1.SetActive(false);
            sectionView2.SetActive(false);
            sectionView4.SetActive(false);
            sectionView3.SetActive(true);

        //Debug.Log("Te desconectaste de servicios en linea");
    } 
}
