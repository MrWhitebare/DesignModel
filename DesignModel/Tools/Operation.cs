using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel.Tools
{
    /// <summary>
    /// 简单工程模式
    /// </summary>
    public class Operation
    {
        private double _numberA = 0;
        private double _numberB = 0;

        private double NumberA
        {
            get
            {
                return _numberA;
            }
            set
            {
                _numberA = value;
            }
        }

        private double NumberB
        {
            get
            {
                return _numberB;
            }
            set
            {
                _numberB = value;
            }
        }

        /// <summary>
        /// 获得运算结果
        /// </summary>
        /// <returns></returns>
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }


}
