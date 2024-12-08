using UnityEngine;

public class MenuInGame : MonoBehaviour
{
    [Header("Game Objects")]
    public GameObject CanvasGO;
    [SerializeField] GameObject buttonsMenu;

    void Awake()
    {
        //Serve para anexar o Game Objects ao script do options, para ele poder sair das opções e retornar pro ponto indicado do menu
        Game.config.exitConfig = new GameObject[1];
        Game.config.exitConfig[0] = buttonsMenu;

        Game.manager.menuInGame = this;
    }

    #region MÉTODO DOS BOTÕES
    public void ButtonContinue()
    {
        CanvasGO.SetActive(false);
    }
    public void ButtonConfig()
    {
        buttonsMenu.SetActive(false);
        Game.config.configChild.SetActive(true);
    }
    public void ButtonExit()
    {
        buttonsMenu.SetActive(false);
        Game.manager.instantiatedObjectsInGame = false;
        Game.manager.menuInGame = null;
        Game.input.PausePlayerDisable();
        Game.transition.targetScene = 0;
        Game.transition.PlayAnimationClosing();
    }
    #endregion
}