﻿#pragma checksum "..\..\Zayavka.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ED1E489C72D110D6448E68CB845B692CA4DBC20184A38E44AD94CC56E3BBB33A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.MahApps;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using uargaz;


namespace uargaz {
    
    
    /// <summary>
    /// Zayavka
    /// </summary>
    public partial class Zayavka : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\Zayavka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchSotrudnik;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Zayavka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ZayavkaTB;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Zayavka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ContextMenuAdd;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Zayavka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ContextMenuChange;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Zayavka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ContextMenuRemove;
        
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
            System.Uri resourceLocater = new System.Uri("/uargaz;component/zayavka.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Zayavka.xaml"
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
            this.SearchSotrudnik = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.ZayavkaTB = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.ContextMenuAdd = ((System.Windows.Controls.MenuItem)(target));
            
            #line 28 "..\..\Zayavka.xaml"
            this.ContextMenuAdd.Click += new System.Windows.RoutedEventHandler(this.ContextMenuAdd_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ContextMenuChange = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 5:
            this.ContextMenuRemove = ((System.Windows.Controls.MenuItem)(target));
            
            #line 32 "..\..\Zayavka.xaml"
            this.ContextMenuRemove.Click += new System.Windows.RoutedEventHandler(this.ContextMenuRemove_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
