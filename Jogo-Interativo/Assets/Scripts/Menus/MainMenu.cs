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

    public void Start()
    {
        if (Game.manager.isPlay == true)
            Game.transition.PlayAnimationOpening();
    }

    #region BOT�ES DO MENU
    public void ButtonPlay() 
    {
        Game.manager.isPlay = true;

        //Mudando para a outra scene
        Game.transition.targetScene = 1;
        Game.transition.PlayAnimationClosing();
    } 
    public void ButtonConfig()
    {
        areaInformation.SetActive(false);
        buttonsMenu.SetActive(false);
        Game.config.configChild.SetActive(true);
    }
    public void ButtonExit() => Application.Quit();
    #endregion
}
