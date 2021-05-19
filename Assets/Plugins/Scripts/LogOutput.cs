using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

/// <summary>
/// ログ出力
/// </summary>
public class LogOutput : MonoBehaviour
{
    /// <summary>
    /// Logger
    /// </summary>
    [Inject]
    private ILogger Logger = null;

    void Awake()
    {
        StartCoroutine(MainLoop());
    }

    /// <summary>
    /// メインループ
    /// </summary>
    /// <returns></returns>
    private IEnumerator MainLoop()
    {
        while(true)
        {
            yield return new WaitForSeconds(1.0f);
            Logger.Show("Test");
        }
    }
}
