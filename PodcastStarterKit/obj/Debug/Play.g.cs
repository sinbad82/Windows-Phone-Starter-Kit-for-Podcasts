﻿#pragma checksum "C:\Users\dani\Documents\Visual Studio 2010\Projects\PodcastStarterKit\PodcastStarterKit\Play.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B0FF837C32D57C9574CA61501E43AC77"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.488
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PodcastStarterKit {
    
    
    public partial class Play : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Image ShowImage;
        
        internal System.Windows.Controls.ProgressBar positionIndicator;
        
        internal System.Windows.Controls.TextBlock textPosition;
        
        internal System.Windows.Controls.TextBlock textRemaining;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton Back;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton PlayTrack;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton Forward;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/PodcastStarterKit;component/Play.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.ShowImage = ((System.Windows.Controls.Image)(this.FindName("ShowImage")));
            this.positionIndicator = ((System.Windows.Controls.ProgressBar)(this.FindName("positionIndicator")));
            this.textPosition = ((System.Windows.Controls.TextBlock)(this.FindName("textPosition")));
            this.textRemaining = ((System.Windows.Controls.TextBlock)(this.FindName("textRemaining")));
            this.Back = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("Back")));
            this.PlayTrack = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("PlayTrack")));
            this.Forward = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("Forward")));
        }
    }
}

