﻿#pragma checksum "..\..\..\UserControls\HangVeItem.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3E3CA2BEFDEC32E6561D8F3153F51E93988C590D2F4A8DA8581DF758FA6FF542"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Quan_Ly_Ban_Ve_May_Bay.UserControls;
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


namespace Quan_Ly_Ban_Ve_May_Bay.UserControls {
    
    
    /// <summary>
    /// HangVeItem
    /// </summary>
    public partial class HangVeItem : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\UserControls\HangVeItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox maHVcBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\UserControls\HangVeItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SLcBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Quan-Ly-Ban-Ve-May-Bay;component/usercontrols/hangveitem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\HangVeItem.xaml"
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
            this.maHVcBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\..\UserControls\HangVeItem.xaml"
            this.maHVcBox.DropDownClosed += new System.EventHandler(this.maHVcBox_DropDownClosed);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\UserControls\HangVeItem.xaml"
            this.maHVcBox.DropDownOpened += new System.EventHandler(this.maHVcBox_DropDownOpened);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SLcBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\..\UserControls\HangVeItem.xaml"
            this.SLcBox.DropDownClosed += new System.EventHandler(this.SLcBox_DropDownClosed);
            
            #line default
            #line hidden
            
            #line 25 "..\..\..\UserControls\HangVeItem.xaml"
            this.SLcBox.DropDownOpened += new System.EventHandler(this.SLcBox_DropDownOpened);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

