using UnityEngine;

public class ButtonInteract : MonoBehaviour
{
    [SerializeField] private ControllerScene controller;

    public void Interact() => controller.ExecuteAction();
}