using UnityEngine;

//Na ordem de execução de scripts, esta classe terá a prioridade máxima.
//Foi aplicado desta maneira, para impedir conflitos.
public class TestGeneral : MonoBehaviour
{

#if UNITY_EDITOR
    [SerializeField] private GameObject game;

    private void Awake()
    {
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
