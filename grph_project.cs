class HalloWorld
{       
    static void Main()
    {
        Console.Clear();// clear the terminal for a clean look
        double M = 0;// the X multiplier
        double b = 0;// the Y cut point
        string pr = "";// the print look
        Console.WriteLine("Y = MX + B");
        Console.Write("enter M = ");
        M = double.Parse(Console.ReadLine());// user put a number and enter
        if (( M >=-0.5 ) && ( M <= 0.5 )) pr = "-";// if the slop is horizontal
        else if (( M > 0.5 ) && ( M <= 3 )) pr = "/";// if it positive
        else if (( M >= 3 ) || ( M <= -3 )) pr = "|";// if it very sharp
        else if (( M < -0.5 ) && ( M >= -3 )) pr = "⧹";// if it negative
        Console.Clear();// clear the user input
        Console.WriteLine("Y = {0}X + B",M);
        Console.Write("enter b = ");
        b = double.Parse(Console.ReadLine());//  user put a number and enter
        Console.Clear();// clear the user input
        graph();// call for the function that print out a graph
        print( M , b , pr );// print the function on the graph
        Console.SetCursorPosition( 0 , 41 );// put the cursor at the end
        Console.ForegroundColor = ConsoleColor.Cyan;// set the color to cyan
        Console.WriteLine(" Y = {0}X + {1} ", M , b ); // write out the fanction
    }
    static void graph()
    {
        int size = 41;// the size of the graph from end to end
        for( int i = 1 ; i <= size ; i++ )// the Y loop
        {
            for ( int k = 1 ; k <= size ; k++ )// the X loop
            {
                if (( i == 21 ) && ( k == 21 )) Console.Write("—✛—");// check if it's the center of the graph and print the intersection looks
                else if (( i == 21 ) && ( k != 21 )) Console.Write("———");// the X line
                else if (( i != 21 ) && ( k == 21 )) Console.Write(" ⎮ ");// the Y line
                else Console.Write(" . "); // normal point
            }
            Console.WriteLine();// go down a line to start a new one
        }
    }
    static void print( double M, double B, string pr)// the function print method
    {
        int a = 0;// this is a number that use to print the coordinates
        int ny  = 0;// a new Y 
       for ( double X = -20; X < 21; X++ )// start from the left to the right
        {
            double Y = ( M * X ) + B;// calculat the point to get the Y
            if (Y < 1) //becouse the terminal print from the top down and the graph is to all directions i need to get it as a positive number so it can be printed
            {
                ny = -((int)Y) + 20;// if the number is less then 1 it will turn negative and half of the length  of the graph will be added
            }
            else
            {
                ny = 20 - ((int)Y);// if it's positive it will be subtracted form half of the graph length
            }
            int nx = ((int)X)+20;// i need the x to be positive so i can tell the function were to point, half of the graph length will be added
            Console.ForegroundColor = ConsoleColor.Red;// set the coler to red for better sight
            if (( ny >= 0 ) && ( ny <= 41 )) // if the Y is in the borders of the graph print it will execute
            {
                Console.SetCursorPosition( nx * 3 + 1, ny );// becouse every point is 2 chars apart i multiply it by 3 and add one so it will print on the dots
                Console.Write(pr);// write the shape of the slop (lines 12 - 15)
                Console.ResetColor();// reset the color
                Console.SetCursorPosition( 123 , a );// set the cursor position to the end of the line
                Console.ForegroundColor = ConsoleColor.Green;// set the color to green
                Console.WriteLine("( {0} , {1} )", string.Format("{0:0.00 }",X) , string.Format("{0:0.00 }",Y) ); //https://stackoverflow.com/questions/1291483/leave-only-two-decimal-places-after-the-dot
                //make the position print be only 2 numbers after the dot
                a++;// it add one so the coordinates will go down a line
                Thread.Sleep(100);// deley so you can se the graph get printed
            }
        }
    }
}
