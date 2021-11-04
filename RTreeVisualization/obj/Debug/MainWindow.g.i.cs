﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "365DBE5D4F61D10CDB35707AC84E2DFB6413C0FB1D8AEFD8474DEE3E957AEC2A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace RTreeVisualization {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem GenerateMenuItem;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem GenerateCountItem;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem CurrentPaintMenuItem;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem RangeSearchMenuItem;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ShowStructureMenuItem;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ResetMenuItem;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas RTreeCanvas;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GeometriesCounTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/RTreeVisualization;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            this.GenerateMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 13 "..\..\MainWindow.xaml"
            this.GenerateMenuItem.Click += new System.Windows.RoutedEventHandler(this.GenerateMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GenerateCountItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 19 "..\..\MainWindow.xaml"
            this.GenerateCountItem.Click += new System.Windows.RoutedEventHandler(this.GenerateCountItem_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CurrentPaintMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 27 "..\..\MainWindow.xaml"
            this.CurrentPaintMenuItem.Click += new System.Windows.RoutedEventHandler(this.CurrentPaintMenuItem_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RangeSearchMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 35 "..\..\MainWindow.xaml"
            this.RangeSearchMenuItem.Click += new System.Windows.RoutedEventHandler(this.RangeSearchMenuItem_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ShowStructureMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 40 "..\..\MainWindow.xaml"
            this.ShowStructureMenuItem.Click += new System.Windows.RoutedEventHandler(this.ShowStructureMenuItem_OnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ResetMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 45 "..\..\MainWindow.xaml"
            this.ResetMenuItem.Click += new System.Windows.RoutedEventHandler(this.ResetMenuItem_OnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RTreeCanvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 58 "..\..\MainWindow.xaml"
            this.RTreeCanvas.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.RTreeCanvas_OnMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 59 "..\..\MainWindow.xaml"
            this.RTreeCanvas.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.RTreeCanvas_OnMouseRightButtonDown);
            
            #line default
            #line hidden
            
            #line 60 "..\..\MainWindow.xaml"
            this.RTreeCanvas.MouseMove += new System.Windows.Input.MouseEventHandler(this.RTreeCanvas_OnMouseMove);
            
            #line default
            #line hidden
            return;
            case 8:
            this.GeometriesCounTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
