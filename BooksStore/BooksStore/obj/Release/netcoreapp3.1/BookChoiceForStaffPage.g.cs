﻿#pragma checksum "..\..\..\BookChoiceForStaffPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7AF52ED21FAB457035D60B8BDBF3A91EDF35FE7A"
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
    /// BookChoiceForStaffPage
    /// </summary>
    public partial class BookChoiceForStaffPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\BookChoiceForStaffPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegisterDataBook;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\BookChoiceForStaffPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditDataBook;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\BookChoiceForStaffPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DataBook;
        
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
            System.Uri resourceLocater = new System.Uri("/BooksStore;component/bookchoiceforstaffpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\BookChoiceForStaffPage.xaml"
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
            this.RegisterDataBook = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\BookChoiceForStaffPage.xaml"
            this.RegisterDataBook.Click += new System.Windows.RoutedEventHandler(this.RegisterDataBook_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.EditDataBook = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\BookChoiceForStaffPage.xaml"
            this.EditDataBook.Click += new System.Windows.RoutedEventHandler(this.EditDataBook_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DataBook = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\BookChoiceForStaffPage.xaml"
            this.DataBook.Click += new System.Windows.RoutedEventHandler(this.DataBook_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

