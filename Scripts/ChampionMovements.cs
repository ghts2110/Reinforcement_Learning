using UnityEngine;
using Photon.Pun;
using UnityEngine.AI;

namespace Myproject.Assets.Scripts
{
    public class ChampionMovements : MonoBehaviourPunCallbacks
    {
        private NavMeshAgent agent;
        private Camera mainCamera;
        private PhotonView _photonView;
        private Animator _animator;
        private Vector3 targetDestination;

        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
            _photonView = GetComponent<PhotonView>();
            _animator = GetComponent<Animator>();
            targetDestination = transform.position;
            mainCamera = Camera.main;
        }

        void Update()
        {
            if(_photonView.IsMine){
                if (Input.GetMouseButtonDown(1))
                {
                    Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;

                    if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                    {
                        targetDestination = hit.point;
                        agent.SetDestination(hit.point);
                    }
                }

                if(Vector3.Distance(transform.position, targetDestination) > 0.5f){
                    _animator.SetBool("isMoving", true);
                }else{
                    _animator.SetBool("isMoving", false);
                }
            }
            
            // Recalcular se estiver travado
            if (agent.pathStatus == NavMeshPathStatus.PathPartial)
            {
                agent.ResetPath();
            }
        }

        public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info){
            if(stream.IsWriting){
                //cliente mandando informacoes 
                stream.SendNext(_animator.GetBool("isMoving"));
            }else{
                // cliente recebendo informacoes
                _animator.SetBool("isMoving", (bool)stream.ReceiveNext());
            }
        }
    }
}