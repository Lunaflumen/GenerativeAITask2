using NewProjectWithFramework;

using Xunit;

namespace NewProjectForTests
{
	public class StudentTests
	{
		#region Constructor

		private readonly StudentConverter _converter;

		public StudentTests()
		{
			_converter = new StudentConverter();
		}

		#endregion

		#region Positive test cases

		[Fact]
		public void ConvertStudents_ShouldReturnHonorRoll_ForHighAchiever()
		{
			// Arrange
			var students = new List<Student>();

			for (int i = 0; i < 20; i++)
			{
				var g = i / 2;

				students.Add(new Student { Age = 21 + i, Grade = 91 + g});
			};

			// Act
			var result = _converter.ConvertStudents(students);

			// Assert
			Assert.True(result[0].HonorRoll);
		}

		[Fact]
		public void ConvertStudents_ShouldReturnExceptional_ForYoungHighAchiever()
		{
			// Arrange
			var students = new List<Student>();

			for (int i = 0; i < 20; i++)
			{
				var g = i / 2;

				students.Add(new Student { Age = 1 + i, Grade = 91 + g });
			};

			// Act
			var result = _converter.ConvertStudents(students);

			// Assert
			Assert.True(result[0].Exceptional);
		}

		[Fact]
		public void ConvertStudents_ShouldReturnPassed_ForPassedStudent()
		{
			// Arrange
			var students = new List<Student>();

			for (int i = 0; i < 20; i++)
			{
				var g = i / 2;

				students.Add(new Student {Grade = 71 + g });
			};

			// Act
			var result = _converter.ConvertStudents(students);

			// Assert
			Assert.True(result[0].Passed);
		}

		[Fact]
		public void ConvertStudents_ShouldReturnFailed_ForFailedStudent()
		{
			// Arrange
			var students = new List<Student>();

			for (int i = 0; i < 20; i++)
			{
				students.Add(new Student { Grade = 70 - i });
			};

			// Act
			var result = _converter.ConvertStudents(students);

			// Assert
			Assert.False(result[0].Passed);
		}

		#endregion

		#region Negative test cases

		[Fact]
		public void ConvertStudents_ShouldReturnEmpty_ForEmptyArray()
		{
			// Arrange
			var students = new List<Student>();

			// Act
			var result = _converter.ConvertStudents(students);

			// Assert
			Assert.Empty(result);
		}

		[Fact]
		public void ConvertStudents_ShouldThrowError_ForNullInput()
		{
			// Arrange
			List<Student>? students = null;

			// Act and Assert
			Assert.Throws<ArgumentNullException>(() => _converter.ConvertStudents(students));
		}

		#endregion
	}
}