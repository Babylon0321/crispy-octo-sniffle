namespace CalcAdd.Tests
{
    public class CalculatorTest
    {
        private readonly Calculator _calculator;

        public CalculatorTest()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_正の数同士_正しい和を返す()
        {
            // Arrange
            int num1 = 2;
            int num2 = 3;

            // Act
            int result = _calculator.Add(num1, num2);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_負の数同士_正しい和を返す()
        {
            // Arrange
            int num1 = -5;
            int num2 = -3;

            // Act
            int result = _calculator.Add(num1, num2);

            // Assert
            Assert.Equal(-8, result);
        }

        [Fact]
        public void Add_正の数と負の数_正しい和を返す()
        {
            // Arrange
            int num1 = 10;
            int num2 = -7;

            // Act
            int result = _calculator.Add(num1, num2);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Add_ゼロと正の数_正しい和を返す()
        {
            // Arrange
            int num1 = 0;
            int num2 = 5;

            // Act
            int result = _calculator.Add(num1, num2);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_ゼロ同士_ゼロを返す()
        {
            // Arrange
            int num1 = 0;
            int num2 = 0;

            // Act
            int result = _calculator.Add(num1, num2);

            // Assert
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(5, 10, 15)]
        [InlineData(-3, 3, 0)]
        [InlineData(100, 200, 300)]
        [InlineData(-10, -20, -30)]
        public void Add_様々な入力_正しい和を返す(int num1, int num2, int expected)
        {
            // Act
            int result = _calculator.Add(num1, num2);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_最大値と1_オーバーフローする()
        {
            // Arrange
            int num1 = int.MaxValue;
            int num2 = 1;

            // Act & Assert
            // オーバーフローは例外を投げないが、値が循環する
            int result = _calculator.Add(num1, num2);
            Assert.Equal(int.MinValue, result);
        }

        [Fact]
        public void Add_最小値とマイナス1_アンダーフローする()
        {
            // Arrange
            int num1 = int.MinValue;
            int num2 = -1;

            // Act & Assert
            int result = _calculator.Add(num1, num2);
            Assert.Equal(int.MaxValue, result);
        }

        [Fact]
        public void Add_大きな正の数同士_正しい和を返す()
        {
            // Arrange
            int num1 = 1000000;
            int num2 = 2000000;

            // Act
            int result = _calculator.Add(num1, num2);

            // Assert
            Assert.Equal(3000000, result);
        }
    }
}