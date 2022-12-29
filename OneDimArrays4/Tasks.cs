namespace OneDimArrays4
{
    public static class Tasks
    {
        public static int Task1(int[] array, int a)
        {
            int result = 0;
            int min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > a)
                {
                    min = array[i];
                    break; 
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] > a) && (array[i] < min))
                {

                    min = array[i];
                }

            }
                result = min;
                return result;
        }

        public static int[] Task2(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                
                if ((array[i] % 2 == 0) && (i % 2==0))
                {
                    array[i]= array[i] + i;
                }
                else if (((array[i] % 2 == 1) || (array[i] % 2 ==-1 )) && (i % 2 == 1))
                {
                    array[i] = array[i] + i;
                }
            }

                return array;
        }

        public static int[] Task3(int[] array, int a)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > a)
                {
                    array[i] = array[i] * 2;
                }
                else
                    array[i] = 0;
            }

                return array;
        }
    }
}
