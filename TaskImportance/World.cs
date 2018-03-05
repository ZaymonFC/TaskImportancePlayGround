using System;
using System.Collections.Generic;

namespace TaskImportance
{
    public class World
    {
        private List<RationalAgent> agents;
        
        public World() {
            Console.WriteLine("Initialised World");

            agents = new List<RationalAgent>();

            agents.Add(new RationalAgent("Harold"));

            Update();
        }

        public void Update() {
            while(true) {
                foreach(RationalAgent agent in agents) {
                    agent.Update();
                }
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}