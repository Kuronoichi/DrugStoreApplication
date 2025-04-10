﻿#pragma checksum "..\..\..\..\AdminPanel\AdminOrderPanel_AddEdit.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EA5E294A3926D5B3890081A080ABC04EA9E0258C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DrugStoreApplication.AdminPanel;
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


namespace DrugStoreApplication.AdminPanel {
    
    
    /// <summary>
    /// AdminOrderPanel_AddEdit
    /// </summary>
    public partial class AdminOrderPanel_AddEdit : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 30 "..\..\..\..\AdminPanel\AdminOrderPanel_AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\AdminPanel\AdminOrderPanel_AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Search;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\AdminPanel\AdminOrderPanel_AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ProductsGrid;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\AdminPanel\AdminOrderPanel_AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid CartGrid;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\AdminPanel\AdminOrderPanel_AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TotalAmountText;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\AdminPanel\AdminOrderPanel_AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SupplierComboBox;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\AdminPanel\AdminOrderPanel_AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_EditOrder;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\AdminPanel\AdminOrderPanel_AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_AddOrder;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DrugStoreApplication;component/adminpanel/adminorderpanel_addedit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\AdminPanel\AdminOrderPanel_AddEdit.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SearchTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.BTN_Search = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\AdminPanel\AdminOrderPanel_AddEdit.xaml"
            this.BTN_Search.Click += new System.Windows.RoutedEventHandler(this.BTN_Search_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ProductsGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.CartGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.TotalAmountText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.SupplierComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 99 "..\..\..\..\AdminPanel\AdminOrderPanel_AddEdit.xaml"
            this.SupplierComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SupplierComboBox_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BTN_EditOrder = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\..\AdminPanel\AdminOrderPanel_AddEdit.xaml"
            this.BTN_EditOrder.Click += new System.Windows.RoutedEventHandler(this.BTN_EditOrder_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BTN_AddOrder = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\..\..\AdminPanel\AdminOrderPanel_AddEdit.xaml"
            this.BTN_AddOrder.Click += new System.Windows.RoutedEventHandler(this.BTN_AddOrder_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 4:
            
            #line 46 "..\..\..\..\AdminPanel\AdminOrderPanel_AddEdit.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BTN_Add_OnClick);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 81 "..\..\..\..\AdminPanel\AdminOrderPanel_AddEdit.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BTN_Remove_OnClick);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

