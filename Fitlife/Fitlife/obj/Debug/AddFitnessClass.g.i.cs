﻿#pragma checksum "..\..\AddFitnessClass.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "068C7F070C7F124BF1C85A80ED46CABB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Fitlife;
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


namespace Fitlife {
    
    
    /// <summary>
    /// AddFitnessClass
    /// </summary>
    public partial class AddFitnessClass : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\AddFitnessClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSubmitFC;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AddFitnessClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtfcidfc;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AddFitnessClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtempfc;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AddFitnessClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtorderfc;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddFitnessClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtclassfc;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AddFitnessClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtdatesfc;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\AddFitnessClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtpricefc;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AddFitnessClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtstatusfc;
        
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
            System.Uri resourceLocater = new System.Uri("/Fitlife;component/addfitnessclass.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddFitnessClass.xaml"
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
            this.BtnSubmitFC = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\AddFitnessClass.xaml"
            this.BtnSubmitFC.Click += new System.Windows.RoutedEventHandler(this.BtnSubmitFC_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtfcidfc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtempfc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtorderfc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtclassfc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtdatesfc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtpricefc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtstatusfc = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

