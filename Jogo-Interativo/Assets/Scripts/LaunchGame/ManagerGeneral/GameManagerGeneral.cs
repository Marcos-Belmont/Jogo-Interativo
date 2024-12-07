using UnityEngine;

public partial class GameManagerGeneral : MonoBehaviour
{
    //Serve para verificar se os Game Objects em jogo j� foram instanciados ou n�o.
    [HideInInspector] public bool instantiatedObjectsInGame = false;

    //Serve para verificar se o jogador j� clicou no bot�o play, na se��o de jogo atual. O objetivo � de habilitar a anima��o de transi��o de scenes
    [HideInInspector] public bool isPlay = false;

    private void Awake() => DontDestroyOnLoad(gameObject); //Torna o game object indestrut�vel
}