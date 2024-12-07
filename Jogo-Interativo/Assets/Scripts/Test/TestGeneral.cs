using UnityEngine;

//Na ordem de execu��o de scripts, esta classe ter� a prioridade m�xima.
//Foi aplicado desta maneira, para impedir conflitos.
public class TestGeneral : MonoBehaviour
{
#if UNITY_EDITOR
    [HideInInspector] public TestGeneral testGeneral;

    [Header("Prefabs")]
    [Tooltip("Anexe aqui o prefab 'Game', para que possa ser intanciado todos os Game Objects necess�rios.")]
    [SerializeField] private GameObject game;

    [Header("Level")]
    [Tooltip("Quando ativo, permite testar em que level come�a")]
    public bool testLevel;
    [Tooltip("Determina em que level come�ar� o jogo")]
    [Range(1,7)]
    public byte targetLevel;


    private void Awake()
    {
        testGeneral = this;

        //Instanciando todas as configura��es do jogo.
        if (Game.instantiated == false)
        {
            Game.instantiated = true;
            Instantiate(game);
        }

        //Serve para validar a troca de anima��es das transi��es.
        Game.manager.isPlay = true;
    }
#endif
}
