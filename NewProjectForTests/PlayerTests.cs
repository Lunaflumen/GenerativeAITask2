using NewProjectWithFramework2;

using Xunit;

namespace NewProjectForTests
{
	public class PlayerTests
	{
		#region Constructor

		private readonly PlayerAnalyzer _analyzer;

		public PlayerTests()
		{
			_analyzer = new PlayerAnalyzer();
		}

		#endregion

		#region Positive test cases

		[Fact]
		public void CalculateScore_ShouldReturnScore_WhenNormalPlayer()
		{
			// Arrange
			var players = new List<Player>
			{
				new Player { Age = 25, Experience = 5, Skills = new List<int> { 2, 2, 2 } }
			};

			// Act
			var score = _analyzer.CalculateScore(players);

			// Assert
			Assert.Equal(250, score);
		}

		[Fact]
		public void CalculateScore_ShouldReturnScore_WhenJuniorPlayer()
		{
			// Arrange
			var players = new List<Player>
			{
				new Player { Age = 15, Experience = 3, Skills = new List<int> { 3, 3, 3 } }
			};

			// Act
			var score = _analyzer.CalculateScore(players);

			// Assert
			Assert.Equal(67.5, score);
		}

		[Fact]
		public void CalculateScore_ShouldReturnScore_WhenSeniorPlayer()
		{
			// Arrange
			var players = new List<Player>
			{
				new Player { Age = 35, Experience = 15, Skills = new List<int> { 4, 4, 4 } }
			};

			// Act
			var score = _analyzer.CalculateScore(players);

			// Assert
			Assert.Equal(2520, score);
		}

		[Fact]
		public void CalculateScore_ShouldReturnSumScore_WhenMultiplePlayers()
		{
			// Arrange
			var players = new List<Player>();
			for (int i = 0; i < 20; i++)
			{
				players.Add(new Player { Age = 25, Experience = 5, Skills = new List<int> { 2, 2, 2 } });
			}

			// Act
			var score = _analyzer.CalculateScore(players);

			// Assert
			Assert.Equal(250 * 20, score);
		}

		#endregion

		#region Negative test cases

		[Fact]
		public void CalculateScore_ShouldThrowException_WhenSkillsIsNull()
		{
			// Arrange
			var players = new List<Player>
			{
				new Player { Age = 25, Experience = 5, Skills = null }
			};

			// Act and Assert
			Assert.Throws<ArgumentNullException>(() => _analyzer.CalculateScore(players));
		}

		[Fact]
		public void CalculateScore_ShouldReturnZero_WhenPlayersListIsEmpty()
		{
			// Arrange
			var players = new List<Player>();
			var analyzer = new PlayerAnalyzer();

			// Act
			var score = analyzer.CalculateScore(players);

			// Assert
			Assert.Equal(0, score);
		}

		#endregion
	}
}