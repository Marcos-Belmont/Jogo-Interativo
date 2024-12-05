using UnityEngine;
using UnityEngine.SceneManagement;

//Esta classe ser� respons�vel pela transi��o de scenes, como aplicar a tela de carregamento e afins.
public class GameTransition : MonoBehaviour
{
    private void Awake() => DontDestroyOnLoad(gameObject); //Torna o game object indestrut�vel

    //Metodo que altera os cenarios.
    public void ChangeScene(byte scene) => SceneManager.LoadScene(scene);
}
