using UnityEngine;

public partial class ControllerScene
{
    private byte _currentChoice = 0;

    [Header("Escolhas")]
    [Tooltip("Determina a quantidade de escolhas que terá aqui.")]
    public bool[] choice;
    //Index 0 = Conversa normal (Sem impacto para a história no futuro)
    //Index 1 = Sobre o casamento de Carlos Henrique
    //Index 2 = Infiltrado no submarino
    //Index 3 = Conflito com submarinos rivais
    //Index 4 = Consequencias do infiltrado, seria em relação a conversa com Amanda Soares (Com impacto de como Amanda lida com a vida)
    //Index 5 = Sobre a escolha de fugir ou se esconder de submarinos inimigos

    public void ExecuteChoice(bool choice)
    {
        this.choice[_currentChoice] = choice;
        _currentChoice++;
    }

    public void ChangeChoiceText(string Title, string optionA, string optionB)
    {
        _titleChoiceText.text = Title;
        _OptionAChoiceText.text = optionA;
        _OptionBChoiceText.text = optionB;
    }

    //Serve para gerar o menu de escolha para o player
    public void GenerateChoice()
    {
#if UNITY_EDITOR
        if (TestGeneral.instance.testLevel == true && _currentChoice < TestGeneral.instance.targetLevel)
            _currentChoice++;
        if (TestGeneral.instance.testLevel == false)
#endif
            CanvasChoiceGO.SetActive(true);
    }
}
