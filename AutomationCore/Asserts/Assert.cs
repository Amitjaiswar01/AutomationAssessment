using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Assert = Xunit.Assert;

namespace AutomationCore.Asserts
{
    public class Assert
    {
        public void Equals(string expected, string actual, string message)
        {
            try
            {
                Xunit.Assert.Equal(expected, actual);
            }
            catch
            {
                Console.WriteLine(message);
                throw;
            }
            
        }

        public void True(bool condition, string message)
        {
            Xunit.Assert.True(condition, message);
        }

        public void False(bool condition, string message)
        {
            Xunit.Assert.False(condition, message);
        }


        public void Contains(string expected, string actual)
        {
            Xunit.Assert.Contains(expected, actual);
        }
    }
}
