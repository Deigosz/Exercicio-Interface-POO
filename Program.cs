using ExerInterface;

ContaCorrente cc1 = new ContaCorrente(10000);
Console.WriteLine($"Tributos a serem pagos da Conta Corrente: {cc1.CalcularTributos():c}");

SeguroVida sg1 = new SeguroVida();
Console.WriteLine($"Tributos a serem pagos do Seguro de Vida: {sg1.CalcularTributos():c}");

TotalizadorTributos tt = new TotalizadorTributos();
tt.Adicionar(cc1);
tt.Adicionar(sg1);

Console.WriteLine("--------------------------------------------------");
Console.WriteLine($"O valor total a ser pago é: {tt.Total:c}");