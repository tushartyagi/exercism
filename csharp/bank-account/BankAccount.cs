using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public class ValidateAccountAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext context) 
    {
        bool isOpen = (bool)context.ObjectType.GetMember("IsOpen").GetValue();
        if (isOpen) return ValidationResult.Success;
        else throw new InvalidOperationException();
    }
}

public class BankAccount
{
    private int _balance;
    private bool _isOpen;
    private object _lock = new object();
        
    public void Open()
    {
        _balance = 0;
        _isOpen = true;
    }
    
    private void ValidateAccount()
    {
        if (!_isOpen) throw new InvalidOperationException(); 

    }    

    //[ValidateAccount]
    public int GetBalance() 
    {
        ValidateAccount();
        return _balance;
    }

    //[ValidateAccount]
    public void UpdateBalance(int entry)
    {
        ValidateAccount();
        lock (_lock)
        {
            _balance += entry;    
        }
    }

    public void Close()
    {
        _isOpen = false;
    }
}