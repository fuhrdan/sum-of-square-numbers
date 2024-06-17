//*****************************************************************************
//** 633. Sum of Square Numbers Leetcode                                     **
//** I did NOT use a hash function to solve this, I went with a zero and a   **
//** square root of the number to come up with two ends, and try to meet at  **
//** the solution.  It was a slower solution, but it did work.      -Dan     **
//*****************************************************************************
//*****************************************************************************

bool judgeSquareSum(int c) {
    long a = 0;
    long b = sqrt(c);
    while(a <= b)
    {
        long s = a*a + b*b;
        if(s == c)
        {
            return true;
        }
        if (s < c) 
        {
            a++;
        }
        else
        {
            b--;
        }
    }
   return false;
}