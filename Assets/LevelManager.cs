using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    static public LevelManager Instance;

    private void Awake()
    {
        Instance = this;
    }
}
