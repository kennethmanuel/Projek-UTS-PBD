using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentClassLibrary
{
    public class Prize
    {
        #region DATA MEMBER
        private int id;
        private int placeNumber;
        private string placeName;
        private int prizeAmount;
        private double prizePercentage;
        #endregion

        #region CONSTRUCTOR
        public Prize(int id, int placeNumber, string placeName, int prizeAmount, double prizePercentage)
        {
            this.Id = id;
            this.PlaceNumber = placeNumber;
            this.PlaceName = placeName;
            this.PrizeAmount = prizeAmount;
            this.PrizePercentage = prizePercentage;
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public int PlaceNumber { get => placeNumber; set => placeNumber = value; }
        public string PlaceName { get => placeName; set => placeName = value; }
        public int PrizeAmount { get => prizeAmount; set => prizeAmount = value; }
        public double PrizePercentage { get => prizePercentage; set => prizePercentage = value; }
        #endregion

        #region METHOD
        #endregion
    }
}
