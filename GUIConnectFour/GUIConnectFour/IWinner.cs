using System;
using System.Collections.Generic;
using System.Text;

namespace GUIConnectFour
{
    interface IWinner
    {
        void Accumulate(int i, string s);
        //find winner in column c going up starting from (r,c)
        bool Straightup(int r, int c);
        //find winner in column c going down starting from (r,c)
        bool Straightdown(int r, int c);
        //find a winner in row r going left starting from (r,c)
        bool Left(int r, int c);
        //find a winner in row r going right starting from (r,c)
        bool Right(int r, int c);
        //find a winner in diagonal left going up starting from (r,c)
        bool Diagleftup(int r, int c);
        //find a winner in diagonal right going down starting from(r, c)
        bool Diagrightdown(int r, int c);
        //find a winner in diagonal left going down starting from(r, c)
        bool Diagleftdown(int r, int c);
        //find a winner in diagonal right going up starting from(r, c)
        bool Diagrightup(int r, int c);
        //return true if there is winner this function should use the previous one
        bool Winner(int change);
    }
}
