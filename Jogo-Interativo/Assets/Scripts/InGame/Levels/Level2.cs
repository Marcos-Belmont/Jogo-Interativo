using UnityEngine;

public class Level2 : MonoBehaviour, ILevel
{
    private byte _stage = 0;

    public void Execute()
    {
        switch (_stage)
        {
            case 0:
                Game.manager.controllerScene.HeitorFarias("\n\n<Color=#28AB3C>João Santana -> Relatório, Farias!</Color>");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:00";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A RESPOSTA DE HEITOR FARIAS";

                break;

            case 1:

                Game.manager.controllerScene.HeitorFarias("\n\nHeitor Farias -> Tá tudo tranquilo, chefia. Nenhuma anomalia dectada, pode prosseguir com o descanso.");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:02";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER A MENSAGEM DE HEITOR FARIAS";

                break;

            case 2:
                Game.manager.controllerScene.HeitorFarias("\n\n<Color=#28AB3C>João Santana -> Entendido!</Color>");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:03";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA ENVIAR UMA MENSAGEM PARA AMANDA SOARES";
                break;

            case 3:
                Game.manager.controllerScene.AmandaSoares("\n\n<Color=#28AB3C>João Santana -> Amandinha, relatório!</Color>");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:04";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE AMANDA SOARES";
                break;

            case 4:
                Game.manager.controllerScene.AmandaSoares("\n\nAmanda Soares -> Desculpe a demora, senhor! Estava resolvendo um problema com um cara que caiu e " +
                    "ficou preso no vaso.");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:27";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA ENVIAR UMA MENSASEM PARA AMANDA SOARES";
                break;

            case 5:
                Game.manager.controllerScene.AmandaSoares("\n\n<Color=#28AB3C>João Santana -> Como a pessoa consegue ficar presa no vaso?</Color>");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:28";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE AMANDA SOARES";
                break;

            case 6:
                Game.manager.controllerScene.AmandaSoares("\n\nAmanda Soares -> Então, deixa eu te contar, menino.");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:28";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE AMANDA SOARES";
                break;

            case 7:
                Game.manager.controllerScene.AmandaSoares("\n\nAmanda Soares -> Lá estava eu, toda estabanada andando pelo corredor, ai eu fui conversar com o Maicon.");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:29";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE AMANDA SOARES";
                break;

            case 8:
                Game.manager.controllerScene.AmandaSoares("\n\nAmanda Soares -> Ele tava me contando umas mó doideiras de física, que te falar, eu não entendi " +
                    "bulufias nenhuma.");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:29";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE AMANDA SOARES";
                break;

            case 9:
                Game.manager.controllerScene.AmandaSoares("\n\nAmanda Soares -> Aii depois veio a Dani que se entrometeu na conversa, toda abusadona. Mas eu relevei, devido a " +
                    "ela vir com uns babados do Jeremias.");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:30";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE AMANDA SOARES";
                break;

            case 10:
                Game.manager.controllerScene.AmandaSoares("\n\nAmanda Soares -> Que olha, deixa eu te contar!");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:30";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER A MENSASEM DE AMANDA SOARES";
                break;

            case 11:
                Game.manager.controllerScene.AmandaSoares("\n\n<Color=#28AB3C>João Santana -> Amanda, chega, foco! Me manda um relatório.</Color>");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:30";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE AMANDA SOARES";
                break;

            case 12:
                Game.manager.controllerScene.AmandaSoares("\n\nAmanda Santana -> Ahh sim, foi mal senhor!");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:31";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE AMANDA SOARES";
                break;

            case 13:
                Game.manager.controllerScene.AmandaSoares("\n\nAmanda Santana -> Bomm, não tenho nada a relatar. Exceto por um barulho no casco de um dos submarinos, pelo " +
                    "que eu fui informada. Mas eu acho que não deve ter nenhum problema nisso.");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:31";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER A MENSASEM DE AMANDA SOARES";
                break;

            case 14:
                Game.manager.controllerScene.AmandaSoares("\n\n<Color=#28AB3C>João Santana -> Entendi, pode descansar!</Color>");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:32";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE AMANDA SOARES";
                break;

            case 15:
                Game.manager.controllerScene.AmandaSoares("\n\nAmanda Santana -> Sim, senhor!");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:32";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE CARLOS HENRIQUE";
                break;

            case 16:
                Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Eai, Jão! Olha tu sabe que é o meu amigo, e por isso eu queria a sua opinião sobre um " +
                    "assunto...");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n12:51";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER A MENSASEM DE CARLOS HENRIQUE";
                break;

            case 17:
                Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>João Santana -> Diga, meu camarada, e não me esconda nada!</Color>");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n12:54";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE CARLOS HENRIQUE";
                break;

            case 18:
                Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> KK Entãooo, você sabe que eu e a Maria estamos namorando faz 3 anos né...?");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n12:54";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER A MENSASEM DE CARLOS HENRIQUE";
                break;

            case 19:
                Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>João Santana -> Tô ligado sim, menor! Bastante tempo até né?</Color>");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n12:55";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER MENSASEM DE CARLOS HENRIQUE";
                break;

            case 20:
                Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Sim kk. Pohh, eu gostaria de saber se seria uma boa ideia pedir ela em " +
                    "casamento amanhã? Eu sei que a situação não é muito boa, mas eu acho que todo momento, é um momento para demonstrar amor, e eu queria demonstrar da melhor forma " +
                    "possível pedindo ela em casamento.");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n12:56";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE CARLOS HENRIQUE";
                break;

