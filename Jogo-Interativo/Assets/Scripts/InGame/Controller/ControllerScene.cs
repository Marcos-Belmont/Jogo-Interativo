using UnityEngine;
using UnityEngine.UI;

public class ControllerScene : MonoBehaviour
{
    [Header("Prefabs")]
    [Tooltip("Anexe o prefab do MenuInGame aqui.")]
    [SerializeField] GameObject _menuInGame;

    [Header("Game Objects")]
    [Tooltip("Anexe o Game Object 'Canvas-Choice', que está dentro do Game Object 'Choice'.")]
    [SerializeField] GameObject CanvasChoiceGO;

    [Header("Text")]
    [Tooltip("Associe o Texto do Game Object 'Content' aqui, que está dentro de 'Canvas-Chat'.")]
    public Text chatText;
    [Tooltip("Associe o Texto do Game Object 'Text-Troop' aqui, que está dentro de 'Canvas-Troop'.")]
    public Text troopText;
    [Tooltip("Associe o Texto do Game Object 'Text-Interact' aqui, que está dentro de 'Canvas-Interact'.")]
    public Text interactText;
    public Text carlosHenriqueButtonText;
    public Text joaquimSilvaButtonText;
    public Text amandaSoaresButtonText;
    public Text heitorFariasButtonText;
    public Text bernadoCostaButtonText;
    public Text monicaSantanaButtonText;
    [HideInInspector] public string carlosHenriqueText;
    [HideInInspector] public string joaquimSilvaText;
    [HideInInspector] public string amandaSoaresText;
    [HideInInspector] public string heitorFariasText;
    [HideInInspector] public string bernadoCostaText;
    [HideInInspector] public string monicaSantanaText;


    [HideInInspector] public byte troopValue = 30;
    private byte _newLevelValue = 0;

    [Header("Levels")]
    [SerializeField] private Level1 _level1;
    [SerializeField] private Level2 _level2;
    [SerializeField] private Level3 _level3;
    [SerializeField] private Level4 _level4;
    [SerializeField] private Level5 _level5;
    [SerializeField] private Level6 _level6;
    [SerializeField] private Level7 _level7;
    private ILevel _currentLevel;

    private void Awake()
    {
        //Serve para gerar intancia dos Game Objects
        if (Game.manager.instantiatedObjectsInGame == false)
        {
            Game.manager.instantiatedObjectsInGame = true;
            Instantiate(_menuInGame);
        }

        //Aplicando Level
        _currentLevel = _level1;
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
    }

    public void ExecuteAction()
    {
        _currentLevel.Execute();
    }

    public void GameOver()
    {
        Game.input.NormalPlayerDisable();
        Game.input.PausePlayerDisable();

        Game.transition.targetScene = 0;
        Game.transition.PlayAnimationClosing();
    }

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
