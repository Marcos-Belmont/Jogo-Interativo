using UnityEngine;

public class MenuInGame : MonoBehaviour
{
    [Header("Game Objects")]
    [SerializeField] GameObject CanvasGO;
    [SerializeField] GameObject buttonsMenu;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        //Serve para anexar o Game Objects ao script do options, para ele poder sair das opções e retornar pro ponto indicado do menu
        Game.config.exitConfig = new GameObject[1];
        Game.config.exitConfig[0] = buttonsMenu;

        Game.input.menuInGame = CanvasGO;
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
        Game.transition.ChangeScene(0);
        Game.manager.instantiatedObjectsInGame = false;
        Game.input.menuInGame = null;
        Game.input.NormalPlayerDisable();
        Game.input.PausePlayerDisable();
        Destroy(gameObject);
    }
    #endregion
}