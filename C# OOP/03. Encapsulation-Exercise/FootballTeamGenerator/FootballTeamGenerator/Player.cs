using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        private double stats;


        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public string Name
        {
            get { return this.name; }
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("A name should not be empty.");
                }

                this.name = value; 
            }
        }
        
        protected int Endurance
        {
            get { return this.endurance; }
            private set 
            {
                if (value > 100 || value < 0)
                {
                    throw new Exception($"Endurance should be between 0 and 100.");
                }

                this.endurance = value; 
            }
        }

        protected int Sprint
        {
            get { return this.sprint; }
            private set 
            {
                if (value > 100 || value < 0)
                {
                    throw new Exception($"Sprint should be between 0 and 100.");
                }

                this.sprint = value;
            }
        }

        protected int Dribble
        {
            get { return this.dribble; }
            private set 
            {
                if (value > 100 || value < 0)
                {
                    throw new Exception($"Dribble should be between 0 and 100.");
                }

                this.dribble = value;
            }
        }

        protected int Passing
        {
            get { return this.passing; }
            private set
            {
                if (value > 100 || value < 0)
                {
                    throw new Exception($"Passing should be between 0 and 100.");
                }

                this.passing = value;
            }
        }

        protected int Shooting
        {
            get { return this.shooting; }
            private set
            {
                if (value > 100 || value < 0)
                {
                    throw new Exception($"Shooting should be between 0 and 100.");
                }

                this.shooting = value;
            }
        }

       

        public int GetStats()
        {
            double result = (endurance + sprint + dribble + passing + shooting) / 5.0;
            return (int)Math.Ceiling(result);
        }

    }
}
