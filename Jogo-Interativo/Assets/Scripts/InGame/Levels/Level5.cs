using UnityEngine;

public class Level5 : MonoBehaviour, ILevel
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
