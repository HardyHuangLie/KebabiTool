﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C69092827F3FB7B98B033B47EB133379E46FD4D0DCC724CBF7E3EB58ED94960D"
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

using Kebabi;
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


namespace Kebabi {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 183 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Remove;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox First;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Forth;
        
        #line default
        #line hidden
        
        
        #line 201 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Third;
        
        #line default
        #line hidden
        
        
        #line 208 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Second;
        
        #line default
        #line hidden
        
        
        #line 215 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Fifth;
        
        #line default
        #line hidden
        
        
        #line 222 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Sixth;
        
        #line default
        #line hidden
        
        
        #line 230 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Start;
        
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
            System.Uri resourceLocater = new System.Uri("/Kebabi;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            this.Remove = ((System.Windows.Controls.CheckBox)(target));
            
            #line 183 "..\..\MainWindow.xaml"
            this.Remove.Checked += new System.Windows.RoutedEventHandler(this.Remove_Checked);
            
            #line default
            #line hidden
            
            #line 183 "..\..\MainWindow.xaml"
            this.Remove.Unchecked += new System.Windows.RoutedEventHandler(this.Remove_Unchecked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.First = ((System.Windows.Controls.CheckBox)(target));
            
            #line 187 "..\..\MainWindow.xaml"
            this.First.Checked += new System.Windows.RoutedEventHandler(this.First_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Forth = ((System.Windows.Controls.CheckBox)(target));
            
            #line 194 "..\..\MainWindow.xaml"
            this.Forth.Checked += new System.Windows.RoutedEventHandler(this.Forth_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Third = ((System.Windows.Controls.CheckBox)(target));
            
            #line 201 "..\..\MainWindow.xaml"
            this.Third.Checked += new System.Windows.RoutedEventHandler(this.Third_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Second = ((System.Windows.Controls.CheckBox)(target));
            
            #line 208 "..\..\MainWindow.xaml"
            this.Second.Checked += new System.Windows.RoutedEventHandler(this.Second_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Fifth = ((System.Windows.Controls.CheckBox)(target));
            
            #line 215 "..\..\MainWindow.xaml"
            this.Fifth.Checked += new System.Windows.RoutedEventHandler(this.Fifth_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Sixth = ((System.Windows.Controls.CheckBox)(target));
            
            #line 222 "..\..\MainWindow.xaml"
            this.Sixth.Checked += new System.Windows.RoutedEventHandler(this.Sixth_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Start = ((System.Windows.Controls.Button)(target));
            
            #line 230 "..\..\MainWindow.xaml"
            this.Start.Click += new System.Windows.RoutedEventHandler(this.Start_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

