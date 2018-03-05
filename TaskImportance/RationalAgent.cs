using System;
using System.Collections.Generic;
using System.Linq;
using TaskImportance.Tasks;

namespace TaskImportance {

	public class RationalAgent {
		//
		// ─── BASIC NEEDS ────────────────────────────────────────────────────────────────
		//
		public int health { get; set; }
		public int hunger { get; set; }
		public int thirst { get; set; }
		public int sleep { get; set; }
		public string name { get; }


		//
		// ─── TASK IMPLEMENTATION ────────────────────────────────────────────────────────
		//
		protected List<Task> tasks;
		
		public RationalAgent(string name)
		{
			health = 100;
			hunger = 100;
			thirst = 100;
			sleep = 100;
			this.name = name;

			Console.WriteLine("Harold was born");

			tasks = new List<Task>();
			tasks.Add(new SleepTask(this));
		}

		public void Update() {
		    ReduceStats();

			foreach(Task task in tasks) {
				task.UpdatePriority();
			}

			var currentTask = tasks.OrderBy(t => t.priority).First();

			Console.WriteLine();

			currentTask.Act();

			ReportStats();
			
		}

		public void ReduceStats () {
			// Lower the agents stats here
		}

		public void ReportStats () {
			Console.WriteLine($"--- {name}'s Stats ---");
			WritePair("Sleep", sleep);
			WritePair("Thirst", thirst);
			WritePair("Hunger", hunger);
			WritePair("Health", health);
		}

		protected void WritePair(string attributeName, int attributeValue){
			Console.WriteLine($"{attributeName} \t {attributeValue}");
		}


	}

}