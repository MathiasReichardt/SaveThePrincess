using System.Collections.Generic;
using SaveThePrincess.Adventure;

namespace SaveThePrincess
{
    public class SeasonedHero : Hero
    {

        public override void SaveThePrincess()
        {
            var castle = TravelToDarkCastle();
            DefeatEnemies(castle.Enemies);
            var princess = FreeThePrincess(castle);
            GuardHome(princess);
            Farewell(princess);
        }

        private void DefeatEnemies(List<Enemy> enemies)
        {
            foreach (var enemy in enemies)
            {
                Defeat(enemy);
            }
        }

        private void Defeat(Enemy enemy)
        {
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

        private void Farewell(Princess princess)
        {
            if (PrincessIsGrateful(princess))
            {
                Kiss(princess);
            }

            CollectSavingFee(princess);
        }

        private bool PrincessIsGrateful(Princess princess)
        {
            return princess.IsSave() && princess.IsAtHome() && princess.Likes(this);
        }
    }
}
