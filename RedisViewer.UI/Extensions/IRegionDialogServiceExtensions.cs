﻿using RedisViewer.Core;
using RedisViewer.UI.Views;
using System;

namespace Prism.Services.Dialogs
{
    public static class IRegionDialogServiceExtensions
    {
        public static void ShowNewConnection(this IRegionDialogService dialogService, Action<IDialogResult> callback)
        {
            dialogService.ShowDialog(nameof(NewConnectionView), null, callback);
        }

        public static void ShowNewKey(this IRegionDialogService dialogService, DatabaseInfo database, Action<IDialogResult> callback)
        {
            //dialogService.ShowDialog(nameof(NewKeyView), new DialogParameters { { "database_info", database } }, callback);
        }
    }
}