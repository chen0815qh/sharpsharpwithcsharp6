﻿using System;

namespace ConsoleApplication1
{
    internal class ExceptionFilters
    {
        public static void OldPain()
        {
            try
            {
                throw new MyException { Id = 200 };
            }
            catch (MyException ex)
            {
                if (ex.Id == 200)
                {
                    // do something
                }
                else
                {
                    throw;
                }
            }
        }

        public static void OldPain2()
        {
            var loggingTurnedOn = false;
            try
            {
                throw new MyException { Id = 200 };
            }
            catch (MyException ex)
            {
                if (!loggingTurnedOn)
                {
                    throw;
                }
                else
                {
                    // log and continue
                }
            }
        }

    }

    [Serializable]
    public class MyException : Exception
    {
        public int Id { get; set; }

        public MyException()
        {
        }

        public MyException(string message) : base(message)
        {
        }

        public MyException(string message, Exception inner) : base(message, inner)
        {
        }

        protected MyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}