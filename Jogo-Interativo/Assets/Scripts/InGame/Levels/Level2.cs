using UnityEngine;

public class Level2 : MonoBehaviour, ILevel
{
    [SerializeField] private ControllerScene _controllerScene;

    private byte stage = 0;

    public void Execute()
    {
        stage++;
    }
}
