using UnityEngine;
using UnityEngine.UI;

public class ButtonsPerson : MonoBehaviour
{
    [Space(10)]
    [Tooltip("Anexe uma imagem dos botões das pessoas, para evitar conflito.")]
    [SerializeField] Image oldImage;

    [SerializeField] private Image[] image;

    [Space(10)]
    [Tooltip("A primeira cor é referente ao botão não pressionado, a segunda cor é referente ao botão pressionado")]
    [SerializeField] private Color32[] color;

    //Index 0 = Carlos Henrique
    //Index 1 = Joaquim Silva
    //Index 2 = Amanda Soares
    //Index 3 = Heitor Farias
    //Index 4 = Bernado Costa
    //Index 5 = Monica Santana
    public void SelectPerson(int personID)
    {
        oldImage.color = color[0]; //Devolvendo a cor original ao botão antigo
        image[personID].color = color[1]; //Anexando a nova cor ao botão novo
        oldImage = image[personID]; //Armazenando o novo botão, como o botão antigo

        Game.manager.controllerScene.chatText.text = Game.manager.controllerScene.personText[personID];
    }
}
