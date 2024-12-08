using UnityEngine;

public class Level6 : MonoBehaviour, ILevel
{
    private byte _stage = 0;

    public void PrepareLevel()
    {
        Game.manager.controllerScene.dateText.text = "03/02/5282\n------------------\n14:44";
        Game.manager.controllerScene.inGameTransition.TransitionText.text = "DIA 105";
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
