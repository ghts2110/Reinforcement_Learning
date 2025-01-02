using UnityEngine;
using TMPro;
using Photon.Pun;

namespace Myproject.Assets.Scripts
{
    public class ButtonScript : MonoBehaviourPunCallbacks
    {
        // texto
        public TMP_Text txt_chat;

        // ShowButtonsScript
        public GameObject menuInicial; 
        public GameObject menuInGame;  
        private ShowButtonsScript showButtonsScript = new ShowButtonsScript();

        // metodos
        public void ButtonCreateRoom(){
            PhotonNetwork.CreateRoom("Room_1");
            txt_chat.text = "Room created. Waiting for players...";
            txt_chat.color = Color.blue;
            showButtonsScript.RemoveButton(menuInicial);
        }

        public void ButtonJoinRoom(){
            PhotonNetwork.JoinRoom("Room_1");
            txt_chat.text = "Joined the room successfully!";
            txt_chat.color = Color.blue;
            showButtonsScript.RemoveButton(menuInicial);
        }

        public void ButtonQuitGame(){
            txt_chat.text = "Quitting game...";
            txt_chat.color = Color.red;
            Application.Quit();

        }

        public void ButtonBackToStart(){
            txt_chat.text = "Left the room";
            txt_chat.color = Color.red;    
            PhotonNetwork.LeaveRoom();
        }
    }
}