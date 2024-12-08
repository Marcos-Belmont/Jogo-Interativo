using UnityEngine;

public class Level7 : MonoBehaviour, ILevel
{
    private byte _stage = 0;

    public void Execute()
    {
        switch (_stage)
        {
            case 0:
                break;
        }

        _stage++;
    }
}
