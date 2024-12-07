using UnityEngine;
using UnityEngine.UI;

public class InGameTransition : MonoBehaviour
{
    private readonly int _IN_GAME_TRANSITION_DAY = Animator.StringToHash("In-Game-Transition-Day");
    private readonly int _IN_GAME_TRANSITION_GAME_OVER = Animator.StringToHash("In-Game-Transition-Game-Over");

    public Text TransitionText;

    [SerializeField] private GameObject _canvasGameOverGO;
    [SerializeField] private Animator _animator;

    public void PlayAnimationTransitionDay() => _animator.Play(_IN_GAME_TRANSITION_DAY);

    public void PlayAnimationTransitionGameOver() => _animator.Play(_IN_GAME_TRANSITION_GAME_OVER);

    public void PlayAnimationTransitionChangeScene()
    {
        _canvasGameOverGO.SetActive(true);
        Game.transition.targetScene = 0;
        Game.transition.PlayAnimationClosing();
    }
}
