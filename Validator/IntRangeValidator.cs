using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Validator
{
    public class IntRangeValidator : ValidationRule
    {
        private int _minvalue;
        private int _maxvalue;

        public int MaxValue
        {
            get { return _maxvalue; }
            set { _maxvalue = value; }
        }

        public IntRangeValidator()
        {
            _minvalue = Int32.MinValue;
            _maxvalue = Int32.MaxValue;
        }

        public int MinValue
        {
            get { return _minvalue; }
            set { _minvalue = value; }
        }


        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            int res = 0;

            try
            {
                if (((string)value).Length > 0)
                {
                    res = Int32.Parse((string)value);
                }
            }
            catch
            {
                return new ValidationResult(false, "illegal character");
            }

            if ((res < MinValue) || (res > MaxValue))
            {
                return new ValidationResult(false, "not in range");
            }

            return new ValidationResult(true, "");
        }
    }
}
