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

    /// <summary>
    /// 表示文字列
    /// </summary>
    public string Message { set { _Message = value; } }
    private string _Message = "Default";

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
            Logger.Show(_Message);
        }
    }
}
