using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateHit : MonoBehaviour
{
    public delegate void ExitEventhandler(KeyCode key);

    public event ExitEventhandler ExitPressed;

    protected virtual void OnExitPressed()
    {
        if (ExitPressed != null)
        {
    
        }
    }
}
