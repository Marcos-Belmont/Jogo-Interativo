using UnityEngine;

//Na ordem de execução de scripts, esta classe terá a prioridade máxima.
//Foi aplicado desta maneira, para impedir conflitos.
public class TestGeneral : MonoBehaviour
{
#if UNITY_EDITOR
    [HideInInspector] public static TestGeneral instance;

    [Header("Prefabs")]
    [Tooltip("Anexe aqui o prefab 'Game', para que possa ser intanciado todos os Game Objects necessários.")]
    [SerializeField] private GameObject game;

    [Header("Level")]
    [Tooltip("Quando ativo, permite testar em que level começa.")]
    public bool testLevel;
    [Tooltip("Determina em que level começará o jogo.")]
    [Range(2,7)]
    public byte targetLevel;
    [Tooltip("Serve para determinar as escolhas. Coloque a mesma quantidade, ou mais, de escolhas que existe no 'ControllerScene'.")]
    public bool[] choice;

    private void Awake()
    {
        instance = this;

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
