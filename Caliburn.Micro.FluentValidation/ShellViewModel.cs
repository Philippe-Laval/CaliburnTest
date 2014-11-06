namespace Caliburn.Micro.FluentValidation
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.Composition;
    using System.Windows;
    using System.Linq;
    using FluentValidation;

    [Export(typeof(IShell))]
    public class ShellViewModel : PropertyChangedBase, IShell, IDataErrorInfo
    {
        private readonly ShellValidator _shellValidator;
        string name;
        string email;
        string zip;

        public ShellViewModel()
        {
            _shellValidator = new ShellValidator();
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyOfPropertyChange(() => Name);
                NotifyOfPropertyChange(() => Error);
                NotifyOfPropertyChange(() => CanSayHello);
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                NotifyOfPropertyChange(() => Email);
                NotifyOfPropertyChange(() => Error);
                NotifyOfPropertyChange(() => CanSayHello);
            }
        }

        public string Zip
        {
            get { return zip; }
            set
            {
                zip = value;
                NotifyOfPropertyChange(() => Zip);
                NotifyOfPropertyChange(() => Error);
                NotifyOfPropertyChange(() => CanSayHello);
            }
        }

        public bool CanSayHello
        {
 //           get { return !string.IsNullOrWhiteSpace(Name); }
            get { return string.IsNullOrWhiteSpace(Error); }
        }

        public void SayHello()
        {
            MessageBox.Show(string.Format("Hello {0}!", Name));
        }

        #region IDataErrorInfo
        public string this[string columnName]
        {
            get
            {
                var firstOrDefault = _shellValidator.Validate(this).Errors.FirstOrDefault(lol => lol.PropertyName == columnName);
                if (firstOrDefault != null)
                    return _shellValidator != null ? firstOrDefault.ErrorMessage : "";
                return "";
            }
        }

        public string Error
        {
            get
            {
                if (_shellValidator != null)
                {
                    var results = _shellValidator.Validate(this);
                    if (results != null && results.Errors.Any())
                    {
                        var errors = string.Join(Environment.NewLine, results.Errors.Select(x => x.ErrorMessage).ToArray());
                        return errors;
                    }
                }
                return string.Empty;
            }
        }
        #endregion

    }
}