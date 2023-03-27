using System;

namespace SafariParkApp.Extra
{
    public class Spartan
    {
        private int _age;
        private int _spartanScore;

        public string FullName { get; set; }

        public int Age
        {
            get => _age;
            set => _age = value < 0 ? throw new ArgumentException("Age cannot be less than 0") : value;
        }

        public string Stream { get; set; }

        public int SpartanScore
        {
            get => _spartanScore;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Score must be between 0 and 100");
                }
                _spartanScore = value;
            }
        }

        public string SpartanDetails()
        {
            return $"{FullName}, Age: {Age}, Course: {Stream}, Spartan Score: {SpartanScore}";
        }
    }
}
