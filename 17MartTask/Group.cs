using System;
using System.Collections.Generic;
using System.Text;

namespace _17MartTask
{
    class Group
    {
        private string _no;
        private int _studentLimit;

        public string No
        {
            get => this._no;
            set
            {
                if (value.Length > 0 && CheckUpper(value))
                {
                    this._no = value;
                }
            }
        }
        public int StudentLimit
        {
            get => _studentLimit;
            set
            {
                if (value >= 0)
                {
                    this._studentLimit = value;
                }
            }
        }

        public bool CheckUpper(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                if (char.IsUpper(name[0]) && char.IsUpper(name[1]) && char.IsDigit(name[2]) && char.IsDigit(name[3]) && char.IsDigit(name[4]))
                {
                    return true;
                }

            }
            return false;
        }
        public string GetInfo()
        {
            return $"No: {this.No} - Name: {this.StudentLimit}";



        }
    }
}
