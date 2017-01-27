using System.Text.RegularExpressions;

public class PhoneNumber
{

    string _phoneNumber;
    string _areaCode;
    public string Number { 
        get { 
            return _areaCode + _phoneNumber;
        }
    }

    public string AreaCode { 
        get {
            return _areaCode;
        } 
    }
    public PhoneNumber(string number)
    {
        FillDetails(number);
    }

    void FillDetails(string number)
    {
        // Instead of whitelisting the acceptable formats (and 
        // create 3 regexes for them) just remove the offending
        // characters and get the digits.
        var re = new Regex(@"[-() .]");
        var s = re.Replace(number, "");
        
        if (s.Length == 10) 
        {
            this._phoneNumber = s.Substring(3);
            this._areaCode = s.Substring(0, 3);
        }
        else if (s.Length == 11 && s[0] == '1')
        {
            this._phoneNumber = s.Substring(4);
            this._areaCode = s.Substring(1, 3);
        }
        else
        {
            this._phoneNumber = "0000000";
            this._areaCode = "000";
        }
    }

    public override string ToString()
    {
        return string.Format("({0}) {1}-{2}", _areaCode, _phoneNumber.Substring(0, 3), _phoneNumber.Substring(3));
    }

}