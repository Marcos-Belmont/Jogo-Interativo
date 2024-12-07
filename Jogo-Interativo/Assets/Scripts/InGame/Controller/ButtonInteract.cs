using UnityEngine;

public class ButtonInteract : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    public void Interact()
    {
        Game.manager.controllerScene.ExecuteAction();
        audioSource.Play();
    }
}