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
			var students = new List<Student>
		{
			new Student { Age = 21, Grade = 95 },
			new Student { Age = 22, Grade = 96 },
			new Student { Age = 23, Grade = 97 },
			new Student { Age = 24, Grade = 98 },
			new Student { Age = 25, Grade = 99 },
			new Student { Age = 26, Grade = 100 },
			new Student { Age = 27, Grade = 95 },
			new Student { Age = 28, Grade = 96 },
			new Student { Age = 29, Grade = 97 },
			new Student { Age = 30, Grade = 98 },
			new Student { Age = 31, Grade = 99 },
			new Student { Age = 32, Grade = 100 },
			new Student { Age = 33, Grade = 95 },
			new Student { Age = 34, Grade = 96 },
			new Student { Age = 35, Grade = 97 },
			new Student { Age = 36, Grade = 98 },
			new Student { Age = 37, Grade = 99 },
			new Student { Age = 38, Grade = 100 },
			new Student { Age = 39, Grade = 95 },
			new Student { Age = 40, Grade = 96 }
		};

			var result = _converter.ConvertStudents(students);

			Assert.True(result[0].HonorRoll);
		}

		[Fact]
		public void ConvertStudents_ShouldReturnExceptional_ForYoungHighAchiever()
		{
			var students = new List<Student>
		{
			new Student { Age = 20, Grade = 95 },
			new Student { Age = 19, Grade = 96 },
			new Student { Age = 18, Grade = 97 },
			new Student { Age = 17, Grade = 98 },
			new Student { Age = 16, Grade = 99 },
			new Student { Age = 15, Grade = 100 },
			new Student { Age = 14, Grade = 95 },
			new Student { Age = 13, Grade = 96 },
			new Student { Age = 12, Grade = 97 },
			new Student { Age = 11, Grade = 98 },
			new Student { Age = 10, Grade = 99 },
			new Student { Age = 9, Grade = 100 },
			new Student { Age = 8, Grade = 95 },
			new Student { Age = 7, Grade = 96 },
			new Student { Age = 6, Grade = 97 },
			new Student { Age = 5, Grade = 98 },
			new Student { Age = 4, Grade = 99 },
			new Student { Age = 3, Grade = 100 },
			new Student { Age = 2, Grade = 95 },
			new Student { Age = 1, Grade = 96 }
		};

			var result = _converter.ConvertStudents(students);

			Assert.True(result[0].Exceptional);
		}

		[Fact]
		public void ConvertStudents_ShouldReturnPassed_ForPassedStudent()
		{
			var students = new List<Student>
		{
			new Student { Age = 21, Grade = 90 },
			new Student { Age = 22, Grade = 89 },
			new Student { Age = 23, Grade = 88 },
			new Student { Age = 24, Grade = 87 },
			new Student { Age = 25, Grade = 86 },
			new Student { Age = 26, Grade = 85 },
			new Student { Age = 27, Grade = 84 },
			new Student { Age = 28, Grade = 83 },
			new Student { Age = 29, Grade = 82 },
			new Student { Age = 30, Grade = 81 },
			new Student { Age = 31, Grade = 80 },
			new Student { Age = 32, Grade = 79 },
			new Student { Age = 33, Grade = 78 },
			new Student { Age = 34, Grade = 77 },
			new Student { Age = 35, Grade = 76 },
			new Student { Age = 36, Grade = 75 },
			new Student { Age = 37, Grade = 74 },
			new Student { Age = 38, Grade = 73 },
			new Student { Age = 39, Grade = 72 },
			new Student { Age = 40, Grade = 71 }
		};

			var result = _converter.ConvertStudents(students);

			Assert.True(result[0].Passed);
		}

		[Fact]
		public void ConvertStudents_ShouldReturnFailed_ForFailedStudent()
		{
			var students = new List<Student>
		{
			new Student { Age = 21, Grade = 70 },
			new Student { Age = 22, Grade = 69 },
			new Student { Age = 23, Grade = 68 },
			new Student { Age = 24, Grade = 67 },
			new Student { Age = 25, Grade = 66 },
			new Student { Age = 26, Grade = 65 },
			new Student { Age = 27, Grade = 64 },
			new Student { Age = 28, Grade = 63 },
			new Student { Age = 29, Grade = 62 },
			new Student { Age = 30, Grade = 61 },
			new Student { Age = 31, Grade = 60 },
			new Student { Age = 32, Grade = 59 },
			new Student { Age = 33, Grade = 58 },
			new Student { Age = 34, Grade = 57 },
			new Student { Age = 35, Grade = 56 },
			new Student { Age = 36, Grade = 55 },
			new Student { Age = 37, Grade = 54 },
			new Student { Age = 38, Grade = 53 },
			new Student { Age = 39, Grade = 52 },
			new Student { Age = 40, Grade = 51 }
		};

			var result = _converter.ConvertStudents(students);

			Assert.False(result[0].Passed);
		}

		#endregion

		#region Negative test cases

		[Fact]
		public void ConvertStudents_ShouldReturnEmpty_ForEmptyArray()
		{
			var students = new List<Student> { };

			var result = _converter.ConvertStudents(students);

			Assert.Empty(result);
		}

		[Fact]
		public void ConvertStudents_ShouldThrowError_ForNullInput()
		{
			List<Student>? students = null;

			Assert.Throws<ArgumentNullException>(() => _converter.ConvertStudents(students));
		}

		#endregion
	}
}