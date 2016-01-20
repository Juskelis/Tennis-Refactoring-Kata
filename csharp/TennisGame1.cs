using System;
using NUnit.Framework;

namespace Tennis
{
    class TennisGame1 : TennisGame
    {
        private int player1Score = 0;
        private int player2Score = 0;
        private string player1Name;
        private string player2Name;

        public TennisGame1(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == player1Name)
                player1Score += 1;
            else if (playerName == player2Name)
                player2Score += 1;
        }

        public string GetScore()
        {
            String score = "";
            if (player1Score == player2Score)
            {
                switch (player1Score)
                {
                    case 0:
                        return "Love-All";
                    case 1:
                        return "Fifteen-All";
                    case 2:
                        return "Thirty-All";
                    default:
                        return "Deuce";
                }
            }
            else if (player1Score >= 4 || player2Score >= 4)
            {
                int scoreDifference = player1Score - player2Score;
                if (scoreDifference == 1)
                    return "Advantage player1";
                else if (scoreDifference == -1)
                    return "Advantage player2";
                else if (scoreDifference >= 2)
                    return "Win for player1";
                else
                    return "Win for player2";
            }
            else
            {
                switch (player1Score)
                {
                    case 0:
                        score += "Love";
                        break;
                    case 1:
                        score += "Fifteen";
                        break;
                    case 2:
                        score += "Thirty";
                        break;
                    case 3:
                        score += "Forty";
                        break;
                }

                score += " - ";

                switch (player2Score)
                {
                    case 0:
                        score += "Love";
                        break;
                    case 1:
                        score += "Fifteen";
                        break;
                    case 2:
                        score += "Thirty";
                        break;
                    case 3:
                        score += "Forty";
                        break;
                }
            }
            return score;
        }
    }

}

