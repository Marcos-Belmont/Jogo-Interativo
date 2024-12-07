using UnityEngine;

public class Level1 : MonoBehaviour, ILevel
{
    [SerializeField] private ControllerScene _controllerScene;

    private byte stage = 0;

    public void Execute()
    {
        switch (stage)
        {
            case 0:
                _controllerScene.GameOver();
                break;
        }
        stage++;
    }
}
