using System;

namespace algoexperttasks
{
    public class Tests
    {

        List<int> array;
        List<int> sequence;
        Solution solution;

        [SetUp]
        public void Setup()
        {
            array = new List<int> { };
            sequence = new List<int> { };
            solution = new Solution();
        }


        [Test]
        public void Test1()
        {
            array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            sequence = new List<int> { 1, 6, -1, 10 };

            Assert.True(solution.IsValidSubsequence(array, sequence));
        
        }

        [Test]
        public void Test2()
        {
            array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            sequence = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };

            Assert.True(solution.IsValidSubsequence(array, sequence));

        }

        [Test]
        public void Test3()
        {
            array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            sequence = new List<int> { 5, 1, 22, 6, -1, 8, 10 };

            Assert.True(solution.IsValidSubsequence(array, sequence));

        }

        [Test]
        public void Test4()
        {
            array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            sequence = new List<int> { 22, 25, 6 };

            Assert.True(solution.IsValidSubsequence(array, sequence));

        }

        [Test]
        public void Test5()
        {
            array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            sequence = new List<int> { 1, 6, 10 };

            Assert.True(solution.IsValidSubsequence(array, sequence));

        }

        [Test]
        public void Test6()
        {
            array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            sequence = new List<int> { 5, 1, 22, 10 };

            Assert.True(solution.IsValidSubsequence(array, sequence));

        }

        [Test]
        public void Test7()
        {
            array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            sequence = new List<int> { 5, -1, 8, 10 };

            Assert.True(solution.IsValidSubsequence(array, sequence));

        }

        [Test]
        public void Test8()
        {
            array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            sequence = new List<int> { 25 };

            Assert.True(solution.IsValidSubsequence(array, sequence));

        }

        [Test]
        public void Test9()
        {
            array = new List<int> { 1, 1, 1, 1, 1 };
            sequence = new List<int> { 1, 1, 1 };

            Assert.True(solution.IsValidSubsequence(array, sequence));

        }

        [Test]
        public void Test10()
        {
            array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            sequence = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10, 12 };

            Assert.False(solution.IsValidSubsequence(array, sequence));

        }

        [Test]
        public void Test11()
        {
            array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            sequence = new List<int> { 4, 5, 1, 22, 25, 6, -1, 8, 10 };

            Assert.False(solution.IsValidSubsequence(array, sequence));

        }

        [Test]
        public void Test12()
        {
            array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            sequence = new List<int> { 5, 1, 22, 23, 6, -1, 8, 10 };

            Assert.False(solution.IsValidSubsequence(array, sequence));

        }

        [Test]
        public void Test13()
        {
            array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            sequence = new List<int> { 5, 1, 22, 22, 25, 6, -1, 8, 10 };

            Assert.False(solution.IsValidSubsequence(array, sequence));

        }

        [Test]
        public void Test14()
        {
            array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            sequence = new List<int> { 5, 1, 22, 22, 6, -1, 8, 10 };

            Assert.False(solution.IsValidSubsequence(array, sequence));

        }

        [Test]
        public void Test15()
        {
            array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            sequence = new List<int> { 1, 6, -1, -1 };

            Assert.False(solution.IsValidSubsequence(array, sequence));

        }

        [Test]
        public void Test16()
        {
            array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            sequence = new List<int> { 1, 6, -1, -1, 10 };

            Assert.False(solution.IsValidSubsequence(array, sequence));

        }

        [Test]
        public void Test17()
        {
            array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            sequence = new List<int> { 1, 6, -1, -2 };

            Assert.False(solution.IsValidSubsequence(array, sequence));

        }

        [Test]
        public void Test18()
        {
            array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            sequence = new List<int> { 26 };

            Assert.False(solution.IsValidSubsequence(array, sequence));

        }

        [Test]
        public void Test19()
        {
            array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            sequence = new List<int> { 5, 1, 25, 22, 6, -1, 8, 10 };

            Assert.False(solution.IsValidSubsequence(array, sequence));

        }

        [Test]
        public void Test20()
        {
            array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            sequence = new List<int> { 5, 26, 22, 8 };

            Assert.False(solution.IsValidSubsequence(array, sequence));

        }

        [Test]
        public void Test21()
        {
            array = new List<int> { 1, 1, 6, 1 };
            sequence = new List<int> { 1, 1, 1, 6 };

            Assert.False(solution.IsValidSubsequence(array, sequence));

        }

        [Test]
        public void Test22()
        {
            array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            sequence = new List<int> { 1, 6, -1, 10, 11, 11, 11, 11 };

            Assert.False(solution.IsValidSubsequence(array, sequence));

        }

        [Test]
        public void Test23()
        {
            array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            sequence = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10, 10 };

            Assert.False(solution.IsValidSubsequence(array, sequence));

        }

        [Test]
        public void Test24()
        {
            array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            sequence = new List<int> { 1, 6, -1, 5 };

            Assert.False(solution.IsValidSubsequence(array, sequence));

        }

    }
}