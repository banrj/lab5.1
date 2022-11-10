int[] mas = new int[] { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };

int[] Sorter(int[] massiv)
{
    int TotalLong = massiv.Length;
    for (int number = 0; number<=TotalLong; number++)
    {
        if (massiv[number] < 0)
        {
            TotalLong--;
        }

    }
    Console.WriteLine(TotalLong);
    int[] newMas = new int[TotalLong];

    for (int numberOut = 0; numberOut < massiv.Length; numberOut++)
    {
        for (int numberIn = numberOut + 1; numberIn < massiv.Length; numberIn++)
        {
            if (massiv[numberOut] > massiv[numberIn])
            {
                int temp = massiv[numberOut];
                massiv[numberOut] = massiv[numberIn];
                massiv[numberIn] = temp;
            }
        }
    }
    int count = 0;
    for (int numberOut = 0; numberOut < massiv.Length; numberOut++)
    {
        {
            Console.WriteLine(mas[numberOut]);
            if (mas[numberOut] > 0)
                newMas[numberOut - count] = mas[numberOut];
            else
                count++;
        }
        
    }

        return newMas;
}


mas=Sorter(mas);

for (int numberOut = 0; numberOut <= mas.Length - 1; numberOut++)
{
    Console.Write($"{mas[numberOut]} ");

}