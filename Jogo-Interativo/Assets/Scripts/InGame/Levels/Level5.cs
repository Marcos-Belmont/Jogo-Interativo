using UnityEngine;

public class Level5 : MonoBehaviour, ILevel
{
    private byte _stage = 0;

    public void PrepareLevel()
    {
        Game.manager.controllerScene.dateText.text = "30/12/5281\n------------------\n03:00";
        Game.manager.controllerScene.inGameTransition.TransitionText.text = "DIA 71";
        Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE AMANDA SOARES";
    }

    public void Execute()
    {
        switch (_stage)
        {
            case 0:
                break;
        }

        _stage++;
    }
}
