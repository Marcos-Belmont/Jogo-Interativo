using UnityEngine;
using Unity.Cinemachine;

public class GameCamera : MonoBehaviour
{
    public Camera cam;
    public CinemachineCamera cC;

    private void Awake()
    {
#if UNITY_EDITOR
        if (gameObject.CompareTag("EditorOnly"))
        {
            Destroy(gameObject);
            Debug.Log("C�mera do editor destru�da");
            return;
        }
#endif
        //Torna o game object indestrut�vel
        DontDestroyOnLoad(gameObject);
    }
}
