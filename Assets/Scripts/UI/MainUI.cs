using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using System;

/// <summary>
/// メインUIのインタフェース
/// </summary>
public interface IMainUI
{
    /// <summary>
    /// Aボタンが押された
    /// </summary>
    IObservable<Unit> OnPressedAButton { get; }

    /// <summary>
    /// Bボタンが押された
    /// </summary>
    IObservable<Unit> OnPressedBButton { get; }
}

/// <summary>
/// メインUI
/// </summary>
public class MainUI : MonoBehaviour, IMainUI
{
    /// <summary>
    /// Aボタン
    /// </summary>
    [SerializeField]
    private Button AButton = null;

    /// <summary>
    /// Bボタン
    /// </summary>
    [SerializeField]
    private Button BButton = null;

    /// <summary>
    /// Aボタンが押された
    /// </summary>
    public IObservable<Unit> OnPressedAButton { get { return AButton.OnClickAsObservable(); } }

    /// <summary>
    /// Bボタンが押された
    /// </summary>
    public IObservable<Unit> OnPressedBButton { get { return BButton.OnClickAsObservable(); } }
}
