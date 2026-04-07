class HalloWorld
{       
    static void Main()
    {
        Console.Clear();
        double M = 0;
        double b = 0;
        string pr = "";
        Console.WriteLine("Y = MX + B");
        Console.Write("enter M = ");
        M = double.Parse(Console.ReadLine());
        if (( M >=-0.5 ) && ( M <= 0.5 )) pr = "-";
        else if (( M > 0.5 ) && ( M <= 3 )) pr = "/";
        else if (( M >= 3 ) || ( M <= -3 )) pr = "|";
        else if (( M < -0.5 ) && ( M >= -3 )) pr = "⧹";
        Console.Clear();
        Console.WriteLine("Y = {0}X + B",M);
        Console.Write("enter b = ");
        b = double.Parse(Console.ReadLine());
        Console.Clear();
        graph();
        print( M , b , pr );
        Console.SetCursorPosition( 0 , 41 );
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(" Y = {0}X + {1} ", M , b ); 
    }
    static void graph()
    {
        int size = 41;
        for( int i = 1 ; i <= size ; i++ )
        {
            for ( int k = 1 ; k <= size ; k++ )
            {
                if (( i == 21 ) && ( k == 21 )) Console.Write("—✛—");
                else if (( i == 21 ) && ( k != 21 )) Console.Write("———");
                else if (( i != 2 ) && ( k == 21 )) Console.Write(" ⎮ ");
                else Console.Write(" . "); 
            }
            Console.WriteLine();
        }
    }
    static async Task print( double M, double B, string pr)
    {
        int a = 0;
        int ny  = 0;
       for ( double X = -20; X < 21; X++ )
        {
            double Y = ( M * X ) + B;
            if (Y < 1) 
            {
                ny = -((int)Y) + 20;
            }
            else
            {
                ny = 20 - ((int)Y);
            }
            int nx = ((int)X)+20;
            Console.ForegroundColor = ConsoleColor.Red;
            if (( ny >= 0 ) && ( ny <= 41 )){
                Console.SetCursorPosition( nx * 3 + 1, ny );
                Console.Write(pr);
                Console.ResetColor();
                Console.SetCursorPosition( 123 , a );
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("( {0} , {1} )", string.Format("{0:0.00 }",X) , string.Format("{0:0.00 }",Y) ); //https://stackoverflow.com/questions/1291483/leave-only-two-decimal-places-after-the-dot
                a++;
                Thread.Sleep(100);
            }
        }
    }
}
