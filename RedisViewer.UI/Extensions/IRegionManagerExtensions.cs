﻿using RedisViewer.Core;
using RedisViewer.UI.Views;
using StackExchange.Redis;

namespace Prism.Regions
{
    public static class IRegionManagerExtensions
    {
        public static void ShowKeyViewer(this IRegionManager regionManager, KeyInfo key)
        {
            var parameters = new NavigationParameters { { "key", key } };
            regionManager.RequestNavigate("ShellRegion", nameof(KeyViewerView), parameters);
        }

        public static void ShowKeyViewerByType(this IRegionManager regionManager, KeyInfo key)
        {
            var parameters = new NavigationParameters { { "key", key } };

            var page = key.Type switch
            {
                RedisType.String => nameof(KeyStringView),
                RedisType.List => nameof(KeyListView),
                RedisType.Set => nameof(KeySetView),
                RedisType.SortedSet => nameof(KeyZsetView),
                RedisType.Hash => nameof(KeyHashView),
                RedisType.Stream => nameof(KeyStreamView),
                _ => nameof(KeyStringView)
            };

            regionManager.RequestNavigate("ViewerRegion", page, parameters);
        }
    }
}