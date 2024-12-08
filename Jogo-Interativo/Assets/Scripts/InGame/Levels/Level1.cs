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
                Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Certo, duas semaninhas já se passaram a partir de hoje." +
                    "" +
                    "\n\nCarlos Henrique -> Tá vivo ainda?");

                Game.manager.controllerScene.dateText.text = "03/11/5281\n------------------\n13:07";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA ESCOLHER QUAL RESPOSTA DARÁ AO CARLOS HENRIQUE";
                break;
            case 1:
                Game.manager.controllerScene.ChangeChoiceText("Responda Carlos Henrique","Com toda a certeza!","No limite do possível.");

                Game.manager.controllerScene.dateText.text = "03/11/5281\n------------------\n13:07";

                Game.manager.controllerScene.GenerateChoice(); //Aplica o menu de escolha
                break;
            case 2:
                if (Game.manager.controllerScene.choice[0] == true)
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>João Santana -> Com toda a certeza!</Color>");
                }
                else
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>João Santana -> No limite do possível!</Color>");
                }

                Game.manager.controllerScene.dateText.text = "03/11/5281\n------------------\n13:08";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE CARLOS HENRIQUE";
                break;
            case 3:
                if (Game.manager.controllerScene.choice[0] == true)
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Hamm, tu é bem durão hein!");
                }
                else
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> É, faz parte! Veja bem, faltam só uns 100 anos agora.");
                }

                Game.manager.controllerScene.dateText.text = "03/11/5281\n------------------\n13:08";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER UMA MENSAGEM DE CARLOS HENRIQUE";
                break;
            case 4:
                if (Game.manager.controllerScene.choice[0] == true)
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>João Santana -> Sempre!</Color>");
                }
                else
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>João Santana -> Hilário...</Color>");
                }

                Game.manager.controllerScene.dateText.text = "03/11/5281\n------------------\n13:08";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE CARLOS HENRIQUE";
                break;
            case 5:
                if (Game.manager.controllerScene.choice[0] == true)
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Por isso tu é o melhor de nós! Mas e a comida, tem o suficiente ai?");

                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER UMA MENSAGEM DE CARLOS HENRIQUE";

                    _stage++;
                }
                else
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Eu sei, eu sou o rei da comédia! ksksksk");

                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE CARLOS HENRIQUE";
                }

                Game.manager.controllerScene.dateText.text = "03/11/5281\n------------------\n13:09";

                break;
            case 6:
                Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Mas me diz ai, tem comida o suficiente para você?");

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER UMA MENSAGEM DE CARLOS HENRIQUE";

                Game.manager.controllerScene.dateText.text = "03/11/5281\n------------------\n13:09";

                break;
            case 7:
                Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>João Santana -> Relaxa, meu nobre! O que mais tem aqui é comida. É ruim? Com toda a " +
                    "certeza! Mas tem o suficente pra dois anos!</Color>");

                Game.manager.controllerScene.dateText.text = "03/11/5281\n------------------\n13:09";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE CARLOS HENRIQUE";
                break;
            case 8:
                Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Ksksksksk, então tá certo! Qualquer coisa é só falar, cara!");

                Game.manager.controllerScene.dateText.text = "03/11/5281\n------------------\n13:09";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER UMA MENSAGEM DE CARLOS HENRIQUE";
                break;
            case 9:
                Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>João Santana -> Beleza, valeu meu nobre!</Color>");

                Game.manager.controllerScene.dateText.text = "03/11/5281\n------------------\n13:10";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE MÔNICA SANTANA";
                break;
            case 10:
                Game.manager.controllerScene.MonicaSantana("\n\nMônica Santana-> Vivo?");

                Game.manager.controllerScene.dateText.text = "03/11/5281\n------------------\n20:57";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA ENVIAR UMA MENSAGEM DE MÔNICA SANTANA";
                break;
            case 11:
                Game.manager.controllerScene.MonicaSantana("\n\n<Color=#28AB3C>João Santana -> Vivo!</Color>");

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
