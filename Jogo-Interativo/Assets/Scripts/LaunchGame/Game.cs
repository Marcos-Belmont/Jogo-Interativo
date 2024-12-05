using UnityEngine;

// Adiciona este script como prioriadade após o 'GeneralTest'.
// Isso vai garantir que este script, mesmo sendo chamado no mesmo metodo, será chamado primeiro que os outros.
public class Game : MonoBehaviour
{
    //Serve para verificar se essa classe já foi instanciada.
    public static bool instantiated = false;

    //Scripts de outras classes.
    public static GameSave save;
    public static GameManagerGeneral manager;
    public static GameConfiguration config;
    public static GameCamera cam;
    public static GameTransition transition;
    public static GameInput input;

    //Game Objects dos scripts.
    [SerializeField] GameObject gameObjectSave;
    [SerializeField] GameObject gameObjectManagerGeneral;
    [SerializeField] GameObject gameObjectConfiguration;
    [SerializeField] GameObject gameObjectCamera;
    [SerializeField] GameObject gameObjectTransition;
    [SerializeField] GameObject gameObjectInput;

    private void Awake()
    {
        //Torna o game object indestrutível
        DontDestroyOnLoad(gameObject);

        //Cria o Game Object do Save e instancia a sua classe
        GameObject getObject = Instantiate(gameObjectSave);
        save = getObject.GetComponent<GameSave>();

        //Pega o salvamento de tudo
        save.GetAllSaves();

        //Cria o Game Object do Manager General e instancia a sua classe
        getObject = Instantiate(gameObjectManagerGeneral);
        manager = getObject.GetComponent<GameManagerGeneral>();

        //Cria o Game Object de Configuration e instancia a sua classe
        getObject = Instantiate(gameObjectConfiguration);
        config = getObject.GetComponent<GameConfiguration>();

        //Cria o Game Object da Camera e instancia a sua classe
        getObject = Instantiate(gameObjectCamera);
        cam = getObject.GetComponent<GameCamera>();

        //Cria o Game Object de Transition e instancia a sua classe
        getObject = Instantiate(gameObjectTransition);
        transition = getObject.GetComponent<GameTransition>();

        //Cria o Game Object do Input e instancia a sua classe
        getObject = Instantiate(gameObjectInput);
        input = getObject.GetComponent<GameInput>();
    }
}
