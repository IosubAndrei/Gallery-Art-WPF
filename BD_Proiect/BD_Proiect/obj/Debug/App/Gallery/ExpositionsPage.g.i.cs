﻿#pragma checksum "..\..\..\..\App\Gallery\ExpositionsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0F988DD9FC607606BDE9C400D7FD800AE21A9B908C23A20CA43664D95B248DF9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BD_Proiect.Gallery;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace BD_Proiect.Gallery {
    
    
    /// <summary>
    /// ExpositionsPage
    /// </summary>
    public partial class ExpositionsPage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\App\Gallery\ExpositionsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ExpositionsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\App\Gallery\ExpositionsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn columnName;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\App\Gallery\ExpositionsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn columnStart;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\App\Gallery\ExpositionsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn columnFinsh;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\App\Gallery\ExpositionsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GallerysButton;
        
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
            System.Uri resourceLocater = new System.Uri("/BD_Proiect;component/app/gallery/expositionspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\App\Gallery\ExpositionsPage.xaml"
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
            this.ExpositionsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 10 "..\..\..\..\App\Gallery\ExpositionsPage.xaml"
            this.ExpositionsDataGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ExpositionsDataGrid_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.columnName = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 3:
            this.columnStart = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 4:
            this.columnFinsh = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.GallerysButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\App\Gallery\ExpositionsPage.xaml"
            this.GallerysButton.Click += new System.Windows.RoutedEventHandler(this.Gallerys_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

