using UnityEngine;

public partial class GameSave : MonoBehaviour
{
    void Awake() => DontDestroyOnLoad(gameObject); //Torna o game object indestrut�vel

    #region SALVAR TUDO
    public void GetAllSaves()
    {
        GetAllSavesConfigurations();
    }

    public void SetAllSaves()
    {
        SetAllSavesConfigurations();
    }
    #endregion
}
