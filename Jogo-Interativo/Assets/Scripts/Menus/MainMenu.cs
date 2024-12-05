using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [Header("Text")]
    [SerializeField] Text TextVersionInformation;

    [Header("Game Objects")]
    [SerializeField] GameObject areaInformation;
    [SerializeField] GameObject buttonsMenu;

    [Header("Prefabs")]
    [SerializeField] GameObject game;

    public void Awake()
    {
        //Instanciando todas as configura��es do jogo.
        if (Game.instantiated == false)
        {
            Game.instantiated = true;
            Instantiate(game);
        }

        //Aplica o texto da vers�o
        TextVersionInformation.text = "Criado por: Marcos Belmont\nVers�o: " + Application.version;

        ////Serve para anexar o Game Objects ao script do options, para ele poder sair das op��es e retornar pro ponto indicado do menu
        Game.config.exitConfig = new GameObject[2];
        Game.config.exitConfig[0] = areaInformation;
        Game.config.exitConfig[1] = buttonsMenu;
    }

    #region BOT�ES DO MENU
    public void ButtonPlay()
    {
        //Game.options.ClearTextMethod();
        Game.transition.ChangeScene(1);
    }
    public void ButtonConfig()
    {
        areaInformation.SetActive(false);
        buttonsMenu.SetActive(false);
        Game.config.configChild.SetActive(true);

        Debug.Log("Configurations");
    }
    public void ButtonExit() => Application.Quit();
    #endregion
}
