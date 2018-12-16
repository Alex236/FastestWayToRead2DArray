using System.Diagnostics;


namespace Arrays
{
    class Arrays
    {
        int width;
        int height;
        int [,] array;
        public Arrays(int width, int height)
        {
            this.width = width;
            this.height = height; 
        }
        unsafe public string Optimal()
        {
            array = new int[width, height];
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for(int i = 0; i < width; i++)
            {
                fixed(int* row = &array[i,0])
                {
                    int* p = row;
                    for (int j = 0; j < height; j++, p++)
                    {
                        int temp = *p;
                    }   
                }
            }
            timer.Stop();
            return "Time " + timer.ElapsedMilliseconds.ToString();
        }
        public string ByRows()
        {
            array = new int[width, height];
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    int temp = array[i,j];
                }
            }
            timer.Stop();
            return "Time " + timer.ElapsedMilliseconds.ToString();
        }
        public string ByColumns()
        {
            array = new int[width, height];
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int temp = array[j,i];
                }
            }
            timer.Stop();
            return "Time " + timer.ElapsedMilliseconds.ToString();
        }
    }
}