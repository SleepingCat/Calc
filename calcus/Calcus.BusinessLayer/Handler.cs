using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalcusDTO;


namespace Calcus.BusinessLayer
{
    public class Handler : IHandler
    {




        public void Process(operands Op)
        {
            switch (Op.Operator)
            {
                case "+": this.Add(Op); break;
                case "-": this.Minus(Op); break;
                case "*": this.Multiply(Op); break;
                case "/": this.Division(Op); break;

                default: break;
            }
        }

        public void Add(operands Op)
        {
            Op.result = Op.firstOperand + Op.secondOperand;
        }

        public void Minus(operands Op)
        {
            Op.result = Op.firstOperand - Op.secondOperand;
        }

        public void Multiply(operands Op)
        {
            Op.result = Op.firstOperand * Op.secondOperand;
        }

        public void Division(operands Op)
        {
            Op.result = Op.firstOperand / Op.secondOperand;
        }
    }
       
}
