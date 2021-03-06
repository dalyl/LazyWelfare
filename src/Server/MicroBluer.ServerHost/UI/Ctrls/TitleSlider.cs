﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MicroBluer.ServerHost.UI.Ctrls
{

    [TemplatePart(Name = TitleTextBlockKey, Type = typeof(Slider))]
    public class TitleSlider: Slider
    {
        private const string TitleTextBlockKey = "PART_TitleTextBlock";

        private TextBlock _tbkTitle;

        public static readonly DependencyProperty TitleProperty;

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        static TitleSlider()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TitleSlider), new FrameworkPropertyMetadata(typeof(TitleSlider)));

            TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(TitleSlider), new UIPropertyMetadata(new PropertyChangedCallback(TitlePropertyChangedCallback)));
        }

        private static void TitlePropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TitleSlider ttb = d as TitleSlider;

            if (ttb._tbkTitle != null)
            {
                ttb._tbkTitle.Text = (string)e.NewValue;
            }
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _tbkTitle = Template.FindName(TitleTextBlockKey, this) as TextBlock;
            if (_tbkTitle == null) return;
            _tbkTitle.Text = Title;
        }
    }
}
