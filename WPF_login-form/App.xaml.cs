﻿using System.Configuration;
using System.Data;
using System.Windows;

namespace WPF_login_form;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public IServiceProvider Services { get; }
    public new static App Current => (App)Application.Current;

}
