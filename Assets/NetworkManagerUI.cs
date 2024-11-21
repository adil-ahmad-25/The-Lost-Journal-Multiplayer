using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;


public class NetworkManagerUI : MonoBehaviour
{
    [SerializeField] private Button serverbtn;
    [SerializeField] private Button hostbtn;
    [SerializeField] private Button clientbtn;

    private void Awake()
    {
        serverbtn.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartServer();
        });
        hostbtn.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartHost();
        });
        clientbtn.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartClient();
        });
    }
}
