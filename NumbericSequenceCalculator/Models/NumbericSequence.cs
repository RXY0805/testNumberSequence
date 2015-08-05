using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace NumbericSequenceCalculator.Models
{
    public class NumbericSequence
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        [Display(Name = "Input number:")]
        public int CurrentNumber { get; set; }

        public NumbericSequence()
        {
            CurrentNumber = 0;
            SequenceResult = new List<string>();
        }

        public NumbericSequence(int number)
        {
            CurrentNumber = number;
            SequenceResult = new List<string>(number);
        }
        public List<string> SequenceResult { get; set; }

        public List<string> GetSequence()
        {

            for (int i = 1; i <= CurrentNumber; i++)
            {
                SequenceResult.Add(i.ToString());
            }
            return SequenceResult;
        }

        public List<string> GetOddSequence()
        {
            for (int i = 1; i < CurrentNumber; i++)
            {
                if (i % 2 == 1)
                {
                    SequenceResult.Add(i.ToString());
                }
            }
            SequenceResult.Add(CurrentNumber.ToString());
            return SequenceResult;
        }

        public List<string> GetEvenSequence()
        {
            for (int i = 1; i < CurrentNumber; i++)
            {
                if (i % 2 == 0)
                {
                    SequenceResult.Add(i.ToString());
                }
            }
            SequenceResult.Add(CurrentNumber.ToString());
            return SequenceResult;
        }

        public List<string> GetCEZSequence()
        {
            for (int i = 1; i < CurrentNumber; i++)
            {
                string temp = null;

                if (i % 3 == 0)
                {
                    temp += "C";
                }
                if (i % 5 == 0)
                {
                    temp += "E";
                }

                if (temp == "CE")
                {
                    temp = "Z";
                }

                if (string.IsNullOrEmpty(temp))
                {
                    SequenceResult.Add(i.ToString());
                }
                else
                {
                    SequenceResult.Add(temp);
                }
            }
            SequenceResult.Add(CurrentNumber.ToString());
            return SequenceResult;
        }

        public List<string> GetFibonacciSequence()
        {
            List<int> evenSequence = new List<int>();

            for (int i = 0; i < CurrentNumber; i++)
            {
                int fibonacciSeriesNumber = GetFibonacci(i);

                if(fibonacciSeriesNumber> CurrentNumber)
                {
                    break;
                }
                else
                {
                    SequenceResult.Add(fibonacciSeriesNumber.ToString());
                }
            }
            SequenceResult.Add(CurrentNumber.ToString());
            return SequenceResult;
        }
        /// <summary>
        /// Get n-th fibonacci number
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private int GetFibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}