            case 21:
                Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> E ai, o que você me diz, irmão?");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n12:56";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA ESCOLHER A MELHOR RESPOSTA PARA CARLOS HENRIQUE";
                break;

            case 22:
                Game.manager.controllerScene.ChangeText("Aconselhe Carlos, Sobre O Pedido De Casamento",
                    "Concordar em fazer o pedido de casamento amanhã!", "Não concordar, falar para ele fazer o pedido quando estiver em solo firme e seguro.");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n12:59";

                Game.manager.controllerScene.GenerateChoice(); //Aplica o menu de escolha
                break;

            case 23:
                if (Game.manager.controllerScene.choice[1] == true)
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>João Santana -> Cara, só segue o seu coração e vai na fé. Você tem o meu total " +
                        "apoio! Duvido nada que vocês serão o casal do ano!</Color>");
                }
                else
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>João Santana -> Caara, eu acho melhor esperar. A situação atual é muito estressante, " +
                        "eu acho melhor pedir ela em casamento quando estiver em solo firme, em segurança. Vocês vão poder aproveitar o momento melhor.</Color>");
                }

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n12:59";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE CARLOS HENRIQUE";
                break;

            case 24:
                if (Game.manager.controllerScene.choice[1] == true)
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Pohh cara, muito obrigado pela sua bença! Amanhã eu vou meter bronca! Heheh");
                }
                else
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Faz total sentido, valeu pela orientação cara. Vou aguardar até lá!");
                }

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n13:01";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER A MENSASEM DE CARLOS HENRIQUE";
                break;

            case 25:

                Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>João Santana -> Disponha, cara!</Color>");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n13:01";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE MÔNICA SANTANA";
                break;

            case 26:

                Game.manager.controllerScene.MonicaSantana("\n\nMônica Santana -> Vivo?");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n22:29";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER A MENSASEM DE MÔNICA SANTANA";
                break;

            case 27:

                Game.manager.controllerScene.MonicaSantana("\n\n<Color=#28AB3C>João Santana -> Vivo!</Color>");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n22:31";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA ENCERRAR O DIA";
                break;

            case 28:
#if UNITY_EDITOR
                if (TestGeneral.instance.testLevel == true)
                {
                    Game.manager.controllerScene.ChangeLevel();
                    break;
                }
#endif

                Game.manager.controllerScene.NextDay();
                break;

        }
        _stage++;
    }
}
