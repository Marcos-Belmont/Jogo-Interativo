using UnityEngine;

public partial class GameSave
{
    private const string _VOLUME = "v";
    private const string _RESOLUTION = "r";

    public byte volume;
    public short resolution;

    public void GetAllSavesConfigurations()
    {
        volume = PlayerPrefs.HasKey(_VOLUME) ? (byte)PlayerPrefs.GetInt(_VOLUME) : (byte)5;
        resolution = PlayerPrefs.HasKey(_RESOLUTION) ? (short)PlayerPrefs.GetInt(_RESOLUTION) : (short)0;
    }

    public void SetAllSavesConfigurations()
    {
        PlayerPrefs.SetInt(_VOLUME, volume);
        PlayerPrefs.SetInt(_RESOLUTION, resolution);
    }
}
