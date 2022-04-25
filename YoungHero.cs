using SaveThePrincess.Adventure;

namespace SaveThePrincess
{
    public class YoungHero : Hero
    {
        public override void SaveThePrincess()
        {
            var castle = TravelToDarkCastle();

            // Defeat all enemies in the castle
            // SLA: make function for iterating (only pass list -> need to know basis)
            foreach (var enemy in castle.Enemies)
            {
                // Handle different enemies
                // SLA: make function for body of loop
                if (enemy is Orc orc)                                                 
                {
                    KillWithSword(orc);
                }
                else if (enemy is Sphynx sphynx)
                {
                    var riddle = sphynx.GetRiddle();
                    SolveRiddle(riddle);
                }
                else
                {
                    throw new RunAwayException();
                }
            }

            var princess = FreeThePrincess(castle);
            GuardHome(princess);

            // My job is done!
            // SLA: make function for code block
            // SLA: make function from if condition to indicate intention not the technical details
            if (princess.IsSave() && princess.IsAtHome() && princess.Likes(this))
            {
                Kiss(princess);
            }

            CollectSavingFee(princess);
        }
    }
}
