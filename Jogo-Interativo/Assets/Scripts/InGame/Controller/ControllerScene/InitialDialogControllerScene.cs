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
        personText[0] = "Carlos Henrique -> Eai, Jão Da Santindade! Já faz uns 7 dias desde aquele dia de bosta, que os separatistas vieram e arrasaram as nossas terras. Bando" +
            " de cretinos!" +
            "\n\nCarlos Henrique -> Mas conta ai, como é que estão indo as coisas neste cubículo aquático? Eu nem acredito que tu, um comandante brabo, prefiriu se arriscar nessa " +
            "casquinha de nada ai, nem arma esse treco tem. Pra mim tu tem uns parafusos a menos" +
            "" +
            "\n\n<Color=#28AB3C>João Santana -> Hahah, cada dia mais eu me arrependo de estar aqui, mas pelo menos dá pra viver bem aqui." +
            "" +
            "\n\nJoão Santana -> Desde aquele dia tudo tem sido uma grande bosta. Mas eu gosto de pensar que o importante que mesmo que a gente enha perdido tudo, o importante " +
            "é que estamos juntos daqueles que nós amamos, e eles estão bem." +
            "" +
            "\n\nJoão Santana -> No dia 4 de fevereiro, a gente já deve chegar na região da Aliança, e depois podemos descansar deste transtorno todo e recomeçar.</Color>" +
            "" +
            "\n\nCarlos Henrique -> É, tá certo, prefiro ver por essa visão positiva também.";
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
        personText[5] = "Mônica Santana ->";
    }
}
