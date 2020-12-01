static void Main(string[] args)
        {
            int N = 2;
            bool[,] takenSeats = new bool[10,2];
            for(var i = 0; i < 10; i++)
            {
                for(var j = 0; j < N; j++)
                {
                    takenSeats[i,j] = false;
                }
            }
            takenSeats[6,1] = true;

            Console.WriteLine(takenSeats[6,1]);
        }
