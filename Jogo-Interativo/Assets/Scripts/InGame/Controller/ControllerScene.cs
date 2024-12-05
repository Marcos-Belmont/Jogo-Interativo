using UnityEngine;

public class ControllerScene : MonoBehaviour
{
    [Header("Prefabs")]
    [Tooltip("Anexe o prefab do MenuInGame aqui.")]
    [SerializeField] GameObject pauseMenu;

    void Awake()
    {
        if (Game.manager.instantiatedObjectsInGame == false)
        {
            Game.manager.instantiatedObjectsInGame = true;
            Instantiate(pauseMenu);
        }
    }

    private void Start()
    {
        //Habilitando os comandos do jogador.
        Game.input.NormalPlayerEnable();
        Game.input.PausePlayerEnable();
    }
}
