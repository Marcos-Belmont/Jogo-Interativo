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
            Debug.Log("Câmera do editor destruída");
            return;
        }
#endif
        //Torna o game object indestrutível
        DontDestroyOnLoad(gameObject);
    }
}
