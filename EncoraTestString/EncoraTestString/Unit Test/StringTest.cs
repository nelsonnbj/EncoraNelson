using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoraTestString
{
   public class StringTest
    {

        [TestMethod()]
        public string SortStringByCharFrequencyTest1(string[] input)
        {
            string[] expectedOutput = { "gggdlquvwz", "tttgjmrwxy", "nnghilptux", "cgijkoptvz","ddppwwaest",
                                        "ccppbiklns", "ffhhblmtvy", "rrrttacnqx", "ccnnadmort", "ffkkdegnst" };
    
            SortingOperations sortString = new SortingOperations();        
            for (int i = 0; i < input.Length; i++)
            {
                var result = sortString.SortStringByCharFrequency(input[i]);
               
                //Assert.Equals(expectedOutput[i], result);
                if (expectedOutput[i].ToString() != result)
                  {
                      return String.Format("Expected Out: {0}  Status : {1}", string.Join(",", expectedOutput),"Failed");                
                  }
            }
            return String.Format("Expected Out: {0}  Status : {1}", string.Join(",", expectedOutput), "OK");
        }

        [TestMethod()]
        public string SortStringByCharFrequencyTest2(string[] input)
        {
           string[] expectedOutput = { "eeuuwwabnz", "fklnovwxyz", "eedfklnrxy", "ddafgioqsw", "ccbfikuvyz" };

            SortingOperations sortString = new SortingOperations();
            for (int i = 0; i < input.Length; i++)
            {
                var result = sortString.SortStringByCharFrequency(input[i]);
                // Assert
                if (expectedOutput[i].ToString() != result)
                {
                    return String.Format("Expected Out: {0}  Status : {1}", string.Join(",", expectedOutput), "Failed");
                }
            }
            return String.Format("Expected Out: {0}  Status : {1}", string.Join(",", expectedOutput), "OK");
        }

        [TestMethod()]
        public string SortStringByCharFrequencyTest3(string[] input)
        {
           string[] expectedOutput = { "ackmq", "rrbkt", "ainvx", "jmnpw", "iopru", "abkst", "ejqrw", "llegw", "ooaiy", "hknqr" };

            SortingOperations sortString = new SortingOperations();
            for (int i = 0; i < input.Length; i++)
            {
                var result = sortString.SortStringByCharFrequency(input[i]);
                // Assert
                if (expectedOutput[i].ToString() != result)
                {
                    return String.Format("Expected Out: {0}  Status : {1}", string.Join(",", expectedOutput), "Failed");
                }
            }
            return String.Format("Expected Out: {0}  Status : {1}", string.Join(",", expectedOutput), "OK");
        }

        [TestMethod()]
        public string SortStringByCharFrequencyTest4(string[] input)
        {
           string[] expectedOutput = { "ijmpz", "nnfjq", "hosxy" };

            SortingOperations sortString = new SortingOperations();
            for (int i = 0; i < input.Length; i++)
            {
                var result = sortString.SortStringByCharFrequency(input[i]);
                // Assert
                if (expectedOutput[i].ToString() != result)
                {
                    return String.Format("Expected Out: {0}  Status : {1}", string.Join(",", expectedOutput), "Failed");
                }
            }
            return String.Format("Expected Out: {0}  Status : {1}", string.Join(",", expectedOutput), "OK");
        }

        [TestMethod()]
        public string SortStringByCharFrequencyTest5(string[] input)
        {
             string[] expectedOutput = { "cqsxy", "abeox", "afkos", "bdilt", "grswy" };

            SortingOperations sortString = new SortingOperations();
            for (int i = 0; i < input.Length; i++)
            {
                var result = sortString.SortStringByCharFrequency(input[i]);
                // Assert
                if (expectedOutput[i].ToString() != result)
                {
                    return String.Format("Expected Out: {0}  Status : {1}", string.Join(",", expectedOutput), "Failed");
                }
            }
            return String.Format("Expected Out: {0}  Status : {1}", string.Join(",", expectedOutput), "OK");
        }

    }
}
