using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class photonHand : MonoBehaviour {

    public PhotonButtons photonB;
    public GameObject mainPlayer;

    private void Awake() {
        DontDestroyOnLoad(this.transform);
        SceneManager.sceneLoaded += OnSceneFinishedLoading;
    }

    public void createNewRoom() {
        PhotonNetwork.CreateRoom(photonB.createRoomInput.text, new RoomOptions() { MaxPlayers = 4 }, null);
    }

    public void joinOrCreateRoom() {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 4;
        PhotonNetwork.JoinOrCreateRoom(photonB.joinRoomInput.text, roomOptions, TypedLobby.Default);

    }
    
    public void moveScene() {
        PhotonNetwork.LoadLevel("EscenaUno");
    }

    private void OnJoinedRoom()
    {
        moveScene();
//        Debug.Log("Estamos en el room" + photonB.createRoomInput.text);
    }

    private void OnSceneFinishedLoading(Scene scene, LoadSceneMode mode) {
        if ( scene.name == "EscenaUno")
        {
            SpawnPlayer();
        }
    }

    private void SpawnPlayer ()
    {
        PhotonNetwork.Instantiate(mainPlayer.name, mainPlayer.transform.position, mainPlayer.transform.rotation, 0);
        
    }

}
