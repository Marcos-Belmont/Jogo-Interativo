using UnityEngine;

public partial class GameManagerGeneral : MonoBehaviour
{
    //Serve para verificar se os Game Objects em jogo já foram instanciados ou não.
    [HideInInspector]public bool instantiatedObjectsInGame = false;

    private void Awake() => DontDestroyOnLoad(gameObject); //Torna o game object indestrutível
}
