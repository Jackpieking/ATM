using Client.View;
using System;

namespace Client.Services;

public class FormContainer : IDisposable
{
    private LoginForm _loginForm;
    private LoadingForm _loadingForm;
    private LoginErrorForm _loginErrorForm;
    private UserMenuForm _userMenuForm;
    private ViewBalanceForm _viewBalanceForm;
    private WithdrawForm _withdrawForm;
    private ConfirmWithdrawForm _confirmWithdrawForm;
    private WithdrawSuccessfullyForm _withdrawSuccessfullyForm;

    public WithdrawSuccessfullyForm GetWithdrawSuccessfullyForm()
    {
        _withdrawSuccessfullyForm ??= new();

        return _withdrawSuccessfullyForm;
    }

    public ConfirmWithdrawForm GetConfirmWithdrawForm()
    {
        _confirmWithdrawForm ??= new();

        return _confirmWithdrawForm;
    }

    public WithdrawForm GetWithdrawForm()
    {
        _withdrawForm ??= new();

        return _withdrawForm;
    }

    public LoginForm GetLoginForm()
    {
        _loginForm ??= new();

        return _loginForm;
    }

    public LoadingForm GetLoadingForm()
    {
        _loadingForm ??= new();

        return _loadingForm;
    }

    public LoginErrorForm GetLoginErrorForm()
    {
        _loginErrorForm ??= new();

        return _loginErrorForm;
    }

    public UserMenuForm GetUserMenuForm()
    {
        _userMenuForm ??= new();

        return _userMenuForm;
    }

    public ViewBalanceForm GetViewBalanceForm()
    {
        _viewBalanceForm ??= new();

        return _viewBalanceForm;
    }

    private bool disposedValue;

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
                _loginForm?.Dispose();
                _userMenuForm?.Dispose();
                _loadingForm?.Dispose();
                _viewBalanceForm?.Dispose();
                _loginErrorForm?.Dispose();
                _confirmWithdrawForm?.Dispose();
                _withdrawForm?.Dispose();
                _withdrawSuccessfullyForm?.Dispose();
            }

            // TODO: free unmanaged resources (unmanaged objects)
            disposedValue = true;
        }
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(obj: this);
    }
}
