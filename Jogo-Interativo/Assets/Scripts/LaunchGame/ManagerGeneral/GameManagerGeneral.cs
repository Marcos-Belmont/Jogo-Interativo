using UnityEngine;

public partial class GameManagerGeneral : MonoBehaviour
{
    //Serve para verificar se os Game Objects em jogo já foram instanciados ou não.
    [HideInInspector] public bool instantiatedObjectsInGame = false;

    //Serve para verificar se o jogador já clicou no botão play, na seção de jogo atual. O objetivo é de habilitar a animação de transição de scenes
    [HideInInspector] public bool isPlay = false;

    private void Awake() => DontDestroyOnLoad(gameObject); //Torna o game object indestrutível
}