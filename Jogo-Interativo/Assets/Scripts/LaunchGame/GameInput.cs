using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour
{
    private PlayerInputActions playerInputActions; //Variável responsável pelo mapeamento dos inputs.

    private void Awake()
    {
        DontDestroyOnLoad(gameObject); //Torna o game object indestrutível

        //Instancia os input actions do Player
        playerInputActions = new PlayerInputActions();
    }

    #region METODOS DE CHECAGEM DO SCRIPT

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

    private void OnPause(InputAction.CallbackContext context) => Game.manager.menuInGame.CanvasGO.SetActive(true);

    #endregion
}