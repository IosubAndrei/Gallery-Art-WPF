﻿#pragma checksum "..\..\..\..\..\App\Main\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3C0EFC96827F8681E13080D211306851328565C1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BD_Proiect;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace BD_Proiect {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\..\App\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Menu_User_Grid;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\App\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Menu_Buttons_Grid;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\App\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Gallerys_Button;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\..\App\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Commands_Button;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\..\App\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Employee_Button;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\..\App\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit_Button;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\..\App\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Sign_Out_Button;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\..\App\Main\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mainGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BD_Proiect;component/app/main/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\App\Main\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 12 "..\..\..\..\..\App\Main\MainWindow.xaml"
            ((BD_Proiect.MainWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Menu_User_Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Menu_Buttons_Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.Gallerys_Button = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\..\App\Main\MainWindow.xaml"
            this.Gallerys_Button.Click += new System.Windows.RoutedEventHandler(this.Gallerys_Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Commands_Button = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\..\..\App\Main\MainWindow.xaml"
            this.Commands_Button.Click += new System.Windows.RoutedEventHandler(this.Commands_Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Employee_Button = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\..\App\Main\MainWindow.xaml"
            this.Employee_Button.Click += new System.Windows.RoutedEventHandler(this.Employee_Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Exit_Button = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\..\..\..\App\Main\MainWindow.xaml"
            this.Exit_Button.Click += new System.Windows.RoutedEventHandler(this.Exit_Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Sign_Out_Button = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\..\..\..\App\Main\MainWindow.xaml"
            this.Sign_Out_Button.Click += new System.Windows.RoutedEventHandler(this.Sign_Out_Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.mainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

