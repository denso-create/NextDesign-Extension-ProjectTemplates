using NdExtension.Commands;
using NdExtension.Events;
using NextDesign.Desktop;
using NextDesign.Desktop.ExtensionPoints;
using NextDesign.Extension;
using System;
using System.Windows;

namespace NdExtension
{
    /// <summary>
    /// エクステンションのエントリポイントです
    /// </summary>
    public class NdExtensionEntryPoint : ExtensionBase
    {
        /// <summary>
        /// アクティベート時の処理です。
        /// </summary>
        protected override void OnActivate()
        {
            // リボン
            ExtensionPoints.Ribbon.AddTab("NdExtension").AddGroup("Group1").AddLargeButton<HelloCommand>("Hello world");

            // イベント
            ExtensionPoints.Events.Application.RegisterOnAfterStart<ApplicationAfterStart>();
        }
    }
}
