using UnityEngine;
using UnityEngine.SceneManagement;

//Esta classe será responsável pela transição de scenes, como aplicar a tela de carregamento e afins.
public class GameTransition : MonoBehaviour
{
    private readonly int _TRANSITION_SCENE = Animator.StringToHash("transitionScene");

    [SerializeField] Animator _animator;
    [SerializeField] GameObject _canvasTransitionGO;

    [HideInInspector] public byte targetScene = 0;

    private void Awake() => DontDestroyOnLoad(gameObject); //Torna o game object indestrutível

    public void PlayAnimationOpening() => _animator.SetBool(_TRANSITION_SCENE, false);

    public void PlayAnimationClosing() => _animator.SetBool(_TRANSITION_SCENE,true);

    //Metodo que altera os cenarios.
    public void ChangeScene() => SceneManager.LoadScene(targetScene);

    //Determina a visibilidade do Canvas
    public void SetVisibility(int state) => _canvasTransitionGO.SetActive(state == 1 ? true : false);
}
