﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ログ表示インタフェース
/// </summary>
public interface ILogger
{
    /// <summary>
    /// 表示
    /// </summary>
    /// <param name="Message">表示するメッセージ</param>
    void Show(string Message);
}

/// <summary>
/// 基本ログ表示
/// </summary>
public class BasicLogger : ILogger
{
    /// <summary>
    /// 表示
    /// </summary>
    /// <param name="Message">表示するメッセージ</param>
    public void Show(string Message)
    {
        Debug.Log(Message);
    }
}

/// <summary>
/// エラーログ表示
/// </summary>
public class ErrorLogger : ILogger
{
    /// <summary>
    /// 表示
    /// </summary>
    /// <param name="Message">表示するメッセージ</param>
    public void Show(string Message)
    {
        Debug.LogError(Message);
    }
}
