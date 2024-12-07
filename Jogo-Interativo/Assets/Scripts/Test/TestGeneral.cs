using UnityEngine;

//Na ordem de execu��o de scripts, esta classe ter� a prioridade m�xima.
//Foi aplicado desta maneira, para impedir conflitos.
public class TestGeneral : MonoBehaviour
{

#if UNITY_EDITOR
    [SerializeField] private GameObject game;

    private void Awake()
    {
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
