using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
namespace ShuXue
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ComputationItem _AddItem;

        public ComputationItem Item1
        {
            get { return _AddItem; }
            set
            {
                _AddItem = value;
                RaisePropertyChanged(nameof(Item1));
            }
        }

        private ComputationItem _MinusItem;

        public ComputationItem Item2
        {
            get { return _MinusItem; }
            set
            {
                _MinusItem = value;
                RaisePropertyChanged(nameof(Item2));
            }
        }

        //public ICommand NextGroupCommand;
        //public ICommand CheckCommand;
        private int _StepCnt;

        public int StepCnt
        {
            get { return _StepCnt; }
            set
            {
                _StepCnt = value;
                RaisePropertyChanged(nameof(StepCnt));
            }
        }


        private ICommand _NextGroupCommand;

        public ICommand NextGroupCommand
        {
            get { return _NextGroupCommand; }
            set { _NextGroupCommand = value;
                RaisePropertyChanged(nameof(NextGroupCommand));
            }
        }
        private ICommand _CheckCommand;

        public ICommand CheckCommand
        {
            get { return _CheckCommand; }
            set
            {
                _CheckCommand = value;
                RaisePropertyChanged(nameof(CheckCommand));
            }
        }

        public MainWindowViewModel()
        {
            Item1 = new ComputationItem() { Operator = "+"};
            Item2 = new ComputationItem() { Operator = "-"};
            NextGroupCommand = new RelayCommand(NextGroup);
            CheckCommand = new RelayCommand(Check);
        }

        void NextGroup()
        {
            Item1.CreateRandomItem();
            Item2.CreateRandomItem();

            StepCnt++;
        }
        void Check()
        {
            Item1.CheckRst = Item1.Check();
            Item2.CheckRst =  Item2.Check();
        }
            
    }

    public class ComputationItem : ViewModelBase
    {
        private double _a;

        public double A
        {
            get
            {
                return _a;
            }
            set
            { _a = value;
              RaisePropertyChanged(nameof(A));
            }
        }
        private double _b;

        public double B
        {
            get
            {
                return _b;
            }
            set
            {
                _b = value;
                RaisePropertyChanged(nameof(B));
            }
        }
        private double _c;

        public double C
        {
            get
            {
                return _c;
            }
            set
            {
                _c = value;
                RaisePropertyChanged(nameof(C));
            }
        }

        private string _Operator;

        public string Operator
        {
            get
            {
                return _Operator;
            }
            set
            {
                _Operator = value;
                RaisePropertyChanged(nameof(Operator));
            }
        }

        private bool _checkRst;

        public bool CheckRst
        {
            get
            {
                return _checkRst;
            }
            set
            {
                _checkRst = value;
                CheckRstString = value ? "OK" : "Failed";
                RaisePropertyChanged(nameof(CheckRst));
            }
        }

        private string _checkRstString;

        public string CheckRstString
        {
            get
            {
                return _checkRstString;
            }
            set
            {
                _checkRstString = value;
                RaisePropertyChanged(nameof(CheckRstString));
            }
        }

        public ComputationItem()
        {
            CreateRandomItem();
        }

        public bool Check()
        {
            bool rst = false;
            switch (Operator)
            {
                case "+":
                    return A + B == C;
                   
                case "-":
                    return A - B == C;
                    
                case "*":
                    return A * B == C;
                    
                case "/":
                    return A / B == C;
                    
                default:
                    break;
            }

            return rst;
        }

        public void CreateRandomItem()
        {
            A = GetRandomInt();
            B = GetRandomInt();
            Operator = GetRandomOperator();
            C = 0;
            CheckRstString = string.Empty;
        }

        private int GetRandomInt()
        {
            var time = DateTime.Now.Ticks;
            var rd = new Random((int)time);
            var value = rd.Next(10);
            return value;
        }

        private string GetRandomOperator()
        {
            var time = DateTime.Now.Ticks;
            var rd = new Random((int)time);
            var dValue = rd.NextDouble();
            if (dValue < 0.5)
                return "+";

            if (dValue > 0.5)
                return "-";

            return "+";
        }
    }


}
