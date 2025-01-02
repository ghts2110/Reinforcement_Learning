using UnityEngine;
using Photon.Pun;


namespace Myproject.Assets.Scripts
{
    public class ShowButtonsScript : MonoBehaviourPunCallbacks
    {
        

        public void ShowButton(GameObject button){
            button.SetActive(true);
        }
        
        
        public void RemoveButton(GameObject button){
            button.SetActive(false);
        }

        public void ShowButtonRemoveButton(GameObject Showbutton, GameObject Removebutton){
            Showbutton.SetActive(true);
            Removebutton.SetActive(false);
        }
    }
}