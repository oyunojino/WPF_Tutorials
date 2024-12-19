﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Serilog;
using WPF_login_form.Core;
using WPF_login_form.Word;
using WPF_login_form.Word.Core;

namespace WPF_login_form;

public partial class LoginViewModel : BaseViewModel
{
    private readonly ILogger _logger;


    /// <summary>
    /// The email of the user
    /// </summary>
    [ObservableProperty]
    private string _email;

    [ObservableProperty]
    private bool _loginIsRunning;

    public LoginViewModel()
    {
        //Email = "choshinyoun@naver.com";

    }

    [RelayCommand]
    private async Task OnRegisterAsync()
    {
        (App.Current.MainWindow.DataContext as MenuViewModel).CurrentPage = ApplicationPage.Register;
        await Task.Delay(1);
    }

    // LoginCommand
    [RelayCommand]
    private async Task OnLoginAsync(object parmeter)
    {
        await RunCommandAsync(() => LoginIsRunning, async () =>
        {
            var pass2 = (parmeter as IHavePassword).SecurePassword.Unsecure();
            var email = Email;
            //MessageBox.Show("1111");
            await Task.Delay(3000);
        });
    }
}