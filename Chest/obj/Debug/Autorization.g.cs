#pragma checksum "..\..\Autorization.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "511111FE79CD8E60890860E354291488E411EAB70F75D7DE45CEC8418BF8D96D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Chest;
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


namespace Chest {
    
    
    /// <summary>
    /// Autorization
    /// </summary>
    public partial class Autorization : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\Autorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Autoriz;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Autorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginText;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\Autorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PasswordText;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Autorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegistrationButton;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\Autorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AuthorizationCommit;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\Autorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AuthorizationRollBack;
        
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
            System.Uri resourceLocater = new System.Uri("/Chest;component/autorization.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Autorization.xaml"
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
            this.Autoriz = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.LoginText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.PasswordText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.RegistrationButton = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\Autorization.xaml"
            this.RegistrationButton.Click += new System.Windows.RoutedEventHandler(this.RegistrationButton_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AuthorizationCommit = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\Autorization.xaml"
            this.AuthorizationCommit.Click += new System.Windows.RoutedEventHandler(this.AuthorizationCommit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AuthorizationRollBack = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\Autorization.xaml"
            this.AuthorizationRollBack.Click += new System.Windows.RoutedEventHandler(this.AuthorizationRollBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

