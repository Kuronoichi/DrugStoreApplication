﻿#pragma checksum "..\..\..\AdminSupplierPanel.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E3E8B38F32062E78B313C43A384207C6CC049A1C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DrugStoreApplication;
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


namespace DrugStoreApplication {
    
    
    /// <summary>
    /// AdminSupplierPanel
    /// </summary>
    public partial class AdminSupplierPanel : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\AdminSupplierPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Profile;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\AdminSupplierPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Orders;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\AdminSupplierPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Products;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\AdminSupplierPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Suppliers;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\AdminSupplierPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Users;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\AdminSupplierPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Add;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\AdminSupplierPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Edit;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\AdminSupplierPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Delete;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\AdminSupplierPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid SuppliersGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/DrugStoreApplication;component/adminsupplierpanel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AdminSupplierPanel.xaml"
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
            this.BTN_Profile = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\AdminSupplierPanel.xaml"
            this.BTN_Profile.Click += new System.Windows.RoutedEventHandler(this.BTN_Profile_OnClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BTN_Orders = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\AdminSupplierPanel.xaml"
            this.BTN_Orders.Click += new System.Windows.RoutedEventHandler(this.BTN_Orders_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BTN_Products = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\AdminSupplierPanel.xaml"
            this.BTN_Products.Click += new System.Windows.RoutedEventHandler(this.BTN_Products_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BTN_Suppliers = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\AdminSupplierPanel.xaml"
            this.BTN_Suppliers.Click += new System.Windows.RoutedEventHandler(this.BTN_Suppliers_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BTN_Users = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\AdminSupplierPanel.xaml"
            this.BTN_Users.Click += new System.Windows.RoutedEventHandler(this.BTN_Users_OnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BTN_Add = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\AdminSupplierPanel.xaml"
            this.BTN_Add.Click += new System.Windows.RoutedEventHandler(this.BTN_Add_OnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BTN_Edit = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\AdminSupplierPanel.xaml"
            this.BTN_Edit.Click += new System.Windows.RoutedEventHandler(this.BTN_Edit_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BTN_Delete = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\AdminSupplierPanel.xaml"
            this.BTN_Delete.Click += new System.Windows.RoutedEventHandler(this.BTN_Delete_OnClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.SuppliersGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

