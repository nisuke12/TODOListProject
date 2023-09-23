using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTODOList.logic
{
    public class StringUtil
    {

        /// <summary>
        /// 文字列のリストから最大の文字数を取得する
        /// </summary>
        /// <param name="strArray">文字列が格納されたリスト</param>
        /// <returns></returns>
        public int MaxStrLength(ArrayList strArray)
        {
            int maxLength = 0;
            if(strArray != null)
            {
                for(int i = 0; i<strArray.Count; i++)
                {
                    if(maxLength < strArray[i].ToString().Length)
                    {
                        maxLength = strArray[i].ToString().Length;
                    }
                }
            }
            return maxLength;
        }


    }
}
