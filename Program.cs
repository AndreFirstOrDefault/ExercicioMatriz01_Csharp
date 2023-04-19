namespace ExercicioResolvido_Aula80
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n,n];
           
            for(int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
              
                for(int j = 0; j < n; j++)
                {
                    mat[i,j] = int.Parse(values[j]);
                } 
            }

            Console.WriteLine("\nMain diagonal:");
            int count = 0;
            foreach(int i in mat)
            {
                if (mat[0,0] == i)
                {
                    Console.Write(mat[0,0] + " " + mat[1,1] + " " + mat[2,2] + "\n");
                }
                
                if(i < 0)
                {
                    count++;
                }
                
            }
            Console.WriteLine("Negative numbers = " + count);
            
        }
    }
}
