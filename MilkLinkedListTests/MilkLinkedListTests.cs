using Milk.LinkedList;
using System;
using Xunit;

namespace MilkLinkedListTests
{
    public class MilkLinkedListTests
    {
        [Fact]
        public void Insert_StateUnderTest_ExpectedBehavior_Strings()
        {
            // Arrange
            var milkLinkedList = new MilkLinkedList<string>();

            string expected = "test1\ntest3\ntest2\n";

            // Act
            milkLinkedList.Insert("test1");
            milkLinkedList.Insert("test2");
            milkLinkedList.Insert("test3", 1);
            string actual = milkLinkedList.PrintList();

            // Assert
            Assert.True(actual == expected);
        }

        [Fact]
        public void Insert_StateUnderTest_ExpectedBehavior_Ints()
        {
            // Arrange
            var milkLinkedList = new MilkLinkedList<int>();

            string expected = "1\n3\n2\n";

            // Act
            milkLinkedList.Insert(1);
            milkLinkedList.Insert(2);
            milkLinkedList.Insert(3, 1);
            string actual = milkLinkedList.PrintList();

            // Assert
            Assert.True(actual == expected);
        }

        [Fact]
        public void Delete_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var milkLinkedList = new MilkLinkedList<string>();
            string expected = "test1\ntest3\n";

            milkLinkedList.Insert("test1");
            milkLinkedList.Insert("test2");
            milkLinkedList.Insert("test3");
            // Act
            milkLinkedList.Delete(1);
            string actual = milkLinkedList.PrintList();

            // Assert
            Assert.True(actual == expected);
        }

        [Fact]
        public void Delete_StateUnderTest_ExpectedBehavior_Ints()
        {
            // Arrange
            var milkLinkedList = new MilkLinkedList<int>();

            string expected = "1\n2\n";

            // Act
            milkLinkedList.Insert(1);
            milkLinkedList.Insert(2);
            milkLinkedList.Insert(3, 1);
            milkLinkedList.Delete(1);
            string actual = milkLinkedList.PrintList();

            // Assert
            Assert.True(actual == expected);
        }

        [Fact]
        public void Insert_StateUnderTest_ExpectedBehavior_ShouldThrowExeption()
        {
            // Arrange
            var milkLinkedList = new MilkLinkedList<int>();

            string expected = "1\n2\n";

            // Act
            milkLinkedList.Insert(1);
            milkLinkedList.Insert(2);
            milkLinkedList.Insert(3, 1);


            // Assert
            Assert.Throws<IndexOutOfRangeException>(() => milkLinkedList.Insert(5, 5));
        }

        [Fact]
        public void Delete_StateUnderTest_ExpectedBehavior_ShouldThrowExeption()
        {
            // Arrange
            var milkLinkedList = new MilkLinkedList<int>();

            string expected = "1\n2\n";

            // Act
            milkLinkedList.Insert(1);
            milkLinkedList.Insert(2);
            milkLinkedList.Insert(3, 1);


            // Assert
            Assert.Throws<IndexOutOfRangeException>(() => milkLinkedList.Delete(5));
        }
    }
}
