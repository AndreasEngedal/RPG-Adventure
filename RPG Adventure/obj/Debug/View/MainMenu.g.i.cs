﻿#pragma checksum "..\..\..\View\MainMenu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9FA5D7922EE6A064BF65060E1075A40F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RPG_Adventure;
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


namespace RPG_Adventure {
    
    
    /// <summary>
    /// MainMenu
    /// </summary>
    public partial class MainMenu : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\View\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal RPG_Adventure.MainMenu RPG_Adventure;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\View\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainMenuLayout;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\View\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loadPlayer;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\View\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button newPlayer;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\View\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitGame;
        
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
            System.Uri resourceLocater = new System.Uri("/RPG Adventure;component/view/mainmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\MainMenu.xaml"
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
            this.RPG_Adventure = ((RPG_Adventure.MainMenu)(target));
            return;
            case 2:
            this.MainMenuLayout = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.loadPlayer = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\View\MainMenu.xaml"
            this.loadPlayer.Click += new System.Windows.RoutedEventHandler(this.loadPlayerButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.newPlayer = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\View\MainMenu.xaml"
            this.newPlayer.Click += new System.Windows.RoutedEventHandler(this.newPlayerButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.exitGame = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\View\MainMenu.xaml"
            this.exitGame.Click += new System.Windows.RoutedEventHandler(this.exitGameButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

