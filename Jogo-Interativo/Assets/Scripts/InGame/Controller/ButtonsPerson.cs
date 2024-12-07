using UnityEngine;
using UnityEngine.UI;

public class ButtonsPerson : MonoBehaviour
{
    [Space(10)]
    [Tooltip("Anexe uma imagem dos bot�es das pessoas, para evitar conflito.")]
    [SerializeField] Image oldImage;

    [SerializeField] private Image[] image;

    [Space(10)]
    [Tooltip("A primeira cor � referente ao bot�o n�o pressionado, a segunda cor � referente ao bot�o pressionado")]
    [SerializeField] private Color32[] color;

    public void SelectPerson(int personID)
    {
        oldImage.color = color[0]; //Devolvendo a cor original ao bot�o antigo
        image[personID].color = color[1]; //Anexando a nova cor ao bot�o novo
        oldImage = image[personID]; //Armazenando o novo bot�o, como o bot�o antigo
    }
}
