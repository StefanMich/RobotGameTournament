using System;
namespace RobotGameTournament.Control
{
    public interface IPrintScores
    {
        void PrintMatchOverview(System.Collections.Generic.List<RobotGameTournament.Match> matches);
        void PrintScoreBoard(System.Collections.Generic.List<RobotGameTournament.Model.Robot> robots);
    }
}
