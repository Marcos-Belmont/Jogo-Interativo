using UnityEngine;

public class ButtonChoice : MonoBehaviour
{
    [Space(10)]
    [Tooltip("Anexe o Game Object 'Canvas-Choice', que est� dentro do Game Object 'Choice'.")]
    [SerializeField] GameObject CanvasChoiceGO;

    [Space(10)]
    [Tooltip("Anexe o Audio Source do Game Object, aqui.")]
    [SerializeField] AudioSource audioSource;

    public void Choice(int option)
    {
        audioSource.Play();

        //0 == Op��o A == true
        //1 == Op��o B == false
        Game.manager.controllerScene.ExecuteChoice(option == 0);

        Game.manager.controllerScene.ExecuteActionLevel();
        CanvasChoiceGO.SetActive(false);
    }
}
