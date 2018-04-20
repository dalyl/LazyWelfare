﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;

namespace LazyWelfare.Mobile.Android
{
    public interface IAgreementHandle
    {
        void Init(WebView webView, string url);
        bool Result { get; }
    }
}