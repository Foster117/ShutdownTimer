﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82710A66F3666702FAD251D7F7AAD831D5D6B666"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Hardcodet.Wpf.TaskbarNotification;
using ShutdownTimer;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ShutdownTimer {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ShutdownTimer.MainWindow timerWindow;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar progress;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_0_5hour;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_1hour;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_1_5hour;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_2hour;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_hours;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_minutes;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_Start;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_seconds;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_Stop;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rb_Shutdown;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rb_Restart;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rb_Lock;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rb_PlaySound;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rb_Sleep;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rb_Hibernate;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ShutdownTimer;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.timerWindow = ((ShutdownTimer.MainWindow)(target));
            
            #line 9 "..\..\MainWindow.xaml"
            this.timerWindow.Closing += new System.ComponentModel.CancelEventHandler(this.TimerWindow_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.progress = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 3:
            this.b_0_5hour = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\MainWindow.xaml"
            this.b_0_5hour.Click += new System.Windows.RoutedEventHandler(this.B_0_5hour_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.b_1hour = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\MainWindow.xaml"
            this.b_1hour.Click += new System.Windows.RoutedEventHandler(this.B_1hour_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.b_1_5hour = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\MainWindow.xaml"
            this.b_1_5hour.Click += new System.Windows.RoutedEventHandler(this.B_1_5hour_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.b_2hour = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\MainWindow.xaml"
            this.b_2hour.Click += new System.Windows.RoutedEventHandler(this.B_2hour_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tb_hours = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\MainWindow.xaml"
            this.tb_hours.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Tb_hours_TextChanged);
            
            #line default
            #line hidden
            
            #line 27 "..\..\MainWindow.xaml"
            this.tb_hours.GotFocus += new System.Windows.RoutedEventHandler(this.Tb_hours_GotFocus);
            
            #line default
            #line hidden
            
            #line 27 "..\..\MainWindow.xaml"
            this.tb_hours.LostFocus += new System.Windows.RoutedEventHandler(this.Tb_hours_LostFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tb_minutes = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\MainWindow.xaml"
            this.tb_minutes.LostFocus += new System.Windows.RoutedEventHandler(this.Tb_minutes_LostFocus);
            
            #line default
            #line hidden
            
            #line 28 "..\..\MainWindow.xaml"
            this.tb_minutes.GotFocus += new System.Windows.RoutedEventHandler(this.Tb_minutes_GotFocus);
            
            #line default
            #line hidden
            
            #line 28 "..\..\MainWindow.xaml"
            this.tb_minutes.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Tb_minutes_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.b_Start = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\MainWindow.xaml"
            this.b_Start.Click += new System.Windows.RoutedEventHandler(this.B_Start_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.tb_seconds = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\MainWindow.xaml"
            this.tb_seconds.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Tb_seconds_TextChanged);
            
            #line default
            #line hidden
            
            #line 30 "..\..\MainWindow.xaml"
            this.tb_seconds.GotFocus += new System.Windows.RoutedEventHandler(this.Tb_seconds_GotFocus);
            
            #line default
            #line hidden
            
            #line 30 "..\..\MainWindow.xaml"
            this.tb_seconds.LostFocus += new System.Windows.RoutedEventHandler(this.Tb_seconds_LostFocus);
            
            #line default
            #line hidden
            return;
            case 11:
            this.b_Stop = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\MainWindow.xaml"
            this.b_Stop.Click += new System.Windows.RoutedEventHandler(this.B_Stop_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.rb_Shutdown = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 13:
            this.rb_Restart = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 14:
            this.rb_Lock = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 15:
            this.rb_PlaySound = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 16:
            
            #line 42 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Label_MouseDown);
            
            #line default
            #line hidden
            return;
            case 17:
            this.rb_Sleep = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 18:
            this.rb_Hibernate = ((System.Windows.Controls.RadioButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

