using TMPro;
using UnityEngine;
using UnityEngine.UI;

public partial class ControllerScene : MonoBehaviour
{
    [Header("Prefabs")]
    [Tooltip("Anexe o prefab do MenuInGame aqui.")]
    [SerializeField] GameObject _menuInGame;

    [Header("Game Objects")]
    [Tooltip("Anexe o Game Object 'Canvas-Choice', que está dentro do Game Object 'Choice'. " +
        "Serve para possibilitar de o jogador realizar uma escolha dentro do jogo quando ativo este Game Object.")]
    public GameObject CanvasChoiceGO;

    [Header("Text")]
    [Tooltip("Associe o Texto do Game Object 'Content' aqui, que está dentro de 'Canvas-Chat'.")]
    public TextMeshProUGUI chatText;
    [Tooltip("Associe o Texto do Game Object 'Text-Troop' aqui, que está dentro de 'Canvas-Troop'.")]
    public Text fleetText;
    [Tooltip("Associe o Texto do Game Object 'Text-Interact' aqui, que está dentro de 'Canvas-Interact'.")]
    public Text dateText;
    [Tooltip("Associe o Texto do Game Object 'Text-Title-Choice' aqui, que está dentro do Game Object 'Choice'.")]
    [SerializeField] Text _titleChoiceText;
    [Tooltip("Associe o Texto do Game Object 'Text-Option-A-Choice' aqui, que está dentro do Game Object 'Choice'.")]
    [SerializeField] Text _OptionAChoiceText;
    [Tooltip("Associe o Texto do Game Object 'Text-Option-B-Choice' aqui, que está dentro do Game Object 'Choice'.")]
    [SerializeField] Text _OptionBChoiceText;
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
    [HideInInspector] public byte fleetValue = 30;
    private byte _newLevelValue = 1;

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

#if UNITY_EDITOR
        //Aplicando ferramenta de teste para começar em determinado dia
        if (TestGeneral.instance.testLevel == true)
        {
            Debug.Log("Testando o level. Começando a partir do level: " + TestGeneral.instance.targetLevel);

            for (byte i = 0; i < choice.Length; i++)
            {
                choice[i] = TestGeneral.instance.choice[i];
            }

            while(_newLevelValue < TestGeneral.instance.targetLevel)
            {
                ExecuteActionLevel();
            }

            TestGeneral.instance.testLevel = false;
        }
#endif
    }

    private void Start()
    {
        //Habilitando os comandos do jogador.
        Game.input.PausePlayerEnable();

        Game.transition.PlayAnimationOpening();
    }

    private void OnDestroy()
    {
        //Habilitando os comandos do jogador.
        Game.input.PausePlayerDisable();

        Game.manager.controllerScene = null;
    }

    public void ExecuteActionLevel() => _currentLevel.Execute();

    public void GameOver()
    {
        Game.input.PausePlayerDisable();

        inGameTransition.PlayAnimationTransitionGameOver();
    }

    public void NextDay() => inGameTransition.PlayAnimationTransitionDay();

    public void ChangeLevel()
    {
        _newLevelValue++;

        switch (_newLevelValue)
        {
            case 2:
                _currentLevel = _level2;

                dateText.text = "10/11/5281\n------------------\n11:00";
                inGameTransition.TransitionText.text = "DIA 21";
                interactText.text = "CLIQUE PARA ENVIAR UMA MENSAGEM PARA HEITOR FARIAS";
                break;
            case 3:
                _currentLevel = _level3;

                dateText.text = "19/11/5281\n------------------\n15:00";
                inGameTransition.TransitionText.text = "DIA 30";
                interactText.text = "CLIQUE PARA ENVIAR UMA MENSAGEM PARA CARLOS HENRIQUE";
                break;
            case 4:
                _currentLevel = _level4;

                dateText.text = "19/12/5281\n------------------\n07:00";
                inGameTransition.TransitionText.text = "DIA 60";
                interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE HEITOR FARIAS";
                break;
            case 5:
                _currentLevel = _level5;

                dateText.text = "30/12/5281\n------------------\n03:00";
                inGameTransition.TransitionText.text = "DIA 71";
                interactText.text = "CLIQUE PARA ENVIAR UMA MENSAGEM PARA HEITOR FARIAS";
                break;
            case 6:
                _currentLevel = _level6;

                dateText.text = "24/01/5282\n------------------\n21:15";
                inGameTransition.TransitionText.text = "DIA 95";
                interactText.text = "CLIQUE PARA ENVIAR UMA MENSAGEM PARA HEITOR FARIAS";
                break;
            case 7:
                _currentLevel = _level7;

                dateText.text = "03/02/5282\n------------------\n14:44";
                inGameTransition.TransitionText.text = "DIA 105";
                interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE AMANDA SOARES";
                break;
        }
    }
}
