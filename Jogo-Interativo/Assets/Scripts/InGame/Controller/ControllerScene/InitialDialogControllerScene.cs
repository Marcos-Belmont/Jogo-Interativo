public partial class ControllerScene
{
    private void InitialDialog()
    {
        interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE CARLOS HENRIQUE";

        CarlosHenrique();
        JoaquimSilva();
        AmandaSoares();
        HeitorFarias();
        BernadoCosta();
        MonicaSantana();
    }

    private void CarlosHenrique()
    {
        personText[0] = "Carlos Henrique -> Eai, J�o Da Santindade! J� faz uns 7 dias desde aquele dia de bosta, que os separatistas vieram e arrasaram as nossas terras. Bando" +
            " de cretinos!" +
            "\n\nCarlos Henrique -> Mas conta ai, como � que est�o indo as coisas neste cub�culo aqu�tico? Eu nem acredito que tu, um comandante brabo, prefiriu se arriscar nessa " +
            "casquinha de nada ai, nem arma esse treco tem. Pra mim tu tem uns parafusos a menos" +
            "" +
            "\n\n<Color=#28AB3C>Jo�o Santana -> Hahah, cada dia mais eu me arrependo de estar aqui, mas pelo menos d� pra viver bem aqui." +
            "" +
            "\n\nJo�o Santana -> Desde aquele dia tudo tem sido uma grande bosta. Mas eu gosto de pensar que o importante que mesmo que a gente enha perdido tudo, o importante " +
            "� que estamos juntos daqueles que n�s amamos, e eles est�o bem." +
            "" +
            "\n\nJo�o Santana -> No dia 4 de fevereiro, a gente j� deve chegar na regi�o da Alian�a, e depois podemos descansar deste transtorno todo e recome�ar.</Color>" +
            "" +
            "\n\nCarlos Henrique -> �, t� certo, prefiro ver por essa vis�o positiva tamb�m.";
    }

    private void JoaquimSilva()
    {
        personText[1] = "Joaquim Silva -> ";
    }

    private void AmandaSoares()
    {
        personText[2] = "Amanda Soares -> ";
    }

    private void HeitorFarias()
    {
        personText[3] = "Heitor Farias -> ";
    }

    private void BernadoCosta()
    {
        personText[4] = "Bernado Costa -> ";
    }

    private void MonicaSantana()
    {
        personText[5] = "M�nica Santana ->";
    }
}
