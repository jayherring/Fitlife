﻿#pragma checksum "..\..\AddFitnessGear.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "65015C7E47DDAB41DB0E450F7F0BDB1D"
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
    /// AddFitnessGear
    /// </summary>
    public partial class AddFitnessGear : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\AddFitnessGear.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid BtnSubmitFG;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AddFitnessGear.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtorder;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AddFitnessGear.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtitem;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AddFitnessGear.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtcolor;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AddFitnessGear.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtprice;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddFitnessGear.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtpprice;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\AddFitnessGear.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtstatus;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AddFitnessGear.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtfgid;
        
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
            System.Uri resourceLocater = new System.Uri("/Fitlife;component/addfitnessgear.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddFitnessGear.xaml"
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
            this.BtnSubmitFG = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.txtorder = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtitem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtcolor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtprice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtpprice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtstatus = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 24 "..\..\AddFitnessGear.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtfgid = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

