﻿#pragma checksum "..\..\..\..\AdminPanel\AdminProductPanel_AddEdit.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AE158E9B2CE41F44D36E411CD42234C326B852A8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
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
    /// AdminProductPanel_AddEdit
    /// </summary>
    public partial class AdminProductPanel_AddEdit : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\AdminPanel\AdminProductPanel_AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB_Main;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\AdminPanel\AdminProductPanel_AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Name;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\AdminPanel\AdminProductPanel_AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Price;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\AdminPanel\AdminProductPanel_AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Quantity;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\AdminPanel\AdminProductPanel_AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CB_Supplier;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\AdminPanel\AdminProductPanel_AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CB_Type;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\AdminPanel\AdminProductPanel_AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_ImagePath;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\AdminPanel\AdminProductPanel_AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image IMG_Preview;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\AdminPanel\AdminProductPanel_AddEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_EndManipulation;
        
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
            System.Uri resourceLocater = new System.Uri("/DrugStoreApplication;component/adminpanel/adminproductpanel_addedit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\AdminPanel\AdminProductPanel_AddEdit.xaml"
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
            this.TB_Main = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.TB_Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TB_Price = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\..\AdminPanel\AdminProductPanel_AddEdit.xaml"
            this.TB_Price.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumericTextBox_OnPreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TB_Quantity = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\..\..\AdminPanel\AdminProductPanel_AddEdit.xaml"
            this.TB_Quantity.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumericTextBox_OnPreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CB_Supplier = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.CB_Type = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.TB_ImagePath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 52 "..\..\..\..\AdminPanel\AdminProductPanel_AddEdit.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BTN_SelectImage_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.IMG_Preview = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            this.BTN_EndManipulation = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\..\AdminPanel\AdminProductPanel_AddEdit.xaml"
            this.BTN_EndManipulation.Click += new System.Windows.RoutedEventHandler(this.BTN_EndManipulation_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

