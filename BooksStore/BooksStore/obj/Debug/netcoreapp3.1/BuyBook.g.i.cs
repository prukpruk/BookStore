﻿#pragma checksum "..\..\..\BuyBook.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D4E1645A39894E0D83E341E904566209A6F32A05"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BooksStore;
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


namespace BooksStore {
    
    
    /// <summary>
    /// BuyBook
    /// </summary>
    public partial class BuyBook : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\BuyBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtISBN;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\BuyBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmailCustomer;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\BuyBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtQuatity;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\BuyBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTotalPrice;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\BuyBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CheckButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\BuyBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BuyButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BooksStore;V1.0.0.0;component/buybook.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\BuyBook.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtISBN = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtEmailCustomer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtQuatity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtTotalPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CheckButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\BuyBook.xaml"
            this.CheckButton.Click += new System.Windows.RoutedEventHandler(this.CheckButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BuyButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\BuyBook.xaml"
            this.BuyButton.Click += new System.Windows.RoutedEventHandler(this.BuyButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

