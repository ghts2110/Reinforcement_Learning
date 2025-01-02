using UnityEngine;
using TMPro;
using Photon.Pun;
using Myproject.Assets.Scripts;
using UnityEngine.SceneManagement;


public class NetworkManeger : MonoBehaviourPunCallbacks
{
    //texto
    public TMP_Text txt_chat;
    
    // ShowButtonsScript
    public GameObject menuInicial; 
    public GameObject menuInGame;  
    private ShowButtonsScript showButtonsScript = new ShowButtonsScript();

    public void Start()
    {
        ConnectToPhoton();
    }

    public void Update()
    {
        // if (Input.GetKeyDown(KeyCode.C))
        // {
        //     PhotonNetwork.CreateRoom("Room_1");
        //     txt_chat.text = "Room created. Waiting for players...";
        //     txt_chat.color = Color.blue;
        // }

        // if (Input.GetKeyDown(KeyCode.E))
        // {
        //     PhotonNetwork.JoinRoom("Room_1");
        //     txt_chat.text = "Joined the room successfully!";
        //     txt_chat.color = Color.blue;
        // }

        // if (Input.GetKeyDown(KeyCode.I))
        // {
        //     PhotonNetwork.Instantiate("player", new Vector3(0, 0, 0), Quaternion.identity, 0);
        //     txt_chat.text = "Instantiated player";
        //     txt_chat.color = Color.blue;
        // }
    }

    public override void OnLeftRoom()
    {
        Debug.Log("Left the room successfully.");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public override void OnJoinedRoom()
    {
        txt_chat.text = "Connected to room";
        txt_chat.color = Color.green;
        showButtonsScript.ShowButton(menuInGame);
    }

    
    public override void OnConnectedToMaster()
    {
        txt_chat.text = "Connected to Master Server!";
        txt_chat.color = Color.green;

        showButtonsScript.ShowButton(menuInicial);
    }

    public void ConnectToPhoton()
    {
        try
        {
            PhotonNetwork.ConnectUsingSettings();
            txt_chat.text = "Connecting to the server...";
            txt_chat.color = Color.blue;
        }
        catch (UnityException error)
        {
            Debug.LogError(error);
        }
    }
}
