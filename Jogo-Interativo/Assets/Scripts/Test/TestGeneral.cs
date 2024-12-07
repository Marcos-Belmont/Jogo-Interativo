using UnityEngine;

//Na ordem de execução de scripts, esta classe terá a prioridade máxima.
//Foi aplicado desta maneira, para impedir conflitos.
public class TestGeneral : MonoBehaviour
{
#if UNITY_EDITOR
    [HideInInspector] public TestGeneral testGeneral;

    [Header("Prefabs")]
    [Tooltip("Anexe aqui o prefab 'Game', para que possa ser intanciado todos os Game Objects necessários.")]
    [SerializeField] private GameObject game;

    [Header("Level")]
    [Tooltip("Quando ativo, permite testar em que level começa")]
    public bool testLevel;
    [Tooltip("Determina em que level começará o jogo")]
    [Range(1,7)]
    public byte targetLevel;


    private void Awake()
    {
        testGeneral = this;

        //Instanciando todas as configurações do jogo.
        if (Game.instantiated == false)
        {
            Game.instantiated = true;
            Instantiate(game);
        }

        //Serve para validar a troca de animações das transições.
        Game.manager.isPlay = true;
    }
#endif
}
