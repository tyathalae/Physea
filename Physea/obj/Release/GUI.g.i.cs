﻿#pragma checksum "..\..\GUI.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "02A32A6A294285958DEC68DE2D508FFB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
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


namespace Physea {
    
    
    /// <summary>
    /// GUI
    /// </summary>
    public partial class GUI : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 83 "..\..\GUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas MainCanvas;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\GUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MassTBo;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\GUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SizeTBo;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\GUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock WeightTBl;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\GUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DragTBl;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\GUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock VelocityTBl;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\GUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock XPosTBl;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\GUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock YPosTBl;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\GUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton CubeRB;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\GUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton SphereRB;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\GUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox UseGravityCB;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\GUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox UseAirResistanceCB;
        
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
            System.Uri resourceLocater = new System.Uri("/Physea;component/gui.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GUI.xaml"
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
            
            #line 9 "..\..\GUI.xaml"
            ((Physea.GUI)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.UserControl_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainCanvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 83 "..\..\GUI.xaml"
            this.MainCanvas.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Canvas_MouseDown);
            
            #line default
            #line hidden
            
            #line 83 "..\..\GUI.xaml"
            this.MainCanvas.MouseMove += new System.Windows.Input.MouseEventHandler(this.Canvas_MouseMove);
            
            #line default
            #line hidden
            
            #line 83 "..\..\GUI.xaml"
            this.MainCanvas.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Canvas_MouseUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MassTBo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.SizeTBo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.WeightTBl = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.DragTBl = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.VelocityTBl = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.XPosTBl = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.YPosTBl = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.CubeRB = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 11:
            this.SphereRB = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 12:
            this.UseGravityCB = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 13:
            this.UseAirResistanceCB = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 14:
            
            #line 136 "..\..\GUI.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Start_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 137 "..\..\GUI.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Stop_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

