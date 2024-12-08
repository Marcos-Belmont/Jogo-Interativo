using UnityEngine;

public class Level4 : MonoBehaviour, ILevel
{
    private byte _stage = 0;

    public void Execute()
    {
        switch (_stage)
        {
            case 0:
                Game.manager.controllerScene.HeitorFarias("\n\n<Color=#28AB3C>Heitor Farias -> Senhor, temos um grande problema!</Color>");

                Game.manager.controllerScene.dateText.text = "19/12/5281\n------------------\n07:00";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER UMA MENSAGEM DE CARLOS HENRIQUE";
                break;
        }

        _stage++;
    }
}
