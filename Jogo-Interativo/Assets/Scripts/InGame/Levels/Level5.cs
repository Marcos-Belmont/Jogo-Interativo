using UnityEngine;

public class Level5 : MonoBehaviour, ILevel
{
    private byte _stage = 0;

    public void PrepareLevel()
    {
        Game.manager.controllerScene.inGameTransition.TransitionText.text = "DIA 71";

        if (Game.manager.controllerScene.choice[2] == true)
        {
            Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE CARLOS HENRIQUE";

            Game.manager.controllerScene.dateText.text = "30/12/5281\n------------------\n09:00";
        }
        else
        {
            Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE AMANDA SOARES";

            Game.manager.controllerScene.dateText.text = "30/12/5281\n------------------\n03:00";

            Game.manager.controllerScene.fleetValue -= 2;
            Game.manager.controllerScene.fleetText.text = "Frota\n--------------\n" + Game.manager.controllerScene.fleetValue.ToString();

            Game.manager.controllerScene.personButtonText[0].text += " (Offline)";
            Game.manager.controllerScene.personButtonText[1].text += " (Offline)";

            _stage = 3;
        }         
    }

    public void Execute()
    {
        switch (_stage)
        {
            case 0:
                Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Ainda se encontra vivo ainda?");

                Game.manager.controllerScene.dateText.text = "30/12/5281\n------------------\n09:00";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER UMA MENSAGEM DE CARLOS HENRIQUE";
                break;

            case 1:
                Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>João Santana -> Não, mas este cubículo já está me deixando louco!</Color>");

                Game.manager.controllerScene.dateText.text = "30/12/5281\n------------------\n09:10";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE CARLOS HENRIQUE";
                break;

            case 2:
                Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> KK, Aguente só mais um mês amigo, só mais um mês. Vamos até a última gota.");

                Game.manager.controllerScene.dateText.text = "30/12/5281\n------------------\n09:17";

                if (Game.manager.controllerScene.choice[3] == true)
                {
                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE MÔNICA SANTANA";
                    _stage += 2;
                }
                else
                {
                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA ENCERRAR O DIA";
                    _stage += 4;
                }
                
                break;

            case 3:
                Game.manager.controllerScene.AmandaSoares("\n\nAmanda Soares -> Passando um relatório, senhor! Parece que o submarino que estava o prisioneiro, colidiu com " +
                    "um outro submarino, tivemos muitas baixas. Pelo que tudo indica, o prisioneiro deve ter escapado e concluído a sua missão original.");

                Game.manager.controllerScene.dateText.text = "30/12/5281\n------------------\n03:00";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER UMA MENSAGEM DE AMANDA SOARES";
                break;

            case 4:
                Game.manager.controllerScene.AmandaSoares("\n\n<Color=#28AB3C>João Santana -> Eh, mais um dia de bosta. Obrigado pelo relatório!</Color>");

                Game.manager.controllerScene.dateText.text = "30/12/5281\n------------------\n03:04";

                if(Game.manager.controllerScene.choice[3] == true)
                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE MÔNICA SANTANA";
                else
                {
                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA ENCERRAR O DIA";
                    _stage += 2;
                }

                break;

            case 5:
                Game.manager.controllerScene.MonicaSantana("\n\nMônica SANTANA -> Vivo?");

                Game.manager.controllerScene.dateText.text = "30/12/5281\n------------------\n21:08";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER UMA MENSAGEM DE MÔNICA SANTANA";
                break;

            case 6:
                Game.manager.controllerScene.MonicaSantana("\n\n<Color=#28AB3C>João Santana -> Vivo!</Color>");

                Game.manager.controllerScene.dateText.text = "30/12/5281\n------------------\n21:09";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA ENCERRAR O DIA";
                break;

            case 7:
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
