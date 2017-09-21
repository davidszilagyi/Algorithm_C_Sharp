using NUnit.Framework;

namespace Basic_CC
{
    [TestFixture]
    internal class Test
    {
        private BasicMethods Algorithms = new BasicMethods();

        [Test]
        public void TestChunkArrayInGroups()
        {
            object[] param0 = new object[] { "a", "b", "c", "d" };
            object[][] test0 = new object[][] {
                new object[] {"a", "b"},
                new object[] {"c", "d"}
            };
            Assert.AreEqual(test0, Algorithms.ChunkArrayInGroups(param0, 2));
            // 1
            object[] param1 = new object[] { 0, 1, 2, 3, 4, 5 };
            object[][] test1 = new object[][] {
                new object[] {0,1,2},
                new object[] {3,4,5},
            };
            Assert.AreEqual(test1, Algorithms.ChunkArrayInGroups(param1, 3));
            // 2
            object[] param2 = new object[] { 0, 1, 2, 3, 4, 5 };
            object[][] test2 = new object[][]{
                new object[] {0,1},
                new object[] {2,3},
                new object[] {4,5}
            };
            Assert.AreEqual(test2, Algorithms.ChunkArrayInGroups(param2, 2));
            // 3
            object[] param3 = new object[] { 0, 1, 2, 3, 4, 5 };
            object[][] test3 = new object[][]{
                new object[] {0,1,2,3},
                new object[] {4,5}
            };
            Assert.AreEqual(test3, Algorithms.ChunkArrayInGroups(param3, 4));
            // 4
            object[] param4 = new object[] { 0, 1, 2, 3, 4, 5, 6 };
            object[][] test4 = new object[][]{
                new object[] {0,1,2},
                new object[] {3,4,5},
                new object[] {6}
            };
            Assert.AreEqual(test4, Algorithms.ChunkArrayInGroups(param4, 3));
            // 5
            object[] param5 = new object[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            object[][] test5 = new object[][]{
                new object[] {0,1,2,3},
                new object[] {4,5,6,7},
                new object[] {8}
            };
            Assert.AreEqual(test5, Algorithms.ChunkArrayInGroups(param5, 4));
            // 6
            object[] param6 = new object[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            object[][] test6 = new object[][]{
                new object[] {0,1},
                new object[] {2,3},
                new object[] {4,5},
                new object[] {6,7},
                new object[] {8}
            };
            Assert.AreEqual(test6, Algorithms.ChunkArrayInGroups(param6, 2));
        }

        [Test]
        public void TestConfirmEnding()
        {
            Assert.AreEqual(true, Algorithms.ConfirmEnding("Bastian", "n"));
            Assert.AreEqual(true, Algorithms.ConfirmEnding("Open sesame", "same"));
            Assert.AreEqual(true, Algorithms.ConfirmEnding("He has to give me a new name", "name"));
            Assert.AreEqual(false, Algorithms.ConfirmEnding("Connor", "n"));
            Assert.AreEqual(false, Algorithms.ConfirmEnding("If you want to save our world, you must hurry. We dont know how much longer we can withstand the nothing", "mountain"));
            Assert.AreEqual(false, Algorithms.ConfirmEnding("Open sesame", "pen"));
            Assert.AreEqual(false, Algorithms.ConfirmEnding("Walking on water and developing software from a specification are easy if both are frozen", "specification"));
        }

        [Test]
        public void TestDestroyer()
        {
            Assert.AreEqual(new object[] { 1, 1 }, Algorithms.Destroyer(new object[] { 1, 2, 3, 1, 2, 3 }, 2, 3 ));
            Assert.AreEqual(new object[] { 1, 5, 1 }, Algorithms.Destroyer(new object[] { 1, 2, 3, 5, 1, 2, 3 }, 2, 3 ));
            Assert.AreEqual(new object[] { 1 }, Algorithms.Destroyer(new object[] { 3, 5, 1, 2, 2 }, 2, 3, 5 ));
            Assert.AreEqual(new object[] { }, Algorithms.Destroyer(new object[] { 2, 3, 2, 3 }, 2, 3 ));
            Assert.AreEqual(new object[] { "hamburger" }, Algorithms.Destroyer(new object[] { "tree", "hamburger", 53 }, "tree", 53));
        }

        [Test]
        public void TestFactorialize()
        {
            Assert.AreEqual(120, Algorithms.Factorialize(5));
            Assert.AreEqual(3628800, Algorithms.Factorialize(10));
            Assert.AreEqual("2432902008176640000", Algorithms.Factorialize(20).ToString());
            Assert.AreEqual(1, Algorithms.Factorialize(0));
        }

        [Test]
        public void TestFindLongestWord()
        {
            Assert.AreEqual(6, Algorithms.FindLongestWord("The quick brown fox jumped over the lazy dog"));
            Assert.AreEqual(5, Algorithms.FindLongestWord("May the force be with you"));
            Assert.AreEqual(6, Algorithms.FindLongestWord("Google do a barrel roll"));
            Assert.AreEqual(8, Algorithms.FindLongestWord("What is the average airspeed velocity of an unladen swallow"));
            Assert.AreEqual(19, Algorithms.FindLongestWord("What if we try a super-long word such as otorhinolaryngology"));
        }

        [Test]
        public void TestGetIndexToIns()
        {
            Assert.AreEqual(2, Algorithms.GetIndexToIns(new int[] { 10, 20, 30, 40, 50 }, 30));
            Assert.AreEqual(3, Algorithms.GetIndexToIns(new int[] { 10, 20, 30, 40, 50 }, 35));
            Assert.AreEqual(1, Algorithms.GetIndexToIns(new int[] { 40, 60 }, 50));
            Assert.AreEqual(0, Algorithms.GetIndexToIns(new int[] { 3, 10, 5 }, 3));
            Assert.AreEqual(2, Algorithms.GetIndexToIns(new int[] { 5, 3, 20, 3 }, 5));
            Assert.AreEqual(2, Algorithms.GetIndexToIns(new int[] { 2, 20, 10 }, 19));
            Assert.AreEqual(3, Algorithms.GetIndexToIns(new int[] { 2, 5, 10 }, 15));
        }

        [Test]
        public void TestlargestOfFour()
        {
            long[][] arr = new long[][]{
                new long[] {13,27,18,26},
                new long[] {4,5,1,3},
                new long[] { 32,35,37,39},
                new long[] {1000,1001,857,1}
            };
            Assert.AreEqual(new long[] { 27, 5, 39, 1001 }, Algorithms.LargestOfFour(arr));
        }

        [Test]
        public void TestPalindrome()
        {
            Assert.True(Algorithms.Palindrome("eye"));
            Assert.True(Algorithms.Palindrome("_eye"));
            Assert.True(Algorithms.Palindrome("race car"));
            Assert.False(Algorithms.Palindrome("not a palindrome"));
            Assert.True(Algorithms.Palindrome("A man, a plan, a canal. Panama"));
            Assert.True(Algorithms.Palindrome("never odd or even"));
            Assert.False(Algorithms.Palindrome("nope"));
            Assert.False(Algorithms.Palindrome("almostomla"));
            Assert.True(Algorithms.Palindrome("My age is 0, 0 si ega ym."));
            Assert.False(Algorithms.Palindrome("1 eye for of 1 eye."));
            Assert.True(Algorithms.Palindrome("0_0 (: /-\\ :) 0-0"));
            Assert.False(Algorithms.Palindrome("five|\\_/|four"));
        }

        [Test]
        public void TestRepeatStringNumTimes()
        {
            Assert.AreEqual("***", Algorithms.RepeatStringNumTimes("*", 3));
            Assert.AreEqual("********", Algorithms.RepeatStringNumTimes("*", 8));
            Assert.AreEqual("abcabcabc", Algorithms.RepeatStringNumTimes("abc", 3));
            Assert.AreEqual("abcabcabcabc", Algorithms.RepeatStringNumTimes("abc", 4));
            Assert.AreEqual("abc", Algorithms.RepeatStringNumTimes("abc", 1));
            Assert.AreEqual("", Algorithms.RepeatStringNumTimes("abc", -2));
        }

        [Test]
        public void TestRevesreString()
        {
            Assert.AreEqual("olleh", Algorithms.ReverseString("hello"));
            Assert.AreEqual("ydwoH", Algorithms.ReverseString("Howdy"));
            Assert.AreEqual("htraE morf sgniteerG", Algorithms.ReverseString("Greetings from Earth"));
        }

        [Test]
        public void TestRot13()
        {
            Assert.AreEqual("FREE CODE CAMP", Algorithms.Rot13("SERR PBQR PNZC"));
            Assert.AreEqual("FREE PIZZA!", Algorithms.Rot13("SERR CVMMN!"));
            Assert.AreEqual("FREE LOVE?", Algorithms.Rot13("SERR YBIR?"));
            Assert.AreEqual("THE QUICK BROWN DOG JUMPED OVER THE LAZY FOX.", Algorithms.Rot13("GUR DHVPX OEBJA QBT WHZCRQ BIRE GUR YNML SBK."));
        }

        [Test]
        public void TestSlasher()
        {
            Assert.AreEqual(new object[] { 3 }, Algorithms.Slasher(new object[] { 1, 2, 3 }, 2));
            Assert.AreEqual(new object[] { 1, 2, 3 }, Algorithms.Slasher(new object[] { 1, 2, 3 }, 0));
            Assert.AreEqual(new object[] { }, Algorithms.Slasher(new object[] { 1, 2, 3 }, 9));
            Assert.AreEqual(new object[] { }, Algorithms.Slasher(new object[] { 1, 2, 3 }, 4));
            Assert.AreEqual(new object[] { "fries", "shake" }, Algorithms.Slasher(new object[] { "burgers", "fries", "shake" }, 1));
            Assert.AreEqual(new object[] { "cheese", 4 }, Algorithms.Slasher(new object[] { 1, 2, "chicken", 3, "potatoes", "cheese", 4 }, 5));
        }

        [Test]
        public void TestTitleCase()
        {
            Assert.AreEqual("I'm A Little Tea Pot", Algorithms.TitleCase("I'm a little tea pot"));
            Assert.AreEqual("Short And Stout", Algorithms.TitleCase("sHoRt AnD sToUt"));
            Assert.AreEqual("Here Is My Handle Here Is My Spout", Algorithms.TitleCase("HERE IS MY HANDLE HERE IS MY SPOUT"));
        }

        [Test]
        public void TestTruncateString()
        {
            string[] arrParam = new string[] {
                "A-tisket a-tasket A green and yellow basket",
                "Peter Piper picked a peck of pickled peppers",
                "A-tisket a-tasket A green and yellow basket",
                "A-tisket a-tasket A green and yellow basket",
                "A-",
                "Absolutely Longer"
            };
            string[] arrExp = new string[] {
                "A-tisket...",
                "Peter Piper...",
                "A-tisket a-tasket A green and yellow basket",
                "A-tisket a-tasket A green and yellow basket",
                "A...",
                "Ab..."
            };
            Assert.AreEqual(arrExp[0], Algorithms.TruncateString(arrParam[0], 11));
            Assert.AreEqual(arrExp[1], Algorithms.TruncateString(arrParam[1], 14));
            Assert.AreEqual(arrExp[2], Algorithms.TruncateString(arrParam[2], arrParam[2].Length));
            Assert.AreEqual(arrExp[3], Algorithms.TruncateString(arrParam[3], arrParam[3].Length + 2));
            Assert.AreEqual(arrExp[4], Algorithms.TruncateString(arrParam[4], 1));
            Assert.AreEqual(arrExp[5], Algorithms.TruncateString(arrParam[5], 2));
        }

        [Test]
        public void TestFalsyBouncer()
        {
            Assert.AreEqual(new object[] { 7, "ate", 9 }, Algorithms.Bouncer(new object[] { 7, "ate", "", false, 9 }));
            Assert.AreEqual(new object[] { "a", "b", "c" }, Algorithms.Bouncer(new object[] { "a", "b", "c" }));
            Assert.AreEqual(new object[0], Algorithms.Bouncer(new object[] { false, null, 0, "NaN", "undefined", "" }));
            Assert.AreEqual(new object[] { 1, 2 }, Algorithms.Bouncer(new object[] { 1, null, "NaN", 2, "undefined" }));
        }
    }
}
