using TMPro;
using UnityEngine;
using UnityEngine.UI;

public partial class ControllerScene : MonoBehaviour
{
    [Header("Prefabs")]
    [Tooltip("Anexe o prefab do MenuInGame aqui.")]
    [SerializeField] GameObject _menuInGame;

    [Header("Game Objects")]
    [Tooltip("Anexe o Game Object 'Canvas-Choice', que está dentro do Game Object 'Choice'.")]
    public GameObject CanvasChoiceGO;

    [Header("Text")]
    [Tooltip("Associe o Texto do Game Object 'Content' aqui, que está dentro de 'Canvas-Chat'.")]
    public TextMeshProUGUI chatText;
    [Tooltip("Associe o Texto do Game Object 'Text-Troop' aqui, que está dentro de 'Canvas-Troop'.")]
    public Text troopText;
    [Tooltip("Associe o Texto do Game Object 'Text-Interact' aqui, que está dentro de 'Canvas-Interact'.")]
    public Text dateText;
    [Tooltip("Associe o Texto do Game Object 'Text-Interact' aqui, que está dentro de 'Canvas-Interact'.")]
    public Text interactText;
    [Tooltip("Associe o texto de todos os botões relacionados as pessoas, aqui.")]
    public Text[] personButtonText;
    //Index 0 = Carlos Henrique
    //Index 1 = Joaquim Silva
    //Index 2 = Amanda Soares
    //Index 3 = Heitor Farias
    //Index 4 = Bernado Costa
    //Index 5 = Monica Santana
    [HideInInspector] public string[] personText = new string[6];

    [Header("Levels")]
    [SerializeField] private Level1 _level1;
    [SerializeField] private Level2 _level2;
    [SerializeField] private Level3 _level3;
    [SerializeField] private Level4 _level4;
    [SerializeField] private Level5 _level5;
    [SerializeField] private Level6 _level6;
    [SerializeField] private Level7 _level7;
    private ILevel _currentLevel;

    [Header("Scripts")]
    public InGameTransition inGameTransition;
    public ButtonsPerson buttonPerson;

    //Geral
    [HideInInspector] public byte troopValue = 30;
    private byte _newLevelValue = 0;

    private void Awake()
    {
        Game.manager.controllerScene = this;

        //Serve para gerar intancia dos Game Objects
        if (Game.manager.instantiatedObjectsInGame == false)
        {
            Game.manager.instantiatedObjectsInGame = true;
            Instantiate(_menuInGame);
        }

        //Aplicando Level
        _currentLevel = _level1;

        //Anexando o texto inicial
        InitialDialog();
    }

    private void Start()
    {
        //Habilitando os comandos do jogador.
        Game.input.NormalPlayerEnable();
        Game.input.PausePlayerEnable();

        Game.transition.PlayAnimationOpening();
    }

    private void OnDestroy()
    {
        //Habilitando os comandos do jogador.
        Game.input.NormalPlayerDisable();
        Game.input.PausePlayerDisable();

        Game.manager.controllerScene = null;
    }

    public void ExecuteAction() => _currentLevel.Execute();

    public void GameOver()
    {
        Game.input.NormalPlayerDisable();
        Game.input.PausePlayerDisable();

        inGameTransition.PlayAnimationTransitionGameOver();
    }

    public void NextDay() => inGameTransition.PlayAnimationTransitionDay();

    public void ChangeLevel()
    {
        _newLevelValue++;

        switch (_newLevelValue)
        {
            case 1:
                _currentLevel = _level2;
                break;
            case 2:
                _currentLevel = _level3;
                break;
            case 3:
                _currentLevel = _level4;
                break;
            case 4:
                _currentLevel = _level5;
                break;
            case 5:
                _currentLevel = _level6;
                break;
            case 6:
                _currentLevel = _level7;
                break;
        }
    }
}
