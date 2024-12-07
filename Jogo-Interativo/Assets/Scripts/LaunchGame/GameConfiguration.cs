using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

//Esta classe serve para as configura��es do usu�rio, exemplo: resolu��o da tela.
public class GameConfiguration : MonoBehaviour
{
    #region CONSTANTES
    //Constante do nome do elemento do audio mixer exposto
    private const string _VOLUME = "Vol";
    #endregion

    #region DROPDOWN
    [Header("Dropdown")]
    [SerializeField] Dropdown _dropdownResolution;
    #endregion

    #region SLIDER
    [Header("Slider")]
    [SerializeField] Slider _sliderVolume;
    #endregion

    #region VOLUME
    [Header("Volume")]
    [SerializeField] AudioMixer _volume;
    #endregion

    #region VARI�VEIS UTILIZADAS EM OUTROS SCRIPTS
    //Serve para fazer a transi��o de tela do Game para o Options.
    [Header("Game Objects")]
    [Tooltip("Anexe aqui o Game Object 'Canvas-Config'")]
    public GameObject configChild;

    //Serve para fazer a transi��o de tela do Options para o Game
    [HideInInspector] public GameObject[] exitConfig;
    #endregion

    void Awake() => DontDestroyOnLoad(gameObject);

    //Aqui ser� aplicada todas as configura��es quando o jogo come�ar
    void Start()
    {
        #region RESOLU��O E FPS
        //Relacionado a resolu��o e ao fps
        try
        {
            // Cria um HashSet para armazenar as resolu��es �nicas
            HashSet<string> uniqueResolutions = new();

            //Looping para adicionar todas as resolu��es vi�veis no game
            foreach (Resolution option in Screen.resolutions)
            {
                //Cria uma string �nica para a resolu��o com base na largura e altura
                string resolutionString = option.width.ToString() + "x" + option.height.ToString();

                // Verifica se a resolu��o j� foi adicionada ao conjunto
                if (!uniqueResolutions.Contains(resolutionString))
                {
                    uniqueResolutions.Add(resolutionString);
                    _dropdownResolution.options.Add(new Dropdown.OptionData() { text = resolutionString });
                }
            }

            _dropdownResolution.options.Reverse();
            _dropdownResolution.value = Game.save.resolution;
        }
        catch (System.Exception)
        {
#if UNITY_EDITOR
            Debug.Log("Falha nas options");
#endif
            _dropdownResolution.options.RemoveRange(0, _dropdownResolution.options.Count);
            _dropdownResolution.options.Add(new Dropdown.OptionData { text = Screen.currentResolution.width.ToString() + "x" + Screen.currentResolution.height.ToString() });
            _dropdownResolution.value = 0;
        }
        #endregion

        DefineResolution();

        //Relacionado ao volume
        _sliderVolume.value = Game.save.volume;
        NewVolume();
    }

    //M�todo utilizado para definir a resolu��o.
    void DefineResolution()
    {
        string width = string.Empty, height = string.Empty;
        bool change = false;

        foreach (char i in _dropdownResolution.options[_dropdownResolution.value].text)
        {
            if (i.Equals('x'))
                change = true;
            else if (change == false)
                width += i;
            else
                height += i;
        }

        Screen.SetResolution(int.Parse(width), int.Parse(height), FullScreenMode.FullScreenWindow, Screen.currentResolution.refreshRateRatio);
    }

    //M�todo utilizado para definir o volume.
    private void NewVolume()
    {
        switch (_sliderVolume.value)
        {
            case 10:
                _volume.SetFloat(_VOLUME, 20);
                break;
            case 9:
                _volume.SetFloat(_VOLUME, 16);
                break;
            case 8:
                _volume.SetFloat(_VOLUME, 12);
                break;
            case 7:
                _volume.SetFloat(_VOLUME, 8);
                break;
            case 6:
                _volume.SetFloat(_VOLUME, 4);
                break;
            case 5:
                _volume.SetFloat(_VOLUME, 0);
                break;
            case 4:
                _volume.SetFloat(_VOLUME, -5);
                break;
            case 3:
                _volume.SetFloat(_VOLUME, -10);
                break;
            case 2:
                _volume.SetFloat(_VOLUME, -15);
                break;
            case 1:
                _volume.SetFloat(_VOLUME, -20);
                break;
            default:
                _volume.SetFloat(_VOLUME, -80);
                break;
        }
    }

    #region BOT�ES DROPDOWN
    public void DropdownResolution()
    {
        Game.save.resolution = (byte)_dropdownResolution.value;

        DefineResolution();
    }
    #endregion

    #region BOT�ES DE ENCERRAR AS CONFIGURA��ES
    public void ConfirmButton()
    {
        Game.save.SetAllSavesConfigurations();

        #region APLICANDO CONFIGURA��ES
        //A resolu��o j� foi aplicada

        //Volume
        if (_sliderVolume.value != Game.save.volume)
        {
            NewVolume();
            Game.save.volume = (byte)_sliderVolume.value;
        }
        #endregion

        Game.save.SetAllSavesConfigurations();

        configChild.SetActive(false);
        foreach (GameObject gO in exitConfig)
        {
            gO.SetActive(true);
        }
    }

    public void CancelButton()
    {
        Game.save.GetAllSavesConfigurations();

        #region CANCELANDO MUDAN�AS

        //Resolu��o
        if (_dropdownResolution.value != Game.save.resolution)
            _dropdownResolution.value = Game.save.resolution;

        //Volume
        if (_sliderVolume.value != Game.save.volume)
            _sliderVolume.value = Game.save.volume;
        #endregion

        configChild.SetActive(false);
        foreach (GameObject gO in exitConfig)
        {
            gO.SetActive(true);
        }
    }
    #endregion
}
