using UnityEngine;

public class Level4 : MonoBehaviour, ILevel
{
    private byte _stage = 0;

    public void PrepareLevel()
    {
        Game.manager.controllerScene.dateText.text = "19/12/5281\n------------------\n07:00";
        Game.manager.controllerScene.inGameTransition.TransitionText.text = "DIA 60";
        Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE HEITOR FARIAS";
    }

    public void Execute()
    {
        switch (_stage)
        {
            case 0:
                Game.manager.controllerScene.HeitorFarias("\n\nHeitor Farias -> Senhor, temos um grande problema!");

                Game.manager.controllerScene.dateText.text = "19/12/5281\n------------------\n07:00";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER UMA MENSAGEM DE HEITOR FARIAS";
                break;

            case 1:
                Game.manager.controllerScene.HeitorFarias("\n\n<Color=#28AB3C>Jo�o Santana -> Pois, diga!</Color>");

                Game.manager.controllerScene.dateText.text = "19/12/5281\n------------------\n07:00";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER UMA MENSAGEM DE HEITOR FARIAS";
                break;

            case 2:
                Game.manager.controllerScene.HeitorFarias("\n\nHeitor Farias -> Detectamos uma frota inimiga, foi regitrado 10 submarinos inimigos na regi�o. A Amanda j� est� " +
                    "ciente, o que devemos fazer?");

                Game.manager.controllerScene.dateText.text = "19/12/5281\n------------------\n07:01";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA ESCOLHER O DESTINO DA FROTA";
                break;

            case 3:
                Game.manager.controllerScene.ChangeChoiceText("Escolha como proceder com a frota inimiga",
                  "Atacar!", "Deixa-los passar.");

                Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n07:02";

                Game.manager.controllerScene.GenerateChoice(); //Aplica o menu de escolha
                break;

            case 4:
                if (Game.manager.controllerScene.choice[3] == true)
                {
                    Game.manager.controllerScene.HeitorFarias("\n\n<Color=#28AB3C>Jo�o Santana -> Ataque com todas as for�as, temos que aproveitar que ainda n�o nos " +
                        "detectaram!</Color>");
                }
                else
                {
                    Game.manager.controllerScene.HeitorFarias("\n\n<Color=#28AB3C>Jo�o Santana -> Deixe-os passar, vamos torcer para que tudo d� certo.</Color>");
                }

                Game.manager.controllerScene.dateText.text = "19/12/5281\n------------------\n07:02";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE HEITOR FARIAS";
                break;

            case 5:
                Game.manager.controllerScene.HeitorFarias("\n\nHeitor Farias -> Positivo, senhor! Irei informar as suas ordens para a Amanda tamb�m!");

                Game.manager.controllerScene.dateText.text = "19/12/5281\n------------------\n07:03";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER UMA MENSAGEM DE HEITOR FARIAS";
                break;

            case 6:
                Game.manager.controllerScene.HeitorFarias("\n\n<Color=#28AB3C>Jo�o Santana -> Entendido!</Color>");

                Game.manager.controllerScene.dateText.text = "19/12/5281\n------------------\n07:04";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA ATUALIZAR AS ESTAT�STICAS";
                break;

            case 7:
                if (Game.manager.controllerScene.choice[3] == true)
                {
                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA ENVIAR UMA MENSAGEM PARA HEITOR FARIAS";
                }
                else
                {
                    Game.manager.controllerScene.fleetValue -= 14;
                    Game.manager.controllerScene.fleetText.text = "Frota\n--------------\n" + Game.manager.controllerScene.fleetValue.ToString();

                    Game.manager.controllerScene.personButtonText[3].text += " (Offline)";
                    Game.manager.controllerScene.personButtonText[4].text += " (Offline)";
                    Game.manager.controllerScene.personButtonText[5].text += " (Offline)";

                    Game.manager.controllerScene.MonicaSantana("<Color=#28AB3C>Jo�o Santana -> Sinto muito irm�, descanse em paz.</color>");

                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA ENVIAR UMA MENSAGEM PARA AMANDA SOARES";
                }

                Game.manager.controllerScene.dateText.text = "19/12/5281\n------------------\n08:26";
                break;

            case 8:
                if (Game.manager.controllerScene.choice[3] == true)
                {
                    Game.manager.controllerScene.HeitorFarias("\n\n<Color=#28AB3C>Jo�o Santana -> Parab�ns, Farias! Esta vit�ria � de todos voc�s, agrade�a a Amanda por " +
                        "mim tamb�m.</Color>");

                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE HEITOR FARIAS";
                }
                else
                {
                    Game.manager.controllerScene.AmandaSoares("\n\n<Color=#28AB3C>Jo�o Santana -> Soares, Como voc� est�?</Color>");

                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE AMANDA SOARES";
                }

                Game.manager.controllerScene.dateText.text = "19/12/5281\n------------------\n08:28";
                break;

            case 9:
                if (Game.manager.controllerScene.choice[3] == true)
                {
                    Game.manager.controllerScene.HeitorFarias("\n\nHeitor Farias -> Muito obrigado, senhor! Pode deixar que eu irei designar os devidos cumprimentos!");

                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE BERNADO COSTA";

                    _stage += 3;
                }
                else
                {
                    Game.manager.controllerScene.AmandaSoares("\n\nAmanda Soares -> P�ssima, foram tantas vidas perdidas, inclusive a do Heitor... Eu queria ter feito algo " +
                        "diferente!");

                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER UMA MENSAGEM DE AMANDA SOARES";
                }

                Game.manager.controllerScene.dateText.text = "19/12/5281\n------------------\n08:32";
                break;

            case 10:
                Game.manager.controllerScene.AmandaSoares("\n\n<Color=#28AB3C>Jo�o Santana -> Foque no agora, ainda temos muitas vidar para salvar.</Color>");

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE AMANDA SOARES";

                Game.manager.controllerScene.dateText.text = "19/12/5281\n------------------\n08:33";
                break;

            case 11:
                Game.manager.controllerScene.AmandaSoares("\n\nAmanda Soares -> Voc� est� certo, darei o meu melhor para cuidar destas vidas!");

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER UMA MENSAGEM DE AMANDA SOARES";

                Game.manager.controllerScene.dateText.text = "19/12/5281\n------------------\n08:34";
                break;

            case 12:
                Game.manager.controllerScene.AmandaSoares("\n\n<Color=#28AB3C>Jo�o Santana -> � isso ai, Soares!.</Color>");

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA ENCERRAR O DIA";

                Game.manager.controllerScene.dateText.text = "19/12/5281\n------------------\n08:34";
                _stage += 5;
                break;

            case 13:
                Game.manager.controllerScene.BernadoCosta("\n\nBernado Costa -> Olha, eu n�o sou muito bom com isso e tals. Mas eu te devo desculpas, voc� realmente mostrou que " +
                    "tem momentos que a gente deve recuar, e tem momentos que a gente deve atacar. Eu estava errado, sinto muito.");

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA REPONDER UMA MENSAGEM DE BERNADO COSTA";

                Game.manager.controllerScene.dateText.text = "19/12/5281\n------------------\n14:48";
                break;
            case 14:
                Game.manager.controllerScene.BernadoCosta("\n\n<Color=#28AB3C>Jo�o Santana -> T� tudo bem, eu sei que voc� s� queria fazer o que achava o certo. " +
                    "Eu te perdoo.</Color>");

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE BERNADO COSTA";

                Game.manager.controllerScene.dateText.text = "19/12/5281\n------------------\n14:53";
                break;

            case 15:
                Game.manager.controllerScene.BernadoCosta("\n\nBernado Costa -> Muito obrigado, Jo�o!");

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE M�NICA SANTANA";

                Game.manager.controllerScene.dateText.text = "19/12/5281\n------------------\n14:53";
                break;

            case 16:
                Game.manager.controllerScene.MonicaSantana("\n\nM�nica Santana -> Vivo?");

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA REPONDER UMA MENSAGEM DE M�NICA SANTANA";

                Game.manager.controllerScene.dateText.text = "19/12/5281\n------------------\n23:47";
                break;

            case 17:
                Game.manager.controllerScene.MonicaSantana("\n\n<Color=#28AB3C>Jo�o Santana -> Vivo!</Color>");

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA ENCERRAR O DIA";

                Game.manager.controllerScene.dateText.text = "19/12/5281\n------------------\n23:54";
                break;

            case 18:
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
