using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represent one Team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represent the score for this particular team.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
