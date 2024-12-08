using UnityEngine;

public class Level1 : MonoBehaviour, ILevel
{
    private byte _stage = 0;

    public void PrepareLevel()
    {
        
    }

    public void Execute()
    {
        switch (_stage)
        {
            case 0:
                Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Certo, duas semaninhas j� se passaram a partir de hoje." +
                    "" +
                    "\n\nCarlos Henrique -> T� vivo ainda?");

                Game.manager.controllerScene.dateText.text = "03/11/5281\n------------------\n13:07";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA ESCOLHER QUAL RESPOSTA DAR� AO CARLOS HENRIQUE";
                break;
            case 1:
                Game.manager.controllerScene.ChangeChoiceText("Responda Carlos Henrique","Com toda a certeza!","No limite do poss�vel.");

                Game.manager.controllerScene.dateText.text = "03/11/5281\n------------------\n13:07";

                Game.manager.controllerScene.GenerateChoice(); //Aplica o menu de escolha
                break;
            case 2:
                if (Game.manager.controllerScene.choice[0] == true)
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>Jo�o Santana -> Com toda a certeza!</Color>");
                }
                else
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>Jo�o Santana -> No limite do poss�vel!</Color>");
                }

                Game.manager.controllerScene.dateText.text = "03/11/5281\n------------------\n13:08";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE CARLOS HENRIQUE";
                break;
            case 3:
                if (Game.manager.controllerScene.choice[0] == true)
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Hamm, tu � bem dur�o hein!");
                }
                else
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> �, faz parte! Veja bem, faltam s� uns 100 anos agora.");
                }

                Game.manager.controllerScene.dateText.text = "03/11/5281\n------------------\n13:08";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER UMA MENSAGEM DE CARLOS HENRIQUE";
                break;
            case 4:
                if (Game.manager.controllerScene.choice[0] == true)
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>Jo�o Santana -> Sempre!</Color>");
                }
                else
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>Jo�o Santana -> Hil�rio...</Color>");
                }

                Game.manager.controllerScene.dateText.text = "03/11/5281\n------------------\n13:08";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE CARLOS HENRIQUE";
                break;
            case 5:
                if (Game.manager.controllerScene.choice[0] == true)
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Por isso tu � o melhor de n�s! Mas e a comida, tem o suficiente ai?");

                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER UMA MENSAGEM DE CARLOS HENRIQUE";

                    _stage++;
                }
                else
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Eu sei, eu sou o rei da com�dia! ksksksk");

                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE CARLOS HENRIQUE";
                }

                Game.manager.controllerScene.dateText.text = "03/11/5281\n------------------\n13:09";

                break;
            case 6:
                Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Mas me diz ai, tem comida o suficiente para voc�?");

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER UMA MENSAGEM DE CARLOS HENRIQUE";

                Game.manager.controllerScene.dateText.text = "03/11/5281\n------------------\n13:09";

                break;
            case 7:
                Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>Jo�o Santana -> Relaxa, meu nobre! O que mais tem aqui � comida. � ruim? Com toda a " +
                    "certeza! Mas tem o suficente pra dois anos!</Color>");

                Game.manager.controllerScene.dateText.text = "03/11/5281\n------------------\n13:09";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE CARLOS HENRIQUE";
                break;
            case 8:
                Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Ksksksksk, ent�o t� certo! Qualquer coisa � s� falar, cara!");

                Game.manager.controllerScene.dateText.text = "03/11/5281\n------------------\n13:09";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER UMA MENSAGEM DE CARLOS HENRIQUE";
                break;
            case 9:
                Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>Jo�o Santana -> Beleza, valeu meu nobre!</Color>");

                Game.manager.controllerScene.dateText.text = "03/11/5281\n------------------\n13:10";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE M�NICA SANTANA";
                break;
            case 10:
                Game.manager.controllerScene.MonicaSantana("\n\nM�nica Santana-> Vivo?");

                Game.manager.controllerScene.dateText.text = "03/11/5281\n------------------\n20:57";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA ENVIAR UMA MENSAGEM DE M�NICA SANTANA";
                break;
            case 11:
                Game.manager.controllerScene.MonicaSantana("\n\n<Color=#28AB3C>Jo�o Santana -> Vivo!</Color>");

                Game.manager.controllerScene.dateText.text = "03/11/5281\n------------------\n20:59";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA ENCERRAR O DIA";
                break;
            case 12:
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
