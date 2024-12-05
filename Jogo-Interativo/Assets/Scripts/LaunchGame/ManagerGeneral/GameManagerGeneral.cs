using UnityEngine;

public partial class GameManagerGeneral : MonoBehaviour
{
    //Serve para verificar se os Game Objects em jogo j� foram instanciados ou n�o.
    [HideInInspector]public bool instantiatedObjectsInGame = false;

    private void Awake() => DontDestroyOnLoad(gameObject); //Torna o game object indestrut�vel
}
