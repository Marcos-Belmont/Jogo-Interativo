using UnityEngine;

public class Level2 : MonoBehaviour, ILevel
{
    private byte _stage = 0;

    public void Execute()
    {
        switch (_stage)
        {
            case 0:
                Game.manager.controllerScene.HeitorFarias("\n\n<Color=#28AB3C>Jo�o Santana -> Relat�rio, Farias!</Color>");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:00";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A RESPOSTA DE HEITOR FARIAS";

                break;

            case 1:

                Game.manager.controllerScene.HeitorFarias("\n\nHeitor Farias -> T� tudo tranquilo, chefia. Nenhuma anomalia dectada, pode prosseguir com o descanso.");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:02";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER A MENSAGEM DE HEITOR FARIAS";

                break;

            case 2:
                Game.manager.controllerScene.HeitorFarias("\n\n<Color=#28AB3C>Jo�o Santana -> Entendido!</Color>");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:03";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA ENVIAR UMA MENSAGEM PARA AMANDA SOARES";
                break;

            case 3:
                Game.manager.controllerScene.AmandaSoares("\n\n<Color=#28AB3C>Jo�o Santana -> Amandinha, relat�rio!</Color>");

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
                Game.manager.controllerScene.AmandaSoares("\n\n<Color=#28AB3C>Jo�o Santana -> Como a pessoa consegue ficar presa no vaso?</Color>");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:28";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE AMANDA SOARES";
                break;

            case 6:
                Game.manager.controllerScene.AmandaSoares("\n\nAmanda Soares -> Ent�o, deixa eu te contar, menino.");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:28";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE AMANDA SOARES";
                break;

            case 7:
                Game.manager.controllerScene.AmandaSoares("\n\nAmanda Soares -> L� estava eu, toda estabanada andando pelo corredor, ai eu fui conversar com o Maicon.");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:29";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE AMANDA SOARES";
                break;

            case 8:
                Game.manager.controllerScene.AmandaSoares("\n\nAmanda Soares -> Ele tava me contando umas m� doideiras de f�sica, que te falar, eu n�o entendi " +
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
                Game.manager.controllerScene.AmandaSoares("\n\n<Color=#28AB3C>Jo�o Santana -> Amanda, chega, foco! Me manda um relat�rio.</Color>");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:30";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE AMANDA SOARES";
                break;

            case 12:
                Game.manager.controllerScene.AmandaSoares("\n\nAmanda Santana -> Ahh sim, foi mal senhor!");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:31";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE AMANDA SOARES";
                break;

            case 13:
                Game.manager.controllerScene.AmandaSoares("\n\nAmanda Santana -> Bomm, n�o tenho nada a relatar. Exceto por um barulho no casco de um dos submarinos, pelo " +
                    "que eu fui informada. Mas eu acho que n�o deve ter nenhum problema nisso.");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:31";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER A MENSASEM DE AMANDA SOARES";
                break;

            case 14:
                Game.manager.controllerScene.AmandaSoares("\n\n<Color=#28AB3C>Jo�o Santana -> Entendi, pode descansar!</Color>");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:32";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE AMANDA SOARES";
                break;

            case 15:
                Game.manager.controllerScene.AmandaSoares("\n\nAmanda Santana -> Sim, senhor!");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n11:32";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE CARLOS HENRIQUE";
                break;

            case 16:
                Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Eai, J�o! Olha tu sabe que � o meu amigo, e por isso eu queria a sua opini�o sobre um " +
                    "assunto...");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n12:51";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER A MENSASEM DE CARLOS HENRIQUE";
                break;

            case 17:
                Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>Jo�o Santana -> Diga, meu camarada, e n�o me esconda nada!</Color>");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n12:54";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE CARLOS HENRIQUE";
                break;

            case 18:
                Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> KK Ent�ooo, voc� sabe que eu e a Maria estamos namorando faz 3 anos n�...?");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n12:54";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER A MENSASEM DE CARLOS HENRIQUE";
                break;

            case 19:
                Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>Jo�o Santana -> T� ligado sim, menor! Bastante tempo at� n�?</Color>");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n12:55";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER MENSASEM DE CARLOS HENRIQUE";
                break;

            case 20:
                Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Sim kk. Pohh, eu gostaria de saber se seria uma boa ideia pedir ela em " +
                    "casamento amanh�? Eu sei que a situa��o n�o � muito boa, mas eu acho que todo momento, � um momento para demonstrar amor, e eu queria demonstrar da melhor forma " +
                    "poss�vel pedindo ela em casamento.");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n12:56";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE CARLOS HENRIQUE";
                break;

            case 21:
                Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> E ai, o que voc� me diz, irm�o?");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n12:56";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA ESCOLHER A MELHOR RESPOSTA PARA CARLOS HENRIQUE";
                break;

            case 22:
                Game.manager.controllerScene.ChangeText("Aconselhe Carlos, Sobre O Pedido De Casamento",
                    "Concordar em fazer o pedido de casamento amanh�!", "N�o concordar, falar para ele fazer o pedido quando estiver em solo firme e seguro.");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n12:59";

                Game.manager.controllerScene.GenerateChoice(); //Aplica o menu de escolha
                break;

            case 23:
                if (Game.manager.controllerScene.choice[1] == true)
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>Jo�o Santana -> Cara, s� segue o seu cora��o e vai na f�. Voc� tem o meu total " +
                        "apoio! Duvido nada que voc�s ser�o o casal do ano!</Color>");
                }
                else
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>Jo�o Santana -> Caara, eu acho melhor esperar. A situa��o atual � muito estressante, " +
                        "eu acho melhor pedir ela em casamento quando estiver em solo firme, em seguran�a. Voc�s v�o poder aproveitar o momento melhor.</Color>");
                }

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n12:59";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE CARLOS HENRIQUE";
                break;

            case 24:
                if (Game.manager.controllerScene.choice[1] == true)
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Pohh cara, muito obrigado pela sua ben�a! Amanh� eu vou meter bronca! Heheh");
                }
                else
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Faz total sentido, valeu pela orienta��o cara. Vou aguardar at� l�!");
                }

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n13:01";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER A MENSASEM DE CARLOS HENRIQUE";
                break;

            case 25:

                Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>Jo�o Santana -> Disponha, cara!</Color>");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n13:01";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A MENSASEM DE M�NICA SANTANA";
                break;

            case 26:

                Game.manager.controllerScene.MonicaSantana("\n\nM�nica Santana -> Vivo?");

                Game.manager.controllerScene.dateText.text = "10/11/5281\n------------------\n22:29";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER A MENSASEM DE M�NICA SANTANA";
                break;

            case 27:

                Game.manager.controllerScene.MonicaSantana("\n\n<Color=#28AB3C>Jo�o Santana -> Vivo!</Color>");

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
