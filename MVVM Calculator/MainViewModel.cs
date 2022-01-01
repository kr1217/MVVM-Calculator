using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Calculator
{
    class MainViewModel : MainViewModelBase
    {
        private Calculator calcular_ = null;
        private double result_ = 0.0;
        private double value1_ = 0.0;
        private double value2_ = 0.0;
        private bool isAddChecked_ = false;
        private bool isSubChecked_ = false;
        private bool isMulChecked_ = false;
        private bool isDivChecked_ = false;
        private bool isAnyRadioBtncheck_ = false;

        public bool IsAnyRadioBtnCheck
        {
            get
            {
                return isAnyRadioBtncheck_;
            }
            set
            {
                isAnyRadioBtncheck_ = value;
                OnPropertyChanged("IsAnyRadioBtnCheck");
            }
        }

        public double Value1
        {
            get
            {
                return value1_;
            }
            set
            {
                value1_ = value;
                OnPropertyChanged("Value1");
            }
        }
        public double Value2
        {
            get
            {
                return value2_;
            }
            set
            {
                value2_ = value;
                OnPropertyChanged("Value2");
            }
        }

        public double Result
        {
            get
            {
                return result_;
            }
            set
            {
                if (value != result_)
                {
                    result_ = value;
                    OnPropertyChanged("Result");
                }

            }
        }

        public bool IsAddChecked
        {
            get
            {
                return isAddChecked_;
            }
            set
            {
                if (value != isAddChecked_)
                {
                    isAddChecked_ = value;
                    IsAnyRadioBtnCheck = true;
                    OnPropertyChanged("IsAddChecked");
                }

            }
        }
        public bool IsSubChecked
        {
            get
            {
                return isSubChecked_;
            }
            set
            {
                if (value != isSubChecked_)
                {
                    isSubChecked_ = value;
                    IsAnyRadioBtnCheck = true;
                    OnPropertyChanged("IsSubChecked");
                }
            }
        }

        public bool IsMulChecked
        {
            get
            {
                return isMulChecked_;
            }
            set
            {
                if (value != isMulChecked_)
                {
                    isMulChecked_ = value;
                    IsAnyRadioBtnCheck = true;
                    OnPropertyChanged("isMulChecked");
                }
            }
        }

        public bool IsDivChecked
        {
            get
            {
                return isDivChecked_;
            }
            set
            {
                if (value != isDivChecked_)
                {
                    isDivChecked_ = value;
                    IsAnyRadioBtnCheck = true;
                    OnPropertyChanged("IsDivChecked");
                }
            }
        }

        public ICommand OkButtonClicked
        {
            get
            {
                return new DelegateCommand(FindResult);
            }
        }

        public void FindResult()
        {
            calcular_ = new Calculator(Value1, Value2);
            if (IsAddChecked)
            {
                Result = calcular_.Add();
            }

            else if (IsSubChecked)
            {
                Result = calcular_.Subtract();
            }

            else if (IsMulChecked)
            {
                Result = calcular_.Multiply();
            }

            else if (IsDivChecked)
            {
                Result = calcular_.Divide();
            }
        }

    }
}
