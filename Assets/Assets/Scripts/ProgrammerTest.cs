using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgrammerTest : MonoBehaviour
{

    [ContextMenu("Clear PlayerPrefs")]
    void ClearPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
}