using UnityEngine;

public class Level7 : MonoBehaviour, ILevel
{
    [SerializeField] private ControllerScene _controllerScene;

    private byte stage = 0;

    public void Execute()
    {
        stage++;
    }
}
