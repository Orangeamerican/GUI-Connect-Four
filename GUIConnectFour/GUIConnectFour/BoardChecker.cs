using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIConnectFour
{
    
    class BoardChecker: IWinner
    {
        public double xWins = 0, oWins = 0, numGames = 0, xAvg = 0, oAvg = 0;
        public string[] word = new string[42];
        public void Clear()
        {
            for (int i = 0; i < 42; i++)
            {
                word[i] = "";
            }

        }
        public void Accumulate(int i, string s)
        //find winner in column c going up starting from (r,c)
        {
            word[i] = s;
        }
        public bool Straightup(int r, int c)
        //find winner in column c going down starting from (r,c)
        {
            if (r + 21 < 42)
            {
                if (word[r] == "X" && word[r + 7] == "X" && word[r + 14] == "X" && word[r + 21] == "X")
                {
                    xWins++;
                    numGames++;
                    xAvg = xWins / numGames;
                    oAvg = oWins / numGames;
                    return true;
                }
                else if (word[r] == "O" && word[r + 7] == "O" && word[r + 14] == "O" && word[r + 21] == "O")
                {
                    oWins++;
                    numGames++;
                    xAvg = xWins / numGames;
                    oAvg = oWins / numGames;
                    return true;
                }
            }
            return false;
        }
        public bool Straightdown(int r, int c)
        //find a winner in row r going left starting from (r,c)
        {
            if (r - 21 > 0)
            {
                if (word[r] == "X" && word[r - 7] == "X" && word[r - 14] == "X" && word[r - 21] == "X")
                {
                    xWins++;
                    numGames++;
                    xAvg = xWins / numGames;
                    oAvg = oWins / numGames;
                    return true;
                }
                else if (word[r] == "O" && word[r - 7] == "O" && word[r - 14] == "O" && word[r - 21] == "O")
                {
                    oWins++;
                    numGames++;
                    xAvg = xWins / numGames;
                    oAvg = oWins / numGames;
                    return true;
                }
            }
            return false;
        }
        public bool Left(int r, int c)
        //find a winner in row r going right starting from (r,c)
        {
            if (r - 3 > 0)
            {
                if (word[r] == "X" && word[r - 1] == "X" && word[r - 2] == "X" && word[r - 3] == "X")
                {
                    xWins++;
                    numGames++;
                    xAvg = xWins / numGames;
                    oAvg = oWins / numGames;
                    return true;
                }
                else if (word[r] == "O" && word[r - 1] == "O" && word[r - 2] == "O" && word[r - 3] == "O")
                {
                    oWins++;
                    numGames++;
                    xAvg = xWins / numGames;
                    oAvg = oWins / numGames;
                    return true;
                }
            }
            return false;
        }
        public bool Right(int r, int c)
        //find a winner in diagonal left going up starting from (r,c)
        {
            if (r + 3 < 42)
            {
                if (word[r] == "X" && word[r + 1] == "X" && word[r + 2] == "X" && word[r + 3] == "X")
                {
                    xWins++;
                    numGames++;
                    xAvg = xWins / numGames;
                    oAvg = oWins / numGames;
                    return true;
                }
                else if (word[r] == "O" && word[r + 1] == "O" && word[r + 2] == "O" && word[r + 3] == "O")
                {
                    oWins++;
                    numGames++;
                    xAvg = xWins / numGames;
                    oAvg = oWins / numGames;
                    return true;
                }
            }
            return false;
        }
        public bool Diagleftup(int r, int c)
        //find a winner in diagonal right going down starting from(r, c)
        {
            if (r -24 > 0)
            {
                if (word[r] == "X" && word[r - 8] == "X" && word[r - 16] == "X" && word[r - 24] == "X")
                {
                    xWins++;
                    numGames++;
                    xAvg = xWins / numGames;
                    oAvg = oWins / numGames;
                    return true;
                }
                else if (word[r] == "O" && word[r - 8] == "O" && word[r - 16] == "O" && word[r - 24] == "O")
                {
                    oWins++;
                    numGames++;
                    xAvg = xWins / numGames;
                    oAvg = oWins / numGames;
                    return true;
                }
            }
            return false;
        }
        public bool Diagrightdown(int r, int c)
        //find a winner in diagonal left going down starting from(r, c)
        {
            if (r + 24 < 42)
            {
                if (word[r] == "X" && word[r + 8] == "X" && word[r + 16] == "X" && word[r + 24] == "X")
                {
                    xWins++;
                    numGames++;
                    xAvg = xWins / numGames;
                    oAvg = oWins / numGames;
                    return true;
                }
                else if (word[r] == "O" && word[r + 8] == "O" && word[r + 16] == "O" && word[r + 24] == "O")
                {
                    oWins++;
                    numGames++;
                    xAvg = xWins / numGames;
                    oAvg = oWins / numGames;
                    return true;
                }
            }
            return false;
        }
        public bool Diagleftdown(int r, int c)
        //find a winner in diagonal right going up starting from(r, c)
        {
            if (r + 18 < 42)
            {
                if (word[r] == "X" && word[r + 6] == "X" && word[r + 12] == "X" && word[r + 18] == "X")
                {
                    xWins++;
                    numGames++;
                    xAvg = xWins / numGames;
                    oAvg = oWins / numGames;
                    return true;
                }
                else if (word[r] == "O" && word[r + 6] == "O" && word[r + 12] == "O" && word[r + 18] == "O")
                {
                    oWins++;
                    numGames++;
                    xAvg = xWins / numGames;
                    oAvg = oWins / numGames;
                    return true;
                }
            }
            return false;
        }
        public bool Diagrightup(int r, int c)
        //return true if there is winner this function should use the previous one
        {
            if (r - 18 > 0)
            {
                if (word[r] == "X" && word[r - 6] == "X" && word[r - 12] == "X" && word[r - 18] == "X")
                {
                    xWins++;
                    numGames++;
                    xAvg = xWins / numGames;
                    oAvg = oWins / numGames;
                    return true;
                }
                else if (word[r] == "O" && word[r - 6] == "O" && word[r - 12] == "O" && word[r - 18] == "O")
                {
                    oWins++;
                    numGames++;
                    xAvg = xWins / numGames;
                    oAvg = oWins / numGames;
                    return true;
                }
            }
            return false;
        }
        public bool Winner(int change)
        {
            if (Straightup(change, 0))
                return true;
            else if (Straightdown(change, 0))
                return true;
            else if (Left(change, 0))
                return true;
            else if (Right(change, 0))
                return true;
            else if (Diagleftdown(change, 0))
                return true;
            else if (Diagleftup(change, 0))
                return true;
            else if (Diagrightup(change, 0))
                return true;
            else if (Diagrightdown(change, 0))
                return true;
            return false;
        }
    }
}
