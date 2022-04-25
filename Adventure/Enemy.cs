namespace SaveThePrincess.Adventure
{
    public class Enemy {}

    public class Orc : Enemy { }

    public class Sphynx : Enemy
    {
        public Riddle GetRiddle()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Riddle { }
}