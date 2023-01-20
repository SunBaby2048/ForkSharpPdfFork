﻿using Avalonia.Media;
using Newtonsoft.Json;
using System;
using YpdfDesktop.Infrastructure.Serialization;

namespace YpdfDesktop.Models.Themes
{
    public class WindowTheme : IWindowTheme
    {
        public string Id { get; }
        public string Name { get; set; }

        [JsonConverter(typeof(ISolidColorBrushConverter))]
        public ISolidColorBrush? ExplorerBackground { get; set; }

        [JsonConverter(typeof(ISolidColorBrushConverter))]
        public ISolidColorBrush? LinkIconForeground { get; set; }
        [JsonConverter(typeof(ISolidColorBrushConverter))]
        public ISolidColorBrush? FavoriteStarIconForeground { get; set; }
        [JsonConverter(typeof(ISolidColorBrushConverter))]
        public ISolidColorBrush? NotFavoriteStarIconForeground { get; set; }

        [JsonConverter(typeof(ISolidColorBrushConverter))]
        public ISolidColorBrush? PanelSelectorBackground { get; set; }
        [JsonConverter(typeof(ISolidColorBrushConverter))]
        public ISolidColorBrush? PanelSelectorIconForeground { get; set; }
        [JsonConverter(typeof(ISolidColorBrushConverter))]
        public ISolidColorBrush? PanelSelectorTextForeground { get; set; }
        [JsonConverter(typeof(ISolidColorBrushConverter))]
        public ISolidColorBrush? PanelSelectorTileDefaultBackground { get; set; }
        [JsonConverter(typeof(ISolidColorBrushConverter))]
        public ISolidColorBrush? PanelSelectorTileEnteredBackground { get; set; }
        [JsonConverter(typeof(ISolidColorBrushConverter))]
        public ISolidColorBrush? PanelSelectorTilePressedBackground { get; set; }

        [JsonConverter(typeof(ISolidColorBrushConverter))]
        public ISolidColorBrush? ToolTileBorderBrush { get; set; }
        [JsonConverter(typeof(ISolidColorBrushConverter))]
        public ISolidColorBrush? ToolTileIconForeground { get; set; }
        [JsonConverter(typeof(ISolidColorBrushConverter))]
        public ISolidColorBrush? ToolTileTextForeground { get; set; }
        [JsonConverter(typeof(ISolidColorBrushConverter))]
        public ISolidColorBrush? ToolTileDefaultBackground { get; set; }
        [JsonConverter(typeof(ISolidColorBrushConverter))]
        public ISolidColorBrush? ToolTileEnteredBackground { get; set; }
        [JsonConverter(typeof(ISolidColorBrushConverter))]
        public ISolidColorBrush? ToolTilePressedBackground { get; set; }

        public WindowTheme() : this(Guid.NewGuid().ToString())
        {
        }

        public WindowTheme(string id) : this(id, string.Empty)
        {
        }

        public WindowTheme(string id, string name)
        {
            Id = id;
            Name = name;

            SetBrushes();
        }

        protected virtual void SetBrushes()
        {
        }
    }
}
