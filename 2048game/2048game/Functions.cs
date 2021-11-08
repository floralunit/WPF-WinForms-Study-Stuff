using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048game
{
    public class Function
    {
        
        public string[] Merge(string[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != "")
                {
                    int k = i;
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (arr[j] != "")
                        {
                            k = j;
                            break;
                        }
                    }

                    if (k != i)
                    {
                        if (arr[i] == arr[k])
                        {
                            arr[k] = (int.Parse(arr[i]) * 2).ToString();
                            arr[i] = "";
                        }
                        else
                        {
                            if (i - k > 1)
                            {
                                arr[k + 1] = arr[i];
                                arr[i] = "";
                            }
                        }

                    }
                    else
                    {
                        arr[0] = arr[i];
                        arr[i] = "";
                    }


                }
            }
            return arr;
        }
        public string[][] Transpose(string[][] doubleArr)
        {
            int row = doubleArr.Length;
            int col = doubleArr[0].Length;
            string[][] result = new string[row][];
            for (int i = 0; i < row; i++)
            {
                result[i] = new string[col];
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    result[j][i] = doubleArr[i][j];
                }
            }

            return result;
        }
    }
}
