public partial class ControllerScene
{
    //Index 0 = Carlos Henrique
    //Index 1 = Joaquim Silva
    //Index 2 = Amanda Soares
    //Index 3 = Heitor Farias
    //Index 4 = Bernado Costa
    //Index 5 = Monica Santana

    public void CarlosHenrique(string text)
    {
        personText[0] += text;
        chatText.text = personText[0];
        buttonPerson.SelectPerson(0);
    }

    public void JoaquimSilva(string text)
    {
        personText[1] += text;
        chatText.text = personText[1];
        buttonPerson.SelectPerson(1);
    }

    public void AmandaSoares(string text)
    {
        personText[2] += text;
        chatText.text = personText[2];
        buttonPerson.SelectPerson(2);
    }

    public void HeitorFarias(string text)
    {
        personText[3] += text;
        chatText.text = personText[3];
        buttonPerson.SelectPerson(3);
    }

    public void BernadoCosta(string text)
    {
        personText[4] += text;
        chatText.text = personText[4];
        buttonPerson.SelectPerson(4);
    }

    public void MonicaSantana(string text)
    {
        personText[5] += text;
        chatText.text = personText[5];
        buttonPerson.SelectPerson(5);
    }
}
