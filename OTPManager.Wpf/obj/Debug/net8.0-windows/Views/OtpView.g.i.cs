﻿#pragma checksum "..\..\..\..\Views\OtpView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "306F7D282B07B32962EA2C8BA1190DF6226FB2D3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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


namespace OTPManager.Wpf.Views {
    
    
    /// <summary>
    /// OtpView
    /// </summary>
    public partial class OtpView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\..\Views\OtpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock otpValueTextBlock;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Views\OtpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock otpRemainingSecondsTextBlock;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Views\OtpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid otpsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\..\Views\OtpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label totalRecordsLabel;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\..\Views\OtpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label dbRevisionLabel;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\..\Views\OtpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label dbRevisionTimestampLabel;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\..\Views\OtpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox selectedOtpDescriptionTextBox;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\..\Views\OtpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox selectedOtpBase32SecretKeyTextBox;
        
        #line default
        #line hidden
        
        
        #line 183 "..\..\..\..\Views\OtpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveButton;
        
        #line default
        #line hidden
        
        
        #line 190 "..\..\..\..\Views\OtpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button insertButton;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\..\..\Views\OtpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteButton;
        
        #line default
        #line hidden
        
        
        #line 213 "..\..\..\..\Views\OtpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button qrCodeButton;
        
        #line default
        #line hidden
        
        
        #line 220 "..\..\..\..\Views\OtpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button randomButton;
        
        #line default
        #line hidden
        
        
        #line 227 "..\..\..\..\Views\OtpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exportOtpKeysButton;
        
        #line default
        #line hidden
        
        
        #line 236 "..\..\..\..\Views\OtpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar progressBar;
        
        #line default
        #line hidden
        
        
        #line 247 "..\..\..\..\Views\OtpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock infoMessageTextBlock;
        
        #line default
        #line hidden
        
        
        #line 257 "..\..\..\..\Views\OtpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock programInfoTextBlock;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/OTPManager;V0.15.0.0;component/views/otpview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\OtpView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 14 "..\..\..\..\Views\OtpView.xaml"
            ((OTPManager.Wpf.Views.OtpView)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_KeyDown);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\..\Views\OtpView.xaml"
            ((OTPManager.Wpf.Views.OtpView)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\..\Views\OtpView.xaml"
            ((OTPManager.Wpf.Views.OtpView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.otpValueTextBlock = ((System.Windows.Controls.TextBlock)(target));
            
            #line 54 "..\..\..\..\Views\OtpView.xaml"
            this.otpValueTextBlock.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.OtpValueTextBlock_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.otpRemainingSecondsTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.otpsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 75 "..\..\..\..\Views\OtpView.xaml"
            this.otpsDataGrid.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.OtpsDataGrid_SelectedCellsChanged);
            
            #line default
            #line hidden
            
            #line 77 "..\..\..\..\Views\OtpView.xaml"
            this.otpsDataGrid.CellEditEnding += new System.EventHandler<System.Windows.Controls.DataGridCellEditEndingEventArgs>(this.OtpsDataGrid_CellEditEnding);
            
            #line default
            #line hidden
            return;
            case 5:
            this.totalRecordsLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.dbRevisionLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.dbRevisionTimestampLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.selectedOtpDescriptionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.selectedOtpBase32SecretKeyTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.saveButton = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.insertButton = ((System.Windows.Controls.Button)(target));
            return;
            case 12:
            this.deleteButton = ((System.Windows.Controls.Button)(target));
            return;
            case 13:
            this.qrCodeButton = ((System.Windows.Controls.Button)(target));
            return;
            case 14:
            this.randomButton = ((System.Windows.Controls.Button)(target));
            return;
            case 15:
            this.exportOtpKeysButton = ((System.Windows.Controls.Button)(target));
            return;
            case 16:
            this.progressBar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 17:
            this.infoMessageTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 18:
            this.programInfoTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

