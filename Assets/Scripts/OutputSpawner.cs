using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class OutputSpawner : MonoBehaviour
{
    /// <summary>
    /// LogOutputのファクトリ
    /// </summary>
    [Inject]
    private OutputFactory Factory = null;

    void Awake()
    {
        var Output = Factory.Create();
        Output.Message = "FromPrefab";
    }
}
