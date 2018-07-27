﻿namespace PhotoShare.App.Utilities
{
    using System;

    public class Check
    {
        public static void CheckLength(int expectedLength, string[] arguments)
        {
            if (expectedLength != arguments.Length)
            {
                throw new ArgumentException(Constants.InvalidArgumentsCount);
            }
        }
    }
}