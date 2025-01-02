using UnityEngine;
using TMPro;
using Photon.Pun;

namespace Myproject.Assets.Scripts
{
    public class ChooseChampion : MonoBehaviourPunCallbacks
    {   
        //texto
        public TMP_Text txt_chat;

        //ShowButtonsScript
        public GameObject menuInGame;  
        private ShowButtonsScript showButtonsScript = new ShowButtonsScript();

        // prefabs
        public GameObject[] prefabs;
        private int index = -1;

        public void SelectCharacter(int index){
            this.index = index;
            txt_chat.text = $"Champion {prefabs[index].name} selected!";
            txt_chat.color = Color.blue;
        }

        public void ButtonInstantiatePlayer(){
            if(index == -1){
                txt_chat.text = "No Champion selected!";
                txt_chat.color = Color.red;
                return;
            }

            PhotonNetwork.Instantiate(prefabs[index].name, new Vector3(0, 0, 0), Quaternion.identity, 0);
            txt_chat.text = "Instantiated player";
            txt_chat.color = Color.magenta;    
            showButtonsScript.RemoveButton(menuInGame);
        }
    }
}