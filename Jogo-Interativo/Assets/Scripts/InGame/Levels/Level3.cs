using UnityEngine;

public class Level3 : MonoBehaviour, ILevel
{
    private byte _stage = 0;

    public void PrepareLevel()
    {
        Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n15:00";
        Game.manager.controllerScene.inGameTransition.TransitionText.text = "DIA 30";
        Game.manager.controllerScene.interactText.text = "CLIQUE PARA ENVIAR UMA MENSAGEM PARA CARLOS HENRIQUE";
    }

    public void Execute()
    {
        switch (_stage)
        {
            case 0:
                Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>João Santana -> Eai cara, nem te perguntei. Como foi o lance lá com a Maria?</Color>");

                Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n15:00";

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE CARLOS HENRIQUE";
                break;

            case 1:
                if (Game.manager.controllerScene.choice[1] == true)
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Opaa! Fala ai meuu amigo, desculpa a demora, tava ocupado com uns assuntos. E cara, " +
                        "te falar, ainda bem que eu segui o seu conselho. Ela disse sim na hora! Ela me falou que tava deprimida antes, mas depois deu falar em se casar com ela, " +
                        "o coração dela jorrou de alegria!");

                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE CARLOS HENRIQUE";
                }
                else
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Oii, cara. Foi mal pela demora. Eu estou muito pra baixo.");

                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA ENVIAR UMA RESPOSTA PARA CARLOS HENRIQUE";
                }

                Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n16:47";
                break;

            case 2:
                if (Game.manager.controllerScene.choice[1] == true)
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Olha, vou te falar hein! Quando a gente sair deste inferno, tu vai ser o padrinho do meu " +
                        "casamento, pode anotar isso ai! Muito obrigado irmão, por ter me ajudado com essa dúvida que eu tava. Sou eternamente grato!");

                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA ENVIAR UMA RESPOSTA PARA CARLOS HENRIQUE";

                    Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n16:48";
                }
                else
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>João Santana -> O que foi que aconteceu cara? Fala comigo, por favor!</Color>");

                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA RESPOSTA DE CARLOS HENRIQUE";

                    Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n16:47";
                }
                break;

            case 3:
                if (Game.manager.controllerScene.choice[1] == true)
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>João Santana -> Que isso meu patrão! Ai sim hein, senti firmesa. Fico muito feliz " +
                        "que tudo deu certo poh. E pode deixar que eu vou ser o melhor padrinho do universo, já até tô pensando no que eu vou fazer! Heheh</Color>");

                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA RESPOSTA DE CARLOS HENRIQUE";    
                }
                else
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> A Maria, ela se matou...");

                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA ENVIAR UMA RESPOSTA PARA CARLOS HENRIQUE";
                }

                Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n16:49";
                break;

            case 4:
                if (Game.manager.controllerScene.choice[1] == true)
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Este é espírito, moleque! Ouhh mas te falar que eu vou ter que sair, tão me chamando " +
                        "aqui. Se cuida, hein!");

                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA ENVIAR UMA RESPOSTA PARA CARLOS HENRIQUE";
                }
                else
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>João Santana -> O que? Mas como isso aconteceu!?</Color>");

                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA RESPOSTA DE CARLOS HENRIQUE";
                }

                Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n16:49";
                break;

            case 5:
                if (Game.manager.controllerScene.choice[1] == true)
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>João Santana -> Tá certo, cara! Depois a gente se fala, todo sucesso para ti!</Color>");

                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA RESPOSTA DE CARLOS HENRIQUE";

                    Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n16:49";
                }
                else
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Eu não percebi, ela tava com uns comportamentos muito estranhos estes dias. " +
                        "Ela tava mal, e eu nem me importei. Eu sou um lixo humano, eu perdi o amor da minha vida por só olhar para mim, enquanto o que eu devia ter feito era " +
                        "olhar bem para ela.");

                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA ENVIAR UMA RESPOSTA PARA CARLOS HENRIQUE";
                }

                Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n16:54";
                break;

            case 6:
                if (Game.manager.controllerScene.choice[1] == true)
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Amém, irmão!");

                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE AMANDA SOARES";

                    Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n16:50";

                    _stage += 5;
                }
                else
                {
                    Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>João Santana -> Carlos, isso não é culpa sua. São coisas ruins que acontecem na vida, você " +
                        "não é Deus para ditar quem vive e quem morre! Cada um é responsável pela própria alma. Se ela fez isso, foi uma escolha dela, não havia nada que você " +
                        "pudesse fazer naquele momento. E eu tenho certeza mais que absoluta que ela do outro lado, não está te culpando. Pelo contrário, ela está torcendo pra " +
                        "você ser feliz!</Color>");

                    Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA RESPOSTA DE CARLOS HENRIQUE";

                    Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n16:54";
                }
                break;

            case 7:
                Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Cara, não sei nem o que dizer. Muito obrigado por estar ao meu lado, eu tava precisando " +
                    "escutar isto. Muito obrigado por ser meu amigo, eu não sei onde eu estaria com a cabeça sem você.");

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA ENVIAR UMA RESPOSTA PARA CARLOS HENRIQUE";

                Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n16:56";
                break;

            case 8:
                Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>João Santana -> Tamo junto, irmão. Sempre vou estar aqui para te ajudar, não importa o " +
                    "problema que for!</Color>");

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA RESPOSTA DE CARLOS HENRIQUE";

                Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n16:57";
                break;

            case 9:
                Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> Valeu, cara! Se cuida você também, não quero perder mais ninguém.");

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA ENVIAR UMA RESPOSTA PARA CARLOS HENRIQUE";

                Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n16:58";
                break;

            case 10:
                Game.manager.controllerScene.CarlosHenrique("\n\n<Color=#28AB3C>João Santana -> Pode deixar cara, eu ainda estarei aqui para te dar todo o apoio do " +
                    "univero!.</Color>");

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA RESPOSTA DE CARLOS HENRIQUE";

                Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n16:58";
                break;

            case 11:
                Game.manager.controllerScene.CarlosHenrique("\n\nCarlos Henrique -> :)");

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE AMANDA SOARES";

                Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n16:59";
                break;

            case 12:
                Game.manager.controllerScene.AmandaSoares("\n\nAmanda Soares -> Senhor, tenho uma informação para ti!");

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER UMA MENSAGEM DE AMANDA SOARES";

                Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n17:13";
                break;

            case 13:
                Game.manager.controllerScene.AmandaSoares("\n\n<Color=#28AB3C>João Santana -> Diga!</Color>");

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE AMANDA SOARES";

                Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n17:14";
                break;

            case 14:
                Game.manager.controllerScene.AmandaSoares("\n\nAmanda Soares -> Um dos submarinos, acabou de informar que capturou um infiltrado dos separatistas. Já o " +
                    "interrogamos e aparentemente a missão dele era sabotar a nossa frota de submarinos.");

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE AMANDA SOARES";

                Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n17:15";
                break;

            case 15:
                Game.manager.controllerScene.AmandaSoares("\n\nAmanda Soares -> O que devemos fazer com ele senhor?");

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA ESCOLHER O DESTINO DO INFILTRADO";

                Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n17:15";
                break;

            case 16:
                Game.manager.controllerScene.ChangeChoiceText("Escolha o destino do infiltrado",
                   "Executem o infiltrado!", "Prendam o infiltrado!");

                Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n17:16";

                Game.manager.controllerScene.GenerateChoice(); //Aplica o menu de escolha
                break;

            case 17:
                if (Game.manager.controllerScene.choice[2] == true)
                {
                    Game.manager.controllerScene.AmandaSoares("\n\n<Color=#28AB3C>João Santana -> Executem o infiltrado!</Color>");
                }
                else
                {
                    Game.manager.controllerScene.AmandaSoares("\n\n<Color=#28AB3C>João Santana -> Prendam o infiltrado!</Color>");
                }
                
                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER A RESPOSTA DE AMANDA SOARES";

                Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n17:17";
                break;

            case 18:
                Game.manager.controllerScene.AmandaSoares("\n\nAmanda Soares -> Assim será feito, como o senhor decidiu!");

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RECEBER UMA MENSAGEM DE MÔNICA SANTANA";

                Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n17:17";
                break;

            case 19:
                Game.manager.controllerScene.MonicaSantana("\n\nMônica Santana -> Vivo?");

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA RESPONDER UMA MENSAGEM DE MÔNICA SANTANA";

                Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n19:18";
                break;

            case 20:
                Game.manager.controllerScene.MonicaSantana("\n\n<Color=#28AB3C>João Santana -> Vivo!</Color>");

                Game.manager.controllerScene.interactText.text = "CLIQUE PARA ENCERRAR O DIA";

                Game.manager.controllerScene.dateText.text = "19/11/5281\n------------------\n19:21";
                break;

            case 21:
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
