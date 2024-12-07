using UnityEngine;

public class Level1 : MonoBehaviour, ILevel
{
    private byte _stage = 0;

    public void Execute()
    {
        switch (_stage)
        {
            case 0:
                Game.manager.controllerScene.personText[0] += "\n\nCarlos Henrique -> Certo, duas semaninhas j� se passaram a partir de hoje." +
                    "" +
                    "\n\nCarlos Henrique -> T� vivo ainda?";
                Game.manager.controllerScene.buttonPerson.SelectPerson(0);
                Game.manager.controllerScene.interactText.text = "CLIQUE PARA ESCOLHER QUAL RESPOSTA DAR� AO CARLOS HENRIQUE";
                break;
            case 1:
                break;
        }
        _stage++;
    }
}
