using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour
{
    [HideInInspector] public GameObject menuInGame; //Pega o gameobject do canvas do Menu In Game.

    private PlayerInputActions playerInputActions; //Variável responsável pelo mapeamento dos inputs.

    private void Awake()
    {
        DontDestroyOnLoad(gameObject); //Torna o game object indestrutível

        //Instancia os input actions do Player
        playerInputActions = new PlayerInputActions();
    }

    #region METODOS DE CHECAGEM DO SCRIPT

    #region REFERENTE A ATIVACAO DOS COMANDOS DO NORMALPLAYER
    public void NormalPlayerEnable()
    {
        //Ativando o mapeamento dos inputs
        playerInputActions.NormalPlayer.Enable();

        NormalPlayerInteractEnable();
    }

    public void NormalPlayerInteractEnable()
    {
        //Ativando inputs de interacao
        playerInputActions.NormalPlayer.Interact.started += OnInteract;
    }
    #endregion

    #region REFERENTE A DESATIVACAO DOS COMANDOS DO NORMALPLAYER
    public void NormalPlayerDisable()
    {
        NormalPlayerInteractDisable();

        //Desativando o mapeamento dos inputs
        playerInputActions.NormalPlayer.Disable();
    }

    public void NormalPlayerInteractDisable()
    {
        //Desativando inputs de interacao
        playerInputActions.NormalPlayer.Interact.started -= OnInteract;
    }
    #endregion

    #region REFERENTE AO PAUSE DO PLAYER EM JOGO
    public void PausePlayerEnable()
    {
        playerInputActions.PausePlayer.Enable();
        playerInputActions.PausePlayer.Pause.started += OnPause;
    }
    public void PausePlayerDisable()
    {
        playerInputActions.PausePlayer.Pause.started -= OnPause;
        playerInputActions.PausePlayer.Disable();
    }
    #endregion

    #endregion

    #region METODOS DOS INPUTS

    private void OnInteract(InputAction.CallbackContext context)
    {
        //Game.manager.player.Interact();
        Debug.Log("Interagiu");
    }

    private void OnPause(InputAction.CallbackContext context)
    {
        try { if (menuInGame != null) menuInGame.SetActive(true); } catch (System.NullReferenceException) { Debug.Log("Pause falhou!"); }
    }

    #endregion
}