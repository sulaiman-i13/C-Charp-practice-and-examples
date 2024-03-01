using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Linq
{
	public static class QuestionBank
	{
		private static Random _random = new Random();
		public static Question PickOne() {
			return All[_random.Next(0, All.Count)]; }
		public static IEnumerable<Question> Randomiaze(int count)
		{
			if (count > All.Count) return AllSuffeld;
			return AllSuffeld.Take(count);
		}
		public static List<Question> GetQuestionRange(IEnumerable<int> range)
		{
			return All.Where((x, i) => range.Contains(i)).ToList();
		}

		public static void ToQuiz(this IEnumerable<Question> source)
		{
			foreach (var item in source)
			{
                Console.WriteLine(item);
                Console.WriteLine(	);
            }
		}
		public static List<Question> All =>
			new List<Question>() {
				new Question() {
					Title="Question 1",
					Choises=new List<Choise>() {
						new Choise() { Order=1,Description="Choice 1"} ,
						new Choise() { Order=2,Description="Choice 2"} ,
						new Choise() { Order=3,Description="Choice 3"} ,
						new Choise() { Order=4,Description="Choice 4"}
					},
					CorrectAnswer=1
				},
				new Question() {
					Title="Question 2",
					Choises=new List<Choise>() {
						new Choise() { Order=1,Description="Choice 1"} ,
						new Choise() { Order=2,Description="Choice 2"} ,
						new Choise() { Order=3,Description="Choice 3"} ,
						new Choise() { Order=4,Description="Choice 4"}
					},
					CorrectAnswer=2
				},
				new Question() {
					Title="Question 3",
					Choises=new List<Choise>() {
						new Choise() { Order=1,Description="Choice 1"} ,
						new Choise() { Order=2,Description="Choice 2"} ,
						new Choise() { Order=3,Description="Choice 3"} ,
						new Choise() { Order=4,Description="Choice 4"}
					},
					CorrectAnswer=3
				},
				new Question() {
					Title="Question 4",
					Choises=new List<Choise>() {
						new Choise() { Order=1,Description="Choice 1"} ,
						new Choise() { Order=2,Description="Choice 2"} ,
						new Choise() { Order=3,Description="Choice 3"} ,
						new Choise() { Order=4,Description="Choice 4"}
					},
					CorrectAnswer=4
				},
				new Question() {
					Title="Question 5",
					Choises=new List<Choise>() {
						new Choise() { Order=1,Description="Choice 1"} ,
						new Choise() { Order=2,Description="Choice 2"} ,
						new Choise() { Order=3,Description="Choice 3"} ,
						new Choise() { Order=4,Description="Choice 4"}
					},
					CorrectAnswer=2
				},
				new Question() {
					Title="Question 6",
					Choises=new List<Choise>() {
						new Choise() { Order=1,Description="Choice 1"} ,
						new Choise() { Order=2,Description="Choice 2"} ,
						new Choise() { Order=3,Description="Choice 3"} ,
						new Choise() { Order=4,Description="Choice 4"}
					},
					CorrectAnswer=1
				},
				new Question() {
					Title="Question 7",
					Choises=new List<Choise>() {
						new Choise() { Order=1,Description="Choice 1"} ,
						new Choise() { Order=2,Description="Choice 2"} ,
						new Choise() { Order=3,Description="Choice 3"} ,
						new Choise() { Order=4,Description="Choice 4"}
					},
					CorrectAnswer=2
				},
				new Question() {
					Title="Question 8",
					Choises=new List<Choise>() {
						new Choise() { Order=1,Description="Choice 1"} ,
						new Choise() { Order=2,Description="Choice 2"} ,
						new Choise() { Order=3,Description="Choice 3"} ,
						new Choise() { Order=4,Description="Choice 4"}
					},
					CorrectAnswer=2
				},
				new Question() {
					Title="Question 9",
					Choises=new List<Choise>() {
						new Choise() { Order=1,Description="Choice 1"} ,
						new Choise() { Order=2,Description="Choice 2"} ,
						new Choise() { Order=3,Description="Choice 3"} ,
						new Choise() { Order=4,Description="Choice 4"}
					},
					CorrectAnswer=2
				},
				new Question() {
					Title="Question 10",
					Choises=new List<Choise>() {
						new Choise() { Order=1,Description="Choice 1"} ,
						new Choise() { Order=2,Description="Choice 2"} ,
						new Choise() { Order=3,Description="Choice 3"} ,
						new Choise() { Order=4,Description="Choice 4"}
					},
					CorrectAnswer=2
				},
				new Question() {
					Title="Question 11",
					Choises=new List<Choise>() {
						new Choise() { Order=1,Description="Choice 1"} ,
						new Choise() { Order=2,Description="Choice 2"} ,
						new Choise() { Order=3,Description="Choice 3"} ,
						new Choise() { Order=4,Description="Choice 4"}
					},
					CorrectAnswer=3
				},
				new Question() {
					Title="Question 12",
					Choises=new List<Choise>() {
						new Choise() { Order=1,Description="Choice 1"} ,
						new Choise() { Order=2,Description="Choice 2"} ,
						new Choise() { Order=3,Description="Choice 3"} ,
						new Choise() { Order=4,Description="Choice 4"}
					},
					CorrectAnswer=4
				},
				new Question() {
					Title="Question 13",
					Choises=new List<Choise>() {
						new Choise() { Order=1,Description="Choice 1"} ,
						new Choise() { Order=2,Description="Choice 2"} ,
						new Choise() { Order=3,Description="Choice 3"} ,
						new Choise() { Order=4,Description="Choice 4"}
					},
					CorrectAnswer=3
				},
				new Question() {
					Title="Question 14",
					Choises=new List<Choise>() {
						new Choise() { Order=1,Description="Choice 1"} ,
						new Choise() { Order=2,Description="Choice 2"} ,
						new Choise() { Order=3,Description="Choice 3"} ,
						new Choise() { Order=4,Description="Choice 4"}
					},
					CorrectAnswer=4
				},
				new Question() {
					Title="Question 15",
					Choises=new List<Choise>() {
						new Choise() { Order=1,Description="Choice 1"} ,
						new Choise() { Order=2,Description="Choice 2"} ,
						new Choise() { Order=3,Description="Choice 3"} ,
						new Choise() { Order=4,Description="Choice 4"}
					},
					CorrectAnswer=2
				},
					};
		private static List<Question> AllSuffeld => All.OrderBy(q => _random.Next()).ToList();
	}
}
