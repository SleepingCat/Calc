using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalcusDTO;

namespace Calcus.BusinessLayer
{
    public interface IHandler
    {

        void Process(operands Op);
                
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Op"></param>
        /// <returns></returns>
         void Add(operands Op);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Op"></param>
        /// <returns></returns>
        void Minus(operands Op);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Op"></param>
        /// <returns></returns>
         void Multiply(operands Op);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Op"></param>
        /// <returns></returns>
         void Division(operands Op);
    }
}
