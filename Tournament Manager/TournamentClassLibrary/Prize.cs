using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentClassLibrary
{
    public class Prize
    {
        private int id; //id is also a place number
        private string placeName;
        private int prizeAmount;
        private double prizePercentage;
        private Tournament tournament;

        #region Constructor
        public Prize(int id, string placeName, int prizeAmount, double prizePercentage, Tournament tournament)
        {
            this.Id = id;
            this.PlaceName = placeName;
            this.PrizeAmount = prizeAmount;
            this.PrizePercentage = prizePercentage;
            this.Tournament = tournament;
        }
        #endregion

        #region Property
        public int Id { get => id; set => id = value; }
        public string PlaceName { get => placeName; set => placeName = value; }
        public int PrizeAmount { get => prizeAmount; set => prizeAmount = value; }
        public double PrizePercentage { get => prizePercentage; set => prizePercentage = value; }
        public Tournament Tournament { get => tournament; set => tournament = value; }
        #endregion
    }
}
