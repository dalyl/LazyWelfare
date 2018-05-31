﻿
namespace LazyWelfare.AndroidAreaView.Core
{
    using Android.Views;

    public class MapArea
    {
        public MapShape Shape { get; set; }

        public string Coords { get; set; }

        public View.IOnClickListener OnClick { get; set; }
    }

}