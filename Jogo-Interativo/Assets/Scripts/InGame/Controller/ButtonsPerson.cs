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

    public void SelectPerson(int personID)
    {
        oldImage.color = color[0]; //Devolvendo a cor original ao botão antigo
        image[personID].color = color[1]; //Anexando a nova cor ao botão novo
        oldImage = image[personID]; //Armazenando o novo botão, como o botão antigo
    }
}
