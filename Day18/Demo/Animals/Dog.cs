﻿namespace Animals
{
    public class Dog : Animal 
    {
        public Dog(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }

        public override string ExplainMyself()
        {
            return base.ExplainMyself() + Environment.NewLine + "The dog sais: Woof";
        }
    }
}
