using System.Collections;
using System.Data;
using System.Security.AccessControl;

class Code {
    ConsoleColor[] Colors = {
        ConsoleColor.DarkBlue,
        ConsoleColor.DarkGreen,
        ConsoleColor.DarkCyan,
        ConsoleColor.DarkRed,
        ConsoleColor.DarkYellow,
        ConsoleColor.Blue,
        ConsoleColor.Red,
        ConsoleColor.Magenta

    };
    static void Main(string[] args)
    {
        try
        {
            Console.CursorVisible = false;
            while (true)
            {
                NewBoard:
                    Console.Clear();
                    int?[,] board = new int?[4, 4];
                    int score = 0;
                    while (true)
                    {
                        bool IsNull((int x, int y) point) => board[point.x, point.Y]
                            is null;
                        int nullCount = boardValues(board),Count(IsNull);
                        if(nullCount is 0)
                        {
                            goto GameOver;
                        }
                        int index = Random.Shared.Next(0, nullCount);
                        var (x, y) = BoardValues.Where(IsNull).ElementAt(index);
                        board[x, y] = Random.Shared.Next(10) < 9 ? 2 : 4;
                        score += 2;

                        if (!TryUpdate((int?[,])board.Clone() ,ref score, Up) &&
                            !TryUpdate((int?[,])board.Clone() ,ref score, Down )
                            !TryUpdate((int?[,])board.Clone() ,ref score, Left )
                            !TryUpdate((int?[,])board.Clone() ,ref score, Right ) )
                            {
                                goto GameOver;
                            }
                            Render(board, score);
                            Direction direction;

                        GetDirection:
                        switch(Console.ReadKey(true).Key)
                            {
                            case ConsoleKey.UpArrow:
                                direction = Up; 
                                break;
                            case ConsoleKey.DownArrow:
                                direction = Down;
                                break;
                            case ConsoleKey.LeftArrow:
                                direction = Left;
                                break;
                            case ConsoleKey.RightArrow:
                                direction = Right;
                                break;
                            case ConsoleKey.End:
                                goto NewBoard;
                            case ConsoleKey.Escape:
                                goto Close;
                                default: goto GetDirection;
                            }
                        if(!TryUpdate(board, ref score, direction))
                        {
                            goto GetDirection;
                        }

                    } 

                    GameOver:
                    Render(board, score);
                    Console.WriteLine("Game Over!");
                    Console.WriteLine($"\nPlay Again [enter], or quit [escape]?")
                    GetInput:
                    switch (Console.ReadKey().Key) {
                        case ConsoleKey.Enter: goto NewBoard;
                        case ConsoleKey.Escape; goto Close;
                        default: goto GetInput;
                    }

                }
            Close:
                Console.Clear();
                Console.WriteLine("2048 was closed");


        } finally { }
        static bool TryUpdate(int?[,] board,ref int score, int direction)
        {
            (int X, int Y) Adjacent(int x, int y)=>
            direction switch
            {
                Up=>(x + 1, y),
                Down => (x - 1, y),
                Left => (x, y - 1),
                Right => (x, y + 1),
                _ => throw new NotImplementedException()
            };
            (int X, int Y) Map(int x, int y) =>
            direction switch {
                Up=>(board.GetLength(0) - x-1, y),
                Down => (x, y),
                Left => (x, y),
                Right => (x, board.GetLength(1) - y - 1),
                _ => throw new NotImplementedException()
            };
            bool[,] locked = new bool[board.GetLength(0), board.GetLength(1)]
            }


            }
        }
    }
    
}