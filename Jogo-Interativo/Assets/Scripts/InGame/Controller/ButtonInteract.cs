using UnityEngine;

public class ButtonInteract : MonoBehaviour
{
    [Space(10)]
    [Tooltip("Anexe o Audio Source do Game Object, aqui.")]
    [SerializeField] AudioSource audioSource;

    public void Interact()
    {
        Game.manager.controllerScene.ExecuteActionLevel();
        audioSource.Play();
    }
}