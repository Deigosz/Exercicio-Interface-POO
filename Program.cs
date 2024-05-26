using ExerInterface.Services;

ContaCorrente contaCorrente = new ContaCorrente(10000);
Console.WriteLine($"Tributos a serem pagos da Conta Corrente: {contaCorrente.CalcularTributos():c}");

SeguroVida seguroVida = new SeguroVida();
Console.WriteLine($"Tributos a serem pagos do Seguro de Vida: {seguroVida.CalcularTributos():c}");

TotalizadorTributos totalizadorTributos = new TotalizadorTributos();
totalizadorTributos.Adicionar(contaCorrente);
totalizadorTributos.Adicionar(seguroVida);

Console.WriteLine("--------------------------------------------------");
Console.WriteLine($"O valor total a ser pago é: {totalizadorTributos.Total:c}");