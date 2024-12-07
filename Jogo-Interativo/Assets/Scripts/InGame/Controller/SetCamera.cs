using UnityEngine;

public class SetCamera : MonoBehaviour
{
    [SerializeField] Canvas[] canvas;

    private void Start()
    {
        foreach (Canvas canvas in canvas)
            canvas.worldCamera = Game.cam.cam;
    }
}
