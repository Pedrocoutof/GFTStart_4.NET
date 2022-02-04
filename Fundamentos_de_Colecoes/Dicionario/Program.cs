
//Dicionario de estados
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("MG", "Minas Gerais");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("SP", "São Paulo");

System.Console.WriteLine("Imprimindo todos estados");
foreach(var item in estados){
    System.Console.WriteLine($"{item.Key} - {item.Value}");
}

//Dicionario de meses
Dictionary<int, string> mes = new Dictionary<int, string>();

mes.Add(1, "Janeiro");
mes.Add(2, "Fevereiro");
mes.Add(3, "Março");
mes.Add(4, "Abril");
mes.Add(5, "Maio");
mes.Add(6, "Junho");
mes.Add(7, "Julho");
mes.Add(8, "Agosto");
mes.Add(9, "Setembro");
mes.Add(10, "Outubro");
mes.Add(11, "Novembro");
mes.Add(12, "Dezembro");

System.Console.WriteLine("Digite qual mes em numero que deseja pesquisar: ");
int valor = int.Parse(System.Console.ReadLine()!);

if(mes.ContainsKey(valor)){
    System.Console.WriteLine($"{mes[valor]}");
}