﻿#pragma checksum "C:\Users\j.hou\Documents\Visual Studio 2013\Projects\Cordova\Hello\Hello\bld\Debug\platforms\wp8\cordovalib\CordovaView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4A3A0EBCA039BA5A8D6DDA94A843C5A4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.34209
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
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


namespace WPCordovaClassLib {
    
    
    public partial class CordovaView : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.WebBrowser CordovaBrowser;
        
        internal System.Windows.Media.Animation.Storyboard FadeIn;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/io.cordova.Hello;component/cordovalib/CordovaView.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CordovaBrowser = ((Microsoft.Phone.Controls.WebBrowser)(this.FindName("CordovaBrowser")));
            this.FadeIn = ((System.Windows.Media.Animation.Storyboard)(this.FindName("FadeIn")));
        }
    }
}

