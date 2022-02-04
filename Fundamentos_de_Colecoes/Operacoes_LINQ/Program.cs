class Program{

    public static void imprimeArray(int [] array){
        foreach(var elemento in array){
            System.Console.Write($"{elemento}, ");
        }
    }
    
    public static void criaArrayPar(int[] arrayOriginal){

        System.Console.WriteLine("\n\n: CRIA ARRAY PAR :");
        System.Console.WriteLine("\nImprimindo array original");
        imprimeArray(arrayOriginal);

        //SINTAXE DE CONSULTA/QUERY
        var arrayParC =  from elemento in arrayOriginal
                        where elemento % 2 == 0
                        orderby elemento
                        select elemento;
        
        System.Console.WriteLine("\nImprimindo array par, utilizando a sintaxe de consulta/query");
        imprimeArray(arrayParC.ToArray());

    
        //SINTAXE DE MÉTODO
        var arrayParM = arrayOriginal.Where(elemento => elemento %2 == 0).OrderBy(elemento => elemento);
        System.Console.WriteLine("\nImprimindo array par, utilizando a sintaxe de metodo");
        imprimeArray(arrayParC.ToArray());
    }

    public static void criaArrayImpar(int[] arrayOriginal){
        
        System.Console.WriteLine("\n\n: CRIA ARRAY IMPAR :");
        System.Console.WriteLine("\nImprimindo array original");
        imprimeArray(arrayOriginal);

        // UTILIZANDO SINTAXE DE CONSULTA/QUERY
        var arrayImparC = from elemento in arrayOriginal
                          where elemento % 2 != 0
                          orderby elemento
                          select elemento;
        
        System.Console.WriteLine("\nImprimindo array impar, utilizando a sintaxe de consulta/query");
        imprimeArray(arrayImparC.ToArray());

        // UTILIZANDO SINTAXE DE METODO

        var arrayImparM = arrayOriginal.Where(elemento => elemento % 2 != 0).OrderBy(elemento => elemento);
        System.Console.WriteLine("\nImprimindo array impar, utilizando a sintaxe de método");
        imprimeArray(arrayImparM.ToArray());

    }
    
    public static void criaArrayComValoresNegativos(int [] arrayOriginal){
        
        System.Console.WriteLine("\n\n: CRIA ARRAY COM VALORES NEGATIVOS :");
        System.Console.WriteLine("\nImprimindo array original");
        imprimeArray(arrayOriginal);

        // UTILIZANDO CONSULTA
        var arrayNegativoC = from elemento in arrayOriginal
                             where elemento < 0
                             orderby elemento
                             select elemento;
        
        System.Console.WriteLine("\nImprimindo array de elementos negativos, utilizando a sintaxe de consulta/query");
        imprimeArray(arrayNegativoC.ToArray());
        

        // UTILIZANDO METODO
        var arrayNegativoM = arrayOriginal.Where(elemento => elemento < 0).OrderBy(elemento => elemento);
        System.Console.WriteLine("\nImprimindo array de elementos negativos, utilizando a sintaxe de metodo");
        imprimeArray(arrayNegativoC.ToArray());

    }

    public static void Main(){
        
        int [] array = new int[21];

        for(int i = 0; i < 21; i++){
            array[i] = i - 10;
        }
        
        criaArrayPar(array);
        criaArrayImpar(array);
        criaArrayComValoresNegativos(array);

    }
}