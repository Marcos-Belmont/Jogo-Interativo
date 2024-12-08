using UnityEngine;

public class Level6 : MonoBehaviour, ILevel
{
    public void PrepareLevel()
    {
        Game.manager.controllerScene.dateText.text = "03/02/5282\n------------------\n14:44";
        Game.manager.controllerScene.inGameTransition.TransitionText.text = "DIA 105";
        Game.manager.controllerScene.interactText.text = "CLIQUE PARA SAIR DO MICRO SUBMARINO E ENCERRAR O ÚLTIMO DIA";
    }

    public void Execute() => Game.manager.controllerScene.GameOver();

}
