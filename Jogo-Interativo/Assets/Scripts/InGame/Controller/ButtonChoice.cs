using UnityEngine;

public class ButtonChoice : MonoBehaviour
{
    [Space(10)]
    [Tooltip("Anexe o Game Object 'Canvas-Choice', que está dentro do Game Object 'Choice'.")]
    [SerializeField] GameObject CanvasChoiceGO;

    [Space(10)]
    [Tooltip("Anexe o Audio Source do Game Object, aqui.")]
    [SerializeField] AudioSource audioSource;

    public void Choice(int option)
    {
        audioSource.Play();

        //0 == Opção A == true
        //1 == Opção B == false
        Game.manager.controllerScene.ExecuteChoice(option == 0);

        Game.manager.controllerScene.ExecuteActionLevel();
        CanvasChoiceGO.SetActive(false);
    }
}
