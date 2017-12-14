﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberValidators.Utils.ISO
{
    public class ISO7064_1983
    {
        /// <summary>
        /// 根据ISO7064:1983.MOD标准获取余
        /// </summary>
        /// <param name="source">要Mod的原始数组</param>
        /// <param name="weightingFactors">加权因子</param>
        /// <param name="mod">取模值</param>
        /// <returns></returns>
        public static int Mod(int[] source, int[] weightingFactors, int mod)
        {
            if (source == null || weightingFactors == null || source.Length != weightingFactors.Length)
            {
                throw new ArgumentException("输入参数不符合ISO7064 Mod规范");
            }
            int sum = source.Select((num, idx) => num * weightingFactors[idx]).Sum();
            return sum % mod;
        }
    }
}